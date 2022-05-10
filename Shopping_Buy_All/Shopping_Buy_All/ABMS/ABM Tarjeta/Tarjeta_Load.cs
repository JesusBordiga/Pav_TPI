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
using System.Runtime;

namespace Shopping_Buy_All
{
    public partial class Tarjeta_Load : Form
    {
        public Tarjeta_Load()
        {
            InitializeComponent();
            CargarTablaTarjetas();
            CargarTiposDocumentos();
            CargarMarcaTarjetas();
            CargarTipoTarjetas();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            cmbTipoDoc.SelectedIndex = -1;
            textNroDoc.Text = "";
            textNroTarjeta.Text = "";
            cmbMarca.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            CargarTablaTarjetas();

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
        private Tarjeta ObtenerDatosTarjeta()
        {
            Tarjeta c = new Tarjeta();

            c.TipoDocumentoTarjeta = (int)cmbTipoDoc.SelectedValue;

            c.NroDocumentoTarjeta = textNroDoc.Text.Trim();

            c.NroTarjetaCliente = textNroTarjeta.Text.Trim();

            c.IdMarcaTarjeta = (int)cmbMarca.SelectedValue;

            c.IdTipoTarjeta = (int)cmbTipo.SelectedValue;
            return c;
        }

        private bool Agregar_Tarjeta(Tarjeta card)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO TarjetaXCliente" +
                                  "Values(@tipoDocumento,@nroDocumento, @nroTarjeta, @IdMarca, @IdTipo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocumento", card.TipoDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroDocumento", card.NroDocumentoTarjeta);
                cmd.Parameters.AddWithValue("@nroTarjeta", card.NroTarjetaCliente);
                cmd.Parameters.AddWithValue("@IdMarca", card.IdMarcaTarjeta);
                cmd.Parameters.AddWithValue("@IdTipo", card.IdTipoTarjeta);
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

        private void btnTarjetaLoad_Click(object sender, EventArgs e)
        {
            Tarjeta c = ObtenerDatosTarjeta();
            bool resultado = Agregar_Tarjeta(c);
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
                    MessageBox.Show("Tarjeta agregado con éxito!");
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
                MessageBox.Show("Error al cargar la Tarjeta! \n" +
                        "Complete los campos por favor!");
            }
        }

    }
}
