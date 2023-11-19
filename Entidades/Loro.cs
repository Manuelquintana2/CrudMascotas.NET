using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Loro que deriva de Mascota
    /// </summary>
    public class Loro : Mascota
    {
        private ETipoLoro tipo;
        private int tiempoDeVuelo;
        private int metrosDeVuelo;
        private string palabra;

        /// <summary>
        /// Propiedades autoimplementadas para obtener y settear los valores de los atributos
        /// </summary>
        public ETipoLoro Tipo { get => tipo; set => tipo = value; }
        public int TiempoDeVuelo { get => tiempoDeVuelo; set => tiempoDeVuelo = value; }
        public int MetrosDeVuelo { get => metrosDeVuelo; set => metrosDeVuelo = value; }
        public string Palabra { get => palabra; set => palabra = value; }

        public Loro(string nombre, int edad, decimal peso, int cantPatas, ETipoLoro tipo, int tiempoDeVuelo, int metrosDeVuelo, string palabra, int id):this(nombre, edad, peso, cantPatas, tipo, tiempoDeVuelo, metrosDeVuelo, palabra)
        {
            this.id = id;
        }

        /// <summary>
        /// Constructor que recibe todos los parametros,llama a otro constructor
        /// inicializa los atributos restantes
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="peso"></param>
        /// <param name="cantPatas"></param>
        /// <param name="tipo"></param>
        /// <param name="tiempoDeVuelo"></param>
        /// <param name="metrosDeVuelo"></param>
        /// <param name="repetirPalabras"></param>
        /// <param name="palabra"></param>
        public Loro(string nombre, int edad, decimal peso, int cantPatas, ETipoLoro tipo, int tiempoDeVuelo, int metrosDeVuelo, string palabra):this(nombre,edad,peso,cantPatas,tipo,tiempoDeVuelo)
        {
            this.MetrosDeVuelo = metrosDeVuelo;
            this.Palabra = palabra;
        }
        /// <summary>
        /// Constructor que recibe algunos parametros, llama al constructor de la clase base
        /// Inicializa sus atributos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="peso"></param>
        /// <param name="cantPatas"></param>
        /// <param name="tipo"></param>
        /// <param name="tiempoDeVuelo"></param>
        public Loro(string nombre,int edad,decimal peso,int cantPatas,ETipoLoro tipo,int tiempoDeVuelo):base(nombre, edad, peso, cantPatas)
        {
            this.Tipo = tipo;
            this.TiempoDeVuelo = tiempoDeVuelo;
        }
        /// <summary>
        /// Constructor vacio, llama al constructor base vacio 
        /// Inicializa todo en valores nulos
        /// </summary>
        public Loro():base()
        {
            this.Tipo = 0;
            this.MetrosDeVuelo = 0;
            this.TiempoDeVuelo = 0;
            this.Palabra = "";
        }
        /// <summary>
        /// Metodo sobreEscrito
        /// 
        /// </summary>
        /// <returns>Retorna un string con el tipo de Mascota</returns>
        public override string TipoDeMascota()
        {
            return "Soy un loro";
        }
        /// <summary>
        /// Sobrecarga del metodo anterior
        /// </summary>
        /// <param name="edad"></param>
        /// <returns>Retorna un string con el tipo de Mascota y su edad </returns>
        public virtual string TipoDeMascota(int edad)
        {
            if (edad > 30)
            {
                return string.Empty;
            }
            else
            {
                if(edad < 0)
                {
                    return null;
                }
            }
            return $"Soy un loro con {this.Edad} años";
        }
        /// <summary>
        /// SobreEscritura del metodo ToString
        /// </summary>
        /// <returns>Retorna todos los datos del loro</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LORO: ");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Volo: {this.TiempoDeVuelo} semanas--");
            sb.AppendLine($"Vuela a: {this.MetrosDeVuelo} metros--");
            sb.AppendLine($"Tipo {this.Tipo}");

            return sb.ToString();
        }
        /// <summary>
        /// Metodo abstracto que repite la palabra pasada por parametros, si es que el loro sabe repetir palabras
        /// </summary>
        /// <returns></returns>
        public override string EmitirSonido()
        {   
            return this.Palabra;   
        }
    }
}
