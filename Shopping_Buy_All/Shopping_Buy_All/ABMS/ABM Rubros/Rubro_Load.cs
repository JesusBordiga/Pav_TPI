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


namespace Shopping_Buy_All
{
    public partial class Rubro_Load : Form
    {
        public Rubro_Load()
        {
            InitializeComponent();
            CargarTablaRubros();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            textRubro.Text = "";
            CargarTablaRubros();
        }
        private void CargarTablaRubros()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Rubros WHERE Borrado like 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaRubros.DataSource = tabla;
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

        private string ObtenerNombreRubro()
        {
            string rubro = textRubro.Text.Trim();
            return rubro;
        }
        private bool ExisteRubro(string rubro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Rubros WHERE Nombre = @rubro AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@rubro", rubro);

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
                throw;
            }
            finally
            {
                cn.Close();
            }
            return result;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string rubro = ObtenerNombreRubro();
                if (!ExisteRubro(rubro))
                {
                    bool resultado = Agregar_Rubro(rubro);
                    if (resultado)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = (
                              " | Nombre: " + rubro + "\n");

                        string titulo = "Información de Carga";

                        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Rubro agregado con éxito!");
                            Clean();
                            CargarTablaRubros();
                        }
                        else
                        {
                            textRubro.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar el Rubro! \n" +
                                "Complete los campos por favor!");
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar el Rubro! \n" +
                        "Este rubro ya existe!");
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el Rubro! \n" +
                        "Complete los campos correctamente por favor!");
            }
        }

        private bool Agregar_Rubro(string rubro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Rubros(Nombre)" +
                                               "VALUES(@rubro)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@rubro", rubro);
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

        private bool ValidarCampos()
        {
            if (textRubro.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
    }
}
