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
using Shopping_Buy_All.Entidades;

namespace Shopping_Buy_All
{
    public partial class MarcaVeh_Modify : Form
    {
        public MarcaVeh_Modify()
        {
            InitializeComponent();
            CargarTablaMarcas();
        }
        
        private void Clean()
        {
            textMarcaNew.Text = "";
            textMarcaOld.Text = "";
            textMarcaOld.Visible = true;
            textMarcaNew.Visible = false;
            btnMarcaLoad.Visible = false;
            labelMarca.Text = "Marca";
            btnSearchMarca.Visible = true;
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

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void Cargar_Campos(string marca)
        {
            //Cargar Nombre Original
            textMarcaOld.Text = marca;
            //Cargar Nombre Nuevo
            textMarcaNew.Text = marca;
            btnMarcaLoad.Visible = true;
            textMarcaOld.Visible = false;
            textMarcaNew.Visible = true;
            labelMarca.Text = "Nueva descripción de marca";
            btnSearchMarca.Visible = false;
        }

        private bool Existe_Marca(string marca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Marcas WHERE Descripcion = @descripcion AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", marca);

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

        private MarcaVehiculo ObtenerDatos()
        {
            MarcaVehiculo marca = new MarcaVehiculo();
            marca.MarcaVeh = textMarcaNew.Text.Trim();
            return marca;
        }

        private bool ModificarMarca(MarcaVehiculo newM, string oldM)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Marcas SET Descripcion = @descripcion WHERE Descripcion = @oldDesc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", newM.MarcaVeh);
                cmd.Parameters.AddWithValue("@oldDesc", oldM);
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

        private void btnSearchMarca_Click(object sender, EventArgs e)
        {
            if (textMarcaOld.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                string marca = textMarcaOld.Text.Trim();
                bool existe = Existe_Marca(marca);
                if (existe)
                {
                    Cargar_Campos(marca);
                }
                else
                {
                    Clean();
                    MessageBox.Show("No existe la marca buscada!!");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnMarcaLoad_Click(object sender, EventArgs e)
        {
            if (textMarcaNew.Text.Trim() != "")
            {
                if (!Existe_Marca(textMarcaNew.Text.Trim()))
                {
                    MarcaVehiculo m = ObtenerDatos();
                    string oldM = textMarcaOld.Text.Trim();
                    bool resultado = ModificarMarca(m, oldM);
                    if (resultado)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = (
                              " | Descripcion: " + m.MarcaVeh + " |" + "\n");

                        string titulo = "Información de MARCA";

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
                    MessageBox.Show("Error al cargar la Marca! \n" +
                            "La marca ya existe!");
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
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaMarcas.Rows[indice];
            string marca = filaSeleccionada.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
            Cargar_Campos(marca);
        }
    }
}
