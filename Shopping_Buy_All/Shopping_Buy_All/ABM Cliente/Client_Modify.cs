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
        }

        private void btnBuscarCliente_click(object sender, EventArgs e)
        {
            if (comboBoxDocType.SelectedIndex != 0 && textNumberDoc.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
            Cliente c = Buscar_Cliente_Documento((int)comboBoxDocType.SelectedValue, textNumberDoc.Text);
            Cargar_Campos(c);
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
            DateTime fecha = c.FechaNacimientoCliente;
            string dia = "";string mes = ""; string año = "";
            dia = fecha.Date.Day.ToString();
            if(dia.Length ==1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();
            textDateBirthDay.Text = dia+mes+año;
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
                string consulta = "Select * FROM Clientes WHERE Borrado like 0";

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
        private Cliente Buscar_Cliente_Documento(int TipoDocumento ,string NroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente client= new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Clientes where TipoDocumento like @tipoDocumento AND NroDocumento like @nrodocumento AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocumento", NroDocumento);
                cmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);

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
        private Cliente Buscar_Cliente(string NroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente client = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Clientes WHERE NroDocumento like @Nrodocumento ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NroDocumento", NroDocumento);

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

        private Cliente ObtenerDatosCliente()
        {

            Cliente c = new Cliente();
            //Tipo de documento
            c.TipoDocumentoCliente = (int)comboBoxDocType.SelectedValue;

            //Nro de documento
            c.DocumentoCliente = textNumberDoc.Text.Trim();

            //Apellido Cliente
            c.ApellidoCliente = textSurnameClient.Text.Trim();

            //Nombre de Cliente
            c.NombreCliente = textNameClient.Text.Trim();

            //Calle de Cliente
            c.CalleCliente = textStreetClient.Text.Trim();

            //Numero de calle de Cliente
            c.NroCalleCliente = int.Parse(textStreetHeight.Text.Trim());

            //Estado civil de cliente
            if (radioButtonSingle.Checked)
            {
                c.EstadoCivilCliente = 1;
            }
            else if (radioButtonMarried.Checked)
            {
                c.EstadoCivilCliente = 2;
            }
            else
            {
                MessageBox.Show("Error al elegir estado Civil de Cliente! \n" +
                    "Complete los campos por favor!");
                radioButtonSingle.Focus();
            }

            //Sexo de cliente
            if (radioButtonMale.Checked)
            {
                c.SexoCliente = 1;
            }
            else if (radioButtonFemale.Checked)
            {
                c.SexoCliente = 2;
            }
            else if (radioButtonOther.Checked)
            {
                c.SexoCliente = 3;
            }
            else
            {
                MessageBox.Show("Error al elegir estado Civil de Cliente! \n" +
                    "Complete los campos por favor!");
                radioButtonMale.Focus();
            }

            //Fecha de nacimiento de Cliente
            c.FechaNacimientoCliente = DateTime.Parse(textDateBirthDay.Text);
            return c;

        }

        private bool ModificarCliente(Cliente client)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Clientes SET TipoDocumento=@tipoDocumento,NroDocumento = @nroDocumento,Apellido =  @apellido,Nombres =  @nombres,Calle =  @calle,NroCalle = @nroCalle,EstadoCivil = @estadoCivil,Sexo = @sexo,FechaNacimiento = @fechaNacimiento WHERE TipoDocumento Like @tipoDocumento AND NroDocumento Like @nroDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocumento", client.TipoDocumentoCliente);
                cmd.Parameters.AddWithValue("@nroDocumento", client.DocumentoCliente);
                cmd.Parameters.AddWithValue("@apellido", client.ApellidoCliente);
                cmd.Parameters.AddWithValue("@nombres", client.NombreCliente);
                cmd.Parameters.AddWithValue("@calle", client.CalleCliente);
                cmd.Parameters.AddWithValue("@nroCalle", client.NroCalleCliente);
                cmd.Parameters.AddWithValue("@estadoCivil", client.EstadoCivilCliente);
                cmd.Parameters.AddWithValue("@sexo", client.SexoCliente);
                cmd.Parameters.AddWithValue("@fechaNacimiento", client.FechaNacimientoCliente);
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

        private void btnClientLoad_Click_1(object sender, EventArgs e)
        {
            Cliente c = ObtenerDatosCliente();
            bool resultado = ModificarCliente(c);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (
                      " |Tipo Documento: " + c.TipoDocumentoCliente + " |Numero Documento: " + c.DocumentoCliente + "|" + "\n"
                    + " |Apellido: " + c.ApellidoCliente + " |Nombre: " + c.NombreCliente + "|" + "\n"
                    + " |Calle: " + c.CalleCliente + " |Nro Calle: " + c.NroCalleCliente + "|" + "\n"
                    + " |Estado Civil: " + c.EstadoCivilCliente + " |Sexo: " + c.SexoCliente + "|" + "\n"
                    + " |Fecha Nacimiento: " + c.FechaNacimientoCliente + "|" + "\n");

                string titulo = "Información de Carga";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Cliente agregado con éxito!");
                    Clean();
                    CargarTablaClientes();
                    CargarTiposDocumentos();


                }
                else
                {
                    comboBoxDocType.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar la persona!");
            }
        }
    }
}
