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
        ValidacionEvento validarNombre;
        public FrmAgregarGato()
        {
            InitializeComponent();
            this.validarNombre = new ValidacionEvento();
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
                this.validarNombre.Nombre = nombre;
                int edad = (int)numEdad.Value;
                decimal peso = numPeso.Value;
                int cantPatas = (int)numPatas.Value;
                int velocidadDeReaccion = (int)numReaccion.Value;
                int metrosDeSalto = (int)numSalto.Value;

                if (rBtnBambino.Checked)
                {
                    if(int.TryParse(this.validarNombre.Nombre,out int id))
                    {
                        this.gato = null;
                    }
                    else
                    {
                        this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Bambino);
                        AccesoADatosGato ado = new AccesoADatosGato();
                        try
                        {
                            ado.Agregar(this.gato);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error agregando gato: " + ex.Message);
                        }
                    }
                }
                else
                {
                    if (rBtnBritanico.Checked)
                    {
                        if (int.TryParse(this.validarNombre.Nombre, out int id))
                        {
                            this.gato = null;
                        }
                        else
                        {
                            this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Bambino);
                            AccesoADatosGato ado = new AccesoADatosGato();
                            try
                            {
                                ado.Agregar(this.gato);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error agregando gato: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        if (rBtnPersa.Checked)
                        {
                            if (int.TryParse(this.validarNombre.Nombre, out int id))
                            {
                                this.gato = null;
                            }
                            else
                            {
                                this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Bambino);
                                AccesoADatosGato ado = new AccesoADatosGato();
                                try
                                {
                                    ado.Agregar(this.gato);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error agregando gato: " + ex.Message);
                                }
                            }
                        }
                        else
                        {
                            if (int.TryParse(this.validarNombre.Nombre, out int id))
                            {
                                this.gato = null;
                            }
                            else
                            {
                                this.gato = new Gato(nombre, edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, ERazaGato.Bambino);
                                AccesoADatosGato ado = new AccesoADatosGato();
                                try
                                {
                                    ado.Agregar(this.gato);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error agregando gato: " + ex.Message);
                                }
                            }
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
