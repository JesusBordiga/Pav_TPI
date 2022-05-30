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

namespace Shopping_Buy_All.ABMS.ABM_TipoVehiculo
{
    public partial class VehicleType_Modify : Form
    {
        private object textNameVehicle;

        public object TextNameTypeVehicle { get; private set; }

        public VehicleType_Modify()
        {
            InitializeComponent();
            CargarTablaTipoVehiculo();
            panelBusqueda.Visible = false;
        }

        private void Clean()
        {
            textNameTypeVehicle.Text = "";
            textCodeType.Text = "";

        }

        private void Cargar_Campos(TipoVehiculo tv)
        {
            //Cargar Codigo
            textCodeType.Text = tv.CodigoTipoVehiculo.ToString();
            //Cargar Nombre
            textNameTypeVehicle.Text = tv.NombreTipoVehiculo;

        }
        private bool validarVacio()
        {
            if (textCodeType.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error! debe cargar codigo de tipo de vehiculo");
                return false;
            }
            else if (textNameTypeVehicle.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error! debe cargar nombre de tipo de vehiculo");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CargarTablaTipoVehiculo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getTipoAutomovilNoBorrado";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaTipoVehiculo.DataSource = tabla;
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
        private TipoVehiculo Buscar_TipoVehiculo(string Code)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            TipoVehiculo tipoVehiculo = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarTipoAutomovilNoBorrado @codigoTipoVehiculo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoTipoVehiculo", Code);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.HasRows && DataReader.Read())
                {
                    tipoVehiculo = new TipoVehiculo();
                    tipoVehiculo.CodigoTipoVehiculo = int.Parse(DataReader["Cod_tipo"].ToString());
                    tipoVehiculo.NombreTipoVehiculo = DataReader["Nombre"].ToString();
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
            return tipoVehiculo;
        }

        private TipoVehiculo ObtenerDatosTipoVehiculo()
        {
            TipoVehiculo tv = new TipoVehiculo();
            //Cargar Codigo
            tv.CodigoTipoVehiculo = int.Parse(textCodeType.Text.Trim());
            //Cargar Nombre
            tv.NombreTipoVehiculo = textNameTypeVehicle.Text.Trim();
            return tv;
        }

        private bool ModificarTipoVehiculo(TipoVehiculo typ)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "modificarTipoAutomovil @codigoTipoVehiculo, @nombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoTipoVehiculo", typ.CodigoTipoVehiculo);
                cmd.Parameters.AddWithValue("@nombre", typ.NombreTipoVehiculo);
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
            if (textCodeType.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                TipoVehiculo tv = Buscar_TipoVehiculo(textCodeType.Text);
                if (tv != null)
                {
                    Cargar_Campos(tv);
                    panelBusqueda.Visible = true;
                    btnSearchType.Visible = false;
                    btnSearchType2.Visible = true;
                    textCodeType.Enabled = false;
                    btnCleanType.Visible = false;
                }
                else
                {
                    MessageBox.Show($"No se encontro el tipo de vehiculo con el codigo {textCodeType.Text}");
                }
            }
        }

        private void btnCleanType_Click(object sender, EventArgs e)
        {
            Clean();
            panelBusqueda.Visible = false;
        }

        private void btnTypeLoad_Click(object sender, EventArgs e)
        {
            if (validarVacio())
            {
                TipoVehiculo tv = ObtenerDatosTipoVehiculo();
                bool resultado = ModificarTipoVehiculo(tv);
                if (resultado)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    String mensajeCarga = (
                        " |Codigo: " + tv.CodigoTipoVehiculo + "|" + "\n"
                        + " |Nombre: " + tv.NombreTipoVehiculo + "|" + "\n");

                    string titulo = "Información de Tipo Vehiculo";

                    DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Producto modificado con éxito!");
                        Clean();
                        panelBusqueda.Visible = false;
                        textCodeType.Clear();
                        CargarTablaTipoVehiculo();
                    }
                    else
                    {
                        textNameTypeVehicle.Focus();
                    }
                }
            }

        }
        private void btnSearchType2_Click(object sender, EventArgs e)
        {
            Clean();
            panelBusqueda.Visible = false;
        }
        private void tablaTipoVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaTipoVehiculo.Rows[indice];
            string codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
            TipoVehiculo tv = Buscar_TipoVehiculo(codigo);
            Cargar_Campos(tv);
            panelBusqueda.Visible = true;
        }
    }
}