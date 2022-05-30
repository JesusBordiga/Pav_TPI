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
        public static Tarjeta Buscar_Tarjeta(Tarjeta t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TarjetaXCliente WHERE TipoDocumento = @tipoDoc AND NroDocumento = @nroDoc AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDoc", t.TipoDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroDoc", t.NroDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroTarjeta", t.NroTarjetaCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    t.IdMarcaTarjeta = int.Parse(DataReader["IdMarca"].ToString());
                    t.IdTipoTarjeta = int.Parse(DataReader["IdTipo"].ToString());
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
            return t;
        }
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
    }

}
