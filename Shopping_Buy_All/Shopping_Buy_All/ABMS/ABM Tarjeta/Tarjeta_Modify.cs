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
    public partial class Tarjeta_Modify : Form
    {
        public Tarjeta_Modify()
        {
            InitializeComponent();
            CargarTablaTarjetas();
            CargarTiposDocumentos();
            CargarMarcaTarjetas();
            CargarTipoTarjetas();

        }

        private void btnBuscarTarjeta_click(object sender, EventArgs e)
        {
            if (cmbTipoDoc.SelectedIndex != 0 && textNroDoc.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                Tarjeta c = Buscar_Tarjeta(textNroTarjeta.Text);
                Cargar_Campos(c);
                SearchPanel.Visible = false;
                btnBuscarTarjeta.Visible = false;
            }
        }
        private void btnBuscarTarjeta_Click(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnBuscarTarjeta.Visible = true;

        }
        private void Clean()
        {
            cmbTipoDoc.SelectedIndex = -1;
            textNroDoc.Text = "";
            textNroTarjeta.Text = "";
            cmbMarcaTarjeta.SelectedIndex = -1;
            cmbTipoTarjeta.SelectedIndex = -1;
        }
        private void Cargar_Campos(Tarjeta c)
        {

            cmbTipoDoc.SelectedValue = c.TipoDocumentoTarjeta;

            textNroDoc.Text = c.NroDocumentoTarjeta;

            textNroTarjeta.Text = c.NroTarjetaCliente;

            cmbMarcaTarjeta.SelectedValue = c.IdMarcaTarjeta;

            cmbTipoTarjeta.SelectedValue = c.IdTipoTarjeta;

        } 
        private void CargarTiposDocumentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM TipoDocumento where Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                cmbTipoDoc.DataSource = tabla;
                cmbTipoDoc.DisplayMember = "NombreDocumento";
                cmbTipoDoc.ValueMember = "TipoDocumento";
                cmbTipoDoc.SelectedIndex = -1;
            }
            catch (Exception )
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        private void CargarTipoTarjetas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM TipoTarjeta where Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                cmbTipoTarjeta.DataSource = tabla;
                cmbTipoTarjeta.DisplayMember = "Nombre";
                cmbTipoTarjeta.ValueMember = "idTipo";
                cmbTipoTarjeta.SelectedIndex = -1;
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
        private void CargarMarcaTarjetas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM MarcaTarjetas where Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                cmbMarcaTarjeta.DataSource = tabla;
                cmbMarcaTarjeta.DisplayMember = "Nombre";
                cmbMarcaTarjeta.ValueMember = "idMarca";
                cmbMarcaTarjeta.SelectedIndex = -1;
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
        private void CargarTablaTarjetas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM TarjetaXCliente WHERE Borrado like 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaTarjetas.DataSource = tabla;
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
        private Tarjeta Buscar_Tarjeta(string NroTarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Tarjeta card = new Tarjeta();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TarjetaXCliente where NroTarjeta like @nroTarjeta AND Borrado = 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTarjeta", NroTarjeta);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader !=null && DataReader.Read())
                {
                    card.TipoDocumentoTarjeta = int.Parse(DataReader["TipoDocumento"].ToString());
                    card.NroDocumentoTarjeta = DataReader["NroDocumento"].ToString();
                    card.NroTarjetaCliente = DataReader["NroTarjeta"].ToString();
                    card.IdMarcaTarjeta = int.Parse(DataReader["IdMarca"].ToString());
                    card.IdTipoTarjeta = int.Parse(DataReader["IdTipo"].ToString());
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
            return card;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private Tarjeta ObtenerDatosTarjeta()
        {
            Tarjeta c = new Tarjeta();

            c.TipoDocumentoTarjeta = (int)cmbTipoDoc.SelectedValue;

            c.NroDocumentoTarjeta = textNroDoc.Text.Trim();

            c.NroTarjetaCliente = textNroTarjeta.Text.Trim();

            c.IdMarcaTarjeta = (int)cmbMarcaTarjeta.SelectedValue;

            c.IdTipoTarjeta = (int)cmbTipoTarjeta.SelectedValue;
            return c;
        }


        private bool ModificarTarjeta(Tarjeta card)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE TarjetaXCliente SET TipoDocumento=@tipoDocumento,NroDocumento = @nroDocumento,NroTarjeta =  @nroTarjeta,IdMarca =  @marca,IdTipo =  @tipo, WHERE TipoDocumento Like @tipoDocumento AND NroDocumento Like @nroDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocumento", card.NroDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroDocumento", card.NroDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroTarjeta", card.NroTarjetaCliente);
                cmd.Parameters.AddWithValue("@idMarca", card.IdMarcaTarjeta);
                cmd.Parameters.AddWithValue("@idTipo", card.IdTipoTarjeta);
                cmd.Parameters.AddWithValue("@borrado", card.BorradoTarjeta);
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

        private void btnTarjetaMod_Click_1(object sender, EventArgs e)
        {
            Tarjeta c = ObtenerDatosTarjeta();
            bool resultado = ModificarTarjeta(c);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (
                      " |Tipo Documento: " + c.TipoDocumentoTarjeta + " |Numero Documento: " + c.NroDocumentoTarjeta + "|" + "\n"
                    + " |Nro. de Tarjeta: " + c.NroTarjetaCliente + " |Marca: " + c.IdMarcaTarjeta + "|" + "\n"
                    + " |Tipo: " + c.IdTipoTarjeta + "\n");

                string titulo = "Información de Carga";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Tarjeta agregada con éxito!");
                    Clean();
                    CargarTablaTarjetas();
                    CargarTiposDocumentos();


                }
                else
                {
                    cmbTipoDoc.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar la persona!");
            }
        }

        private void tablaTarjetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaTarjetas.Rows[indice];
                string nroTarjeta = filaSeleccionada.Cells["NroTarjeta"].Value.ToString();
                Tarjeta c = Buscar_Tarjeta(nroTarjeta);
                Clean();
                SearchPanel.Visible = false;
                btnBuscarTarjeta.Visible = false;
                cmbTipoDoc.Visible = true;
                label4.Visible = true;
                Cargar_Campos(c);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Seleccione una casilla dentro de la tabla");
            }
        }
    }
}
