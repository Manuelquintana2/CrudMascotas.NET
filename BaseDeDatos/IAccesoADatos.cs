using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public interface IAccesoADatos<T> where T : Mascota
    {
        List<T> ObtenerLista();
        void Agregar(T dato);
        void Modificar(T dato);
        void Eliminar(int id);

    }
}
