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

namespace Shopping_Buy_All.Productos
{
    public partial class Product_Load : Form
    {
        public Product_Load()
        {
            InitializeComponent();
            CargarTablaProductos();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            textNameProduct.Text = "";
            textPrice.Text="";
        }
        
        private void CargarTablaProductos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Productos WHERE Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaProductos.DataSource = tabla;
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
        private Producto ObtenerDatosProducto()
        {
            Producto p = new Producto();

            //Nombre de Producto
            p.NombreProducto = textNameProduct.Text.Trim();

            //Precio de Producto
            p.PrecioProducto = float.Parse(textPrice.Text.Trim());

            return p;
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            Producto p = ObtenerDatosProducto();
            bool resultado = Agregar_Producto(p);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (
                      " |Nombre: " + p.NombreProducto + "|" + "\n"
                    + " |Precio: " + p.PrecioProducto + "|" + "\n");

                string titulo = "Información de Carga";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Producto agregado con éxito!");
                    Clean();
                    CargarTablaProductos();
                }
                else
                {
                    textNameProduct.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el Producto! \n" +
                        "Complete los campos por favor!");
            }
        }

        private bool Agregar_Producto(Producto product)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Productos(NombreProducto,Precio) Values(@nombre,@precio)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", product.NombreProducto);
                cmd.Parameters.AddWithValue("@precio", product.PrecioProducto);

                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {

                throw;
                resultado = false;
            }
            catch (Exception ex)
            {

                throw;
                resultado = false;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
    }
}
