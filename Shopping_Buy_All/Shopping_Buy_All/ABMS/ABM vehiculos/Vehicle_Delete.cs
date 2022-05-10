using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Shopping_Buy_All.Entidades;

using System.Windows.Forms;

namespace Shopping_Buy_All.ABMS.ABM_Vehiculos
{
    public partial class Vehicle_Delete : Form
    {
        public Vehicle_Delete()
        {
            InitializeComponent();
        }

        private void VehicleDelete_Load(object sender, EventArgs e)
        {
            CargarTablaVehiculo();
        }

        private void Clean()
        {
            textNamePatente.Text = "";
            textNroDoc.Text = "";
            textNameModelo.Text = "";
            comboBoxDocType.SelectedValue = "";
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

        private void Cargar_Campos(Automovil a)
        {
            //Cargar NroDoc
            textNroDoc.Text = a.DocumentoPropietario.ToString();
            //Cargar Patente
            textNamePatente.Text = a.PatenteAutomovil;
            //Tipo de documento
            comboBoxDocType.SelectedValue = a.TipoDocumentoPropietario;
            //Modelo Vehiculo
            textNameModelo.Text = a.ModeloAutomovil;

        }

        private void CargarTablaVehiculo()
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
                tablaVehiculos.DataSource = tabla;
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

        private Automovil Buscar_Vehiculos(string Code)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Automovil aut = new Automovil();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Automovil WHERE Patente like @patente AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", Code);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    aut.DocumentoPropietario = DataReader["NroDoc"].ToString();
                    aut.PatenteAutomovil = DataReader["Patente"].ToString();
                    aut.TipoDocumentoPropietario = int.Parse(DataReader["TipoDoc"].ToString());
                    aut.ModeloAutomovil = DataReader["Modelo"].ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return aut;
        }

        private Automovil ObtenerDatosVehiculo()
        {
            Automovil a = new Automovil();
            //Cargar NroDoc
            a.DocumentoPropietario = textNroDoc.Text.Trim();
            //Cargar Patente
            a.PatenteAutomovil = textNamePatente.Text.Trim();
            //Cargar tipoDoc
            a.TipoDocumentoPropietario = (int)comboBoxDocType.SelectedValue;
            //Modelo Vehiculo
            a.ModeloAutomovil = textNameModelo.Text.Trim();
            return a;
        }

        private bool BorrarVehiculo(int Codigo, int Borrado)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE TipoAuto SET Borrado = @borrado WHERE NroDoc Like @nrodoc AND Borrado like 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nrodoc", Codigo);
                cmd.Parameters.AddWithValue("@patente", Borrado);
                cmd.Parameters.AddWithValue("@modelo", Borrado);
                cmd.Parameters.AddWithValue("@tipodocpropietario", Borrado);
                cmd.CommandType = CommandType.Text;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Automovil a = ObtenerDatosVehiculo();
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = (
                " |NroDoc: " + a.DocumentoPropietario + "|" + "\n"
                    + " |Patente: " + a.PatenteAutomovil + "|" + "\n"
                    + " |Modelo: " + a.ModeloAutomovil + "|" + "\n"
                    + " |TipoDoc: " + a.TipoDocumentoPropietario + "|" + "\n");


            string titulo = "Información del vehiculo";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Borrado agregado con éxito!");
                //BorrarVehiculo(a.DocumentoPropietario, 1);
                Clean();
                SearchPanel.Visible = true;
                btnSearchvehicle.Visible = true;
                btnSerach2.Visible = false;
                CargarTablaVehiculo();
            }
            else
            {
                textNamePatente.Focus();
            }
        }

        private void btnSearchVehicle_Click_1(object sender, EventArgs e)
        {
            if (textNroDoc.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                Automovil a = Buscar_Vehiculos(textNroDoc.Text);
                Cargar_Campos(a);
                SearchPanel.Visible = false;
                btnSearchvehicle.Visible = false;
                btnSerach2.Visible = true;
            }
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnSerach2.Visible = true;
        }

        private void btnSerach2_Click(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnSearchvehicle.Visible = true;
            btnSerach2.Visible = false;
        }

        private void tablaVehiculos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Clean();
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaVehiculos.Rows[indice];
            string NroDoc = filaSeleccionada.Cells["NroDoc"].Value.ToString();
            Automovil a = Buscar_Vehiculos(NroDoc);
            Cargar_Campos(a);
            SearchPanel.Visible = false;
            btnSearchvehicle.Visible = false;
            btnSerach2.Visible = true;

        }

    }
}
