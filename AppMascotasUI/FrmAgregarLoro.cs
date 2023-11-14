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
    public partial class FrmAgregarLoro : Form
    {
        public Loro loro;
        public FrmAgregarLoro()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Se crea una instancia de Loro y se le asigna al atributo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {  
            if (this.ValidarTexto() && this.CargarForm())
            {
                bool repite = VerificarSiRepitePalabras();
                string nombre = txtNombre.Text;
                int edad = (int)numEdad.Value;
                decimal peso = numPeso.Value;
                int cantPatas = (int)numPatas.Value;
                int tiempoDeVuelo = (int)numTiempoVuelo.Value;
                int metrosDeVuelo = (int)numAltura.Value;
                string palabra = txtFrase.Text;

                if (rBtnAfricano.Checked)
                {
                    this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.Africano, tiempoDeVuelo, metrosDeVuelo, repite, palabra);
                }
                else
                {
                    if (rBtnAmazonico.Checked)
                    {
                        this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.DeAmazonas, tiempoDeVuelo, metrosDeVuelo, repite, palabra);
                    }
                    else
                    {
                        if (rBtnEclecto.Checked)
                        {
                            this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.Eclecto, tiempoDeVuelo, metrosDeVuelo, repite, palabra);
                        }
                        else
                        {

                            this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.Guacamayo, tiempoDeVuelo, metrosDeVuelo, repite, palabra);
                        }
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Complete los campos","Cuidado");
            }
        }
        /// <summary>
        /// Verifica que los textbox no esten nulos
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
        /// <summary>
        /// Valida que el usuario ingres si o no
        /// </summary>
        /// <returns></returns>
        private bool ValidarTexto()
        {
            bool retorno = false;
            this.txtRepite.Text = this.txtRepite.Text.ToLower();
            if (this.txtRepite.Text == "si" || this.txtRepite.Text == "no")
            {
                retorno = true;
            }
            else
            {
                MessageBox.Show("Ingrese: SI/NO");
                retorno = false;
            }
            return retorno;
        }
        /// <summary>
        /// Devuelve un bool dependiendo si sabe hablar o no
        /// </summary>
        /// <returns></returns>
        private bool VerificarSiRepitePalabras()
        {
            bool verificado = true;
            if (txtRepite.Text == "si")
            {
                verificado = true;
            }
            else
            {
                verificado = false;
            }
            return verificado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
