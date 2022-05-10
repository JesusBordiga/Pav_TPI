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

namespace Shopping_Buy_All.ABM_Estado_Civil
{
    public partial class EstadoCivil_Load : Form
    {
        public EstadoCivil_Load()
        {
            InitializeComponent();
            CargarTablaEsCiv();
        }

        private void limpiarCampos()
        {
            txtNombreEC.Text = "";
        }
        private void CargarTablaEsCiv()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "SELECT * FROM TipoEstadoCivil WHERE Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaEsCiv.DataSource = tabla;
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
        private void btnECLoad_Click(object sender, EventArgs e)
        {
            EstadoCivil esCiv = new EstadoCivil(txtNombreEC.Text.Trim(), 0);
            bool resultado = Agregar_EstadoCivil(esCiv);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + esCiv.NombreEc + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Estado Civil agregado con éxito!");
                    limpiarCampos();
                    CargarTablaEsCiv();
                }
                else
                {
                    txtNombreEC.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el Estado Civil! \n Complete los campos por favor!");
            }
        }
        private bool Agregar_EstadoCivil(EstadoCivil esCiv)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO TipoEstadoCivil Values(@nombre, 0)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", esCiv.NombreEc);

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
    }
}
