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

        }

        private void Cargar_Campos(Automovil a)
        {
            //Cargar NroDoc
            textNroDoc.Text = a.DocumentoPropietario.ToString();
            //Cargar Nombre
            textNamePatente.Text = a.PatenteAutomovil;

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

        private Automovil Buscar_Automovil(string Code)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Automovil automovil = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Automovil WHERE NroDoc like @nroDocPropietario AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocPropietario", Code);

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
            //Cargar Nombre
            a.PatenteAutomovil = textNamePatente.Text.Trim();
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
            if (textNroDoc.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                Automovil a = Buscar_Automovil(textNroDoc.Text);
                if (a != null)
                {
                    Cargar_Campos(a);
                    searchPanel.Visible = false;
                    btnSearchType.Visible = false;
                    btnCancel.Visible = true;
                    textNroDoc.Enabled = false;
                    btnCleanType.Visible = false;
                }
                else
                {
                    MessageBox.Show($"No se encontro el vehiculo con el numero de documento {textNroDoc.Text}");
                }
            }
        }

        private void btnCleanType_Click(object sender, EventArgs e)
        {
            Clean();
            searchPanel.Visible = true;
            btnSearchType.Visible = true;
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
                    + " |Patente: " + a.PatenteAutomovil + "|" + "\n");

                string titulo = "Información de Tipo Vehiculo";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Producto modificado con éxito!");
                    Clean();
                    searchPanel.Visible = true;
                    btnSearchType.Visible = true;
                    btnCleanType.Visible = true;
                    textNamePatente.Clear();
                    textNroDoc.Enabled = true;
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
            textNroDoc.Enabled = true;
            btnCleanType.Visible = true;
        }

        private void tablaVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaVehiculos.Rows[indice];
            string codigo = filaSeleccionada.Cells["NroDoc"].Value.ToString();
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
