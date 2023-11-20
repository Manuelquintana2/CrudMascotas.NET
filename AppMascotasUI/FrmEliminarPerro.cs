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
    public partial class FrmEliminarPerro : FrmEliminar
    {
        public Perro perro;
        public FrmEliminarPerro()
        {
            InitializeComponent();
            this.numComer.ReadOnly = true;
            this.numVelocidad.ReadOnly = true;
        }
        /// <summary>
        /// Rellena los campos con las propiedades del Perro que se le pasa por parametro
        /// </summary>
        /// <param name="perro"></param>
        public FrmEliminarPerro(Perro perro) : this()
        {
            this.txtNombre.Text = perro.Nombre;
            this.numEdad.Value = perro.Edad;
            this.numPatas.Value = perro.CantPatas;
            this.numPeso.Value = perro.Peso;
            this.numComer.Value = perro.VelocidadParaComer;
            this.numVelocidad.Value = perro.KilometrosPorHora;
            this.numId.Value = perro.Id;
            ValidarRaza(perro);
        }
        /// <summary>
        /// Checkea el radioButton respecto a la raza del perro que le pasan por parametro
        /// </summary>
        /// <param name="perro"></param>
        private void ValidarRaza(Perro perro)
        {
            if (perro.Raza == ERazaPerro.Dooberman)
            {
                this.rBtnDooberman.Checked = true;
            }
            else
            {
                if (perro.Raza == ERazaPerro.Galgo)
                {
                    this.rBtnGalgo.Checked = true;
                }
                else
                {
                    if (perro.Raza == ERazaPerro.Pitbull)
                    {
                        this.rBtnPitbull.Checked = true;
                    }
                    else
                    {
                        this.rBtnRotweiller.Checked = true;
                    }
                }
            }
        }

        /// <summary>
        /// Elimina el perro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (base.CargarForm())
            {
                string nombre = txtNombre.Text;
                int edad = (int)numEdad.Value;
                decimal peso = numPeso.Value;
                int cantPatas = (int)numPatas.Value;
                int kmH = (int)numVelocidad.Value;
                int velocidadParaComer = (int)numComer.Value;
                int id = (int)numId.Value;

                if (rBtnGalgo.Checked)
                {
                    this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Galgo, kmH, velocidadParaComer,id);
                    AccesoADatosPerro ado = new AccesoADatosPerro();
                    try
                    {
                        ado.Eliminar(this.perro.Id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar: " + ex.Message);
                    }
                }
                else
                {
                    if (rBtnPitbull.Checked)
                    {
                        this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Pitbull, kmH, velocidadParaComer,id);
                        AccesoADatosPerro ado = new AccesoADatosPerro();
                        try
                        {
                            ado.Eliminar(this.perro.Id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo eliminar: " + ex.Message);
                        }
                    }
                    else
                    {
                        if (rBtnDooberman.Checked)
                        {
                            this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Dooberman, kmH, velocidadParaComer,id);
                            AccesoADatosPerro ado = new AccesoADatosPerro();
                            try
                            {
                                ado.Eliminar(this.perro.Id);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se pudo eliminar: " + ex.Message);
                            }
                        }
                        else
                        {
                            this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Rotweiller, kmH, velocidadParaComer, id);
                            AccesoADatosPerro ado = new AccesoADatosPerro();
                            try
                            {
                                ado.Eliminar(this.perro.Id);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se pudo eliminar: " + ex.Message);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmEliminarPerro_Load(object sender, EventArgs e)
        {

        }
    }
}
