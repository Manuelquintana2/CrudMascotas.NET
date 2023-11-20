using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiExcepcion:Exception
    {
        Object objetoError;
        public MiExcepcion(string mensaje, Object objetoError):base(mensaje) 
        {
            this.objetoError = objetoError;
        }
        public Object Error
        {
            get { return objetoError;}
        }
    }
}
