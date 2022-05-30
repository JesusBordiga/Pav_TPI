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
    public class AD_Productos
    {
        //PRODUCT LOAD
        public static bool Cargar_Producto(Producto product)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "agregarProducto @nombre, @precio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", product.NombreProducto);
                cmd.Parameters.AddWithValue("@precio", product.PrecioProducto);

                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo cargar el producto.\nError en la base de datos.", "ERROR");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el producto.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        public static DataTable CargarTablaProductos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getProductoNoBorrado";


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
            catch (SqlException)
            {
                MessageBox.Show("No se pudo cargar tabla de producto.\nError en la base de datos.", "ERROR");
                throw;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar tabla de producto.\nError en la base de datos.", "ERROR");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        //PRODUCT MODIFY
        public static Producto Buscar_Producto(string Code)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Producto product = new Producto();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BuscarProductoNoBorrado @codigoProducto";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoProducto", Code);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    product.CodigoProducto = int.Parse(DataReader["Codigo_Producto"].ToString());
                    product.NombreProducto = DataReader["NombreProducto"].ToString();
                    product.PrecioProducto = float.Parse(DataReader["Precio"].ToString());

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo buscar producto.\nError en la base de datos.", "ERROR");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo buscar producto.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return product;


        }
        public static bool ModificarProducto(Producto prod)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ModificarProducto @nombreProducto, @precio, @codigoProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoProducto", prod.CodigoProducto);
                cmd.Parameters.AddWithValue("@nombreProducto", prod.NombreProducto);
                cmd.Parameters.AddWithValue("@precio", prod.PrecioProducto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo modificar producto.\nError en la base de datos.", "ERROR");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo modificar producto.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        //PRODUCT DELETE
        public static bool BorrarProducto(int Codigo, int Borrado)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarProducto @codigoProducto, @borrado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoProducto", Codigo);
                cmd.Parameters.AddWithValue("@borrado", Borrado);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo borrar producto.\nError en la base de datos.", "ERROR");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo borrar producto.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
    }
}
