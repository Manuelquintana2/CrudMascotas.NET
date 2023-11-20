using Entidades;
using System.Text;
using System.Text.Json;

namespace AppMascotasUI
{
    public partial class FrmLogin : Form
    {
        private List<Usuario> listasUsuario;
        private Usuario ingresar;
        private int cantIntentos;
        /// <summary>
        /// COnstructor del login
        /// Iniciliza los atributos, pone en true el modo contraseña del textbox clave
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            this.listasUsuario = new List<Usuario>();
            cantIntentos = 3;
            ingresar = new Usuario();
            this.txtClave.UseSystemPasswordChar = true;
        }
        /// <summary>
        /// Lee el archivo json con los usuarios registrados, se los asigna a una lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string path = "MOCK_DATA.json";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string json_str = sr.ReadToEnd();
                    this.listasUsuario = (List<Usuario>)JsonSerializer.Deserialize(json_str, typeof(List<Usuario>));
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error no se encontro el archivo");
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }

        }
        /// <summary>
        /// Verifica si el usuario que ingreso es correcto, si no lo es, le resta intentos
        /// Si se queda sin entonces se cierra la app
        /// Si ingresa oculta el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.ingresar.correo = txtUsuario.Text;
            this.ingresar.clave = txtClave.Text;
            bool retorno = false;

            foreach (Usuario usuario in listasUsuario)
            {
                if (this.ingresar.correo == usuario.correo && ingresar.clave == usuario.clave)
                {
                    this.ingresar = usuario;
                    MessageBox.Show($"Bienvenido {this.ingresar.nombre}", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmMascotasPrincipal frm = new FrmMascotasPrincipal(this.ingresar);
                    retorno = true;
                    this.Hide();
                    frm.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    RegistrarUsuarios();
                    break;
                }
            }
            if (retorno == false && this.cantIntentos > 1)
            {
                cantIntentos--;
                MessageBox.Show($"Contraseña incorrecta, quedan {this.cantIntentos} intentos","Incorrecto");
            }
            else
            {
                this.Close();
            }
        }
        /// <summary>
        /// Si no existe, crea, y si existe le añade al archivo el nombre, apellido y fecha con año,meses,
        /// dias,minutos y segundos del usuario que se logueo.
        /// </summary>
        private void RegistrarUsuarios()
        {
            Encoding miCodificacion = Encoding.UTF8;
            DateTime fecha = new DateTime();

            fecha = DateTime.Now;
            try
            {
                StreamWriter sw = new StreamWriter("./Usuarios.log", true, miCodificacion);
                sw.WriteLine($"{this.ingresar.nombre}-{this.ingresar.apellido}-{fecha},");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        /// <summary>
        /// Boton que oculta o muestra la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (this.txtClave.UseSystemPasswordChar)
            {
                this.txtClave.UseSystemPasswordChar = !this.txtClave.UseSystemPasswordChar;
                this.btnMostrar.Text = "Ocultar";
            }
            else
            {
                this.txtClave.UseSystemPasswordChar = !this.txtClave.UseSystemPasswordChar;
                this.btnMostrar.Text = "Mostrar";
            }
        }
    }
}