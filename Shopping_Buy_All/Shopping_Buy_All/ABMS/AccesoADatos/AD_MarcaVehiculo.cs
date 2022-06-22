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
    public class AD_MarcaVehiculo
    {
        private AccesoADatos _DB = new AccesoADatos();

        /// <summary>
        /// Obtiene todas los marcas de vehiculo
        /// </summary>
        /// <returns></returns>
        public DataTable _Rpt_Marcas()
        {
            string consulta = "getMarcaNoBorrado";
            return _DB.Consultar(consulta);
        }

        /// <summary>
        /// Obtiene las marcas que comienzan con una letra
        /// </summary>
        /// <param name="letr"></param>
        /// <returns></returns>
        public DataTable _Rpt_Marcas(string letr)
        {
            string consulta = "getMarcasPorLetra " + letr;
            return _DB.Consultar(consulta);
        }

        /// <summary>
        /// Obtiene las marcas dentro de un rango de IDs
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public DataTable _Rpt_Marcas(int min, int max)
        {
            string consulta = "getMarcasPorRangoID " + min.ToString() + "," + max.ToString();
            return _DB.Consultar(consulta);
        }

        //MARCA VEHICULO LOAD
        public static bool Agregar_Marca(MarcaVehiculo mark)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Marcas (Descripcion) " +
                                               "Values(@descripcion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", mark.MarcaVeh);
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
        public static object CargarTablaMarcas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Marcas WHERE Borrado = 0";

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
                MessageBox.Show("Error en la base de datos.", "ERROR");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        //MARCA VEHICULO MODIFY
        public static bool ExisteMarca(string marca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Marcas WHERE Descripcion = @marca AND Borrado like 0";

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
        public static bool ModificarMarca(string newM, string oldM)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Marcas SET Descripcion = @newNombre WHERE Descripcion = @oldNombre";
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

        //MARCA VEHICULO DELETE

    }
}
