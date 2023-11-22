using Entidades;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace BaseDeDatos
{
    /// <summary>
    /// Clase que integra una interfaz generica
    /// </summary>
    public class AccesoADatosPerro : IAccesoADatos<Perro>
    {
        private SqlConnection conexion;
        private static string cadena_conexion;
        /// <summary>
        /// Constructor estatico que inicializa la cadena_conexion 
        /// </summary>
        static AccesoADatosPerro()
        {
            AccesoADatosPerro.cadena_conexion = Properties.Resources.miConexion;
        }
        public AccesoADatosPerro()
        {
            this.conexion = new SqlConnection(AccesoADatosPerro.cadena_conexion);
        }
        /// <summary>
        /// Obtiene los perros de la BD, los retorna en una lista de perros
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Perro> ObtenerLista()
        {
            List<Perro> lista = new List<Perro>();

            string query = "SELECT id,nombre,edad,peso,cantPatas,kilometrosPorHora,velocidadParaComer,raza FROM Perro";

            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosPerro.cadena_conexion))
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
                                    Perro perro = new Perro();
                                    perro.Id = Convert.ToInt32(dr["id"]);
                                    perro.Nombre = dr["nombre"].ToString();
                                    perro.Edad = Convert.ToInt32(dr["edad"]);
                                    perro.Peso = Convert.ToDecimal(dr["peso"]);
                                    perro.CantPatas = Convert.ToInt32(dr["cantPatas"]);
                                    perro.KilometrosPorHora = Convert.ToInt32(dr["kilometrosPorHora"]);
                                    perro.VelocidadParaComer = Convert.ToInt32(dr["velocidadParaComer"]);
                                    perro.Raza = (ERazaPerro)(int)(dr["raza"]);
                                    lista.Add(perro);
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
        /// Agrega el perro recibido por parametro a la BD
        /// </summary>
        /// <param name="p"></param>
        /// <exception cref="Exception"></exception>
        public void Agregar(Perro p)
        {
            
            string query = "INSERT INTO Perro (nombre,edad,peso,cantPatas,kilometrosPorHora,velocidadParaComer,raza)" +
                        " VALUES(@Nombre, @Edad, @Peso, @CantPatas, @KilometrosPorHora, @VelocidadParaComer, @Raza); ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosPerro.cadena_conexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // se puede determinar si es Procedimiento Tabla o consulta
                        // comando.CommandType = CommandType.TableDirect;
                        comando.Parameters.Add(new SqlParameter("nombre", SqlDbType.VarChar) { Value = p.Nombre });
                        comando.Parameters.Add(new SqlParameter("edad", SqlDbType.Int) { Value = p.Edad });
                        comando.Parameters.Add(new SqlParameter("peso", SqlDbType.Decimal) { Value = p.Peso });
                        comando.Parameters.Add(new SqlParameter("cantPatas", SqlDbType.Int) { Value = p.CantPatas });
                        comando.Parameters.Add(new SqlParameter("kilometrosPorHora", SqlDbType.Int) { Value = p.KilometrosPorHora });
                        comando.Parameters.Add(new SqlParameter("velocidadParaComer", SqlDbType.Int) { Value = p.VelocidadParaComer });
                        comando.Parameters.Add(new SqlParameter("raza", SqlDbType.Int) { Value = p.Raza });
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
        /// Modifica el perro, por el nuevo perro recibido por Parametro
        /// </summary>
        /// <param name="p"></param>
        /// <exception cref="Exception"></exception>
        public void Modificar(Perro p)
        {
            string query = "UPDATE Perro " +
                "SET nombre = @Nombre ,edad = @Edad, peso = @Peso," +
                " cantPatas = @CantPatas, kilometrosPorHora = @KilometrosPorHora," +
                " velocidadParaComer = @VelocidadParacomer, raza = @Raza" +
                " WHERE id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosPerro.cadena_conexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("id", SqlDbType.Int) { Value = p.Id });
                        comando.Parameters.Add(new SqlParameter("nombre", SqlDbType.VarChar) { Value = p.Nombre});
                        comando.Parameters.Add(new SqlParameter("edad", SqlDbType.Int) { Value = p.Edad });
                        comando.Parameters.Add(new SqlParameter("peso", SqlDbType.Decimal) { Value = p.Peso});
                        comando.Parameters.Add(new SqlParameter("cantPatas", SqlDbType.Int) { Value = p.CantPatas });
                        comando.Parameters.Add(new SqlParameter("kilometrosPorHora", SqlDbType.Int) { Value = p.KilometrosPorHora });
                        comando.Parameters.Add(new SqlParameter("velocidadParaComer", SqlDbType.Int) { Value = p.VelocidadParaComer });
                        comando.Parameters.Add(new SqlParameter("raza", SqlDbType.Int) { Value = p.Raza });
                       
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
        /// Elimina el perro de la BD, lo busca por ID
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public void Eliminar(int id)
        {
            string query = "DELETE FROM Perro " +
                " WHERE id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatosPerro.cadena_conexion))
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