using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Shopping_Buy_All.Entidades;

namespace Shopping_Buy_All
{
    public partial class MarcaVehiculo_Load : Form
    {
        public MarcaVehiculo_Load()
        {
            InitializeComponent();
            CargarTablaMarcas();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            cmbMarca.Text = "";
            CargarTablaMarcas();

        }

        private void CargarTablaMarcas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Marcas WHERE Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaMarcas.DataSource = tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
        }
        private MarcaVehiculo ObtenerDatosMarca()
        {
            MarcaVehiculo c = new MarcaVehiculo();

            c.MarcaVeh = cmbMarca.Text.Trim();

            return c;
        }

        private bool Agregar_Marca(MarcaVehiculo mark)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Marcas (Descripcion) " +
                                               "Values(@descripcion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", mark.MarcaVeh);
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar la Marca.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }

        private void btnMarcaLoad_Click(object sender, EventArgs e)
        {
            MarcaVehiculo c = ObtenerDatosMarca();
            bool resultado = Agregar_Marca(c);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (" |Marca: " + c.MarcaVeh + "\n");

                string titulo = "Información de Carga";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Marca agregado con éxito!");
                    Clean();
                    CargarTablaMarcas();
                }
                else
                {
                    cmbMarca.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar la Marca! \n" +
                        "Complete los campos por favor!");
            }
        }
    }
}
