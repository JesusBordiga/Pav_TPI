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
    public partial class Rubro_Modify : Form
    {
        public Rubro_Modify()
        {
            InitializeComponent();
            CargarTablaRubros();
        }

        private void Clean()
        {
            textRubroOld.Text = "";
            textRubroNew.Text = "";
            textRubroOld.Visible = true;
            textRubroNew.Visible = false;
            btnModify.Visible = false;
            btnSearch.Visible = true;
            labelRubro.Visible = true;
            labelMod.Visible = false;
            textRubroOld.Focus();
        }

        private void Cargar_Campos(string rubro)
        {
            //Cargar Nombre Original
            textRubroOld.Text = rubro;
            //Cargar Nombre Nuevo
            textRubroNew.Text = rubro;
            btnModify.Visible = true;
            textRubroOld.Visible = false;
            textRubroNew.Visible = true;
            btnSearch.Visible = false;
            labelRubro.Visible = false;
            labelMod.Visible = true;
            textRubroNew.Focus();
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

        private string ObtenerDatos()
        {
            string r = textRubroNew.Text.Trim();
            return r;
        }

        private bool ModificarRubro(string newR, string oldR)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Rubros SET Nombre = @newNombre WHERE Nombre = @oldNombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@newNombre", newR);
                cmd.Parameters.AddWithValue("@oldNombre", oldR);
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
            if (textRubroOld.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                string rubro = textRubroOld.Text.Trim();
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
            if (textRubroNew.Text.Trim() != "")
            {
                string newR = ObtenerDatos();
                if (!ExisteRubro(newR))
                {
                    string oldR = textRubroOld.Text.Trim().ToLower();
                    bool resultado = ModificarRubro(newR, oldR);
                    if (resultado)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = (
                              " | Rubro: " + newR + " |" + "\n");

                        string titulo = "Información de Rubro";

                        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Rubro modificado con éxito!");
                            Clean();
                            CargarTablaRubros();
                        }
                        else
                        {
                            textRubroOld.Focus();
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
                    MessageBox.Show("Error al modificar el Rubro! \n" +
                            "Ya existe un rubro con ese nombre!");
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el Rubro! \n" +
                            "Complete los campos por favor!");
            }
        }

        private void tablaRubros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaRubros.Rows[indice];
            string rubro = filaSeleccionada.Cells["Nombre"].Value.ToString();
            Cargar_Campos(rubro);
        }
    }
}
