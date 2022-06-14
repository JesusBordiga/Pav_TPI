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
        public static bool cargarFactura(Factura factura, int nroFactura)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlTransaction objTransaction = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "agregarFactura @codLocal, @tipoDocumento, @nroDocumento, @nroTarjeta, @fecha";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codLocal", factura.CodigoLocalFactura);
                cmd.Parameters.AddWithValue("@tipoDocumento", factura.TipoDocumentoFactura);
                cmd.Parameters.AddWithValue("@nroDocumento", factura.DocumentoFactura);
                cmd.Parameters.AddWithValue("@nroTarjeta", factura.NroTarjetaFactura);
                cmd.Parameters.AddWithValue("@fecha", factura.FechaCompraFactura);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                objTransaction = cn.BeginTransaction("AltaDeFactura");
                cmd.Transaction = objTransaction;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                foreach (var detalle in factura.DetallesFactura)
                {
                    string consultaDetalle = "agregarDetalleFactura @nroFactura, @codLocal, @codProducto, @cantidad, @precio";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nroFactura", nroFactura);
                    cmd.Parameters.AddWithValue("@codLocal", factura.CodigoLocalFactura);
                    cmd.Parameters.AddWithValue("@codProducto", detalle.CodigoPorductoDetalle);
                    cmd.Parameters.AddWithValue("@cantidad",  detalle.CantidadProductoDetalle);
                    cmd.Parameters.AddWithValue("@precio", detalle.PrecioDetalle);
                    cmd.CommandText = consultaDetalle;
                    cmd.ExecuteNonQuery();
                }
                objTransaction.Commit();
                return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
                objTransaction.Rollback();
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
                objTransaction.Rollback();
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static DataTable getMasVendido()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "getMasVendido";

                command.Parameters.Clear();
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
        public static DataTable getMasVendidoPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "getMasVendidoPorFecha @fechaDesde, @fechaHasta";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                command.Parameters.AddWithValue("@fechaHasta", fechaHasta);
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
        public static DataTable getMasVendidoPorLocal(int idLocal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "getMasVendidoPorLocal @idLocal";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@idLocal", idLocal);
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
