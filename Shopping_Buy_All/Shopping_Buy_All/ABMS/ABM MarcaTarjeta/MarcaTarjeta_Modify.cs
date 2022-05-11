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
    public partial class MarcaTarjeta_Modify : Form
    {
        public MarcaTarjeta_Modify()
        {
            InitializeComponent();
            CargarTablaMarcas();
        }

        private void Clean()
        {
            textMarcaOld.Text = "";
            textMarcaNew.Text = "";
            textMarcaOld.Visible = true;
            textMarcaNew.Visible = false;
            btnModify.Visible = false;
            btnSearch.Visible = true;
            labelMarca.Visible = true;
            labelMod.Visible = false;
            textMarcaOld.Focus();
        }

        private void Cargar_Campos(string marca)
        {
            //Cargar Nombre Original
            textMarcaOld.Text = marca;
            //Cargar Nombre Nuevo
            textMarcaNew.Text = marca;
            btnModify.Visible = true;
            textMarcaOld.Visible = false;
            textMarcaNew.Visible = true;
            btnSearch.Visible = false;
            labelMarca.Visible = false;
            labelMod.Visible = true;
            textMarcaNew.Focus();
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

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private bool ExisteRubro(string marca)
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
                throw;
            }
            finally
            {
                cn.Close();
            }
            return result;
        }

        private string ObtenerDatos()
        {
            string m = textMarcaNew.Text.Trim();
            return m;
        }

        private bool ModificarMarca(string newM, string oldM)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE MarcaTarjetas SET Nombre = @newNombre WHERE Nombre = @oldNombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@newNombre", newM);
                cmd.Parameters.AddWithValue("@oldNombre", oldM);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textMarcaOld.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                string rubro = textMarcaOld.Text.Trim();
                bool existe = ExisteRubro(rubro);
                if (existe)
                {
                    Cargar_Campos(rubro);
                }
                else
                {
                    Clean();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (textMarcaNew.Text.Trim() != "")
            {
                string newM = ObtenerDatos();
                if (!ExisteRubro(newM))
                {
                    string oldM = textMarcaOld.Text.Trim().ToLower();
                    bool resultado = ModificarMarca(newM, oldM);
                    if (resultado)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = (
                              " | Marca: " + newM + " |" + "\n");

                        string titulo = "Información de Marca";

                        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Marca modificada con éxito!");
                            Clean();
                            CargarTablaMarcas();
                        }
                        else
                        {
                            textMarcaOld.Focus();
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
                    MessageBox.Show("Error al modificar la Marca! \n" +
                            "Ya existe una marca con ese nombre!");
                }
            }
            else
            {
                MessageBox.Show("Error al cargar la Marca! \n" +
                            "Complete los campos por favor!");
            }
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
