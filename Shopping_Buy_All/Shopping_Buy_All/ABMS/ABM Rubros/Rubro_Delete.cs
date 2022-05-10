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
    public partial class Rubro_Delete : Form
    {
        public Rubro_Delete()
        {
            InitializeComponent();
        }

        private void Rubro_Delete_Load(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            btnDelete.Visible = false;
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

        private void Clean()
        {
            textRubro.Text = "";
            btnDelete.Visible = false;
            btnSearch.Visible = true;
            textRubro.Enabled = true;
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

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textRubro.Text.Trim() == "")
            {
                MessageBox.Show("Error, Debe completar los campos!!");
            }
            else
            {
                string rubro = textRubro.Text.Trim();
                bool existe = ExisteRubro(rubro);
                if (existe)
                {
                    Cargar_Campos(rubro);
                }
                else
                {
                    MessageBox.Show("El rubro que busca no existe o fue borrado!");
                }
            }
        }

        private bool BorrarRubro(string rubro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Rubros SET Borrado = 1 WHERE Nombre = @rubro AND Borrado like 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@rubro", rubro);
                cmd.CommandType = CommandType.Text;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string rubro = textRubro.Text.Trim();
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = (
                  " | Nombre: " + rubro + " |" + "\n" + "\n" + " | Desea eliminar a este rubro??");

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                bool resultado = BorrarRubro(rubro);
                if (resultado)
                {
                    MessageBox.Show("Rubro Borrado con éxito!");
                    Clean();
                    btnDelete.Visible = false;
                    btnSearch.Visible = true;
                    CargarTablaRubros();
                    textRubro.Focus();
                }
                else
                {
                    MessageBox.Show("El Rubro No fue Borrado!");
                }
            }
            else
            {
                textRubro.Focus();
            }
        }

        private void Cargar_Campos(string rubro)
        {
            textRubro.Text = rubro;
            btnDelete.Visible = true;
            btnSearch.Visible = false;
            textRubro.Enabled = false;
        }

        private void tablaRubros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaRubros.Rows[indice];
                string rubro = filaSeleccionada.Cells["Nombre"].Value.ToString();
                Cargar_Campos(rubro);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una casilla dentro de la tabla", "ERROR");
            }
        }
    }
}
