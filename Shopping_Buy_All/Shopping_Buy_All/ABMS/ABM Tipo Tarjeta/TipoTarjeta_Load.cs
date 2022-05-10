using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Shopping_Buy_All.Entidades;

namespace Shopping_Buy_All.ABM_Tipo_Tarjeta
{
    public partial class TipoTarjeta_Load : Form
    {
        public TipoTarjeta_Load()
        {
            InitializeComponent();
            CargarTablaTipoTarjeta();
        }
        private void limpiarCampos()
        {
            txtNombreTdT.Text = "";
        }
        private void CargarTablaTipoTarjeta()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "SELECT * FROM TipoTarjeta WHERE Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaTipoTarjeta.DataSource = tabla;
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
        private bool Agregar_TipoTarjeta(TipoTarjeta tipoTarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO TipoTarjeta Values(@nombre, 0)";
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
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        private void btnTipoTarjetaLoad_Click(object sender, EventArgs e)
        {
            TipoTarjeta tipoTarjeta = new TipoTarjeta(txtNombreTdT.Text.Trim(), 0);
            bool resultado = Agregar_TipoTarjeta(tipoTarjeta);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + tipoTarjeta.NombreTipoTarjeta + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Tipo de Tarjeta agregado con éxito!");
                    limpiarCampos();
                    CargarTablaTipoTarjeta();
                }
                else
                {
                    txtNombreTdT.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el Tipo de Tarjeta! \n Complete los campos por favor!");
            }
        }
    }
}
