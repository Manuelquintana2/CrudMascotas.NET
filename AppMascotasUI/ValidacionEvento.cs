using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMascotasUI
{
    public delegate void ValidarNombre(string nombre);
    public class ValidacionEvento
    {
        private string nombre;
        public event ValidarNombre validarNombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                this.nombre = value;
                if (int.TryParse(nombre, out int id))
                {
                    this.validarNombre.Invoke($"El nombre: {this.nombre} de la mascota es invalido");
                }
            }
        }
        public ValidacionEvento()
        {
            this.nombre = "";
            this.validarNombre += FrmMascotasPrincipal.NombreInvalido;
        }
    }
}
