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

namespace Shopping_Buy_All.ABMS.ABM_Profesiones
{
    public partial class Profesion_Load : Form
    {
        public Profesion_Load()
        {
            InitializeComponent();
            CargarTablaProfesiones();
        }
        private void limpiarCampos()
        {
            txtNombreProf.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void CargarTablaProfesiones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getProfesionNoBorrado";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;
            
                cn.Open();
                comand.Connection = cn;
            
                DataTable tabla = new DataTable();
            
                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaProfesiones.DataSource = tabla;
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
        private void btnCargarProf_Click(object sender, EventArgs e)
        {
            bool resultado = cargarProfesion(txtNombreProf.Text);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + txtNombreProf.Text.Trim() + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Profesion agregada con éxito!");
                    limpiarCampos();
                    CargarTablaProfesiones();
                }
                else
                {
                    txtNombreProf.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el tipo de documento! \n Complete los campos por favor!");
            }
        }
        private bool cargarProfesion(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "agregarProfesion @nombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);

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
