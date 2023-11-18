using BaseDeDatos;
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
    public partial class FrmModificarLoro : FrmModificar
    {
        public Loro loro;
        /// <summary>
        /// Constructor default, desasocia la funcion del boton de la clase padre
        /// </summary>
        public FrmModificarLoro()
        {
            InitializeComponent();
            this.btnModificar.Click -= new EventHandler(this.btnModificar_Click);
        }
        /// <summary>
        /// Rellena los campos con los datos del Loro que le hayan pasado por parametro
        /// </summary>
        /// <param name="loro"></param>
        public FrmModificarLoro(Loro loro) : this()
        {
            this.txtNombre.Text = loro.Nombre;
            this.numEdad.Value = loro.Edad;
            this.numPatas.Value = loro.CantPatas;
            this.numPeso.Value = loro.Peso;
            this.numAltura.Value = loro.MetrosDeVuelo;
            this.numTiempoVuelo.Value = loro.TiempoDeVuelo;
            this.txtFrase.Text = loro.Palabra;
            this.numId.Value = loro.Id;
            ValidarTipo(loro);
        }
        /// <summary>
        /// Checkea el radio button que corresponde segun el tipo de loro
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
        /// Crea un nuevo loro modificado, valida que no falte completar ningun campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (base.CargarForm())
            {
                string nombre = txtNombre.Text;
                int edad = (int)numEdad.Value;
                decimal peso = numPeso.Value;
                int cantPatas = (int)numPatas.Value;
                int tiempoDeVuelo = (int)numTiempoVuelo.Value;
                int metrosDeVuelo = (int)numAltura.Value;
                string palabra = txtFrase.Text;
                int id = (int)numId.Value;

                if (rBtnAfricano.Checked)
                {
                    this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.Africano, tiempoDeVuelo, metrosDeVuelo, palabra, id);
                    AccesoADatos.modificarLoro(this.loro);
                }
                else
                {
                    if (rBtnAmazonico.Checked)
                    {
                        this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.DeAmazonas, tiempoDeVuelo, metrosDeVuelo, palabra, id);
                        AccesoADatos.modificarLoro(this.loro);
                    }
                    else
                    {
                        if (rBtnEclecto.Checked)
                        {
                            this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.Eclecto, tiempoDeVuelo, metrosDeVuelo, palabra, id);
                            AccesoADatos.modificarLoro(this.loro);
                        }
                        else
                        {
                            this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.Guacamayo, tiempoDeVuelo, metrosDeVuelo, palabra, id);
                            AccesoADatos.modificarLoro(this.loro);
                        }
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Complete los campos", "Cuidado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmModificarLoro_Load(object sender, EventArgs e)
        {

        }
    }
}
