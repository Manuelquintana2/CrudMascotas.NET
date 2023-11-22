using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMascotasUI
{
    /// <summary>
    /// Delegado para hacer un evento, sus metodos recibiran un nombre
    /// </summary>
    /// <param name="nombre"></param>
    public delegate void ValidarNombre(string nombre);
    /// <summary>
    /// Clase para soltar un evento cuando el nombre sea invalido
    /// </summary>
    public class ValidacionEvento
    {
        private string nombre;
        public event ValidarNombre validarNombre;

        /// <summary>
        /// Propiedad
        /// Si el nombre da true al momento de parsearlo, significa que es un numero, se invoca al evento.
        /// </summary>
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
        /// <summary>
        /// Setea los atributos por default, se le agrega un metodo al evento validarNombre,
        /// </summary>
        public ValidacionEvento()
        {
            this.nombre = "";
            this.validarNombre += FrmMascotasPrincipal.NombreInvalido;
        }
    }
}
