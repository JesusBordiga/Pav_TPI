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
    public partial class Product_Delete : Form
    {
        AD_Productos _datosProductos = new AD_Productos();
        public Product_Delete()
        {
            InitializeComponent();
            CargarTablaProductos();
            labelEliminarproducto.Text = "Buscar Producto";
            panelBuscar.Visible = false;
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
        private void btnSearchProduct_Click_1(object sender, EventArgs e)
        {
            if (textCodeProduct.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                DataTable productos = _datosProductos.Buscar_Producto(textCodeProduct.Text.Trim());
                if (productos.Rows.Count == 1)
                {
                    labelEliminarproducto.Text = "Eliminar Producto";
                    Producto p = new Producto();
                    p.NombreProducto = productos.Rows[0]["NombreProducto"].ToString();
                    p.CodigoProducto = (int)productos.Rows[0]["Codigo_Producto"];
                    p.PrecioProducto = (float)Convert.ToDouble(productos.Rows[0]["Precio"]);
                    Cargar_Campos(p);
                    panelBuscar.Visible = true;

                }
                else
                {
                    MessageBox.Show("Error! \n No se encontró el producto");
                }
            }
        }
        private void Cargar_Campos(Producto p)
        {
            //Cargar Codigo
            textCodeProduct.Text = p.CodigoProducto.ToString();
            //Cargar Nombre
            textNameProduct.Text = p.NombreProducto;
            //Cargar Precio
            textPrice.Text = p.PrecioProducto.ToString();
            textCodeProduct.Enabled = false;
            textNameProduct.Enabled = false;
            textPrice.Enabled = false;
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clean();
            labelEliminarproducto.Text = "Buscar Producto";
            panelBuscar.Visible = false;
        }

        //FUNCIONES
        public Producto CrearProducto(DataTable datosProducto)
        {
            Producto p = new Producto();
            p.CodigoProducto = (int)datosProducto.Rows[0]["Codigo_Producto"];
            p.PrecioProducto = (float)Convert.ToDouble(datosProducto.Rows[0]["Precio"]);
            p.NombreProducto = datosProducto.Rows[0]["NombreProducto"].ToString();
            return p;
        }
        private void Clean()
        {
            textCodeProduct.Enabled = true;
            textNameProduct.Text = "";
            textCodeProduct.Text = "";
            textPrice.Text = "";
            labelEliminarproducto.Text = "Buscar Producto";
        }
        private Producto ObtenerDatosProducto()
        {
            Producto p = new Producto();
            //Cargar Codigo
            p.CodigoProducto = int.Parse(textCodeProduct.Text.Trim());
            //Cargar Nombre
            p.NombreProducto = textNameProduct.Text.Trim();
            //Cargar Precio
            p.PrecioProducto = int.Parse(textPrice.Text.Trim());
            return p;
        }
        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clean();
                labelEliminarproducto.Text = "Eliminar Producto";
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaProductos.Rows[indice];
                string codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
                DataTable producto = _datosProductos.Buscar_Producto(codigo);
                if (producto.Rows.Count == 1)
                {
                    Producto p = CrearProducto(producto);
                    Cargar_Campos(p);
                    panelBuscar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error! \n No se encontró el producto");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Seleccione una casilla dentro de la tabla");
            }
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {            
            Producto p = ObtenerDatosProducto();
            _datosProductos.BorrarProducto(p.CodigoProducto, 1);
            CargarTablaProductos();
            panelBuscar.Visible = false;
            Clean();
            MessageBox.Show("Se borro el producto con éxito");
        }
    }
}

