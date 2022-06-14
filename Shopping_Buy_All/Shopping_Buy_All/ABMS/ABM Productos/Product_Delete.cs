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
        public Product_Delete()
        {
            InitializeComponent();
            CargarTablaProductos();
            labelEliminarproducto.Text=("Buscar Producto");
        }

        //ACCESO A BASE DE DATOS
        private void CargarTablaProductos()
        {
            try
            {
                tablaProductos.DataSource = AD_Productos.CargarTablaProductos();
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
                Producto p = AD_Productos.Buscar_Producto(textCodeProduct.Text.Trim());
                Cargar_Campos(p);
                panelBuscar.Visible = true;
            }
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clean();
            labelEliminarproducto.Text = "Buscar Producto";
            panelBuscar.Visible = false;
            btnSearchProduct.Visible = true;
            textCodeProduct.Enabled = true;
            textNameProduct.Enabled = true;
            textPrice.Enabled = true;
        }
        private void btnSerachProduct2_Click_1(object sender, EventArgs e)
        {
            panelBuscar.Visible = false;
            labelEliminarproducto.Text = ("Eliminar Producto");
            textCodeProduct.Enabled = false;
            textNameProduct.Enabled = false;
            textPrice.Enabled = false;
        }

        //FUNCIONES
        private void Clean()
        {
            textNameProduct.Text = "";
            textCodeProduct.Text = "";
            textPrice.Text = "";
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
            p.PrecioProducto = int.Parse(textPrice.Text.Trim());
            return p;
        }
        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelEliminarproducto.Text = ("Eliminar Producto");
                Clean();
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaProductos.Rows[indice];
                string codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
                Producto p = AD_Productos.Buscar_Producto(codigo);
                Cargar_Campos(p);
                panelBuscar.Visible = true;
                btnSearchProduct.Visible = false;
                btnSearchProduct2.Visible = true;
                textCodeProduct.Enabled = false;
                textNameProduct.Enabled = false;
                textPrice.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Seleccione una casilla dentro de la tabla");
            }
        }

    }
}

