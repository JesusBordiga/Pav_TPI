using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shopping_Buy_All.ABMS.ABM_TipoVehiculo.VehicleType_Modify;
using Shopping_Buy_All.Entidades;

namespace Shopping_Buy_All.ABMS.ABM_TipoVehiculo
{
    public partial class VehicleType_Delete : Form
    {
        public VehicleType_Delete()
        {
            InitializeComponent();
        }
        private void TypeDelete_Load(object sender, EventArgs e)
        {
            CargarTablaTipoVehiculo();
        }
        private void Clean()
        {
            textNameType.Text = "";
            textCodeType.Text = "";
        }
        private void Cargar_Campos(TipoVehiculo tv)
        {
            //Cargar Codigo
            textCodeType.Text = tv.CodigoTipoVehiculo.ToString();
            //Cargar Nombre
            textNameType.Text = tv.NombreTipoVehiculo;
            
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
        private bool validarVacio()
        {
            if (textCodeType.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error! debe cargar codigo de tipo de vehiculo");
                return false;
            }
            else if (textNameType.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error! debe cargar nombre de tipo de vehiculo");
                return false;
            }
            else
            {
                return true;
            }
        }
        private TipoVehiculo Buscar_TipoVehiculo(string Code)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            TipoVehiculo typ = new TipoVehiculo();
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
                if (DataReader != null && DataReader.Read())
                {
                    typ.CodigoTipoVehiculo= int.Parse(DataReader["Cod_tipo"].ToString());
                    typ.NombreTipoVehiculo = DataReader["Nombre"].ToString();

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
            return typ;
        }

        private TipoVehiculo ObtenerDatosTipoVehiculo()
        {
            TipoVehiculo tv = new TipoVehiculo();
            //Cargar Codigo
            tv.CodigoTipoVehiculo = int.Parse(textCodeType.Text.Trim());
            //Cargar Nombre
            tv.NombreTipoVehiculo = textNameType.Text.Trim();
            return tv;
        }

        private bool BorrarTipoVehiculo(int Codigo, int Borrado)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "borrarTipoAutomovil @codigoTipo, @borrado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoTipo", Codigo);
                cmd.Parameters.AddWithValue("@borrado", Borrado);
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
        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            if (validarVacio())
            {
                TipoVehiculo tv = ObtenerDatosTipoVehiculo();
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (
                      " |Codigo: " + tv.CodigoTipoVehiculo + "|" + "\n"
                    + " |Nombre: " + tv.NombreTipoVehiculo + "|" + "\n");

                string titulo = "Información de tipo de vehiculo";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Borrado agregado con éxito!");
                    BorrarTipoVehiculo(tv.CodigoTipoVehiculo, 1);
                    Clean();
                    SearchPanel.Visible = true;
                    btnSearchType.Visible = false;
                    btnSerachType2.Visible = true;
                    CargarTablaTipoVehiculo();
                }
                else
                {
                    textNameType.Focus();
                }
            }
        }

        private void btnSearchType_Click_1(object sender, EventArgs e)
        {
            if (textCodeType.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                TipoVehiculo tv = Buscar_TipoVehiculo(textCodeType.Text);
                Cargar_Campos(tv);
                SearchPanel.Visible = false;
                btnSearchType.Visible = false;
                btnSerachType2.Visible = true;
            }
        }
        private void btnClean_Click_1(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnSearchType.Visible = true;
        }

        private void btnSerachType2_Click(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnSearchType.Visible = true;
            btnSerachType2.Visible = false;
        }

        private void tablaTipoVehiculo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Clean();
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaTipoVehiculo.Rows[indice];
            string codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
            TipoVehiculo tv = Buscar_TipoVehiculo(codigo);
            Cargar_Campos(tv);
            SearchPanel.Visible = false;
            btnSearchType.Visible = false;
            btnSerachType2.Visible = true;

        }
    }
}
