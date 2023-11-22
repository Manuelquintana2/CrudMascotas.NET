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
    /// Clase que integra una interfaz generica
    /// </summary>
    public class AccesoADatosGato : IAccesoADatos<Gato>
    {
        private SqlConnection conexion;
        private static string cadena_conexion;
        /// <summary>
        /// Constructor estatico, asigna la cadena de conexion a la variable cadena_conexion.
        /// </summary>
        static AccesoADatosGato()
        {
            AccesoADatosGato.cadena_conexion = Properties.Resources.miConexion;
        }
        public AccesoADatosGato()
        {
            this.conexion = new SqlConnection(AccesoADatosGato.cadena_conexion);
        }
        /// <summary>
        /// Se conecta a la BD, obtiene los gatos que hay en la tabla y la retorna en forma de una lista de gatos
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Gato> ObtenerLista()
        {
            List<Gato> lista = new List<Gato>();

            string query = "SELECT id,nombre,edad,peso,cantPatas,velocidadDeReaccion,metrosDeSalto,raza FROM Gato";

            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosGato.cadena_conexion))
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
                                    Gato gato = new Gato();
                                    gato.Id = Convert.ToInt32(dr["id"]);
                                    gato.Nombre = dr["nombre"].ToString();
                                    gato.Edad = Convert.ToInt32(dr["edad"]);
                                    gato.Peso = Convert.ToDecimal(dr["peso"]);
                                    gato.CantPatas = Convert.ToInt32(dr["cantPatas"]);
                                    gato.VelocidadDeReaccion = Convert.ToInt32(dr["velocidadDeReaccion"]);
                                    gato.MetrosDeSalto = Convert.ToInt32(dr["metrosDeSalto"]);
                                    gato.Raza = (ERazaGato)(int)(dr["raza"]);
                                    lista.Add(gato);
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
        /// Recibe un Gato como parametro, lo agrega en la tabla de la BD
        /// </summary>
        /// <param name="g"></param>
        /// <exception cref="Exception"></exception>
        public void Agregar(Gato g)
        {

            string query = "INSERT INTO Gato (nombre,edad,peso,cantPatas,velocidadDeReaccion,metrosDeSalto,raza)" +
                        " VALUES(@Nombre, @Edad, @Peso, @CantPatas, @VelocidadDeReaccion, @MetrosDeSalto, @Raza); ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosGato.cadena_conexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // se puede determinar si es Procedimiento Tabla o consulta
                        // comando.CommandType = CommandType.TableDirect;
                        comando.Parameters.Add(new SqlParameter("nombre", SqlDbType.VarChar) { Value = g.Nombre });
                        comando.Parameters.Add(new SqlParameter("edad", SqlDbType.Int) { Value = g.Edad });
                        comando.Parameters.Add(new SqlParameter("peso", SqlDbType.Decimal) { Value = g.Peso });
                        comando.Parameters.Add(new SqlParameter("cantPatas", SqlDbType.Int) { Value = g.CantPatas });
                        comando.Parameters.Add(new SqlParameter("velocidadDeReaccion", SqlDbType.Int) { Value = g.VelocidadDeReaccion });
                        comando.Parameters.Add(new SqlParameter("metrosDeSalto", SqlDbType.Int) { Value = g.MetrosDeSalto });
                        comando.Parameters.Add(new SqlParameter("raza", SqlDbType.Int) { Value = g.Raza });
                        comando.ExecuteNonQuery();

                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Recibe un gato como parametro, y modifica el gato coincidente por id en la Tabla con sus nuevos parametros
        /// </summary>
        /// <param name="g"></param>
        /// <exception cref="Exception"></exception>
        public void Modificar(Gato g)
        {
            string query = "UPDATE Gato " +
                "SET nombre = @Nombre ,edad = @Edad, peso = @Peso," +
                " cantPatas = @CantPatas, velocidadDeReaccion = @VelocidadDeReaccion," +
                " metrosDeSalto = @MetrosDeSalto, raza = @Raza" +
                " WHERE id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosGato.cadena_conexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("id", SqlDbType.Int) { Value = g.Id });
                        comando.Parameters.Add(new SqlParameter("nombre", SqlDbType.VarChar) { Value = g.Nombre });
                        comando.Parameters.Add(new SqlParameter("edad", SqlDbType.Int) { Value = g.Edad });
                        comando.Parameters.Add(new SqlParameter("peso", SqlDbType.Decimal) { Value = g.Peso });
                        comando.Parameters.Add(new SqlParameter("cantPatas", SqlDbType.Int) { Value = g.CantPatas });
                        comando.Parameters.Add(new SqlParameter("velocidadDeReaccion", SqlDbType.Int) { Value = g.VelocidadDeReaccion });
                        comando.Parameters.Add(new SqlParameter("metrosDeSalto", SqlDbType.Int) { Value = g.MetrosDeSalto });
                        comando.Parameters.Add(new SqlParameter("raza", SqlDbType.Int) { Value = g.Raza });

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
        /// Recibe un Id, Elimina al gato que contenga ese id
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public void Eliminar(int id)
        {
            string query = "DELETE FROM Gato " +
                " WHERE id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosGato.cadena_conexion))
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
