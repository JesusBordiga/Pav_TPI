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
            btnSearch.Visible = true;
            btnDeleteClient.Visible = false;
            CargarTiposDocumentos();
            CargarTablaClientes();
            comboBoxDocType.Enabled = true;
            textNumberDoc.Enabled = true;
            labelClienteaEliminar.Text = "Buscar Cliente";

        }
        private void CargarTablaClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getClienteNoBorrado";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaClientes.DataSource = tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
            finally
            {
                cn.Close();
            }
        }
        private void CargarTiposDocumentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getTipoDocumentoNoBorrado";

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
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
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
        private bool Buscar_Cliente1(int TipoDocumento, string NroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente client = new Cliente();
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarClienteNoBorrado @tipoDocumento, @nroDocumento";

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
                    cn.Close();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    tablaClientes.DataSource = tabla;
                    resultado = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
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
              CargarTablaClientes();
              btnDeleteClient.Visible = false;
              btnSearch.Visible = true;
              comboBoxDocType.Enabled = true;
              textNumberDoc.Enabled = true;
              labelClienteaEliminar.Text = "Buscar Cliente";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (validarCliente())
            {
                bool existe = Buscar_Cliente1((int)comboBoxDocType.SelectedValue, textNumberDoc.Text.Trim());
                if (existe)
                {
                    labelClienteaEliminar.Text = "Cliente a Eliminar";
                    tablaClientes.Visible = true;
                    btnDeleteClient.Visible = true;
                    btnSearch.Visible = false;
                    comboBoxDocType.Enabled = false;
                    textNumberDoc.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El usuario que busca no existe o fue borrado!");
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
                string consulta = "borrarCliente @tipoDocumento, @nroDocumento, @borrado";
                    //"UPDATE Clientes SET Borrado = @borrado WHERE TipoDocumento Like @tipoDocumento AND NroDocumento Like @nroDocumento AND Borrado like 0";
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
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            Cliente c = Buscar_Cliente_Documento((comboBoxDocType.SelectedIndex + 1).ToString(), textNumberDoc.Text);
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
                bool resultado = BorrarCliente(comboBoxDocType.SelectedIndex + 1, textNumberDoc.Text.Trim(), 1);
                if (resultado)
                {
                    MessageBox.Show("Cliente Borrado con éxito!");
                    Clean();
                    //BorrarCliente(c);
                    CargarTiposDocumentos();
                    btnDeleteClient.Visible = false;
                    btnSearch.Visible = true;
                    CargarTablaClientes();
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
        private void Cargar_Campos(Cliente c)
        {
            //Cargar Tipo Documento
            comboBoxDocType.SelectedValue = c.TipoDocumentoCliente;
            //Cargar Documento
            textNumberDoc.Text = c.DocumentoCliente;
        }
        private bool validarCliente()
        { 
            bool resultado = false;
            if (comboBoxDocType.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Error, Cargar tipo de documento!");
                comboBoxDocType.Focus();
            }
            else if (textNumberDoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar numero de documento!");
                textNumberDoc.Focus();
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }
        private Cliente Buscar_Cliente_Documento(string TipoDocumento, string NroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente client = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarClienteNoBorrado @tipoDocumento, @nroDocumento";

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
                    client.TipoDocumentoCliente = int.Parse(DataReader["TipoDoc"].ToString());
                    client.DocumentoCliente = DataReader["NroDocumento"].ToString();
                    client.ApellidoCliente = DataReader["Apellido"].ToString();
                    client.NombreCliente = DataReader["Nombres"].ToString();
                    client.CalleCliente = DataReader["Calle"].ToString();
                    client.NroCalleCliente = int.Parse(DataReader["NroCalle"].ToString());
                    client.EstadoCivilCliente = int.Parse(DataReader["EstadoCiv"].ToString());
                    client.SexoCliente = int.Parse(DataReader["Sex"].ToString());
                    client.FechaNacimientoCliente = DateTime.Parse(DataReader["FechaNacimiento"].ToString());
                }
                cn.Close();
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                tablaClientes.DataSource = tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
            finally
            {
                cn.Close();
            }
            return client;

        }

        private void tablaClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaClientes.Rows[indice];
                string documento = filaSeleccionada.Cells["NroDocumento"].Value.ToString();
                string tipodocumento = filaSeleccionada.Cells["TipoDoc"].Value.ToString();
                Cliente c = Buscar_Cliente_Documento(tipodocumento, documento);
                Clean();
                Cargar_Campos(c);
                btnDeleteClient.Visible = true;
                comboBoxDocType.Enabled = false;
                textNumberDoc.Enabled = false;
                labelClienteaEliminar.Text = "Cliente a Eliminar";
            }
            catch
            {
                MessageBox.Show("Error! \n Seleccione una casilla dentro de la tabla!");
            }
        }
    }
}

