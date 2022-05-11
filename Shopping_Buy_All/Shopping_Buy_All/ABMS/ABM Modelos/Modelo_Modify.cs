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
    public partial class Modelo_Modify : Form
    {
        public Modelo_Modify()
        {
            InitializeComponent();
            CargarTablaModelos();
            CargarIdMarcas();
            CargarIdMarcas2();
            CargarCodigosTipoAuto();
            CargarCodigosTipoAuto2();
        }

        private void btnBuscarCliente_click(object sender, EventArgs e)
        {
            if ((int)comboBoxTipoAuto.SelectedIndex == 0 && (int)comboBoxIdMarca.SelectedIndex == 0 && textNombreModelo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
            Modelo m = Buscar_Modelo(textNombreModelo.Text.Trim(), (int)comboBoxIdMarca.SelectedIndex, (int)comboBoxTipoAuto.SelectedIndex);
            Cargar_Campos(m);
            SearchPanel.Visible=false;
            btnSearchClient.Visible=false;

            }
        }
        private void btnSearchClient2_Click(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnSearchClient.Visible = true;

        }
        private void Clean()
        {
            textNombreModelo.Text = "";
            comboBoxIdMarca.SelectedIndex = -1;
            comboBoxTipoAuto.SelectedIndex = -1;
            textNombreNuevo.Text = "";
            comboBoxNuevoIdMarca.SelectedIndex = -1;
            comboBoxNuevoTipoAuto.SelectedIndex = -1;
            CargarTablaModelos();
        }
        private void Cargar_Campos(Modelo m)
        {
            //Cargar Tipo Documento
            textNombreModelo.Text = m.NombreModeloAuto;
            //Cargar Documento
            comboBoxIdMarca.SelectedIndex = m.idMarcaAuto;
            //Cargar Apellido
            comboBoxTipoAuto.SelectedIndex = m.CodBorradoigoTipoAuto;
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
        private void CargarIdMarcas2()
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

                comboBoxNuevoIdMarca.DataSource = tabla;
                comboBoxNuevoIdMarca.DisplayMember = "Descripcion";
                comboBoxNuevoIdMarca.ValueMember = "Id";
                comboBoxNuevoIdMarca.SelectedIndex = -1;
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
        private void CargarCodigosTipoAuto2()
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

                comboBoxNuevoTipoAuto.DataSource = tabla;
                comboBoxNuevoTipoAuto.DisplayMember = "Nombre";
                comboBoxNuevoTipoAuto.ValueMember = "Cod_tipo";
                comboBoxNuevoTipoAuto.SelectedIndex = -1;
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
        private Modelo Buscar_Modelo(string NombreModelo, int IdMarca, int CodigoTipoAuto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Modelo model= new Modelo();
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
                if (DataReader !=null && DataReader.Read())
                {
                    model.NombreModeloAuto = DataReader["NombreModelo"].ToString();
                    model.idMarcaAuto = int.Parse(DataReader["IdMarca"].ToString());
                    model.CodigoModeloAuto = int.Parse(DataReader["CodigoTipoAuto"].ToString());
                }
            }
            catch (Exception )
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return model;

        }

        private Modelo Buscar_Modelo(string NombreModelo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Modelo model = new Modelo();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Modelos WHERE NombreModelo like @nombreModelo ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", NombreModelo);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        public void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaModelos.Rows[indice];
            string nombre = filaSeleccionada.Cells["NombreModelo"].Value.ToString();
            Modelo m = Buscar_Modelo(nombre);
            Clean();
            SearchPanel.Visible = false;
            btnSearchClient.Visible = false;
            textNombreNuevo.Visible = false;
            comboBoxIdMarca.Visible = false;
            comboBoxTipoAuto.Visible = false;
            Cargar_Campos(m);
        }

        private Modelo ObtenerDatosModelo()
        {

           Modelo m = new Modelo();
            //Nombre Modelo
            m.NombreModeloAuto = textNombreNuevo.Text.Trim();

            //Id Marca
            m.idMarcaAuto = (int)comboBoxNuevoIdMarca.SelectedValue;

            //Codigo Tipo
            m.CodigoModeloAuto = (int)comboBoxNuevoTipoAuto.SelectedValue;

            return m;

        }

        private bool ModificarModelo(Modelo model)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Modelos SET NombreModelo = @nombreModelo, IdMarca = @idMarca, CodigoTipoAuto =  @codigoTipoAuto WHERE NombreModelo Like @nombreModeloViejo AND IdMarca Like @idMarcaVieja AND codigoTipoAuto like @codigoTipoAutoViejo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", model.NombreModeloAuto);
                cmd.Parameters.AddWithValue("@idMarca", model.idMarcaAuto);
                cmd.Parameters.AddWithValue("@codigoTipoAuto", model.CodigoModeloAuto);
                cmd.Parameters.AddWithValue("@nombreModeloViejo", textNombreModelo.Text);
                cmd.Parameters.AddWithValue("@idMarcaVieja", (int)comboBoxIdMarca.SelectedValue);
                cmd.Parameters.AddWithValue("@codigoTipoAutoViejo", (int)comboBoxNuevoTipoAuto.SelectedValue);
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

        private void btnClientLoad_Click_1(object sender, EventArgs e)
        {
            Modelo m = ObtenerDatosModelo();
            bool resultado = ModificarModelo(m);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (" |Nobre Del Modelo: " + m.NombreModeloAuto + " | \n | Id Marca: " + m.idMarcaAuto + "| \n | Codigo Modelo de Auto:" + m.CodigoModeloAuto + " | \n");

                string titulo = "Información de Carga";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Cliente agregado con éxito!");
                    Clean();
                    CargarTablaModelos();
                    CargarIdMarcas();
                    CargarIdMarcas2();
                    CargarCodigosTipoAuto();
                    CargarCodigosTipoAuto2();
                }
                else
                {
                    textNombreModelo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar la persona!");
            }
        }
    }
}
