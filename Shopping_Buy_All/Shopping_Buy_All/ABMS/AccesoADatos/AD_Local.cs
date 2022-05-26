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
    public class AD_Local
    {

        //LOCAL LOAD
        public static DataTable ObtenerTablaLocalReducida()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getLocalNoBorrados";

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
        public static bool Agregar_Local(Local l)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "agregarLocal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", l.NombreLocal);
                cmd.Parameters.AddWithValue("@TipoComercio", l.TipoComercio);


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


        //LOCAL MODIFY
        public static bool Buscar_Local(Local l)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            TipoComercio comercio = new TipoComercio();
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarLocalNoBorrado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", l.NombreLocal);
                cmd.Parameters.AddWithValue("@TipoComercio", l.TipoComercio);


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

        public static bool ExisteLocal(Local l)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "existeLocal";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", l.NombreLocal);
                cmd.Parameters.AddWithValue("@TipoComercio", l.TipoComercio);


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

        public static bool Modificar_LocalANoBorrado(Local l)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "modificarLocalANoBorrado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", l.NombreLocal);
                cmd.Parameters.AddWithValue("@TipoComercio", l.TipoComercio);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
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
        public static Local Buscar_LocalPorCodigo(string codigo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Local l = new Local();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarLocalPorCodigoNoBorrado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", codigo);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataReader DataReader = cmd.ExecuteReader();

                if (DataReader != null && DataReader.Read())
                {
                    l.NombreLocal = DataReader["Nombre"].ToString();
                    l.TipoComercio = int.Parse(DataReader["TipoComercio"].ToString());
                }
                return l;

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

        public static int Buscar_LocalPorNombreYTipoComercio(Local l)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            int Codigo = -1; 
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarLocalPorNombreYTipoComercioNoBorrado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", l.NombreLocal);
                cmd.Parameters.AddWithValue("@TipoComercio", l.TipoComercio);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataReader DataReader = cmd.ExecuteReader();

                if (DataReader != null && DataReader.Read())
                {
                    Codigo = int.Parse(DataReader["CodigoLocal"].ToString());
                }
                return Codigo;

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

        public static bool Modificar_Local(string Codigo, Local l)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "modificarLocal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", Codigo);
                cmd.Parameters.AddWithValue("@IdTipoComercio", l.TipoComercio);
                cmd.Parameters.AddWithValue("@NombreLocal", l.NombreLocal);
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

        //LOCAL DELETE
        public static bool BorrarLocal(int Codigo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarLocal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", Codigo);
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
