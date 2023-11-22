using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    /// <summary>
    /// Clase utilizada para serializar cualquier tipo de dato
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Serializadora<T>: IXml<T>
    {
        private static string path;

        /// <summary>
        /// Inicializa la variable estatica path, con la ubicacion donde se guardara el archivo
        /// </summary>
        static Serializadora()
        {
            Serializadora<T>.path = "./"; 
        }
        /// <summary>
        /// Metodo que recibe cualquier tipo de dato (T) y un string con el nombre que se le pondra al archivo 
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool Serializar(T dato, string path)
        {
            bool seSerializo = false;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(Serializadora<T>.path + path, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, dato);
                    seSerializo = true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return seSerializo;
        }
        /// <summary>
        /// Retorna un T, osea el dato que sea a la hora de llamarse al metodo.
        /// se le pasa el nombre del archivo a deserealizar.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public T Deserializar(string path)
        {
            T aux = default(T);
            try
            {
                using (XmlTextReader reader = new XmlTextReader(Serializadora<T>.path + path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    aux = (T)ser.Deserialize(reader);
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return default;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return aux;
        }
    }
}
