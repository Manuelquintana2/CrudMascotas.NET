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
    public partial class FrmModificarPerro : FrmModificar
    {
        public Perro perro;
        /// <summary>
        /// Desasocia la funcion del boton modificar de la clase base
        /// </summary>
        public FrmModificarPerro()
        {
            InitializeComponent();
            this.btnModificar.Click -= new EventHandler(this.btnModificar_Click);
        }
        /// <summary>
        /// Rellena todos los textbox, los radioButtons, y los numericUpDown con sus respectivos datos.
        /// </summary>
        /// <param name="perro">Recibe un Perro como parametro para rellenar los campos</param>
        public FrmModificarPerro(Perro perro) : this()
        {
            this.txtNombre.Text = perro.Nombre;
            this.numEdad.Value = perro.Edad;
            this.numPatas.Value = perro.CantPatas;
            this.numPeso.Value = perro.Peso;
            this.numComer.Value = perro.VelocidadParaComer;
            this.numVelocidad.Value = perro.KilometrosPorHora;
            ValidarRaza(perro);
        }
        /// <summary>
        /// Checkea el radio button segun la raza del perro
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
        /// Crea el nuevo perro modificado
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
                int kmH = (int)numVelocidad.Value;
                int velocidadParaComer = (int)numComer.Value;
                int id = (int)numId.Value;

                if (rBtnGalgo.Checked)
                {
                    this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Galgo, kmH, velocidadParaComer, id);
                    AccesoADatos.modificarPerro(this.perro);
                }
                else
                {
                    if (rBtnPitbull.Checked)
                    {
                        this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Pitbull, kmH, velocidadParaComer,id);
                        AccesoADatos.modificarPerro(this.perro);
                    }
                    else
                    {
                        if (rBtnDooberman.Checked)
                        {
                            this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Dooberman, kmH, velocidadParaComer,id);
                            AccesoADatos.modificarPerro(this.perro);
                        }
                        else
                        {
                            this.perro = new Perro(nombre, edad, peso, cantPatas, ERazaPerro.Rotweiller, kmH, velocidadParaComer, id);
                            AccesoADatos.modificarPerro(this.perro);
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
        /// Cancela la accion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmModificarPerro_Load(object sender, EventArgs e)
        {

        }
    }
}
