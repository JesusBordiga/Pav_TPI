using Shopping_Buy_All.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.ABMS.AccesoADatos
{
    public class AD_TipoComercio
    {
        //TIPO COMERCIO LOAD
        public static DataTable ObtenerTablaTipoComercioReducida()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getTipoComercioNoBorrados";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.StoredProcedure;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool Agregar_TipoComercio(TipoComercio comercio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "agregarTipoComercio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreTipoComercio", comercio.NombreTipoComercio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }

        //TIPO COMERCIO MODIFY
        public static bool Modificar_TipoComercioANoBorrado(TipoComercio comercio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "modificarTipoComercio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreTipoComercio", comercio.NombreTipoComercio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        public static bool ModificarNombre_TipoComercio(int Id, TipoComercio comercio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "modificarNombreTipoComercio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdTipoComercio", Id);
                cmd.Parameters.AddWithValue("@NombreTipoComercio", comercio.NombreTipoComercio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        public static bool Buscar_TipoComercio(string NombreTipoComercio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            TipoComercio comercio = new TipoComercio();
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarTipoComercioPorNombreNoBorrado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreTipoComercio", NombreTipoComercio);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {                    
                    cn.Close();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    
                    resultado = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        public static bool Buscar_TipoComercioPorIdyNombre(string Id, string NombreTipoComercio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarTipoComercioPorIDyNombreNoBorrado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreTipoComercio", NombreTipoComercio);
                cmd.Parameters.AddWithValue("@IdTipoComercio", Id);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    cn.Close();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    resultado = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        public static string Buscar_TipoComercioPorId(string Id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            TipoComercio comercio = new TipoComercio();
            string resultado = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarTipoComercioPorIdNoBorrado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdTipoComercio", Id);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    resultado = DataReader["NombreTipoComercio"].ToString();
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        public static int Buscar_TipoComercioPorNombre(string NombreTipoComercio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            TipoComercio comercio = new TipoComercio();
            int resultado = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarTipoComercioPorNombreNoBorrado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreTipoComercio", NombreTipoComercio);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    resultado = int.Parse(DataReader["Tipo_Comercio"].ToString());
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        public static bool ExisteTipoComercio(String NombreTipoComercio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "existeTipoComercio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreTipoComercio", NombreTipoComercio);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    cn.Close();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    resultado = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        //TIPO COMERCIO DELETE
        public static bool BorrarTipoComercio(String NombreTipoComercio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarTipoComercio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreTipoComercio", NombreTipoComercio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

    }
}
