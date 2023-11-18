using BaseDeDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMascotasUI
{
    public partial class FrmModificarGato : FrmModificar
    {
        public Gato gato;
        public FrmModificarGato()
        {
            InitializeComponent();
            this.btnModificar.Click -= new EventHandler(this.btnModificar_Click);
        }
        /// <summary>
        /// Rellena los campos con los respectivos valores del gato
        /// </summary>
        /// <param name="gato"></param>
        public FrmModificarGato(Gato gato) : this()
        {
            this.txtNombre.Text = gato.Nombre;
            this.numEdad.Value = gato.Edad;
            this.numPatas.Value = gato.CantPatas;
            this.numPeso.Value = gato.Peso;
            this.numReaccion.Value = gato.VelocidadDeReaccion;
            this.numSalto.Value = gato.MetrosDeSalto;
            this.numId.Value = gato.Id;
            ValidarRaza(gato);
        }
        /// <summary>
        /// Checkea el boton correspondiente segun la raza del gato
        /// </summary>
        /// <param name="gato"></param>
        private void ValidarRaza(Gato gato)
        {
            if (gato.Raza == ERazaGato.Siames)
            {
                this.rBtnSiames.Checked = true;
            }
            else
            {
                if (gato.Raza == ERazaGato.Britanico)
                {
                    this.rBtnBritanico.Checked = true;
                }
                else
                {
                    if (gato.Raza == ERazaGato.Bambino)
                    {
                        this.rBtnBambino.Checked = true;
                    }
                    else
                    {
                        this.rBtnPersa.Checked = true;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Crea el nuevo gato modificado 
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
                int velocidadDeReaccion = (int)numReaccion.Value;
                int metrosDeSalto = (int)numSalto.Value;
                int id = (int)numId.Value;

                if (rBtnBambino.Checked)
                {
                    this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Bambino,id);
                    AccesoADatosGato ado = new AccesoADatosGato();
                    ado.Modificar(this.gato);
                }
                else
                {
                    if (rBtnBritanico.Checked)
                    {
                        this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Britanico,id);
                        AccesoADatosGato ado = new AccesoADatosGato();
                        ado.Modificar(this.gato);
                    }
                    else
                    {
                        if (rBtnPersa.Checked)
                        {
                            this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Persa, id);
                            AccesoADatosGato ado = new AccesoADatosGato();
                            ado.Modificar(this.gato);
                        }
                        else
                        {
                            this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Siames, id);
                            AccesoADatosGato ado = new AccesoADatosGato();
                            ado.Modificar(this.gato);
                        }
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Complete el nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
