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
using Shopping_Buy_All.ABMS.AccesoADatos;

namespace Shopping_Buy_All
{
    public partial class Client_Load : Form
    {
        public Client_Load()
        {
            InitializeComponent();
            CargarTablaClientes();
            CargarTipoDocumento();
            CargarTipoSexo();
            CargarTipoEstadoCivil();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void CargarTablaClientes()
        {
            tablaClientes.DataSource = AD_Cliente.ObtenerDatosClientes(); ;
        }
        private void CargarTipoDocumento()
        {
            comboBoxDocType.DataSource = AD_Cliente.ObtenerTipoDocumento();
            comboBoxDocType.DisplayMember = "NombreDocumento";
            comboBoxDocType.ValueMember = "TipoDocumento";
            comboBoxDocType.SelectedIndex = -1;
        }
        private void CargarTipoSexo()
        {
            comboBoxSex.DataSource = AD_Cliente.ObtenerTipoSexo();
            comboBoxSex.DisplayMember = "NombreSexo";
            comboBoxSex.ValueMember = "TipoSexo";
            comboBoxSex.SelectedIndex = -1;
        }
        private void CargarTipoEstadoCivil()
        {
            comboBoxEstadoCivil.DataSource = AD_Cliente.CargarTipoEstadoCivil();
            comboBoxEstadoCivil.DisplayMember = "NombreEstadoCivil";
            comboBoxEstadoCivil.ValueMember = "TipoEstadoCivil";
            comboBoxEstadoCivil.SelectedIndex = -1;
            
        }


        private void Clean()
        {
            comboBoxDocType.SelectedIndex = -1;
            textNumberDoc.Text = "";
            textSurnameClient.Text = "";
            textNameClient.Text = "";
            textStreetClient.Text = "";
            textStreetHeight.Text = "";
            comboBoxEstadoCivil.SelectedIndex = -1;
            comboBoxSex.SelectedIndex = -1;
            textDateBirthDay.Text = "";
            AD_Cliente.ObtenerDatosClientes();

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
            c.EstadoCivilCliente=(int)comboBoxEstadoCivil.SelectedValue;
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
                           
                            bool resultado = AD_Cliente.Agregar_Cliente(c);
                            if (resultado)
                            {
                            MessageBox.Show("Cliente agregado con éxito!");
                            Clean();
                            AD_Cliente.ObtenerDatosClientes();
                            AD_Cliente.ObtenerTipoDocumento();
                            }
                        }
                        else
                        {
                            comboBoxDocType.Focus();
                        }

            }
        }
       
    }
}
