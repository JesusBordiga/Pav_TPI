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
    public partial class MarcaVehiculo_Modify : Form
    {
        public MarcaVehiculo_Modify()
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
                string consulta = "Select * FROM Marcas WHERE Borrado like 0";

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

        private bool ExisteMarca(string marca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Marcas WHERE Descripcion = @marca AND Borrado like 0";

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

        private string ObtenerDatos()
        {
            string r = textMarcaNew.Text.Trim();
            return r;
        }

        private bool ModificarMarca(string newM, string oldM)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Marcas SET Descripcion = @newNombre WHERE Descripcion = @oldNombre";
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
            catch (Exception)
            {
                MessageBox.Show("No se pudo modificar la Marca.\nError en la base de datos.", "ERROR");
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
                string mark = textMarcaOld.Text.Trim();
                bool existe = ExisteMarca(mark);
                if (existe)
                {
                    Cargar_Campos(mark);
                }
                else
                {
                    MessageBox.Show("La Marca buscada no existe.");
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
            if (ValidarCampos())
            {
                string newR = ObtenerDatos();
                if (!ExisteMarca(newR))
                {
                    string oldR = textMarcaOld.Text.Trim().ToLower();
                    bool resultado = ModificarMarca(newR, oldR);
                    if (resultado)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = (
                              " | Marca: " + newR + " |" + "\n");

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
                        MessageBox.Show("Error al modificar la Marca! \n" +
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
                MessageBox.Show("Error al modificar la Marca! \n" +
                            "Complete los campos por favor!");
            }
        }

        private bool ValidarCampos()
        {
            // Validar que no esté vacío o no tenga más de 50 caracteres
            if (textMarcaNew.Text.Trim() == "" || textMarcaNew.Text.Trim().Length > 50)
            {
                return false;
            }
            return true;
        }
        private void tablaMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaMarcas.Rows[indice];
                string mark = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                Cargar_Campos(mark);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una casilla dentro de la tabla", "ERROR");
            }
        }
    }
}
