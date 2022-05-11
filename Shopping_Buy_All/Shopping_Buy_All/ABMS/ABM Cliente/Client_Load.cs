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
    public partial class Client_Load : Form
    {
        public Client_Load()
        {
            InitializeComponent();
            CargarTablaClientes();
            CargarTiposDocumentos();
            CargarTipoSexo();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
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
            comboBoxSex.SelectedIndex = -1;
            textDateBirthDay.Text = "";
            CargarTablaClientes();

        }
        private void CargarTipoSexo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM TipoSexo";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                comboBoxSex.DataSource = tabla;
                comboBoxSex.DisplayMember = "NombreSexo";
                comboBoxSex.ValueMember = "TipoSexo";
                comboBoxSex.SelectedIndex = -1;
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
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
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
                string consulta = "SELECT TD.NombreDocumento AS TipoDocumento,C.NroDocumento,C.Apellido,C.Nombres,C.Calle,C.NroCalle,TEC.NombreEstadoCivil AS EstadoCivil" +
                    ",TS.NombreSexo AS Sexo,C.FechaNacimiento,C.Borrado FROM Clientes C JOIN TipoDocumento TD ON (C.TipoDocumento = TD.TipoDocumento) " +
                    "JOIN TipoEstadoCivil TEC ON (C.EstadoCivil = TEC.TipoEstadoCivil) JOIN TipoSexo TS ON (C.Sexo = TS.TipoSexo) WHERE C.Borrado = 0";

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
        private bool validarCliente()
        {;
            if (comboBoxDocType.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Error, Cargar tipo de documento!");
                comboBoxDocType.Focus();
                return false;
            }
            else if (textNumberDoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar numero de documento!");
                textNumberDoc.Focus();
                return false;
            }
            else if (textSurnameClient.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar apellido de cliente!");
                textSurnameClient.Focus();
                return false;
            }
            else if (textNameClient.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar nombre de cliente!");
                textNameClient.Focus();
                return false;
            }
            else if (textStreetClient.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar domicilio de cliente!");
                textStreetClient.Focus();
                return false;
            }
            else if (textStreetHeight.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar numero de calle de cliente!");
                textStreetHeight.Focus();
                return false;
            }
            
            else if (radioButtonSingle.Checked == false && radioButtonMarried.Checked == false)
            {
                MessageBox.Show("Error, Cargar estado civil de cliente!");
                textDateBirthDay.Focus();
                return false;
            }
            else if (comboBoxSex.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Error, Cargar tipo de sexo!");
                comboBoxSex.Focus();
                return false;
            }
            else if (textDateBirthDay.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar fecha de nacimiento de cliente!");
                textDateBirthDay.Focus();
                return false;
            }
            else
            {
                return true;
            }
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
            if (radioButtonSingle.Checked && radioButtonMarried.Checked)
            {
                MessageBox.Show("Error al elegir estado Civil de Cliente! \n" +
                        "Seleccione solo una opción!");
            }
            else
            {
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
            }
            //Tipo de sexo
            c.SexoCliente = (int)comboBoxSex.SelectedValue;

            //Fecha de nacimiento de Cliente
            c.FechaNacimientoCliente = DateTime.Parse(textDateBirthDay.Text);

            return c;
        }
        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            bool valido =validarCliente();
            if (valido)
            {
                Cliente c = ObtenerDatosCliente();
                bool resultado = Agregar_Cliente(c);
                if (resultado)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = (
                              " |Tipo Documento: " + c.TipoDocumentoCliente + " |Numero Documento: " + c.DocumentoCliente + "|" + "\n"
                            + " |Apellido: " + c.ApellidoCliente + " |Nombre: " + c.NombreCliente + "|" + "\n"
                            + " |Calle: " + c.CalleCliente + " |Nro Calle: " + c.NroCalleCliente + "|" + "\n"
                            + " |Estado Civil: " + c.EstadoCivilCliente + " |Sexo: " + c.SexoCliente + "|" + "\n"
                            + " |Fecha Nacimiento: " + c.FechaNacimientoCliente.ToShortDateString() + "|" + "\n");

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
            }
        }
        private bool Agregar_Cliente(Cliente client)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Clientes(TipoDocumento,NroDocumento,Apellido,Nombres,Calle,NroCalle,EstadoCivil,Sexo,FechaNacimiento)" +
                                               "Values(@tipoDocumento,@nroDocumento, @apellido, @nombres, @calle, @nroCalle, @estadoCivil,@sexo, @fechaNacimiento)";
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
    }
}
