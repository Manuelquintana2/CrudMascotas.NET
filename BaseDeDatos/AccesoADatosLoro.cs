using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    /// <summary>
    /// Clase que Integra una interfaz generica
    /// </summary>
    public class AccesoADatosLoro : IAccesoADatos<Loro>
    {
        private SqlConnection conexion;
        private static string cadena_conexion;
        /// <summary>
        /// Contructor estatico, asigna el valor de cadena_conexion
        /// </summary>
        static AccesoADatosLoro()
        {
            AccesoADatosLoro.cadena_conexion = Properties.Resources.miConexion;
        }
        public AccesoADatosLoro()
        {
            this.conexion = new SqlConnection(AccesoADatosLoro.cadena_conexion);
        }
        /// <summary>
        /// Obtiene los loros de la BD, y los retorna en forma de lista de loros
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Loro> ObtenerLista()
        {
            List<Loro> lista = new List<Loro>();

            string query = "SELECT id,nombre,edad,peso,cantPatas,tiempoDeVuelo,metrosDeVuelo,palabra,tipo FROM Loro";

            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosLoro.cadena_conexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Loro loro = new Loro();
                                    loro.Id = Convert.ToInt32(dr["id"]);
                                    loro.Nombre = dr["nombre"].ToString();
                                    loro.Edad = Convert.ToInt32(dr["edad"]);
                                    loro.Peso = Convert.ToDecimal(dr["peso"]);
                                    loro.CantPatas = Convert.ToInt32(dr["cantPatas"]);
                                    loro.TiempoDeVuelo = Convert.ToInt32(dr["tiempoDeVuelo"]);
                                    loro.MetrosDeVuelo = Convert.ToInt32(dr["metrosDeVuelo"]);
                                    loro.Palabra = dr["palabra"].ToString();
                                    loro.Tipo = (ETipoLoro)(int)(dr["tipo"]);
                                    lista.Add(loro);
                                }
                            }
                        }
                    }

                    // Opcional
                    conexion.Close();
                }
                return lista;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Recibe un loro y lo agrega a la BD
        /// </summary>
        /// <param name="l"></param>
        /// <exception cref="Exception"></exception>
        public void Agregar(Loro l)
        {

            string query = "INSERT INTO Loro (nombre,edad,peso,cantPatas,tiempoDeVuelo,metrosDeVuelo,palabra,tipo)" +
                        " VALUES(@Nombre, @Edad, @Peso, @CantPatas, @TiempoDeVuelo, @MetrosDeVuelo, @Palabra, @Tipo); ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosLoro.cadena_conexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // se puede determinar si es Procedimiento Tabla o consulta
                        // comando.CommandType = CommandType.TableDirect;
                        comando.Parameters.Add(new SqlParameter("nombre", SqlDbType.VarChar) { Value = l.Nombre });
                        comando.Parameters.Add(new SqlParameter("edad", SqlDbType.Int) { Value = l.Edad });
                        comando.Parameters.Add(new SqlParameter("peso", SqlDbType.Decimal) { Value = l.Peso });
                        comando.Parameters.Add(new SqlParameter("cantPatas", SqlDbType.Int) { Value = l.CantPatas });
                        comando.Parameters.Add(new SqlParameter("tiempoDeVuelo", SqlDbType.Int) { Value = l.TiempoDeVuelo });
                        comando.Parameters.Add(new SqlParameter("metrosDeVuelo", SqlDbType.Int) { Value = l.MetrosDeVuelo });
                        comando.Parameters.Add(new SqlParameter("palabra", SqlDbType.VarChar) { Value = l.Palabra });
                        comando.Parameters.Add(new SqlParameter("tipo", SqlDbType.Int) { Value = l.Tipo });
                        comando.ExecuteNonQuery();

                    }
                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Recibe un loro y lo modifica en la BD
        /// </summary>
        /// <param name="l"></param>
        /// <exception cref="Exception"></exception>
        public void Modificar(Loro l)
        {
            string query = "UPDATE Loro " +
                "SET nombre = @Nombre ,edad = @Edad, peso = @Peso," +
                " cantPatas = @CantPatas, tiempoDeVuelo = @TiempoDeVuelo," +
                " metrosDeVuelo = @MetrosDeVuelo, palabra = @Palabra, tipo = @Tipo" +
                " WHERE id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosLoro.cadena_conexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("id", SqlDbType.Int) { Value = l.Id });
                        comando.Parameters.Add(new SqlParameter("nombre", SqlDbType.VarChar) { Value = l.Nombre });
                        comando.Parameters.Add(new SqlParameter("edad", SqlDbType.Int) { Value = l.Edad });
                        comando.Parameters.Add(new SqlParameter("peso", SqlDbType.Decimal) { Value = l.Peso });
                        comando.Parameters.Add(new SqlParameter("cantPatas", SqlDbType.Int) { Value = l.CantPatas });
                        comando.Parameters.Add(new SqlParameter("tiempoDeVuelo", SqlDbType.Int) { Value = l.TiempoDeVuelo });
                        comando.Parameters.Add(new SqlParameter("metrosDeVuelo", SqlDbType.Int) { Value = l.MetrosDeVuelo });
                        comando.Parameters.Add(new SqlParameter("palabra", SqlDbType.VarChar) { Value = l.Palabra });
                        comando.Parameters.Add(new SqlParameter("tipo", SqlDbType.Int) { Value = l.Tipo });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Recibe un Id, elimina el Id coincidente en la BD
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public void Eliminar(int id)
        {
            string query = "DELETE FROM Loro " +
                " WHERE id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosLoro.cadena_conexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = id });
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
