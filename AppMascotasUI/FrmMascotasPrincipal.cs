using Entidades;
using BaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using Microsoft.Win32;

namespace AppMascotasUI
{
    /// <summary>
    /// Delegado que recibira un parametro loro, se le agregaran 3 metodos a este delegado
    /// </summary>
    /// <param name="loro"></param>
    public delegate void DelegadoPalabras(Loro loro);
    /// <summary>
    /// Delegado para poder usar multihilos, recibe la fecha
    /// </summary>
    /// <param name="fecha"></param>
    public delegate void DelegadoActualizar(DateTime fecha);
    public partial class FrmMascotasPrincipal : Form
    {
        /// <summary>
        /// Crea la lista de mascotas que le pasara por parametro a el atributo casa
        /// </summary>
        private List<Mascota> mascotas;
        private Usuario usuarioLogueado;
        private string fecha;
        private Casa casa;
        private CancellationToken cancelarFlujo;
        private CancellationTokenSource fuenteDeCancelacion;
        DelegadoPalabras miDelegado;

        /// <summary>
        /// Inicializa la lista de mascotas
        /// inicializa la fecha con el formato corto
        /// Inicializa la fecha, y los tokens de cancelacion de hilos
        /// </summary>
        public FrmMascotasPrincipal()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + "./fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.mascotas = new List<Mascota>();
            this.fecha = DateTime.Now.ToShortDateString();
            this.fuenteDeCancelacion = new CancellationTokenSource();
            this.cancelarFlujo = this.fuenteDeCancelacion.Token;
        }
        /// <summary>
        /// Constructor que recibe el Usuario que se logueo actualmente
        /// Asigna los valores a los atributos, 
        /// Crea la instancia Casa con la lista de mascotas y un limite de mascotas modificable desde el programa
        /// </summary>
        /// <param name="usuarioLogueado"></param>
        public FrmMascotasPrincipal(Usuario usuarioLogueado) : this()
        {
            this.usuarioLogueado = usuarioLogueado;
            this.casa = new Casa(mascotas, 15);
        }
        /// <summary>
        /// Actualiza el ListBoxMascotas
        /// </summary>
        private void ActualizarVisor()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.casa.mascotas)
            {
                lstMascotas.Items.Add(mascota.ToString());
            }
        }
        /// <summary>
        /// mientras el token de cancelacion no se llame, actualiza la fecha
        /// </summary>
        private void BucleTiempo()
        {
            do
            {
                if (this.cancelarFlujo.IsCancellationRequested) break;

                this.ActualizarFecha(DateTime.Now);
                Thread.Sleep(1000);
            } while (true);
        }
        /// <summary>
        /// Metodo para actualizar el label, con la fecha
        /// </summary>
        /// <param name="fecha"></param>
        private void ActualizarFecha(DateTime fecha)
        {
            if (this.lblHora.InvokeRequired)
            {
                DelegadoActualizar d = new DelegadoActualizar(ActualizarFecha);
                object[] arrayParametro = { fecha };

                this.lblHora.Invoke(d, arrayParametro); //    para invocar al hilo principal, tenes que 
                                                        //    hacerlo desde un control creado en el hilo main
            }
            else this.lblHora.Text = fecha.ToString();
        }
        /// <summary>
        /// Funcion que fusiona todas las listas obtenida de la BD, y las agrega a una lista Mascota
        /// Uso Task para que no se tilde el programa mientras se obtienen los datos de la base
        /// </summary>
        /// <returns></returns>
        private async Task<List<Mascota>> FusionarListas()
        {
            List<Mascota> mascotas = new List<Mascota>();
            try
            {
                mascotas = await Task.Run(() =>
                {
                    AccesoADatosPerro adoPerro = new AccesoADatosPerro();
                    AccesoADatosLoro adoLoro = new AccesoADatosLoro();
                    AccesoADatosGato adoGato = new AccesoADatosGato();

                    List<Perro> listaPerro = adoPerro.ObtenerLista();
                    List<Gato> listaGato = adoGato.ObtenerLista();
                    List<Loro> listaLoro = adoLoro.ObtenerLista();

                    foreach (Perro perro in listaPerro)
                    {
                        mascotas.Add(perro);
                    }
                    foreach (Gato gato in listaGato)
                    {
                        mascotas.Add(gato);
                    }
                    foreach (Loro loro in listaLoro)
                    {
                        mascotas.Add(loro);
                    }
                    return mascotas;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Obteniendo los datos {ex.Message}");
            }
            return mascotas;
        }
        /// <summary>
        /// Escribe el nombre, Apellido, y la fecha del usuario que esta logueado actualmente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMascotasPrincipal_Load(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.lblArchivo.BackColor = Color.Transparent;
            this.lblHora.BackColor = Color.Transparent;
            this.lblUsuario.BackColor = Color.Transparent;
            this.gBoxOrden.BackColor = Color.Transparent;
            this.lblArchivo.Text = $"Nombre: {this.usuarioLogueado.nombre} {Environment.NewLine}" +
                $"Apellido: {this.usuarioLogueado.apellido} {Environment.NewLine}" +
                $"Fecha: {this.fecha}";
            Task t1 = Task.Run(() => { this.BucleTiempo(); });
        }
        /// <summary>
        /// Lee el archivo Usuario.Log que almacena la lista de todos los usuarios logueados
        /// </summary>
        /// <returns>Retorna un string con todos los usuarios logueados</returns>
        private string LeerArchivoLog()
        {
            Encoding miCodificacion = Encoding.UTF8;
            string path = "./Usuarios.log";
            string archivo = "";
            try
            {
                if (File.Exists(path))
                    using (StreamReader sr = new StreamReader(path, miCodificacion))
                    {
                        archivo = sr.ReadToEnd();
                    }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return archivo;
        }
        /// <summary>
        /// Te advierte el cierre de la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMascotasPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Quieres cerrar la aplicacion? ", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rta == DialogResult.No)
            {
                e.Cancel = true;

            }
        }
        /// <summary>
        /// Agrega mascotas a la casa, para que no rompa, valida que la Mascota tenga un nombre y no vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.usuarioLogueado.perfil == "vendedor")
            {
                MessageBox.Show($"Error no puedes agregar mascotas, PERFIL: {usuarioLogueado.perfil}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmAgregarMascotas frm = new FrmAgregarMascotas();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    if (frm.perro.Nombre != "")
                    {
                        this.casa += frm.perro;
                    }
                    else
                    {
                        if (frm.gato.Nombre != "")
                        {
                            this.casa += frm.gato;
                        }
                        else
                        {
                            if (frm.loro.Nombre != "")
                            {
                                this.casa += frm.loro;
                            }
                        }
                    }
                    this.ActualizarVisor();
                }
            }
        }
        /// <summary>
        /// Genera un formlario con la lista de Usuarios logueados anteriormente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            string archivo = LeerArchivoLog();
            FrmUsuarios frm = new FrmUsuarios(archivo);
            frm.ShowDialog();
        }

        /// <summary>
        /// Modifica Mascotas segun si es Perro, Gato o Loro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.usuarioLogueado.perfil == "vendedor")
            {
                MessageBox.Show($"Error no puedes modificar mascotas, PERFIL: {usuarioLogueado.perfil}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int indice;
                indice = this.lstMascotas.SelectedIndex;

                if (indice == -1)
                {
                    return;
                }
                Mascota m = this.casa.mascotas[indice];
                if (m is Perro)
                {
                    Perro perro = (Perro)m;
                    FrmModificarPerro frm = new FrmModificarPerro(perro);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        this.casa.mascotas[indice] = frm.perro;
                        this.ActualizarVisor();
                    }
                }
                else
                {
                    if (m is Gato)
                    {
                        Gato gato = (Gato)m;
                        FrmModificarGato frm = new FrmModificarGato(gato);
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            this.casa.mascotas[indice] = frm.gato;
                            this.ActualizarVisor();
                        }
                    }
                    else
                    {
                        Loro loro = (Loro)m;
                        FrmModificarLoro frm = new FrmModificarLoro(loro);
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            this.casa.mascotas[indice] = frm.loro;
                            this.ActualizarVisor();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Elimina Mascotas segun si es Perro, Gato o Loro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.usuarioLogueado.perfil == "vendedor" || this.usuarioLogueado.perfil == "supervisor")
            {
                MessageBox.Show($"Error no puedes eliminar mascotas, PERFIL: {usuarioLogueado.perfil}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int indice;
                indice = this.lstMascotas.SelectedIndex;

                if (indice == -1)
                {
                    return;
                }
                Mascota m = this.casa.mascotas[indice];
                if (m is Perro)
                {
                    Perro perro = (Perro)m;
                    FrmEliminarPerro frm = new FrmEliminarPerro(perro);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        this.casa -= frm.perro;
                        this.ActualizarVisor();
                    }
                }
                else
                {
                    if (m is Gato)
                    {
                        Gato gato = (Gato)m;
                        FrmEliminarGato frm = new FrmEliminarGato(gato);
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            this.casa -= frm.gato;
                            this.ActualizarVisor();
                        }
                    }
                    else
                    {
                        Loro loro = (Loro)m;
                        FrmEliminarLoro frm = new FrmEliminarLoro(loro);
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            this.casa -= frm.loro;
                            this.ActualizarVisor();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Ordena segun el criterio que le pases por el radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (this.rBtnAscendenteEdad.Checked == true)
            {
                this.casa.mascotas.Sort(Casa.OrdenarPorEdadAsc);
                this.ActualizarVisor();

            }
            else if (this.rBtnDescendenteEdad.Checked == true)
            {
                this.casa.mascotas.Sort(Casa.OrdenarPorEdadDesc);
                this.ActualizarVisor();

            }
            else if (this.rBtnAscendentePeso.Checked == true)
            {
                this.casa.mascotas.Sort(Casa.OrdenarPorPesoAsc);
                this.ActualizarVisor();
            }
            else
            {
                if (this.rBtnDescendentePeso.Checked == true)
                {
                    this.casa.mascotas.Sort(Casa.OrdenarPorPesoDesc);
                    this.ActualizarVisor();
                }
                else
                {
                    MessageBox.Show("Marque un criterio de ordenamiento");
                }
            }
        }
        /// <summary>
        /// Guarda la mascota seleccionada por el usuario, en un archivoXML
        /// Utiliza la clase Generica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string path = "mascotaFav.xml";
            Mascota mascotaFav = ObtenerMascota();

            try
            {
                if (mascotaFav == null)
                {
                    MessageBox.Show("No hay mascotas guardadas", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Serializadora<Mascota> serializarMascota = new Serializadora<Mascota>();
                    if (serializarMascota.Serializar(mascotaFav, path))
                    {
                        MessageBox.Show("Se guardo la mascota favorita", "Exitos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error serializando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //XmlSerializer serializador = new XmlSerializer(typeof(List<Mascota>));
                    //serializador.Serialize(escritorxml, this.casa.mascotas);
                    //MessageBox.Show("Se guardaron los datos", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);  

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Obtiene la mascota selecciona en la ListBox
        /// </summary>
        /// <returns></returns>
        private Mascota ObtenerMascota()
        {
            int indice;
            indice = this.lstMascotas.SelectedIndex;

            if (indice == -1)
            {
                MessageBox.Show("Error seleccione una mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            Mascota m = this.casa.mascotas[indice];
            return m;
        }
        /// <summary>
        /// Llama al fusionar lista, le manda una orden await, para que no se tilde
        /// LLama a actualizar visor para actualizar los datos en la ListBox
        /// Actualiza la lista de mascotas de la casa para ver las mascotas del archivo guardado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private async void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            this.casa.mascotas = await this.FusionarListas();
            this.ActualizarVisor();
            //OpenFileDialog frm = new OpenFileDialog();

            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    string Path = frm.FileName;

            //    try
            //    {
            //        using (XmlTextReader lector = new XmlTextReader(Path))
            //        {
            //            XmlSerializer serializador = new XmlSerializer(typeof(List<Mascota>));
            //            this.casa.mascotas = (List<Mascota>)serializador.Deserialize(lector);

            //            this.ActualizarVisor();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        /// <summary>
        /// Segun la mascota que selecciones, te dira el tipo que es
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSonido_Click(object sender, EventArgs e)
        {
            Mascota m = ObtenerMascota();
            if (m == null)
            {
                return;
            }
            else
            {
                MessageBox.Show(m.TipoDeMascota(), "Tipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Segun el animal que selecciones, te emitira un sonido,
        /// Recuerda que si es un loro debe tener la habilidad de repetirPalabras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmitirSonido_Click(object sender, EventArgs e)
        {
            Mascota m = ObtenerMascota();
            if (m == null)
            {
                return;
            }
            else
            {
                MessageBox.Show(m.EmitirSonido(), "Sonido");
            }
        }
        /// <summary>
        /// Deserealiza la mascota guardada por el usuario, usando la clase generica
        /// Abre un form con tu mascota Favorita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string path = "mascotaFav.xml";
            Serializadora<Mascota> serializadora = new Serializadora<Mascota>();
            Mascota mascotaFav = serializadora.Deserializar(path);
            if (mascotaFav == null)
            {
                MessageBox.Show("No se encontro una mascota guardada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MascotaFav frm = new MascotaFav(mascotaFav);
                frm.ShowDialog();
            }
        }
        private void CortarPalabrasLoro(Loro loro)
        {
            try
            {
                string cadenaCortada = loro.Palabra.Substring(0, 4);
                MessageBox.Show("Cadena cortada: " + cadenaCortada, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw new MiExcepcion("Ocurrio un error en: ", loro);
            }
        }
        private void ConvertirMayuscPalabrasLoro(Loro loro)
        {
            try
            { 
                string cadenaMayus = loro.Palabra.ToUpper();
                MessageBox.Show("Cadena en mayuscula: " + cadenaMayus, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw new MiExcepcion("Ocurrio un error en: ", loro);
            }
        }
        private void ContarCaracteresLoro(Loro loro)
        {
            try
            {
                int caracteres = loro.Palabra.Length;
                MessageBox.Show($"Caracteres de la palabra: {caracteres}", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                throw new MiExcepcion("Ocurrio un error en: ", loro);
            }
        }
        /// <summary>
        /// Guarda en el atributo miDelegado de tipo DelegadoPalabras, los metodos que va a invocar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelegado_Click(object sender, EventArgs e)
        {
            try
            {
                this.miDelegado = ContarCaracteresLoro;
                this.miDelegado += ConvertirMayuscPalabrasLoro;
                this.miDelegado += CortarPalabrasLoro;
                Mascota m = ObtenerMascota();
                if(m is Loro)
                {
                    Loro loro = new Loro();
                    loro = (Loro)m;
                    miDelegado(loro);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un loro", "cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(MiExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Recibe un nombre invalido, hace una advertencia
        /// </summary>
        /// <param name="m"></param>
        public static void NombreInvalido(string m)
        {
            MessageBox.Show(m, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
