using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    /// <summary>
    /// Interfaz generica, donde el dato T solo puede ser Mascota o sus derivadas
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAccesoADatos<T> where T : Mascota
    {
        /// <summary>
        /// Devuelve una lista generica de tipo Mascota o sus derivadas.
        /// </summary>
        /// <returns></returns>
        List<T> ObtenerLista();
        /// <summary>
        /// Agrega el dato que recibe
        /// </summary>
        /// <param name="dato"></param>
        void Agregar(T dato);
        /// <summary>
        /// Modifica el dato que recibe
        /// </summary>
        /// <param name="dato"></param>
        void Modificar(T dato);
        /// <summary>
        /// Elimina el dato, segun el Id que tiene
        /// </summary>
        /// <param name="id"></param>
        void Eliminar(int id);

    }
}
