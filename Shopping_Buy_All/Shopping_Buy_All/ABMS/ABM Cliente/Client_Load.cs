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
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            radioButtonOther.Checked = false;
            textDateBirthDay.Text = "";
            CargarTablaClientes();

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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
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


            //Sexo de cliente
            if (radioButtonMale.Checked && radioButtonFemale.Checked && radioButtonOther.Checked
                || radioButtonMale.Checked && radioButtonFemale.Checked
                || radioButtonFemale.Checked && radioButtonOther.Checked
                || radioButtonMale.Checked && radioButtonOther.Checked)
            {
                MessageBox.Show("Error al elegir Sexo de Cliente! \n" +
                        "Seleccione solo 1 sexo por favor!");
            }
            else
            { 
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
                    MessageBox.Show("Error al elegir Sexo de Cliente! \n" +
                        "Complete los campos por favor!");
                    radioButtonMale.Focus();
                }
            }
            //Fecha de nacimiento de Cliente
            c.FechaNacimientoCliente = DateTime.Parse(textDateBirthDay.Text);


            return c;
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("Error al cargar el Cliente! \n" +
                        "Complete los campos por favor!");
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
    }
}
