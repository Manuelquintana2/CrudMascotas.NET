using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AppMascotasUI
{
    public partial class FrmEliminar : Form
    {
        public Mascota mascota;
        public FrmEliminar()
        {
            InitializeComponent();
            this.txtNombre.ReadOnly = true;
            this.numEdad.ReadOnly = true;
            this.numPatas.ReadOnly = true;
            this.numPeso.ReadOnly = true;
        }
        /// <summary>
        /// Rellena los campos con los datos de la mascota
        /// </summary>
        /// <param name="mascota"></param>
        public FrmEliminar(Mascota mascota) : this()
        {
            this.txtNombre.Text = mascota.Nombre;
            this.numEdad.Value = mascota.Edad;
            this.numPatas.Value = mascota.CantPatas;
            this.numPeso.Value = mascota.Peso;
        }
        /// <summary>
        /// Verifica que los textbox no esten vacios
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

        private void FrmEliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
