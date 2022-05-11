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
    public partial class MarcaTarjeta_Load : Form
    {
        public MarcaTarjeta_Load()
        {
            InitializeComponent();
            CargarTablaMarcas();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            textMarca.Text = "";
            CargarTablaMarcas();
        }

        private void CargarTablaMarcas()
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
                tablaMarcas.DataSource = tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
        }

        private string ObtenerNombreMarca()
        {
            string rubro = textMarca.Text.Trim();
            return rubro;
        }
        private bool ExisteMarca(string marca)
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string marca = ObtenerNombreMarca();
                if (!ExisteMarca(marca))
                {
                    bool resultado = Agregar_Marca(marca);
                    if (resultado)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = (
                              " | Nombre: " + marca + "\n");

                        string titulo = "Información de Carga";

                        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Marca agregada con éxito!");
                            Clean();
                            CargarTablaMarcas();
                        }
                        else
                        {
                            textMarca.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar la Marca! \n" +
                                "Complete los campos por favor!");
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar la Marca! \n" +
                        "Esta marca ya existe!");
                }
            }
            else
            {
                MessageBox.Show("Error al cargar la Marca! \n" +
                        "Complete los campos correctamente por favor!");
            }
        }

        private bool Agregar_Marca(string marca)
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

        private bool ValidarCampos()
        {
            if (textMarca.Text.Trim() == "" || textMarca.Text.Trim().Length > 50)
            {
                return false;
            }
            return true;
        }
    }
}
