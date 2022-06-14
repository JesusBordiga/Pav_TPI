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
    public partial class Tarjeta_Delete : Form
    {
        public Tarjeta_Delete()
        {
            InitializeComponent();
            CargarTablaTarjetas();
            CargarTiposDocumentos();
            CargarTipoTarjetas();
            CargarMarcaTarjetas();
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
            catch (Exception)
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

                cmbTipo.DataSource = tabla;
                cmbTipo.DisplayMember = "Nombre";
                cmbTipo.ValueMember = "idTipo";
                cmbTipo.SelectedIndex = -1;
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

                cmbMarca.DataSource = tabla;
                cmbMarca.DisplayMember = "Nombre";
                cmbMarca.ValueMember = "idMarca";
                cmbMarca.SelectedIndex = -1;
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
                string consulta = "Select * FROM TarjetaXCliente WHERE Borrado = 0";

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

        private void Clean()
        {
            cmbTipoDoc.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            textNroDoc.Text = "";
            textNroTarjeta.Text = "";
            cmbTipoDoc.Enabled = true;
            textNroDoc.Enabled = true;
            textNroTarjeta.Enabled = true;
            btnDelete.Visible = false;
            btnSearch.Visible = true;
            labelMarca.Visible = false;
            labelTipo.Visible = false;
            cmbMarca.Visible = false;
            cmbTipo.Visible = false;
            cmbTipoDoc.Focus();
        }

        private void Cargar_Campos(Tarjeta t)
        {
            cmbTipoDoc.SelectedValue = t.TipoDocumentoTarjeta;
            textNroDoc.Text = t.NroDocumentoTarjeta;
            textNroTarjeta.Text = t.NroTarjetaCliente;
            cmbTipoDoc.Enabled = false;
            textNroDoc.Enabled = false;
            textNroTarjeta.Enabled = false;
            cmbMarca.Visible = true;
            cmbTipo.Visible = true;
            cmbMarca.SelectedValue = t.IdMarcaTarjeta;
            cmbTipo.SelectedValue = t.IdTipoTarjeta;
            labelMarca.Visible = true;
            labelTipo.Visible = true;
            btnDelete.Visible = true;
            btnSearch.Visible = false;
            cmbMarca.Focus();
        }

        private bool ExisteTarjeta(Tarjeta t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TarjetaXCliente WHERE TipoDocumento = @tipoDoc AND NroDocumento = @nroDoc AND NroTarjeta = @nroTarjeta AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDoc", t.TipoDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroDoc", t.NroDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroTarjeta", t.NroTarjetaCliente);
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

        private Tarjeta ObtenerDatosBuscar()
        {
            Tarjeta t = new Tarjeta();
            if (cmbTipoDoc.SelectedIndex == -1)
            {
                t.TipoDocumentoTarjeta = 0;
            }
            else
            {
                t.TipoDocumentoTarjeta = (int)cmbTipoDoc.SelectedValue;
            }
            t.NroDocumentoTarjeta = textNroDoc.Text.Trim();
            t.NroTarjetaCliente = textNroTarjeta.Text.Trim();
            return t;
        }

        private Tarjeta ObtenerDatos()
        {
            Tarjeta t = new Tarjeta();
            t.TipoDocumentoTarjeta = (int)cmbTipoDoc.SelectedValue;
            t.NroDocumentoTarjeta = textNroDoc.Text.Trim();
            t.NroTarjetaCliente = textNroTarjeta.Text.Trim();
            t.IdMarcaTarjeta = (int)cmbMarca.SelectedValue;
            t.IdTipoTarjeta = (int)cmbTipo.SelectedValue;
            return t;
        }

        private bool EliminarTarjeta(Tarjeta t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE TarjetaXCliente SET Borrado = 1 WHERE TipoDocumento = @tipoDocumento AND NroDocumento = @nroDocumento AND NroTarjeta = @nroTarjeta AND Borrado LIKE 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocumento", t.TipoDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroDocumento", t.NroDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroTarjeta", t.NroTarjetaCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo borrar la Tarjeta.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Tarjeta t = ObtenerDatosBuscar();
            bool existe = ExisteTarjeta(t);
            if (existe)
            {
                t = Buscar_Tarjeta(t);
                Cargar_Campos(t);
            }
            else
            {
                Clean();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private Tarjeta Buscar_Tarjeta(Tarjeta t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TarjetaXCliente WHERE TipoDocumento = @tipoDoc AND NroDocumento = @nroDoc AND NroTarjeta = @nroTarjeta AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDoc", t.TipoDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroDoc", t.NroDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroTarjeta", t.NroTarjetaCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    t.IdMarcaTarjeta = int.Parse(DataReader["IdMarca"].ToString());
                    t.IdTipoTarjeta = int.Parse(DataReader["IdTipo"].ToString());
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
            return t;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Tarjeta t = ObtenerDatos();
                bool resultado = EliminarTarjeta(t);
                if (resultado)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    String mensajeCarga = (
                    " |Tipo Documento: " + t.TipoDocumentoTarjeta + " |Numero Documento: " + t.NroDocumentoTarjeta + "|" + "\n"
                + " |Nro. de Tarjeta: " + t.NroTarjetaCliente + " |Marca: " + t.IdMarcaTarjeta + "|" + "\n"
                + " |Tipo: " + t.IdTipoTarjeta + "\n");

                    string titulo = "Información de Tarjeta";

                    DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Tarjeta borrada con éxito!");
                        Clean();
                        CargarTablaTarjetas();
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar la Tarjeta! \n" +
                            "Complete los campos por favor!");
                }
            }
            else
            {
                MessageBox.Show("Error al cargar la Tarjeta! \n" +
                            "Complete los campos por favor!");
            }
        }

        private bool ValidarCampos()
        {
            if (cmbMarca.SelectedIndex == -1 || cmbTipo.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void tablaTarjetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaTarjetas.Rows[indice];
                string tipoDoc = filaSeleccionada.Cells["TipoDocumento"].Value.ToString();
                string nroDoc = filaSeleccionada.Cells["NroDocumento"].Value.ToString();
                string nroTarjeta = filaSeleccionada.Cells["NroTarjeta"].Value.ToString();
                Tarjeta t = new Tarjeta();
                t.TipoDocumentoTarjeta = int.Parse(tipoDoc);
                t.NroDocumentoTarjeta = nroDoc;
                t.NroTarjetaCliente = nroTarjeta;
                t = Buscar_Tarjeta(t);
                Cargar_Campos(t);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una casilla dentro de la tabla", "ERROR");
            }
        }
    }
}
