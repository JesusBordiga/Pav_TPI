using Shopping_Buy_All.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping_Buy_All.ABMS;

namespace Shopping_Buy_All.ABMS.AccesoADatos
{
    public class AD_Cliente
    {
        //CLIENT LOAD
         public static object CargarTipoEstadoCivil()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getEstadoCivilNoBorrado";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
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
         public static bool Agregar_Cliente(Cliente client)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "agregarCliente @tipoDocumento,@nroDocumento, @apellido, @nombres, @calle, @nroCalle, @estadoCivil, @sexo, @fechaNacimiento";
                //"INSERT INTO Clientes(TipoDocumento,NroDocumento,Apellido,Nombres,Calle,NroCalle,EstadoCivil,Sexo,FechaNacimiento) Values(@tipoDocumento,@nroDocumento, @apellido, @nombres, @calle, @nroCalle, @estadoCivil,@sexo, @fechaNacimiento)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocumento", client.TipoDocumentoCliente);
                cmd.Parameters.AddWithValue("@nroDocumento", client.DocumentoCliente);
                cmd.Parameters.AddWithValue("@apellido", client.ApellidoCliente);
                cmd.Parameters.AddWithValue("@nombres", client.NombreCliente);
                cmd.Parameters.AddWithValue("@calle", client.CalleCliente);
                cmd.Parameters.AddWithValue("@nroCalle", client.NroCalleCliente);
                cmd.Parameters.AddWithValue("@estadoCivil", client.EstadoCivilCliente);
                cmd.Parameters.AddWithValue("@sexo", client.SexoCliente);
                cmd.Parameters.AddWithValue("@fechaNacimiento", client.FechaNacimientoCliente);
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
         public static object ObtenerTipoSexo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getTipoSexoNoBorrado";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
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
         public static object ObtenerTipoDocumento()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getTipoDocumentoNoBorrado";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
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
         public static DataTable ObtenerDatosClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getClienteNoBorrado";
                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
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
        
        //CLIENT MODIFY
        public static bool ModificarCliente(Cliente client)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "modificarCliente @tipoDocumento, @nroDocumento, @apellido, @nombres, @calle, @nroCalle, @estadoCivil, @sexo, @fechaNacimiento";
                //"UPDATE Clientes SET TipoDocumento = @tipoDocumento, NroDocumento = @nroDocumento, Apellido = @apellido, Nombres = @nombres, Calle = @calle, NroCalle = @nroCalle, EstadoCivil = @estadoCivil, Sexo = @sexo, FechaNacimiento = @fechaNacimiento WHERE TipoDocumento Like @tipoDocumento AND NroDocumento Like @nroDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocumento", client.TipoDocumentoCliente);
                cmd.Parameters.AddWithValue("@nroDocumento", client.DocumentoCliente);
                cmd.Parameters.AddWithValue("@apellido", client.ApellidoCliente);
                cmd.Parameters.AddWithValue("@nombres", client.NombreCliente);
                cmd.Parameters.AddWithValue("@calle", client.CalleCliente);
                cmd.Parameters.AddWithValue("@nroCalle", client.NroCalleCliente);
                cmd.Parameters.AddWithValue("@estadoCivil", client.EstadoCivilCliente);
                cmd.Parameters.AddWithValue("@sexo", client.SexoCliente);
                cmd.Parameters.AddWithValue("@fechaNacimiento", client.FechaNacimientoCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        //CLIENT DELETE
        public static bool BorrarCliente(int TipoDocumento, string NroDocumento, int Borrado)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "borrarCliente @tipoDocumento, @nroDocumento, @borrado";
                //"UPDATE Clientes SET Borrado = @borrado WHERE TipoDocumento Like @tipoDocumento AND NroDocumento Like @nroDocumento AND Borrado like 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocumento", NroDocumento);
                cmd.Parameters.AddWithValue("@borrado", Borrado);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
    }
}
