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

        private void CargarTablaTipoVehiculo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM TipoAuto WHERE Borrado like 0";

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
            TipoVehiculo tipoVehiculo = new TipoVehiculo();
            try
            {
               SqlCommand cmd = new SqlCommand();
               string consulta = "SELECT * FROM TipoAuto WHERE Cod_tipo like @codigoTipoVehiculo AND Borrado like 0";

               cmd.Parameters.Clear();
               cmd.Parameters.AddWithValue("@codigoTipoVehiculo", Code);

               cmd.CommandType = CommandType.Text;
               cmd.CommandText = consulta;

               cn.Open();
               cmd.Connection = cn;
               SqlDataReader DataReader = cmd.ExecuteReader();
               if (DataReader != null && DataReader.Read())
               {
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
                string consulta = "UPDATE Productos SET NombreProducto = @nombreProducto , Precio = @precio WHERE Codigo_Producto Like @codigoProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoTipoVehiculo", typ.CodigoTipoVehiculo);
                cmd.Parameters.AddWithValue("@nombreProducto", typ.NombreTipoVehiculo);
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
                TipoVehiculo tv = Buscar_TipoVehiculo (textCodeType.Text);
                Cargar_Campos(tv);
                searchPanel.Visible = false;
                btnSearchType.Visible = false;
                btnSearchType2.Visible = true;
            }
        }

        private void btnCleanType_Click(object sender, EventArgs e)
        {
            Clean();
            searchPanel.Visible = true;
            btnSearchType.Visible = true;
        }

        private void btnTypeLoad_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Producto agregado con éxito!");
                    Clean();
                    searchPanel.Visible = false;
                    btnSearchType.Visible = false;
                    btnSearchType2.Visible = true;
                    CargarTablaTipoVehiculo();
                }
                else
                {
                    textNameTypeVehicle.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el tipo de vehiculo! \n" +
                            "Complete los campos por favor!");
            }
        }
        private void btnSearchType2_Click(object sender, EventArgs e)
        {
            Clean();
            searchPanel.Visible = true;
            btnSearchType.Visible = true;
            btnSearchType2.Visible = false;
        }
        private void tablaTipoVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaTipoVehiculo.Rows[indice];
            string codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
            TipoVehiculo tv = Buscar_TipoVehiculo(codigo);
            Cargar_Campos(tv);
            searchPanel.Visible = false;
            btnSearchType.Visible = false;
            btnSearchType2.Visible = true;
        }

    }
}


