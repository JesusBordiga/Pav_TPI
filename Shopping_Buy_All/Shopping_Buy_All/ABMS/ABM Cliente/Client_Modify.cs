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
using Shopping_Buy_All.ABMS.AccesoADatos;
using Shopping_Buy_All.Entidades;

namespace Shopping_Buy_All
{
    public partial class Client_Modify : Form
    {
        public Client_Modify()
        {
            InitializeComponent();
            CargarTablaClientes();
            CargarTipoDocumento();
            CargarTipoSexo();
            CargarTipoEstadoCivil();
            searchPanel.Visible = false;
        }

        //ACCESO A BASE DE DATOS
        private void CargarTablaClientes()
        {
            try
            {
                tablaClientes.DataSource = AD_Cliente.ObtenerDatosClientes();
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Otener Datos del Cliente");
            }
        }
        private void CargarTipoDocumento()
        {
            try
            {
                comboBoxDocType.DataSource = AD_Cliente.ObtenerTipoDocumento();
                comboBoxDocType.DisplayMember = "NombreDocumento";
                comboBoxDocType.ValueMember = "TipoDocumento";
                comboBoxDocType.SelectedIndex = -1;
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Otener Datos de Tipos de Documentos");
            }
        }
        private void CargarTipoSexo()
        {
            try
            {
                comboBoxSex.DataSource = AD_Cliente.ObtenerTipoSexo();
                comboBoxSex.DisplayMember = "NombreSexo";
                comboBoxSex.ValueMember = "TipoSexo";
                comboBoxSex.SelectedIndex = -1;
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Otener Datos de Tipo de Sexo");
            }
        }
        private void CargarTipoEstadoCivil()
        {
            try
            {
                comboBoxEstadoCivil.DataSource = AD_Cliente.CargarTipoEstadoCivil();
                comboBoxEstadoCivil.DisplayMember = "NombreEstadoCivil";
                comboBoxEstadoCivil.ValueMember = "TipoEstadoCivil";
                comboBoxEstadoCivil.SelectedIndex = -1;
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Otener Datos de Tipo de Estado Civil");
            }


        }
        private Cliente Buscar_Cliente_Documento(string TipoDocumento ,string NroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente client= new Cliente();
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
                if (DataReader !=null && DataReader.Read())
                {
                    client.TipoDocumentoCliente = int.Parse(DataReader["TipoDoc"].ToString());
                    client.DocumentoCliente= DataReader["NroDocumento"].ToString();
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
                MessageBox.Show("Error al buscar al cliente");
            }
            finally
            {
                cn.Close();
            }
            return client;

        }

        //BOTONES
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
            searchPanel.Visible = false;
            labelBuscarCliente.Text = "Buscar Cliente";
            CargarTablaClientes();
            comboBoxDocType.Enabled = true;
            textNumberDoc.Enabled = true;
        }
        private void btnBuscarCliente_click(object sender, EventArgs e)
        {
            if (comboBoxDocType.SelectedIndex != 0 && textNumberDoc.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                labelBuscarCliente.Text = "Modificar Cliente";
                Cliente c = Buscar_Cliente_Documento(comboBoxDocType.SelectedValue.ToString(), textNumberDoc.Text);
                Cargar_Campos(c);
                searchPanel.Visible = true;
                comboBoxDocType.Enabled = false;
                textNumberDoc.Enabled = false;
            }
        }
        private void btnSearchClient2_Click(object sender, EventArgs e)
        {
            Clean();
            searchPanel.Visible = true;
            comboBoxDocType.Enabled = true;
            textNumberDoc.Enabled = true;

        }
        private void btnClientLoad_Click_1(object sender, EventArgs e)
        {
            if (validarCliente())
            {
                Cliente c = ObtenerDatosCliente();
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
                    bool resultado = AD_Cliente.ModificarCliente(c);
                    if (resultado)
                    {
                        MessageBox.Show("Cliente agregado con éxito!");
                        Clean();
                        CargarTablaClientes();
                        CargarTipoDocumento();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la persona!");
                    }

                }
                else
                {
                    comboBoxDocType.Focus();
                }

            }
        }

        //FUNCIONES
        private void Clean()
        {
            comboBoxDocType.SelectedIndex = -1;
            textNumberDoc.Text = "";
            textSurnameClient.Text = "";
            textNameClient.Text = "";
            textStreetClient.Text = "";
            textStreetHeight.Text = "";
            comboBoxEstadoCivil.SelectedIndex = -1;
            textDateBirthDay.Text = "";
            comboBoxSex.SelectedIndex = -1;
            searchPanel.Visible = false;
        }
        private bool validarCliente()
        {
            ;
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

            else if (comboBoxEstadoCivil.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Error, Cargar estado civil de cliente!");
                comboBoxEstadoCivil.Focus();
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
            //Estado civil de cliente
            comboBoxEstadoCivil.SelectedValue = c.EstadoCivilCliente;
            //Cargar Tipo Sexo
            comboBoxSex.SelectedValue = c.SexoCliente;

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
            c.EstadoCivilCliente = (int)comboBoxEstadoCivil.SelectedValue;

            //Sexo de cliente
            c.SexoCliente = (int)comboBoxSex.SelectedValue;

            //Fecha de nacimiento de Cliente
            c.FechaNacimientoCliente = DateTime.Parse(textDateBirthDay.Text);
            return c;

        }       
        private void tablaClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelBuscarCliente.Text = "Modificar Cliente";
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaClientes.Rows[indice];
                string documento = filaSeleccionada.Cells["NroDocumento"].Value.ToString();
                string tipodocumento = filaSeleccionada.Cells["TipoDoc"].Value.ToString();
                Cliente c = Buscar_Cliente_Documento(tipodocumento, documento);
                Clean();
                searchPanel.Visible = true;
                Cargar_Campos(c);
                comboBoxDocType.Enabled = true;
                textNumberDoc.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error! seleccione una casilla dentro de la tabla");
            }
        }
    }
}
