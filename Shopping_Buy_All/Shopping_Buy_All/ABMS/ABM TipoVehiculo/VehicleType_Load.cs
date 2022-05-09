using Shopping_Buy_All.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.ABMS.ABM_TipoVehiculo
{
    public partial class VehicleType_Load : Form
    {
        public VehicleType_Load()
        {
            InitializeComponent();
            CargarTablaTipoVehiculo();
        }

        private void CargarTablaTipoVehiculo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM TipoAuto WHERE Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaTipoVehiculo.DataSource = tabla;
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

        private TipoVehiculo ObtenerDatosTipoVehiculo()
        {
            TipoVehiculo t = new TipoVehiculo();

            //Nombre de TipoVehiculo
            t.Nombre = textNameVehicle.Text.Trim();

            return t;
        }

        private void Clean()
        {
            textNameVehicle.Text = "";
        }

        private void butVehicleLoad_Click(object sender, EventArgs e)
        {
            TipoVehiculo tv = ObtenerDatosTipoVehiculo();
            bool resultado = Agregar_TipoVehiculo(tv);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (
                      " |Nombre: " + tv.Nombre );

                string titulo = "Información de Carga";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Tipo Vehiculo agregado con éxito!");
                    Clean();
                    CargarTablaTipoVehiculo();
                }
                else
                {
                    textNameVehicle.Focus();
                }
            }
        }
        private bool Agregar_TipoVehiculo(TipoVehiculo tipoVehiculo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO TipoAuto(Nombre,Borrado) Values(@nombre,@borrado)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", tipoVehiculo.Nombre);
                cmd.Parameters.AddWithValue("@borrado", tipoVehiculo.Borrado);

                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }

        private void butClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
