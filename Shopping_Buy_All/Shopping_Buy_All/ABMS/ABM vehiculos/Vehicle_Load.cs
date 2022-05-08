using Shopping_Buy_All.Entidades;
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

namespace Shopping_Buy_All.ABMS.ABM_Vehiculos
{
    public partial class Vehicle_Load : Form
    {
        public Vehicle_Load()
        {
            InitializeComponent();
            CargarTablaVehiculos();
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
            textPatente.Text = "";
            textNameModelo.Text = "";
            CargarTablaVehiculos();

        }

        private void CargarTiposDocumentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM TipoDoc";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                comboBoxDocType.DataSource = tabla;
                comboBoxDocType.DisplayMember = "NroDoc";
                comboBoxDocType.ValueMember = "TipoDoc";
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

        private void CargarTablaVehiculos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Automovil WHERE Borrado like 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaVehiculo.DataSource = tabla;
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

        private Automovil ObtenerDatosCliente()
        {
            Automovil a = new Automovil();
            //Tipo de documento
            a.TipoDocumentoPropietario = (int)comboBoxDocType.SelectedValue;

            //Nro de documento
            a.DocumentoPropietario = textNumberDoc.Text.Trim();


            /* ---- REVISAR ----  
            //Apellido Cliente
            a. = textSurnameClient.Text.Trim();

            //Nombre de Cliente
            a.NombreCliente = textNameClient.Text.Trim();

            //Calle de Cliente
            a.CalleCliente = textStreetClient.Text.Trim();

            //Numero de calle de Cliente
            a.NroCalleCliente = int.Parse(textStreetHeight.Text.Trim());

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
                    a.EstadoCivilCliente = 1;
                }
                else if (radioButtonMarried.Checked)
                {
                    a.EstadoCivilCliente = 2;
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
                    a.SexoCliente = 1;
                }
                else if (radioButtonFemale.Checked)
                {
                    a.SexoCliente = 2;
                }
                else if (radioButtonOther.Checked)
                {
                    a.SexoCliente = 3;
                }
                else
                {
                    MessageBox.Show("Error al elegir Sexo de Cliente! \n" +
                        "Complete los campos por favor!");
                    radioButtonMale.Focus();
                }
            }
            //Fecha de nacimiento de Cliente
            a.FechaNacimientoCliente = DateTime.Parse(textDateBirthDay.Text);

            */

            return a;
        }
    }
}
