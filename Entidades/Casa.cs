using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Casa no deriva de nadie
    /// </summary>
    public class Casa
    {
        /// <summary>
        /// Tiene una lista de mascotas para que pueda ser usada en el proyecto
        /// </summary>
        public List<Mascota> mascotas;
        private short cantMascotas;

        /// <summary>
        /// Constructor vacio que inicializa sus atributos en nulo
        /// </summary>
        public Casa()
        {
            this.mascotas = new List<Mascota>();
            this.cantMascotas = 0;
        }
        /// <summary>
        /// Recibe la cantidad maxima de mascotas que pueda tener la casa,, llama al constructor vacio
        /// </summary>
        /// <param name="cantMascotas"></param>
        public Casa(short cantMascotas):this()
        {
            this.cantMascotas = cantMascotas;
        }
        /// <summary>
        /// Recibe una lista de mascotas y llama al constructor anterior
        /// </summary>
        /// <param name="mascotas"></param>
        /// <param name="cantMascotas"></param>
        public Casa(List<Mascota> mascotas, short cantMascotas):this(cantMascotas)
        {
            this.mascotas = mascotas;
        }

        /// <summary>
        /// Sobrecarga del operador ==, Compara si una mascota se encuentra en la casa
        /// </summary>
        /// <param name="m"></param>
        /// <param name="c"></param>
        /// <returns>retorna true si la mascota esta en la casa</returns>
        public static bool operator ==(Mascota m, Casa c)
        {
            bool retorno = false;
            foreach (Mascota item in c.mascotas)
            {
                if (item == m)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
            //return t.Pasajeros.Contains(p); SOLO SIRVE SI SE SOBREESCRIBE EL EQUALS
        }

        /// <summary>
        /// Sobrecarga del !=
        /// </summary>
        /// <param name="m"></param>
        /// <param name="c"></param>
        /// <returns>Retorna true si la mascota NO esta en la casa</returns>
        public static bool operator !=(Mascota m, Casa c)
        {
            return !(m == c);
        }
        /// <summary>
        /// Verifica si la mascota NO esta en la casa y la agrega
        /// </summary>
        /// <param name="c"></param>
        /// <param name="m"></param>
        /// <returns>Retorna un objeto casa con su nueva lista</returns>
        public static Casa operator +(Casa c, Mascota m)
        {
            if (c.mascotas.Count() < c.cantMascotas)
            {
                if (m != c)
                {
                    c.mascotas.Add(m);
                }
                else
                {
                    Console.WriteLine("La mascota ya esa en la casa");
                }
            }
            else
            {
                Console.WriteLine("La casa esta llena de mascotas");
            }
            return c;
        }
        /// <summary>
        /// Verifica si la mascota esta en la casa, si la encuentra, la elimina
        /// </summary>
        /// <param name="c"></param>
        /// <param name="m"></param>
        /// <returns>Retorna objeto Casa con su lista actualizada</returns>
        public static Casa operator -(Casa c, Mascota m)
        {
            if(m == c)
            {
                c.mascotas.Remove(m);
            }
            else
            {
                Console.WriteLine("No existe esta mascota en la casa");
            }
            return c;
        }
        /// <summary>
        /// Ordena las mascotas de forma ascendente por su peso
        /// </summary>
        /// <param name="m"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static int OrdenarPorPesoAsc(Mascota m, Mascota m2) // forma ascendente
        {
            if (m.Peso < m2.Peso)
            {
                return -1;
            }
            else if (m.Peso > m2.Peso)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Ordena de forma descendente por su peso
        /// </summary>
        /// <param name="m"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static int OrdenarPorPesoDesc(Mascota m, Mascota m2) // forma ascendente
        {
            if (m.Peso > m2.Peso)
            {
                return -1;
            }
            else if (m.Peso < m2.Peso)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Ordena de forma ascendente por su edad
        /// </summary>
        /// <param name="m"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static int OrdenarPorEdadAsc(Mascota m, Mascota m2) // forma ascendente
        {
            if (m.Edad < m2.Edad)
            {
                return -1;
            }
            else if (m.Edad > m2.Edad)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Ordena de forma descendente por su edad
        /// </summary>
        /// <param name="m"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static int OrdenarPorEdadDesc(Mascota m, Mascota m2) // forma ascendente
        {
            if (m.Edad > m2.Edad)
            {
                return -1;
            }
            else if (m.Edad < m2.Edad)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
