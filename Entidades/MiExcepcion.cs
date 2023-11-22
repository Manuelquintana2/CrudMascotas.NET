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
        /// <summary>
        /// Constructor recibe dos parametros, el mensaje que se va a dar, y el objeto que causo el error
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="objetoError"></param>
        public MiExcepcion(string mensaje, Object objetoError):base(mensaje) 
        {
            this.objetoError = objetoError;
        }
        /// <summary>
        /// Obtiene el objeto que causo el error
        /// </summary>
        public Object Error
        {
            get { return objetoError;}
        }
    }
}
