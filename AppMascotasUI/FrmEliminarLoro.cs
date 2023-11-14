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
    public partial class FrmEliminarLoro : FrmEliminar
    {
        public Loro loro;
        public FrmEliminarLoro()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Rellena los campos con los datos del loro pasado por parametro
        /// </summary>
        /// <param name="loro"></param>
        public FrmEliminarLoro(Loro loro) : this()
        {
            this.txtNombre.Text = loro.Nombre;
            this.numEdad.Value = loro.Edad;
            this.numPatas.Value = loro.CantPatas;
            this.numPeso.Value = loro.Peso;
            this.numAltura.Value = loro.MetrosDeVuelo;
            this.numTiempoVuelo.Value = loro.TiempoDeVuelo;
            this.txtFrase.Text = loro.Palabra;
            AsignarTexto(loro);
            ValidarTipo(loro);
        }
        /// <summary>
        /// Checkea el radio button segun el tipo de loro que sea
        /// </summary>
        /// <param name="loro"></param>
        private void ValidarTipo(Loro loro)
        {
            if (loro.Tipo == ETipoLoro.Africano)
            {
                this.rBtnAfricano.Checked = true;
            }
            else
            {
                if (loro.Tipo == ETipoLoro.DeAmazonas)
                {
                    this.rBtnAmazonico.Checked = true;
                }
                else
                {
                    if (loro.Tipo == ETipoLoro.Guacamayo)
                    {
                        this.rBtnGuacamayo.Checked = true;
                    }
                    else
                    {
                        this.rBtnEclecto.Checked = true;
                    }
                }
            }
        }
        /// <summary>
        /// Rellena el textbox segun si el loro pasado por parametro puede hablar o no
        /// </summary>
        /// <param name="loro"></param>
        private void AsignarTexto(Loro loro)
        {
            if (loro.RepetirPalabras == true)
            {
                txtRepite.Text = "si";
            }
            else
            {
                txtRepite.Text = "no";
            }
        }
        /// <summary>
        /// Devuelve un booleano dependiendo si el loro sabe hablar "si" o no lo sabe "no"
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
        /// <summary>
        /// Verifica que el usuario ingrese si o no
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
        /// Elimina el loro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.ValidarTexto() && base.CargarForm())
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
