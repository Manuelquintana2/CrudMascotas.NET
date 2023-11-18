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
    public partial class FrmEliminarGato : FrmEliminar
    {
        public Gato gato;
        public FrmEliminarGato()
        {
            InitializeComponent();
            this.numReaccion.ReadOnly = true;
            this.numSalto.ReadOnly = true;
        }
        /// <summary>
        /// Rellena los campos con los correspondientes datos del Gato pasado por parametro
        /// </summary>
        /// <param name="gato"></param>
        public FrmEliminarGato(Gato gato) : this()
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
        /// Checkea el radio button de la raza segun la raza del gato pasado por parametro
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
        /// Elimina el gato.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.CargarForm())
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
                    AccesoADatos.EliminarGato(this.gato.Id);
                }
                else
                {
                    if (rBtnBritanico.Checked)
                    {
                        this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Britanico,id);
                        AccesoADatos.EliminarGato(this.gato.Id);
                    }
                    else
                    {
                        if (rBtnPersa.Checked)
                        {
                            this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Persa,id);
                            AccesoADatos.EliminarGato(this.gato.Id);
                        }
                        else
                        {
                            this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Siames,id);
                            AccesoADatos.EliminarGato(this.gato.Id);
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
        private void FrmEliminarGato_Load(object sender, EventArgs e)
        {

        }
    }
}
