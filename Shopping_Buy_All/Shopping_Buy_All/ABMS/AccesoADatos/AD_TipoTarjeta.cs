using Shopping_Buy_All.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.ABMS.AccesoADatos
{
    public class AD_TipoTarjeta
    {

        public DataTable GetComprasPorTipo(string anio, string mes)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT TI.Nombre, COUNT(*) 'Cantidad' " +
                    "FROM ComprasPorCliente C JOIN TarjetaXCliente T " +
                    "ON (C.Numero_Tarjeta = T.NroTarjeta " +
                    "AND C.Tipo_Documento = T.TipoDocumento " +
                    "AND C.Numero_Documento = T.NroDocumento) " +
                    "JOIN TipoTarjeta TI ON T.IdTipo = TI.idTipo " +
                    "WHERE C.Borrado = 0 AND T.Borrado = 0 AND TI.Borrado = 0 " +
                    "AND YEAR(FechaCompra) = @anio " +
                    "AND MONTH(FechaCompra) = @mes " +
                    "GROUP BY TI.Nombre, TI.idTipo " +
                    "ORDER BY 'Cantidad' DESC";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.Parameters.AddWithValue("@mes", mes);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (SqlException)
            {
                MessageBox.Show("Error!.\nError en la base de datos.", "ERROR");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!.\nHubo un error!", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return tabla;
        }

        //TIPO TARJETA LOAD
        public static object obtenerDatosTipoTarjeta()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "getTipoTarjetaNoBorrado";
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
            catch (SqlException)
            {
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
                throw;
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool agregarTipoTarjeta(TipoTarjeta tipoTarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "agregarTipoTarjeta @nombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", tipoTarjeta.NombreTipoTarjeta);

                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
                throw;
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        //TIPO TARJETA MODIFY
        public static object buscarTipoTarjeta(string nombreViejo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "buscarTipoTarjetaNoBorrado @Nombre";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Nombre", nombreViejo);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
                throw;
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static void modificarTipoTarjeta(string nombreNuevo, string nombreViejo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "modificarTipoTarjeta @nombreNuevo, @nombreViejo";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombreNuevo", nombreNuevo);
                command.Parameters.AddWithValue("@nombreViejo", nombreViejo);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
            finally
            {
                cn.Close();
            }
        }
        //TIPO TARJETA DELETE
        public static void borrarTipoTarjeta(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "borrarTipoTarjeta @nombre";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
