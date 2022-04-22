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
            comboBoxDocType.Items.Add("DNI");
            comboBoxDocType.Items.Add("Pasaporte");
            comboBoxDocType.Items.Add("Libreta Universitaria");

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
        }
        private void Agegrar_Ciente(Client cliente)
        {
            DataGridViewRow fila = new DataGridViewRow();
            //Agregar Tipo de Documento a Tabla
            DataGridViewTextBoxCell cTipoDoc = new DataGridViewTextBoxCell();
            cTipoDoc.Value = cliente.tipoDocumento;
            fila.Cells.Add(cTipoDoc);

            //Agregar Tipo de Documento a Tabla
            DataGridViewTextBoxCell cNumeroDoc = new DataGridViewTextBoxCell();
            cNumeroDoc.Value = cliente.nroDocumento;
            fila.Cells.Add(cNumeroDoc);

            //Agregar Tipo de Documento a Tabla
            DataGridViewTextBoxCell cApellido = new DataGridViewTextBoxCell();
            cApellido.Value = cliente.Apellido;
            fila.Cells.Add(cApellido);

            //Agregar Tipo de Documento a Tabla
            DataGridViewTextBoxCell cNombre = new DataGridViewTextBoxCell();
            cNombre.Value = cliente.Nombre;
            fila.Cells.Add(cNombre);

            //Agregar Tipo de Documento a Tabla
            DataGridViewTextBoxCell cDomicilio = new DataGridViewTextBoxCell();
            cDomicilio.Value = cliente.Domicilio;
            fila.Cells.Add(cDomicilio);

            //Agregar Tipo de Documento a Tabla
            DataGridViewTextBoxCell cAltura = new DataGridViewTextBoxCell();
            cAltura.Value = cliente.Altura;
            fila.Cells.Add(cAltura);

            //Agregar Tipo de Documento a Tabla
            DataGridViewTextBoxCell cEstadoCivil = new DataGridViewTextBoxCell();
            cEstadoCivil.Value = cliente.EstadoCivil;
            fila.Cells.Add(cEstadoCivil);

            //Agregar Tipo de Documento a Tabla
            DataGridViewTextBoxCell cSexo = new DataGridViewTextBoxCell();
            cSexo.Value = cliente.Sexo;
            fila.Cells.Add(cSexo);

            //Agregar Tipo de Documento a Tabla
            DataGridViewTextBoxCell cFechaNacimiento = new DataGridViewTextBoxCell();
            cFechaNacimiento.Value = cliente.FechaNacimiento;
            fila.Cells.Add(cFechaNacimiento);

            tablaClientes.Rows.Add(fila);

        }
        private void btnClientLoad_Click(object sender, EventArgs e)
        {
            string tipoDocumento = comboBoxDocType.GetItemText(comboBoxDocType.SelectedItem);
            string nroDocumento = textNumberDoc.Text;
            string apellido = textSurnameClient.Text;
            string nombre = textNameClient.Text;
            string domicilio = textStreetClient.Text;
            string altura = textStreetHeight.Text;
            string sexo = "";
            string estadoCivil = "";
            string fechaNacimiento = textDateBirthDay.Text;
            bool estadoCivilOK = true;
            if (radioButtonSingle.Checked && radioButtonMarried.Checked)
                {
                    MessageBox.Show("Error, Ingrese solo una opcion en estado Civil!");
                    radioButtonSingle.Focus();
                    estadoCivilOK = false;
                }
            else
                {
                    if (radioButtonSingle.Checked)
                    {
                        estadoCivil = "Soltero";
                    }
                    if (radioButtonMarried.Checked)
                    {
                        estadoCivil = "Casado";
                    }
                }
            if (radioButtonMale.Checked)
                {
                    sexo = "Hombre";
                }
            if(radioButtonFemale.Checked)
                {
                    sexo = "Mujer";
                }
            if (radioButtonOther.Checked)
                {
                    sexo = "Otro";

                }

            if(estadoCivilOK)
                {  
                    if (tipoDocumento.Equals("") ||nroDocumento.Equals("")||apellido.Equals("") ||nombre.Equals("") ||domicilio.Equals("") ||altura.Equals("") ||
                        sexo.Equals("") ||estadoCivil.Equals("")||fechaNacimiento.Equals(""))
                    {
                        MessageBox.Show("Error \n" +
                            "Por Favor Complete todos los campos!");
                        comboBoxDocType.Focus();
                    }
                    else
                    { 
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = (
                             " |Tipo Documento: " + tipoDocumento + " |Numero Documento: " + nroDocumento +"|"+"\n"
                            + " |Apellido: " + apellido + " |Nombre: " + nombre + "|" + "\n"
                            + " |Domicilio: " + domicilio + " |Altura: " + altura + "|" + "\n"
                            + " |Sexo: " + sexo + " |Estado Civil: " + estadoCivil + "|" + "\n"
                            + " |Fecha Nacimiento: " + fechaNacimiento+"|"+"\n");
                        string titulo = "Información de Carga";

                        DialogResult resultado = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (resultado == DialogResult.OK)
                        {
                            bool estadoClienteBand = true;
                            Client cliente = new Client(tipoDocumento, nroDocumento, apellido, nombre, domicilio, altura, sexo, estadoCivil
                                                       ,fechaNacimiento, estadoClienteBand);
                            //Agegrar_Ciente(cliente);
                            tablaClientes.DataSource = cliente;
                            Clean();
                        }
                        else
                        {
                            comboBoxDocType.Focus();
                        }
                }
            }
        }
        private void CargarTablaClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * FROM Clients";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable table = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
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
        

    }   
}
