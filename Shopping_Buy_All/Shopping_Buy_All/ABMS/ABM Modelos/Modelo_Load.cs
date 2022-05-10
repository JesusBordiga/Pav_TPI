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
    public partial class Modelo_Load : Form
    {
        public Modelo_Load()
        {
            InitializeComponent();
            CargarTablaModelos();
            CargarIdMarcas();
            CargarCodigosTipoAuto();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            textNombreModelo.Text = "";
            comboBoxIdMarca.SelectedIndex = -1;
            comboBoxTipoAuto.SelectedIndex = -1;
            CargarTablaModelos();

        }
        private void CargarIdMarcas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Marcas";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                comboBoxIdMarca.DataSource = tabla;
                comboBoxIdMarca.DisplayMember = "Descripcion";
                comboBoxIdMarca.ValueMember = "Id";
                comboBoxIdMarca.SelectedIndex = -1;
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

        private void CargarCodigosTipoAuto()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM TipoAuto";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                comboBoxTipoAuto.DataSource = tabla;
                comboBoxTipoAuto.DisplayMember = "Nombre";
                comboBoxTipoAuto.ValueMember = "Cod_tipo";
                comboBoxTipoAuto.SelectedIndex = -1;
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
        private void CargarTablaModelos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Modelos WHERE Borrado like 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaModelos.DataSource = tabla;
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
        private Modelo ObtenerDatosModelo()
        {
            Modelo m = new Modelo();

            //Nombre del Modelo
            m.NombreModeloAuto = textNombreModelo.Text.Trim();

            //Id Marca
            m.idMarcaAuto = (int)comboBoxIdMarca.SelectedValue;

            //Codigo del modelo
            m.CodigoModeloAuto = (int)comboBoxTipoAuto.SelectedValue;

            return m;
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            Modelo m = ObtenerDatosModelo();
            bool resultado = Agregar_Modelo(m);
            if (resultado)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    String mensajeCarga = (
                          " |Nobre Del Modelo: " + m.NombreModeloAuto + " | \n | Id Marca: " + m.idMarcaAuto + "| \n | Codigo Modelo de Auto:" + m.CodigoModeloAuto + " |");

                    string titulo = "Información de Carga";

                    DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Modelo agregado con éxito!");
                        Clean();
                        CargarTablaModelos();
                        CargarIdMarcas();
                    CargarCodigosTipoAuto();


                    }
                    else
                    {
                        textNombreModelo.Focus();
                    }
                }
            else
            {
                MessageBox.Show("Error al cargar el Modelo! \n" +
                        "Complete los campos por favor!");
            }
        }

        private bool Agregar_Modelo(Modelo model)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Modelos(NombreModelo,IdMarca,CodigoTipoAuto)" +
                                               "Values(@nombreModelo,@idMarcaAuto, @CodBorradoigoTipoAuto)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", model.NombreModeloAuto);
                cmd.Parameters.AddWithValue("@idMarcaAuto", model.idMarcaAuto);
                cmd.Parameters.AddWithValue("@CodBorradoigoTipoAuto", model.CodigoModeloAuto);

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
    }
}
