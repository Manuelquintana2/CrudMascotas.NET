using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Perro))]
    [XmlInclude(typeof(Gato))]
    [XmlInclude(typeof(Loro))]
    
    
    /// <summary>
    /// Clase Base abstracta mascota
    /// </summary>
    public abstract class Mascota
    {
        protected int id;
        protected string nombre;
        protected int edad;
        protected decimal peso;
        protected int cantPatas;
        /// <summary>
        /// Propiedades para poder obtener y setear los valores de los atributos
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad;}
            set { edad = value; }
        }
        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public int CantPatas
        {
            get { return cantPatas; }
            set { cantPatas = value; }
        }
        /// <summary>
        /// Sobrecarga de constructor que no recibe parametros
        /// </summary>
        public Mascota()
        {
            this.nombre = string.Empty;
            this.edad = 0;
            this.peso = 0;
            this.cantPatas = 0;
        }
        /// <summary>
        /// Sobrecarga de constructor que recibe 3 parametros y utiliza el this para llamar 
        /// al constructor que sea necesario
        /// Inicializa atributos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="peso"></param>
        public Mascota(string nombre,int edad,decimal peso):this(nombre,edad)
        {
            this.peso = peso;
        }
        /// <summary>
        /// Sobrecarga que recibe 4 parametros y llama al constructor que recibe 3 parametros
        /// Inicializa atributos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="peso"></param>
        /// <param name="cantPatas"></param>
        public Mascota(string nombre, int edad, decimal peso, int cantPatas):this(nombre,edad,peso)
        {
            this.cantPatas = cantPatas;
        }
        /// <summary>
        /// Sobrecarga que recibe 2 parametros y llama al constructor que inicializa los atributos por default
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        public Mascota(string nombre, int edad):this()
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        /// <summary>
        /// Metodo virtual que dice el tipo de mascota del que lo llama
        /// </summary>
        /// <returns>Retorna una cadena que dice el tipo de animal que es</returns>
        public virtual string TipoDeMascota()
        {
            return "Soy un animal";
        }
        /// <summary>
        /// Sobrecarga del metodo, le suma la informacion de la edad del animal
        /// </summary>
        /// <param name="edad"></param>
        /// <returns></returns>
        public virtual string TipoDeMascota(int edad)
        {
            return $"Soy un animal con {this.Edad} años";
        }
        /// <summary>
        /// Muestra todos los datos del animal
        /// </summary>
        /// <returns>retorna un string con los datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}--");
            sb.AppendLine($"Edad: {this.edad}--");
            sb.AppendLine($"Peso: {this.peso}--");
            sb.AppendLine($"Total de patas: {this.cantPatas}--");

            return sb.ToString();
        }
        /// <summary>
        /// SobreCarga del operador explicit para poder castear sin problema
        /// </summary>
        /// <param name="m"></param>
        public static explicit operator string(Mascota m)
        {
            return m.nombre;
        }
        /// <summary>
        /// Sobrecarga del operador Implicit para castear sin necesidad de mostrarlo
        /// </summary>
        /// <param name="m"></param>
        public static implicit operator int(Mascota m)
        {
            return m.edad;
        }
        /// <summary>
        /// Sobreescribo el metodo Equals para poder comparar si son iguales con mi criterio elegido,
        /// en este caso por nombre y peso
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Mascota)
            {
                retorno = this == (Mascota)obj;
            }
            return retorno;
        }
        /// <summary>
        /// Metodo abstracto que sera implementado en las clases derivadas
        /// </summary>
        /// <returns></returns>
        public abstract string EmitirSonido();

        /// <summary>
        /// Sobrecarga del operador == para comparar si dos animales son iguales por peso y nombre
        /// </summary>
        /// <param name="m"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator ==(Mascota m, Mascota m2)
        {
            if (m is not null && m2 is not null)
            {
                return m.nombre == m2.nombre && m.peso == m2.peso;
            }
            if(m is null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sobrecarga necesaria para que no tire error de compilacion, niega el resultado de la comparacion
        /// de esa manera da el distinto
        /// </summary>
        /// <param name="m"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator !=(Mascota m, Mascota m2)
        {
            return !(m == m2);
        }
    }
}