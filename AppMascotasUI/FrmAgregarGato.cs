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

namespace AppMascotasUI
{
    public partial class FrmAgregarGato : Form
    {
        public Gato gato;
        public FrmAgregarGato()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Agrega una instancia de gato y se le asigna al atributo
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
                int velocidadDeReaccion = (int)numReaccion.Value;
                int metrosDeSalto = (int)numSalto.Value;

                if (rBtnBambino.Checked)
                {
                    this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Bambino);
                    AccesoADatosGato ado = new AccesoADatosGato();
                    ado.Agregar(this.gato);
                }
                else
                {
                    if (rBtnBritanico.Checked)
                    {
                        this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Britanico);
                        AccesoADatosGato ado = new AccesoADatosGato();
                        ado.Agregar(this.gato);
                    }
                    else
                    {
                        if (rBtnPersa.Checked)
                        {
                            this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Persa);
                            AccesoADatosGato ado = new AccesoADatosGato();
                            ado.Agregar(this.gato);
                        }
                        else
                        {
                            this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Siames);
                            AccesoADatosGato ado = new AccesoADatosGato();
                            ado.Agregar(this.gato);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmAgregarGato_Load(object sender, EventArgs e)
        {

        }
    }
}
