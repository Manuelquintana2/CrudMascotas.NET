using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase gato que deriva de Mascota
    /// </summary>
    public class Gato:Mascota
    {
        private int velocidadDeReaccion;
        private int metrosDeSalto;
        private ERazaGato raza;
        /// <summary>
        /// Propiedades para todos los atributos propios de Gato
        /// </summary>
        public int VelocidadDeReaccion
        {
            get { return this.velocidadDeReaccion; }
            set { this.velocidadDeReaccion = value; }
        }

        public int MetrosDeSalto
        {
            get { return this.metrosDeSalto; }
            set { this.metrosDeSalto = value; }
        }
        
        public ERazaGato Raza
        {
            get { return this.raza; }
            set { this.raza = value; }
        }

        public Gato(string nombre, int edad, decimal peso, int cantPatas, int velocidadDeReaccion, int metrosDeSalto, ERazaGato raza, int id):this(nombre,edad, peso, cantPatas, velocidadDeReaccion, metrosDeSalto, raza)
        {
            this.id = id;
        }
        /// <summary>
        /// Constructor de la clase gato que recibe algunos parametros, llama al constructor base
        /// Inicializa un atributo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="peso"></param>
        /// <param name="cantPatas"></param>
        /// <param name="velocidadDeReaccion"></param>
        public Gato(string nombre, int edad, decimal peso, int cantPatas,int velocidadDeReaccion):base(nombre, edad, peso, cantPatas)
        {
            this.velocidadDeReaccion = velocidadDeReaccion;
        }
        /// <summary>
        /// SobreCarga que recibe todos los parametros, llama al constructor anterior
        /// Inicializa dos atributos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="peso"></param>
        /// <param name="cantPatas"></param>
        /// <param name="velocidadDeReaccion"></param>
        /// <param name="metrosDeSalto"></param>
        /// <param name="raza"></param>
        public Gato(string nombre, int edad, decimal peso, int cantPatas, int velocidadDeReaccion, int metrosDeSalto, ERazaGato raza) : this(nombre, edad, peso, cantPatas, velocidadDeReaccion)
        {
            this.metrosDeSalto = metrosDeSalto;
            this.raza = raza;
        }
        /// <summary>
        /// Sobrecarga de constructor vacio que llama al constructor de la clase base que tambien esta vacio
        /// Inicializa todo en valores nulos
        /// </summary>
        public Gato():base()
        {
            this.velocidadDeReaccion = 0;
            this.metrosDeSalto= 0;
            this.raza = 0;
        }
        /// <summary>
        /// Metodo virtual sobreescrito que dice que tipo de mascota es
        /// </summary>
        /// <returns>Retorna un string un el dato</returns>
        public override string TipoDeMascota()
        {
            return "Soy un gato";
        }
        /// <summary>
        /// SobreCarga del metodo, le agrega el dato de la edad
        /// </summary>
        /// <param name="edad"></param>
        /// <returns>Retorna un string con el tipo de mascota y su edad</returns>
        public virtual string TipoDeMascota(int edad)
        {
            return $"Soy un gato con {this.Edad} años";
        }
        /// <summary>
        /// Metodo ToString sobreCargado para mostrar todos los datos del Gato
        /// </summary>
        /// <returns>Retorna un string con los Datos cargados</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("GATO: ");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Reacciona en: {this.velocidadDeReaccion} segundos--");
            sb.AppendLine($"Salta hasta {this.metrosDeSalto} metros--");
            sb.AppendLine($"Raza {this.raza}");

            return sb.ToString();
        }
        /// <summary>
        /// Metodo abstracto sobreescrito que emite el sonido del animal
        /// </summary>
        /// <returns></returns>
        public override string EmitirSonido()
        {
            return "Miau";
        }
    }
}
