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
                string consulta = "Select * FROM TipoDocumento WHERE Borrado like 0";

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

        private Automovil ObtenerDatosVehiculos()
        {
            Automovil a = new Automovil();
            //Tipo de documento
            a.TipoDocumentoPropietario = (int)comboBoxDocType.SelectedValue;

            //Nro de documento
            a.DocumentoPropietario = textNumberDoc.Text.Trim();

            //Patente Vehiculo
            a.PatenteAutomovil = textPatente.Text.Trim();

            //Nombre de Cliente
            a.ModeloAutomovil = textNameModelo.Text.Trim();

            return a;
        }

        private void btnVehicleLoad_Click(object sender, EventArgs e)
        {
            Automovil a = ObtenerDatosVehiculos();
            bool resultado = Agregar_Vehiculo(a);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (
                      " |Tipo Documento: " + a.TipoDocumentoPropietario + " |Numero Documento: " + a.DocumentoPropietario + "|" + "\n"
                    + " |Patente del vehiculo: " + a.PatenteAutomovil + " |Modelo del vehiculo: " + a.ModeloAutomovil + "|" + "\n");
        
                string titulo = "Información de Carga";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Cliente agregado con éxito!");
                    Clean();
                    CargarTablaVehiculos();
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

        private bool Agregar_Vehiculo(Automovil a)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Automovil (TipoDoc,NroDoc,Patente,Modelo)" +
                                               "Values(@tipoDoc,@nroDoc, @patente, @modelo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDoc", a.TipoDocumentoPropietario);
                cmd.Parameters.AddWithValue("@nroDoc", a.DocumentoPropietario);
                cmd.Parameters.AddWithValue("@patente", a.PatenteAutomovil);
                cmd.Parameters.AddWithValue("@modelo", a.ModeloAutomovil);
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
