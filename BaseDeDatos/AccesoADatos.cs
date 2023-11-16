﻿using Entidades;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace BaseDeDatos
{
    public class AccesoADatos
    {
        private SqlConnection conexion;
        private static string cadena_conexion;
        private SqlCommand comando;

        static AccesoADatos()
        {
            AccesoADatos.cadena_conexion = Properties.Resources.miConexion;
        }
        public AccesoADatos()
        {
            this.conexion = new SqlConnection(AccesoADatos.cadena_conexion);
        }

        public static List<Perro> ObtenerListaPerro()
        {
            List<Perro> lista = new List<Perro>();

            string query = "SELECT id,nombre,edad,peso,cantPatas,kilometrosPorHora,velocidadParaComer,raza FROM Perro";

            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatos.cadena_conexion))
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
                                    var perro = new Perro();
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
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void agregarPerro(Perro p)
        {
            
            string query = "INSERT INTO Perro (nombre,edad,peso,cantPatas,kilometrosPorHora,velocidadParaComer,raza)" +
                        " VALUES(@Nombre, @Edad, @Peso, @CantPatas, @KilometrosPorHora, @VelocidadParaComer, @Raza); ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatos.cadena_conexion))
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
            catch (Exception ex)
            {
                throw;
            }     
        }
        public static void modificarPerro(Perro p)
        {
            string query = "UPDATE Perro " +
                "SET nombre = @Nombre ,edad = @Edad, peso = @Peso," +
                " cantPatas = @CantPatas, kilometrosPorHora = @KilometrosPorHora," +
                " velocidadParaComer = @VelocidadParacomer, raza = @Raza" +
                " WHERE id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatos.cadena_conexion))
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
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void EliminarPerro(int id)
        {
            string query = "DELETE FROM Perro " +
                " WHERE id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatos.cadena_conexion))
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
            catch (Exception ex)
            {
                throw;
            }
        }
        public static List<Gato> ObtenerListaGato()
        {
            List<Gato> lista = new List<Gato>();

            string query = "SELECT id,nombre,edad,peso,cantPatas,velocidadDeReaccion,metrosDeSalto,raza FROM Gato";

            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatos.cadena_conexion))
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
                                    var gato = new Gato();
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
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void agregarGato(Gato g)
        {
            
            string query = "INSERT INTO Gato (nombre,edad,peso,cantPatas,velocidadDeReaccion,metrosDeSalto,raza)" +
                        " VALUES(@Nombre, @Edad, @Peso, @CantPatas, @VelocidadDeReaccion, @MetrosDeSalto, @Raza); ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatos.cadena_conexion))
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
                throw;
            }
        }
        public static void modificarGato(Gato g)
        {
            string query = "UPDATE Gato " +
                "SET nombre = @Nombre ,edad = @Edad, peso = @Peso," +
                " cantPatas = @CantPatas, velocidadDeReaccion = @VelocidadDeReaccion," +
                " metrosDeSalto = @MetrosDeSalto, raza = @Raza" +
                " WHERE id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatos.cadena_conexion))
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
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void EliminarGato(int id)
        {
            string query = "DELETE FROM Gato " +
                " WHERE id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADatos.cadena_conexion))
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
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}