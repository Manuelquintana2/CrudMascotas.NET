using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMascotasUI
{
    public partial class FrmModificar : Form
    {
        public Mascota mascota;

        public FrmModificar()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Rellena los campos con los datos de la mascota
        /// </summary>
        /// <param name="mascota"></param>
        public FrmModificar(Mascota mascota)
        {
            this.txtId.Text = mascota.Id.ToString();
            this.txtNombre.Text = mascota.Nombre;
            this.numEdad.Value = mascota.Edad;
            this.numPatas.Value = mascota.CantPatas;
            this.numPeso.Value = mascota.Peso;

        }
        /// <summary>
        /// Funcion que verifica que los textbox no esten vacios
        /// </summary>
        /// <returns></returns>
        protected bool CargarForm()
        {
            bool cargado = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox & control.Text == String.Empty)
                {
                    cargado = false;
                    break;
                }
            }
            return cargado;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = (int)numEdad.Value;
            decimal peso = numPeso.Value;
            int cantPatas = (int)numPatas.Value;
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {

        }
    }
}
