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
    public class AD_MarcaTarjeta
    {
        //MARCA TARJETA LOAD
        public static bool Agregar_Marca(string marca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO MarcaTarjetas(Nombre)" +
                                               "VALUES(@marca)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar la Marca.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        public static bool ExisteMarca(string marca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM MarcaTarjetas WHERE Nombre = @marca AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marca", marca);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    result = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo buscar la Marca.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return result;
        }
        public static object CargarTablaMarcas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM MarcaTarjetas WHERE Borrado like 0";

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

        //MARCA TARJETA MODIFY
        public static bool ModificarMarca(string newM, string oldM)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE MarcaTarjetas SET Nombre = @newNombre WHERE Nombre = @oldNombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@newNombre", newM);
                cmd.Parameters.AddWithValue("@oldNombre", oldM);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo modificar la Marca.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool ExisteRubro(string marca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM MarcaTarjetas WHERE Nombre = @marca AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marca", marca);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    result = true;
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
            return result;
        }

        //MARCA TARJETA DELETE
        public static bool BorrarMarca(string marca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE MarcaTarjetas SET Borrado = 1 WHERE Nombre = @marca AND Borrado like 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar la Marca.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public DataTable GetComprasPorMarca(string anio, string mes)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT M.Nombre, COUNT(*) 'Cantidad' " +
                    "FROM ComprasPorCliente C JOIN TarjetaXCliente T " +
                    "ON (C.Numero_Tarjeta = T.NroTarjeta " +
                    "AND C.Tipo_Documento = T.TipoDocumento " +
                    "AND C.Numero_Documento = T.NroDocumento) " +
                    "JOIN MarcaTarjetas M ON T.IdMarca = M.idMarca " +
                    "WHERE C.Borrado = 0 AND T.Borrado = 0 AND M.Borrado = 0 " +
                    "AND YEAR(FechaCompra) = @anio " +
                    "AND MONTH(FechaCompra) = @mes " +
                    "GROUP BY M.Nombre, M.idMarca " +
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

        public DataTable _Rpt_MarcaTarjeta()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM MarcaTarjeta WHERE Borrado = 0 order by Nombre";
                cmd.Parameters.Clear();
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
        public DataTable _Rpt_MarcaTarjeta(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM MarcaTarjeta WHERE Borrado = 0 and Nombre like '" + nombre.Trim() + "%' order by Nombre";
                cmd.Parameters.Clear();
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
        public DataTable _Rpt_MarcaTarjeta1(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM MarcaTarjeta WHERE Borrado = 0 and idMarca like '" + id + "%' order by idMarca";
                cmd.Parameters.Clear();
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
        } }
}

