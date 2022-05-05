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
using Shopping_Buy_All.ABMS.AccesoADatos;

namespace Shopping_Buy_All
{
    public partial class TipoComercio_Delete : Form
    {
        public TipoComercio_Delete()
        {
            InitializeComponent();

        }
        private void Client_Delete_Load(object sender, EventArgs e)
        {
            tablaTipoComercio.Visible = false;
            btnSearch.Visible = true;
            btnDeleteTipoComercio.Visible = false;
        }
        
        private void Clean()
        {
            txtNombreTipoComercio.Text = "";
        }
        private Cliente Cargar_Cliente(int TipoDocumento, string NroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente client = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Clientes where TipoDocumento like @tipoDocumento AND NroDocumento like @nrodocumento AND Borrado Like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocumento", NroDocumento);
                cmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    client.TipoDocumentoCliente = int.Parse(DataReader["TipoDocumento"].ToString());
                    client.DocumentoCliente = DataReader["NroDocumento"].ToString();
                    client.ApellidoCliente = DataReader["Apellido"].ToString();
                    client.NombreCliente = DataReader["Nombres"].ToString();
                    client.CalleCliente = DataReader["Calle"].ToString();
                    client.NroCalleCliente = int.Parse(DataReader["NroCalle"].ToString());
                    client.EstadoCivilCliente = int.Parse(DataReader["EstadoCivil"].ToString());
                    client.SexoCliente = int.Parse(DataReader["Sexo"].ToString());
                    client.FechaNacimientoCliente = DateTime.Parse(DataReader["FechaNacimiento"].ToString());
                    
                }
                cn.Close();

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                tablaTipoComercio.DataSource = tabla;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return client;

        }
        
        private void btnClean_Click(object sender, EventArgs e)
            {    
              Clean();
              tablaTipoComercio.Visible = false;
              btnDeleteTipoComercio.Visible = false;
              btnSearch.Visible = true;
            }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtNombreTipoComercio.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Debe completar los campos!!");
            }
            else
            {
                try
                {
                    bool existe = AD_TipoComercio.Buscar_TipoComercio(txtNombreTipoComercio.Text.Trim());
                    if (existe)
                    {
                        tablaTipoComercio.Visible = true;
                        btnDeleteTipoComercio.Visible = true;
                        btnSearch.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("El Tipo Comercio que busca no existe o fue borrado!");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }
        private bool BorrarCliente(int TipoDocumento, string NroDocumento,int Borrado)
        {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Clientes SET Borrado = @borrado WHERE TipoDocumento Like @tipoDocumento AND NroDocumento Like @nroDocumento AND Borrado like 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocumento", NroDocumento);
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
            Cliente c = Cargar_Cliente((int)comboBoxDocType.SelectedValue, textNumberDoc.Text.Trim());
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = (
                  " |Tipo Documento: " + c.TipoDocumentoCliente + " |Numero Documento: " + c.DocumentoCliente + "|" + "\n"
                + " |Apellido: " + c.ApellidoCliente + " |Nombre: " + c.NombreCliente + "|" + "\n"
                + " |Calle: " + c.CalleCliente + " |Nro Calle: " + c.NroCalleCliente + "|" + "\n"
                + " |Estado Civil: " + c.EstadoCivilCliente + " |Sexo: " + c.SexoCliente + "|" + "\n"
                + " |Fecha Nacimiento: " + c.FechaNacimientoCliente.ToShortDateString() + "|" + "\n" + "\n" + " |Desea eliminar a este cliente??");

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                bool resultado = BorrarCliente((int)comboBoxDocType.SelectedValue, textNumberDoc.Text.Trim(), 1);
                if (resultado)
                {
                    MessageBox.Show("Cliente Borrado con éxito!");
                    Clean();
                    //BorrarCliente(c);
                    CargarTiposDocumentos();
                    tablaTipoComercio.Visible = false;
                    btnDeleteTipoComercio.Visible = false;
                    btnSearch.Visible = true;
                    comboBoxDocType.Focus();
                }
                else
                {
                    MessageBox.Show("Cliente No fue Borrado!");
                }
            }
            else
            {
                comboBoxDocType.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Grilla_Clientes tabla = new Grilla_Clientes();
            tabla.Show();

        }
    }
}

