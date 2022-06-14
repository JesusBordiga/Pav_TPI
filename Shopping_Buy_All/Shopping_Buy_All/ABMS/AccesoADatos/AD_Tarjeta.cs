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
                command.Parameters.AddWithValue("@tipoDoc",tipoDoc);
                command.Parameters.AddWithValue("@nroDoc",nroDoc);
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

            //TARJETA MODIFY

            //TARJETA DELETE
        }
    }
}
