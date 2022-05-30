using Shopping_Buy_All.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping_Buy_All.ABMS;
using System.Windows.Forms;

namespace Shopping_Buy_All.ABMS.AccesoADatos
{
    public class AD_Facturacion
    {
        public static Cliente Buscar_Cliente_Documento(string TipoDocumento, string NroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente client = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarClienteNoBorrado @tipoDocumento, @nroDocumento";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocumento", NroDocumento);
                cmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    client.TipoDocumentoCliente = int.Parse(DataReader["TipoDoc"].ToString());
                    client.DocumentoCliente = DataReader["NroDocumento"].ToString();
                    client.ApellidoCliente = DataReader["Apellido"].ToString();
                    client.NombreCliente = DataReader["Nombres"].ToString();
                    client.CalleCliente = DataReader["Calle"].ToString();
                    client.NroCalleCliente = int.Parse(DataReader["NroCalle"].ToString());
                    client.EstadoCivilCliente = int.Parse(DataReader["EstadoCiv"].ToString());
                    client.SexoCliente = int.Parse(DataReader["Sex"].ToString());
                    client.FechaNacimientoCliente = DateTime.Parse(DataReader["FechaNacimiento"].ToString());
                }
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar al cliente");
            }
            finally
            {
                cn.Close();
            }
            return client;
        }
        public static int getNroFactura()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "getMaxNroFactura";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    int nroFac = int.Parse(DataReader["MaxNum"].ToString());
                    return nroFac + 1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return -1;
        }
        public static object getTarjetaCliente(int tipoDoc, string nroDoc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "getTarjetaClienteFactura @nroDocumento, @tipoDocumento";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nroDocumento", nroDoc);
                command.Parameters.AddWithValue("@tipoDocumento", tipoDoc);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;
                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return null;
        }
    }

}
