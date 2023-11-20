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
    public partial class FrmAgregarLoro : Form
    {
        public Loro loro;
        ValidacionEvento validarNombre;
        public FrmAgregarLoro()
        {
            InitializeComponent();
            this.validarNombre = new ValidacionEvento();
        }
        /// <summary>
        /// Se crea una instancia de Loro y se le asigna al atributo
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
                int tiempoDeVuelo = (int)numTiempoVuelo.Value;
                int metrosDeVuelo = (int)numAltura.Value;
                string palabra = txtFrase.Text;

                if (rBtnAfricano.Checked)
                {
                    if(int.TryParse(this.validarNombre.Nombre, out int id))
                    {
                        this.loro = new Loro();
                    }
                    else
                    {
                        this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.Africano, tiempoDeVuelo, metrosDeVuelo, palabra);
                        AccesoADatosLoro ado = new AccesoADatosLoro();
                        try
                        {
                            ado.Agregar(this.loro);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("No se pudo agregar: " + ex.Message);
                        }
                    }
                }
                else
                {
                    if (rBtnAmazonico.Checked)
                    {
                        if (int.TryParse(this.validarNombre.Nombre, out int id))
                        {
                            this.loro = new Loro();
                        }
                        else
                        {
                            this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.DeAmazonas, tiempoDeVuelo, metrosDeVuelo, palabra);
                            AccesoADatosLoro ado = new AccesoADatosLoro();
                            try
                            {
                                ado.Agregar(this.loro);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se pudo agregar: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        if (rBtnEclecto.Checked)
                        {
                            if (int.TryParse(this.validarNombre.Nombre, out int id))
                            {
                                this.loro = new Loro();
                            }
                            else
                            {
                                this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.Eclecto, tiempoDeVuelo, metrosDeVuelo, palabra);
                                AccesoADatosLoro ado = new AccesoADatosLoro();
                                try
                                {
                                    ado.Agregar(this.loro);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("No se pudo agregar: " + ex.Message);
                                }
                            }
                        }
                        else
                        {
                            if (int.TryParse(this.validarNombre.Nombre, out int id))
                            {
                                this.loro = new Loro();
                            }
                            else
                            {
                                this.loro = new Loro(nombre, edad, peso, cantPatas, ETipoLoro.Guacamayo, tiempoDeVuelo, metrosDeVuelo, palabra);
                                AccesoADatosLoro ado = new AccesoADatosLoro();
                                try
                                {
                                    ado.Agregar(this.loro);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("No se pudo agregar: " + ex.Message);
                                }
                            }
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
