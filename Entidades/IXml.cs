using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IXml<T>
    {
        bool Serializar(T dato, string path);
        T Deserializar(string path);
    }
}
