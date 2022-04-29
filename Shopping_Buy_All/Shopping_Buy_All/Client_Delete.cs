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
    public partial class Client_Delete : Form
    {
        public Client_Delete()
        {
            InitializeComponent();

        }
        private void Client_Delete_Load(object sender, EventArgs e)
        {
            tablaClientes.Visible = false;
            btnSearch.Visible = true;
            btnDeleteClient.Visible = false;
            CargarTiposDocumentos();
        }
        private void CargarTiposDocumentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM TipoDocumento";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                comboBoxDocType.DataSource = tabla;
                comboBoxDocType.DisplayMember = "NombreDocumento";
                comboBoxDocType.ValueMember = "TipoDocumento";
                comboBoxDocType.SelectedIndex = -1;
            }
            catch (Exception ex)
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
            comboBoxDocType.SelectedIndex = -1;
            textNumberDoc.Text = "";
        }
        private Cliente Buscar_Cliente(string NroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente client = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Clientes where  NroDocumento like @Nrodocumento";
                //TipoDocumendo like @TipoDocumento AND
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NroDocumento", NroDocumento);
                //cmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);

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
                tablaClientes.DataSource = tabla;
            }
            catch (Exception ex)
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
              tablaClientes.Visible = false;
              btnDeleteClient.Visible = false;
              btnSearch.Visible = true;
            }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textNumberDoc.Text.Equals(""))
            //if (comboBoxDocType.SelectedIndex !=0 && textNumberDoc.Text.Equals(""))
            {
                MessageBox.Show("Error, Debe completar los campos!!");
                }
            else
                {
                Cliente client = Buscar_Cliente(textNumberDoc.Text);
                // Cliente client =Buscar_Cliente(comboBoxDocType.Text,textNumberDoc.Text);
                tablaClientes.Visible = true;
                btnDeleteClient.Visible = true;
                btnSearch.Visible = false;
                }
        }
        private bool BorrarCliente(Cliente client)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Clientes SET  WHERE TipoDocumento Like @tipoDocumento AND NroDocumento Like @nroDocumento";
                cmd.Parameters.Clear();
                client.BorradoCliente = 1;
                cmd.Parameters.AddWithValue("@borrado", client.BorradoCliente);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException ex)
            {

                throw;
                resultado = false;
            }
            catch (Exception ex)
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

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = (
                  " |Tipo Documento: " + c.TipoDocumentoCliente + " |Numero Documento: " + c.DocumentoCliente + "|" + "\n"
                + " |Apellido: " + c.ApellidoCliente + " |Nombre: " + c.NombreCliente + "|" + "\n"
                + " |Calle: " + c.CalleCliente + " |Nro Calle: " + c.NroCalleCliente + "|" + "\n"
                + " |Estado Civil: " + c.EstadoCivilCliente + " |Sexo: " + c.SexoCliente + "|" + "\n"
                + " |Fecha Nacimiento: " + c.FechaNacimientoCliente + "|" + "\n" + "\n" + " |Desea eliminar a este cliente??");

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Cliente Borrado con éxito!");
                Clean();
                //BorrarCliente(c);
                CargarTiposDocumentos();
                tablaClientes.Visible = false;
                btnDeleteClient.Visible = false;
                btnSearch.Visible = true;
            }
            else
            {
                comboBoxDocType.Focus();
            }
        }
    }
}

