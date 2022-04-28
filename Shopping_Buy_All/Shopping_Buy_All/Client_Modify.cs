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
    public partial class Client_Modify : Form
    {
        public Client_Modify()
        {
            InitializeComponent();
            CargarTablaClientes();
            CargarTiposDocumentos();
            comboBoxDocType.Visible = false;
            label4.Visible = false;
        }

        private void btnBuscarCliente_click(object sender, EventArgs e)
        {
            Cliente c = Buscar_Cliente(textNumberDoc.Text);
            Cargar_Campos(c);
            SearchPanel.Visible=false;
            btnSearchClient.Visible=false;
            comboBoxDocType.Visible = true;
            label4.Visible = true;
        }
        private void btnSearchClient2_Click(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnSearchClient.Visible = true;
            comboBoxDocType.Visible = false;
            label4.Visible = false;

        }
        private void Clean()
        {
            comboBoxDocType.SelectedIndex = -1;
            textNumberDoc.Text = "";
            textSurnameClient.Text = "";
            textNameClient.Text = "";
            textStreetClient.Text = "";
            textStreetHeight.Text = "";
            radioButtonSingle.Checked = false;
            radioButtonMarried.Checked = false;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            radioButtonOther.Checked = false;
            textDateBirthDay.Text = "";
        }
        private void Cargar_Campos(Cliente c)
        {
            //Cargar Tipo Documento
            comboBoxDocType.SelectedValue = c.TipoDocumentoCliente;
            //Cargar Documento
            textNumberDoc.Text = c.DocumentoCliente;
            //Cargar Apellido
            textSurnameClient.Text = c.ApellidoCliente;
            //Cargar Nombre
            textNameClient.Text = c.NombreCliente;
            //Cargar Calle
            textStreetClient.Text = c.CalleCliente;
            //Cargar Nro Calle
            textStreetHeight.Text = c.NroCalleCliente.ToString();
            //Cargar Estado Civil
            if (c.EstadoCivilCliente == 1)
            {
                radioButtonSingle.Checked = true;
            }
            else if (c.EstadoCivilCliente == 2)
            {
                radioButtonMarried.Checked = true;
            }
            //Cargar Sexo
            if (c.SexoCliente == 1)
            {
                radioButtonMale.Checked = true;
            }
            else if (c.SexoCliente == 2)
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonOther.Checked = true;
            }
            //Cargar Fecha Nacimiento 
            textDateBirthDay.Text = c.FechaNacimientoCliente.Date.ToString();
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
        private void CargarTablaClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Clientes";

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
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        private Cliente Buscar_Cliente(string NroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente client= new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Clientes where NroDocumento like @Nrodocumento";
                //cmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NroDocumento", NroDocumento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader !=null && DataReader.Read())
                {
                    client.TipoDocumentoCliente = int.Parse(DataReader["TipoDocumento"].ToString());
                    client.DocumentoCliente= DataReader["NroDocumento"].ToString();
                    client.ApellidoCliente = DataReader["Apellido"].ToString();
                    client.NombreCliente = DataReader["Nombres"].ToString();
                    client.CalleCliente = DataReader["Calle"].ToString();
                    client.NroCalleCliente = int.Parse(DataReader["NroCalle"].ToString());
                    client.EstadoCivilCliente = int.Parse(DataReader["EstadoCivil"].ToString());
                    client.SexoCliente = int.Parse(DataReader["Sexo"].ToString());
                    client.FechaNacimientoCliente = DateTime.Parse(DataReader["FechaNacimiento"].ToString());
                }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaClientes.Rows[indice];
            string documento = filaSeleccionada.Cells["NroDocumento"].Value.ToString();
            Cliente c = Buscar_Cliente(documento);
            Clean();
            SearchPanel.Visible = false;
            btnSearchClient.Visible = false;
            comboBoxDocType.Visible = true;
            label4.Visible = true;
            Cargar_Campos(c);
        }


    }
}
