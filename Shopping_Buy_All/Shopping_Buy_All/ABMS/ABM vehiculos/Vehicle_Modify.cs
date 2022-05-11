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
    public partial class Vehicle_Modify : Form
    {
        public Vehicle_Modify()
        {
            InitializeComponent();
            CargarTablaVehiculo();
        }

        private void Clean()
        {
            textNamePatente.Text = "";
            textNroDoc.Text = "";
            textNameModelo.Text = "";
            comboBoxDocType.SelectedValue = "";

        }

        private void Cargar_Campos(Automovil a)
        {
            //Cargar NroDoc
            textNroDoc.Text = a.DocumentoPropietario.ToString();
            //Cargar Nombre
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
                searchPanel.DataSource = tabla;
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

        private Automovil Buscar_Automovil(string Code)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Automovil automovil = null;
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
                if (DataReader != null && DataReader.HasRows && DataReader.Read())
                {
                    automovil = new Automovil();
                    automovil.DocumentoPropietario = DataReader["NroDoc"].ToString();
                    automovil.PatenteAutomovil = DataReader["Patente"].ToString();
                    automovil.TipoDocumentoPropietario = int.Parse(DataReader["TipoDoc"].ToString());
                    automovil.ModeloAutomovil = DataReader["Modelo"].ToString();
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
            return automovil;
        }

        private Automovil ObtenerDatosVehiculo()
        {
            Automovil a = new Automovil();
            //Cargar NroDoc
            a.DocumentoPropietario = textNroDoc.Text.Trim();
            //Cargar tipoDoc
            a.TipoDocumentoPropietario = (int)comboBoxDocType.SelectedValue;
            //Patente Vehiculo
            a.PatenteAutomovil = textNamePatente.Text.Trim();
            //Modelo Vehiculo
            a.ModeloAutomovil = textNameModelo.Text.Trim();
            return a;
        }

        private bool ModificarVehiculo(Automovil aut)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Automovil SET Patente = @patente WHERE NroDoc Like @nrodocpropietario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nrodocpropietario", aut.DocumentoPropietario);
                cmd.Parameters.AddWithValue("@patente", aut.PatenteAutomovil);
                cmd.Parameters.AddWithValue("@modelo", aut.ModeloAutomovil);
                cmd.Parameters.AddWithValue("@tipodocpropietario", aut.TipoDocumentoPropietario);
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

        private void btnSearchType_Click(object sender, EventArgs e)
        {
            if (textNamePatente.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                Automovil a = Buscar_Automovil(textNamePatente.Text);
                if (a != null)
                {
                    Cargar_Campos(a);
                    searchPanel.Visible = false;
                    btnSearchType.Visible = false;
                    btnCancel.Visible = true;
                    textNamePatente.Enabled = false;
                    btnCleanType.Visible = false;
                }
                else
                {
                    MessageBox.Show($"No se encontro registrado el vehiculo con esa patente {textNroDoc.Text}");
                }
            }
        }

        private void btnCleanType_Click(object sender, EventArgs e)
        {
            Clean();
            searchPanel.Visible = true;
            btnSearchType.Visible = true;
            textNamePatente.Enabled = true;
        }

        private void btnModifyVehicle_Click(object sender, EventArgs e)
        {
            Automovil a = ObtenerDatosVehiculo();
            bool resultado = ModificarVehiculo(a);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (
                    " |NroDoc: " + a.DocumentoPropietario + "|" + "\n"
                    + " |Patente: " + a.PatenteAutomovil + "|" + "\n"
                    + " |Modelo: " + a.ModeloAutomovil + "|" + "\n"
                    + " |TipoDoc: " + a.TipoDocumentoPropietario + "|" + "\n");

                string titulo = "Información del Vehiculo";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Vehiculo modificado con éxito!");
                    Clean();
                    searchPanel.Visible = true;
                    btnSearchType.Visible = true;
                    btnCleanType.Visible = true;
                    textNamePatente.Clear();
                    textNamePatente.Enabled = true;
                    CargarTablaVehiculo();
                }
                else
                {
                    textNamePatente.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el tipo de vehiculo! \n" +
                            "Complete los campos por favor!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clean();
            searchPanel.Visible = true;
            btnSearchType.Visible = true;
            btnCancel.Visible = false;
            textNamePatente.Enabled = true;
            btnCleanType.Visible = true;
        }

        private void tablaVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = searchPanel.Rows[indice];
            string codigo = filaSeleccionada.Cells["Patente"].Value.ToString();
            Automovil a = Buscar_Automovil(codigo);
            Cargar_Campos(a);
            searchPanel.Visible = false;
            btnSearchType.Visible = false;
            btnCancel.Visible = true;
            textNroDoc.Enabled = false;
            btnCleanType.Visible = false;
        }
    }
}
