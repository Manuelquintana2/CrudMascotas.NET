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
    public partial class FrmAgregarPerro : Form
    {
        public Perro perro;
        ValidacionEvento validarNombre;
        public FrmAgregarPerro()
        {
            InitializeComponent();
            this.validarNombre = new ValidacionEvento();
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
                this.validarNombre.Nombre = nombre;
                int edad = (int)numEdad.Value;
                decimal peso = numPeso.Value;
                int cantPatas = (int)numPatas.Value;
                int kmH = (int)numVelocidad.Value;
                int velocidadParaComer = (int)numComer.Value;

                if (rBtnGalgo.Checked)
                {
                    if(int.TryParse(this.validarNombre.Nombre, out int id))
                    {
                        this.perro = new Perro();
                    }
                    else
                    {
                        this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Galgo, kmH, velocidadParaComer);
                        AccesoADatosPerro ado = new AccesoADatosPerro();
                        try
                        {
                            ado.Agregar(this.perro);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error agregando perro: " +ex.Message);
                        }
                    }
                }
                else
                {
                    if (rBtnPitbull.Checked)
                    {
                        if (int.TryParse(this.validarNombre.Nombre, out int id))
                        {
                            this.perro = new Perro();
                        }
                        else
                        {
                            this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Pitbull, kmH, velocidadParaComer);
                            AccesoADatosPerro ado = new AccesoADatosPerro();
                            try
                            {
                                ado.Agregar(this.perro);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error agregando perro: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        if (rBtnDooberman.Checked)
                        {
                            if (int.TryParse(this.validarNombre.Nombre, out int id))
                            {
                                this.perro = new Perro();
                            }
                            else
                            {
                                this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Dooberman, kmH, velocidadParaComer);
                                AccesoADatosPerro ado = new AccesoADatosPerro();
                                try
                                {
                                    ado.Agregar(this.perro);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error agregando perro: " + ex.Message);
                                }
                            }
                        }
                        else
                        {
                            if (int.TryParse(this.validarNombre.Nombre, out int id))
                            {
                                this.perro = new Perro();
                            }
                            else
                            {
                                this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Rotweiller, kmH, velocidadParaComer);
                                AccesoADatosPerro ado = new AccesoADatosPerro();
                                try
                                {
                                    ado.Agregar(this.perro);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error agregando perro: " + ex.Message);
                                }
                            }
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
