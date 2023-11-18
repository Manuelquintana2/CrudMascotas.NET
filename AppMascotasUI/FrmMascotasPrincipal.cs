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
    public partial class FrmMascotasPrincipal : Form
    {
        /// <summary>
        /// Crea la lista de mascotas que le pasara por parametro a el atributo casa
        /// </summary>
        private List<Mascota> mascotas;
        private Usuario usuarioLogueado;
        private string fecha;
        private Casa casa;
        /// <summary>
        /// Inicializa la lista de mascotas
        /// inicializa la fecha con el formato corto
        /// </summary>
        public FrmMascotasPrincipal()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + "./fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.mascotas = new List<Mascota>();
            this.fecha = DateTime.Now.ToShortDateString();
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

        private List<Mascota> FusionarListas()
        {
            List<Mascota> mascotas = new List<Mascota>();
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
        }
        /// <summary>
        /// Escribe el nombre, Apellido, y la fecha del usuario que esta logueado actualmente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMascotasPrincipal_Load(object sender, EventArgs e)
        {
            lblArchivo.Text = $"Nombre: {this.usuarioLogueado.nombre} {Environment.NewLine}" +
                $"Apellido: {this.usuarioLogueado.apellido} {Environment.NewLine}" +
                $"Fecha: {this.fecha}";

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
            catch (Exception ex)
            {
                MessageBox.Show("Error");
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
        /// Guarda el archivo con el registro de la lista de mascotas donde quiera el usuario
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
        /// Abre el archivo con el registro de la lista de mascotas donde eligio el usuario y lo deserealiza
        /// Actualiza la lista de mascotas de la casa para ver las mascotas del archivo guardado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            this.casa.mascotas = FusionarListas();
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
            int indice;
            indice = this.lstMascotas.SelectedIndex;

            if (indice == -1)
            {
                return;
            }
            Mascota m = this.casa.mascotas[indice];
            MessageBox.Show(m.TipoDeMascota(), "Tipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Segun el animal que selecciones, te emitira un sonido,
        /// Recuerda que si es un loro debe tener la habilidad de repetirPalabras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmitirSonido_Click(object sender, EventArgs e)
        {
            int indice;
            indice = this.lstMascotas.SelectedIndex;

            if (indice == -1)
            {
                return;
            }
            Mascota m = this.casa.mascotas[indice];
            MessageBox.Show(m.EmitirSonido(), "Sonido");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string path = "mascotaFav.xml";
            try
            {
                Serializadora<Mascota> serializadora = new Serializadora<Mascota>();
                Mascota mascotaFav = serializadora.Deserializar(path);
                MascotaFav frm = new MascotaFav(mascotaFav);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro una mascota guardada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
