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
    public partial class MarcaTarjeta_Delete : Form
    {
        public MarcaTarjeta_Delete()
        {
            InitializeComponent();
        }

        private void Marca_Delete_Load(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            btnDelete.Visible = false;
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

        private void Clean()
        {
            textMarca.Text = "";
            btnDelete.Visible = false;
            btnSearch.Visible = true;
            textMarca.Enabled = true;
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

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textMarca.Text.Trim() == "")
            {
                MessageBox.Show("Error, Debe completar los campos!!");
            }
            else
            {
                string marca = textMarca.Text.Trim();
                bool existe = ExisteMarca(marca);
                if (existe)
                {
                    Cargar_Campos(marca);
                }
                else
                {
                    MessageBox.Show("La marca que busca no existe o fue borrado!");
                }
            }
        }

        private bool BorrarMarca(string marca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE MarcaTarjetas SET Borrado = 1 WHERE Nombre = @marca AND Borrado like 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar la Marca.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string marca = textMarca.Text.Trim();
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = (
                  " | Nombre: " + marca + " |" + "\n" + "\n" + " | Desea eliminar a esta marca??");

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                bool resultado = BorrarMarca(marca);
                if (resultado)
                {
                    MessageBox.Show("Marca Borrada con éxito!");
                    Clean();
                    btnDelete.Visible = false;
                    btnSearch.Visible = true;
                    CargarTablaMarcas();
                    textMarca.Focus();
                }
                else
                {
                    MessageBox.Show("La Marca No fue Borrado!");
                }
            }
            else
            {
                textMarca.Focus();
            }
        }

        private void Cargar_Campos(string marca)
        {
            textMarca.Text = marca;
            btnDelete.Visible = true;
            btnSearch.Visible = false;
            textMarca.Enabled = false;
        }

        private void tablaMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaMarcas.Rows[indice];
                string marca = filaSeleccionada.Cells["Nombre"].Value.ToString();
                Cargar_Campos(marca);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una casilla dentro de la tabla", "ERROR");
            }
        }
    }
}
