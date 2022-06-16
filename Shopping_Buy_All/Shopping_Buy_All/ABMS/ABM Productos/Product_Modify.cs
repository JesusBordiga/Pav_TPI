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

namespace Shopping_Buy_All
{
    public partial class Product_Modify : Form
    {
        AD_Productos _DB = new AD_Productos();
        public  Product_Modify()
        {
            InitializeComponent();
            CargarTablaProductos();
            panelBuscar.Visible = false;
            labelModificarproducto.Text = "Buscar Producto";
        }

        //ACCESO A BASE DE DATOS
        private void CargarTablaProductos()
        {
            try
            {
                tablaProductos.DataSource = _DB.CargarTablaProductos();
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Cargar Tabla Productos");
            }
        }

        //BOTONES
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (textCodeProduct.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                DataTable producto = _DB.Buscar_Producto(textCodeProduct.Text);
                if (producto.Rows.Count == 1)
                {
                    Producto p = CrearProducto(producto);
                    Cargar_Campos(p);
                    labelModificarproducto.Text = "Buscar Producto";
                    textCodeProduct.Enabled = false;
                    panelBuscar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error! \n No se encontró el producto");
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
            labelModificarproducto.Text = "Buscar Producto";
            textCodeProduct.Enabled = false;
        }
        private void btnPorductLoad_Click(object sender, EventArgs e)
        {
            Producto p = ObtenerDatosProducto();
            _DB.ModificarProducto(p);
            MessageBox.Show("Producto agregado con éxito!");
            Clean();
            panelBuscar.Visible = false;
            labelModificarproducto.Text = "Buscar Producto";
            btnSerachProduct2.Visible = true;
            CargarTablaProductos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable producto = _DB.Buscar_Producto(textCodeProduct.Text);
            if (producto.Rows.Count == 1)
            {
                Producto p = CrearProducto(producto);
                Cargar_Campos(p);
                panelBuscar.Visible = true;
                labelModificarproducto.Text = "Modificar Producto";
                textCodeProduct.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error! \n No se encontró el producto");
            }

        }

        //FUNCIONES
        private void Clean()
        {
            textNameProduct.Text = "";
            textCodeProduct.Text = "";
            textPrice.Text = "";
            panelBuscar.Visible = false;
            textCodeProduct.Enabled = true;
        }
        private void Cargar_Campos(Producto p)
        {
            //Cargar Codigo
            textCodeProduct.Text = p.CodigoProducto.ToString();
            //Cargar Nombre
            textNameProduct.Text = p.NombreProducto;
            //Cargar Precio
            textPrice.Text = p.PrecioProducto.ToString();
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
        public Producto CrearProducto(DataTable datosProducto)
        {
            Producto p = new Producto();
            p.CodigoProducto = (int)datosProducto.Rows[0]["Codigo_Producto"];
            p.PrecioProducto = (float)Convert.ToDouble(datosProducto.Rows[0]["Precio"]);
            p.NombreProducto = datosProducto.Rows[0]["NombreProducto"].ToString();
            return p;
        }
        public void tablaProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaProductos.Rows[indice];
                string codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
                DataTable producto = _DB.Buscar_Producto(codigo);
                if (producto.Rows.Count == 1)
                {
                    Producto p = CrearProducto(producto);
                    Cargar_Campos(p);
                    panelBuscar.Visible = true;
                    textCodeProduct.Enabled = false;
                    labelModificarproducto.Text = "Modificar Producto";
                }
                else
                {
                    MessageBox.Show("Error! \n No se encontró el producto");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Seleccione una casilla dentro de la tabla!");
            }
        }

    }
}
