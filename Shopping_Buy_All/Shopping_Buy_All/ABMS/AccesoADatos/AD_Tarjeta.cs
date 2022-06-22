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
    public class AD_Tarjeta
    {
        public AccesoADatos _DB = new AccesoADatos();

        //TARJETA LOAD
        public static object obtenerDatosTarjeta(int tipoDoc, string nroDoc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "getTarjetaNoBorrado @tipoDoc, @nroDoc";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@tipoDoc", tipoDoc);
                command.Parameters.AddWithValue("@nroDoc", nroDoc);
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

        public static DataTable ObtenerCantidadMarcasTarjeta()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "SELECT M.Nombre, COUNT(C.IdMarca) 'CantidadTipos' FROM" +
                                   "MarcaTarjetas M JOIN TarjetaXCliente C on C.IdMarca = M.idMarca" +
                                   "WHERE C.Borrado = 0 and M.Borrado = 0  GROUP BY M.Nombre" +
                                   "ORDER BY 'CantidadTipos' DESC";

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
        public DataTable ObtenerCantidadMarcasTarjeta1()
        {
            string consulta = "SELECT M.Nombre, COUNT(C.IdMarca) 'CantidadMarcas' FROM " +
                               "MarcaTarjetas M JOIN TarjetaXCliente C on C.IdMarca = M.idMarca " +
                               "WHERE C.Borrado = 0 and M.Borrado = 0  GROUP BY M.Nombre " +
                               "ORDER BY 'CantidadMarcas' DESC";
            return _DB.Consultar(consulta);
        }

        public DataTable ObtenerCantidadTiposTarjeta1()
        {
            string consulta = "SELECT T.Nombre, COUNT(C.IdMarca) 'CantidadTipos' FROM " +
                              " TipoTarjeta T JOIN TarjetaXCliente C on C.IdTipo = T.idTipo " +
                              " WHERE C.Borrado = 0 and T.Borrado = 0  GROUP BY T.Nombre " +
                              " ORDER BY 'CantidadTipos' DESC ";

            return _DB.Consultar(consulta);
        }
    }
}
