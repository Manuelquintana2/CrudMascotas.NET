using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Perro que hereda de Mascota
    /// </summary>
    public class Perro : Mascota
    {
        private int kilometrosPorHora;
        private int velocidadParaComer;
        private ERazaPerro raza;
        /// <summary>
        /// Propiedades autoimplementadas para obtener y settear el valor de los atributos
        /// </summary>
        public int KilometrosPorHora { get => kilometrosPorHora; set => kilometrosPorHora = value; }
        public int VelocidadParaComer { get => velocidadParaComer; set => velocidadParaComer = value; }
        public ERazaPerro Raza { get => raza; set => raza = value; }



        public Perro(string nombre, int edad, decimal peso, int cantPatas, ERazaPerro raza, int kilometrosPorHora, int velocidadParaComer, int id) : this(nombre, edad, peso, cantPatas, raza, kilometrosPorHora, velocidadParaComer)
        {
            this.id = id;
        }

        /// <summary>
        /// Constructor que recibe todos los parametros para sus atributos, 
        /// llama a otro constructor que inicializa otros atributos
        /// Inicializa un atributo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="peso"></param>
        /// <param name="cantPatas"></param>
        /// <param name="raza"></param>
        /// <param name="kilometrosPorHora"></param>
        /// <param name="velocidadParaComer"></param>
        public Perro(string nombre, int edad, decimal peso, int cantPatas, ERazaPerro raza, int kilometrosPorHora ,int velocidadParaComer):this(nombre,edad, peso, cantPatas, raza,velocidadParaComer)
        {
            this.KilometrosPorHora = kilometrosPorHora;
        }
        /// <summary>
        /// Constructor que llama al de la clase Base para inicializar todos sus atributos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="peso"></param>
        /// <param name="cantPatas"></param>
        /// <param name="raza"></param>
        /// <param name="velocidadParaComer"></param>
        public Perro(string nombre, int edad,decimal peso,int cantPatas, ERazaPerro raza, int velocidadParaComer):base(nombre, edad, peso, cantPatas)
        {
            this.VelocidadParaComer = velocidadParaComer;
            this.Raza = raza;
        }
        /// <summary>
        /// Constructor vacio que llama al de la clase base para inicializar sus valores en nulo
        /// </summary>
        public Perro():base()
        {
            this.KilometrosPorHora = 0;
            this.VelocidadParaComer = 0;
            this.Raza = 0;
        }
        /// <summary>
        /// Metodo virtual sobreescrito que dice el tipo de mascota
        /// </summary>
        /// <returns></returns>

        public override string TipoDeMascota()
        {
            return "Soy un perro";
        }
        /// <summary>
        /// metodo sobrecargado, hace lo mismo que el anterior pero le agrega el dato de la edad
        /// </summary>
        /// <param name="edad"></param>
        /// <returns></returns>
        public virtual string TipoDeMascota(int edad)
        {
            return $"Soy un perro con {this.Edad} años";
        }
        /// <summary>
        /// Metodo sobreescrito que muestra todos los datos del Perro
        /// </summary>
        /// <returns>Retorna un string con todos los datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PERRO: ");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Velocidad: {this.KilometrosPorHora} Km/H--");
            sb.AppendLine($"Tarda {this.VelocidadParaComer} minutos para comer--");
            sb.AppendLine($"Raza: {this.Raza}");
            
            return sb.ToString();
        }
        /// <summary>
        /// Metodo Abstracto en la clase base, sobreescrito para que emita el sonido de un perro
        /// </summary>
        /// <returns></returns>
        public override string EmitirSonido()
        {
            return "guau";
        }
    }
}
