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
        private void btnSearchClient2_Click(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnSearchProduct.Visible = true;

        }
        private void Clean()
        {
            textNameProduct.Text = "";
            textBoxCodeProduct.Text = "";
            textPrice.Text = "";
        }
        private void Cargar_Campos(Producto p)
        {
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
            catch (Exception ex)
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
                    product.PrecioProducto = int.Parse(DataReader["Precio"].ToString());

                }
            }
            catch (Exception ex)
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
            //Cargar Nombre
            textNameProduct.Text = p.NombreProducto;
            //Cargar Precio
            textPrice.Text = p.PrecioProducto.ToString();

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
                string consulta = "UPDATE Porductos SET NombrePorducto = @nombreProducto , Precio = @precio WHERE Codigo_Producto Like @codigoProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoProducto", prod.CodigoProducto);
                cmd.Parameters.AddWithValue("@tipoDocumento", prod.NombreProducto);
                cmd.Parameters.AddWithValue("@nroDocumento", prod.PrecioProducto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException ex)
            {

                throw;
                resultado = false;
            }
            catch (Exception)
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

        private void btnClientLoad_Click_1(object sender, EventArgs e)
        {
            Producto p = ObtenerDatosProducto();
            bool resultado = ModificarProducto(p);
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

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            if (textBoxCodeProduct.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                Producto p = Buscar_Producto(textNameProduct.Text);
                Cargar_Campos(p);
                SearchPanel.Visible = false;
                btnSearchProduct.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaProductos.Rows[indice];
            string codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
            Producto p = Buscar_Producto(codigo);
            Clean();
        }

        private void textBoxCodeProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SearchPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
