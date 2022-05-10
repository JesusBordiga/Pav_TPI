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
using Shopping_Buy_All.ABM_Cliente;

namespace Shopping_Buy_All
{
    public partial class Modelo_Delete : Form
    {
        public Modelo_Delete()
        {
            InitializeComponent();
            CargarTablaModelos();
            CargarIdMarcas();
            CargarCodigosTipoAuto();
        }
        private void Client_Delete_Load(object sender, EventArgs e)
        {
            tablaModelos.Visible = false;
            btnSearch.Visible = true;
            btnDeleteModelo.Visible = false;
            CargarIdMarcas();
            CargarCodigosTipoAuto();

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
        private void Clean()
        {
            textNombreModelo.Text = "";
            comboBoxIdMarca.SelectedIndex = -1;
            comboBoxTipoAuto.SelectedIndex = -1;
            CargarTablaModelos();
        }
        private Modelo Cargar_Modelo(string NombreModelo, int IdMarca, int CodigoTipoAuto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Modelo model = new Modelo();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Modelos where NombreModelo like @nombreModelo AND IdMarca like @idMarca AND CodigoTipoAuto like @codigoTipoAuto AND Borrado Like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", NombreModelo);
                cmd.Parameters.AddWithValue("@idMarca", IdMarca);
                cmd.Parameters.AddWithValue("@codigoTipoAuto", CodigoTipoAuto);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {

                    model.NombreModeloAuto = DataReader["NombreModelo"].ToString();
                    model.idMarcaAuto = int.Parse(DataReader["IdMarca"].ToString());
                    model.CodigoModeloAuto = int.Parse(DataReader["CodigoTipoAuto"].ToString());
                }
                cn.Close();

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
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
            return model;

        }
        private bool Buscar_Modelo(string NombreModelo, int IdMarca, int CodigoTipoAuto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Modelo model = new Modelo();
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Modelos where NombreModelo like @nombreModelo AND IdMarca like @idMarca AND CodigoTipoAuto like @codigoTipoAuto AND Borrado Like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", NombreModelo);
                cmd.Parameters.AddWithValue("@idMarca", IdMarca);
                cmd.Parameters.AddWithValue("@codigoTipoAuto", CodigoTipoAuto);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    model.NombreModeloAuto = DataReader["NombreModelo"].ToString();
                    model.idMarcaAuto = int.Parse(DataReader["IdMarca"].ToString());
                    model.CodigoModeloAuto = int.Parse(DataReader["CodigoTipoAuto"].ToString());
                    cn.Close();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    tablaModelos.DataSource = tabla;
                    resultado = true;
                }
  
            }
            catch (Exception)
            {

                throw;
                resultado = false;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        private void btnClean_Click(object sender, EventArgs e)
            {    
              Clean();
              tablaModelos.Visible = false;
              btnDeleteModelo.Visible = false;
              btnSearch.Visible = true;
            }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((int)comboBoxTipoAuto.SelectedIndex == 0 && (int)comboBoxIdMarca.SelectedIndex == 0 && textNombreModelo.Text.Trim().Equals(""))
                {
                MessageBox.Show("Error, Debe completar los campos!!");
                }
            else
                {
                bool existe = Buscar_Modelo(textNombreModelo.Text.Trim(), (int)comboBoxIdMarca.SelectedValue, (int)comboBoxTipoAuto.SelectedValue);
                if (existe)
                    {
                    tablaModelos.Visible = true;
                    btnDeleteModelo.Visible = true;
                    btnSearch.Visible = false;
                    }
                else
                    {
                    MessageBox.Show("El modelo que busca no existe o fue borrado!");
                    }
                }
        }
        private bool BorrarModelo(string NombreModelo, int IdMarca, int CodigoTipoAuto, int Borrado)
        {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Modelos SET Borrado = @borrado WHERE NombreModelo Like @nombreModelo AND IdMarca Like @idMarca AND CodigoTipoAuto Like @codigoTipoAuto AND Borrado like 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", NombreModelo);
                cmd.Parameters.AddWithValue("@idMarca", IdMarca);
                cmd.Parameters.AddWithValue("@codigoTipoAuto", CodigoTipoAuto);
                cmd.Parameters.AddWithValue("@borrado", Borrado);
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

        private void btnDeleteClient_Click(object sender, EventArgs e)

        {
            Modelo m = Cargar_Modelo(textNombreModelo.Text.Trim(), (int)comboBoxIdMarca.SelectedValue, (int)comboBoxTipoAuto.SelectedValue);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = (" |Nobre Del Modelo: " + m.NombreModeloAuto + " | \n | Id Marca: " + m.idMarcaAuto + "| \n | Codigo Modelo de Auto:" + m.CodigoModeloAuto + " | \n Desea eliminar a este modelo?");

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                bool resultado = BorrarModelo(textNombreModelo.Text.Trim(), (int)comboBoxIdMarca.SelectedValue, (int)comboBoxTipoAuto.SelectedValue, 1);
                if (resultado)
                {
                    MessageBox.Show("Modelo Borrado con éxito!");
                    Clean();
                    //BorrarModelo(m);
                    CargarIdMarcas();
                    CargarCodigosTipoAuto();
                    tablaModelos.Visible = false;
                    btnDeleteModelo.Visible = false;
                    btnSearch.Visible = true;
                    textNombreModelo.Focus();
                }
                else
                {
                    MessageBox.Show("El modelo no fue Borrado!");
                }
            }
            else
            {
                textNombreModelo.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Grilla_Modelos tabla = new Grilla_Modelos();
            tabla.Show();
            bool creado = true;

        }
    }
}

