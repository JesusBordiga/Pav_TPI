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

namespace Shopping_Buy_All
{
    public partial class Product_Modify : Form
    {
        public  Product_Modify()
        {
            InitializeComponent();
            CargarTablaProductos();
        }
        private void Clean()
        {
            textNameProduct.Text = "";
            textCodeProduct.Text = "";
            textPrice.Text = "";
        }
        private void Cargar_Campos(Producto p)
        {
            //Cargar Codigo
            textCodeProduct.Text =p.CodigoProducto.ToString();
            //Cargar Nombre
            textNameProduct.Text = p.NombreProducto;
            //Cargar Precio
            textPrice.Text = p.PrecioProducto.ToString();
        }

        private void CargarTablaProductos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Productos WHERE Borrado like 0";

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
        private Producto Buscar_Producto(string Code)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Producto product= new Producto();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Productos WHERE Codigo_Producto like @codigoProducto AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoProducto", Code);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    product.CodigoProducto = int.Parse(DataReader["Codigo_Producto"].ToString());
                    product.NombreProducto = DataReader["NombreProducto"].ToString();
                    product.PrecioProducto = float.Parse(DataReader["Precio"].ToString());

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
            return product;


        }

        private Producto ObtenerDatosProducto()
        {
            Producto p = new Producto();
            //Cargar Codigo
            p.CodigoProducto = int.Parse(textCodeProduct.Text.Trim());
            //Cargar Nombre
            p.NombreProducto = textNameProduct.Text.Trim();
            //Cargar Precio
             p.PrecioProducto= int.Parse(textPrice.Text.Trim());
            return p;
        }

        private bool ModificarProducto(Producto prod)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Productos SET NombreProducto = @nombreProducto , Precio = @precio WHERE Codigo_Producto Like @codigoProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoProducto", prod.CodigoProducto);
                cmd.Parameters.AddWithValue("@nombreProducto", prod.NombreProducto);
                cmd.Parameters.AddWithValue("@precio", prod.PrecioProducto);
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
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (textCodeProduct.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                Producto p = Buscar_Producto(textCodeProduct.Text);
                Cargar_Campos(p);
                SearchPanel.Visible = false;
                btnSearchProduct.Visible = false;
                btnSerachProduct2.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnSearchProduct.Visible = true;
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaProductos.Rows[indice];
            string codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
            Producto p = Buscar_Producto(codigo);
            Cargar_Campos(p);
            SearchPanel.Visible = false;
            btnSearchProduct.Visible = false;
            btnSerachProduct2.Visible = true;
        }

        private void btnPorductLoad_Click(object sender, EventArgs e)
        {
            Producto p = ObtenerDatosProducto();
            bool resultado = ModificarProducto(p);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (
                      " |Codigo: " + p.CodigoProducto + "|" + "\n"
                    + " |Nombre: " + p.NombreProducto + "|" + "\n"
                    + " |Precio: " + p.PrecioProducto + "|" + "\n");

                string titulo = "Información de Producto";

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

        private void button1_Click(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnSearchProduct.Visible = true;
            btnSerachProduct2.Visible = false;
        }
    }
}
