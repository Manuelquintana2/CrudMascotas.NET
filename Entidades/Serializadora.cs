using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class Serializadora<T>: IXml<T>
    {
        private static string path;

        static Serializadora()
        {
            Serializadora<T>.path = "./"; 
        }

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
