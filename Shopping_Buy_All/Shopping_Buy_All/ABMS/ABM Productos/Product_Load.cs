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
using Shopping_Buy_All.ABMS.AccesoADatos;
using Shopping_Buy_All.Entidades;

namespace Shopping_Buy_All.Productos
{
    public partial class Product_Load : Form
    {
        AD_Productos _datosProductos = new AD_Productos();
        public Product_Load()
        {
            InitializeComponent();
            CargarTablaProductos();
        }

        //ACCESO A BASE DE DATOS
        private void CargarTablaProductos()
        {
            try
            {
               tablaProductos.DataSource = _datosProductos.CargarTablaProductos();
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Cargar Tabla Productos");
            }
        }

        //BOTONES
        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarProducto())
            {
                Producto p = ObtenerDatosProducto();
                _datosProductos.Cargar_Producto(p);
                CargarTablaProductos();
                MessageBox.Show("Producto agregado con éxito!");
                Clean();
            }
            
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        //FUNCIONES
        private Producto ObtenerDatosProducto()
        {
            Producto p = new Producto();

            //Nombre de Producto
            p.NombreProducto = textNameProduct.Text.Trim();

            //Precio de Producto
            p.PrecioProducto = float.Parse(textPrice.Text.Trim());

            return p;
        }
        private void Clean()
        {
            textNameProduct.Text = "";
            textPrice.Text="";
        }
        private bool ValidarProducto()
        {
            if (textNameProduct.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error! Cargar Nombre de producto");
                textNameProduct.Focus();
                return false;
            }
            else if (textPrice.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error! Cargar precio de producto");
                textNameProduct.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
