using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMascotasUI
{
    public partial class MascotaFav : Form
    {
        public Mascota mascota;

        public MascotaFav()
        {
            InitializeComponent();
        }
        public MascotaFav(Mascota mascota) : this()
        {
            this.mascota = mascota;
        }
        private void DeterminarImagen()
        {
            if (this.mascota is Perro)
            {
                this.imagenMascota.ImageLocation = "./perro.jpg";
            }
            else
            {
                if (this.mascota is Gato)
                {
                    this.imagenMascota.ImageLocation = "./gato.jpg";
                }
                else
                {
                    this.imagenMascota.ImageLocation = "./loro.jpg";
                }
            }
        }
        private void AsignarTexto()
        {
            label1.Text = "Mi nombre es "+ this.mascota.Nombre;
            label2.Text = "Tengo "+this.mascota.Edad.ToString() + "Años";
            label4.Text = this.mascota.EmitirSonido();
        }

        private void MascotaFav_Load(object sender, EventArgs e)
        {
            DeterminarImagen();
            AsignarTexto();
        }
    }
}
