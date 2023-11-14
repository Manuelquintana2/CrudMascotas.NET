using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMascotasUI
{
    public partial class FrmAgregarPerro : Form
    {
        public Perro perro;
        public FrmAgregarPerro()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Crea una instancia de Perro y se la asigna al atributo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.CargarForm())
            {
                string nombre = txtNombre.Text;
                int edad = (int)numEdad.Value;
                decimal peso = numPeso.Value;
                int cantPatas = (int)numPatas.Value;
                int kmH = (int)numVelocidad.Value;
                int velocidadParaComer = (int)numComer.Value;

                if (rBtnGalgo.Checked)
                {
                    this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Galgo, kmH, velocidadParaComer);
                }
                else
                {
                    if (rBtnPitbull.Checked)
                    {
                        this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Pitbull, kmH, velocidadParaComer);
                    }
                    else
                    {
                        if (rBtnDooberman.Checked)
                        {
                            this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Dooberman, kmH, velocidadParaComer);
                        }
                        else
                        {

                            this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Rotweiller, kmH, velocidadParaComer);
                        }
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Complete el nombre","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Verifica que los textbox no esten vacios
        /// </summary>
        /// <returns></returns>
        private bool CargarForm()
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
    }
}
