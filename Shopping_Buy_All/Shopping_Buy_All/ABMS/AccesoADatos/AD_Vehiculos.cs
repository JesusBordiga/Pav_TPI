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
    public class AD_Vehiculos
    {
        //VEHICULO LOAD

        //VEHICULO MODIFY

        //VEHICULO DELETE

        public DataTable _Rpt_Vehiculos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Automovil WHERE Borrado = 0 order by Patente";
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
        public DataTable _Rpt_Vehiculos(string patente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Automovil WHERE Borrado = 0 and Patente like '" + patente.Trim() + "%' order by Patente";
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
        public DataTable _Rpt_Vehiculos1(string doc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Automovil WHERE Borrado = 0 and NroDoc like '"+doc.Trim()+"%' order by NroDoc";
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
    }
}

