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
        public  Product_Modify()
        {
            InitializeComponent();
            CargarTablaProductos();
            panelBuscar.Visible = false;
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
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (textCodeProduct.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                Producto p = AD_Productos.Buscar_Producto(textCodeProduct.Text);
                Cargar_Campos(p);
                panelBuscar.Visible = true;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void btnPorductLoad_Click(object sender, EventArgs e)
        {
            Producto p = ObtenerDatosProducto();
            bool resultado = AD_Productos.ModificarProducto(p);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (
                      " |Codigo: " + p.CodigoProducto + "|" + "\n"
                    + " |Nombre: " + p.NombreProducto + "|" + "\n"
                    + " |Precio: " +"$"+ p.PrecioProducto + "|" + "\n");

                string titulo = "Información de Producto";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Producto agregado con éxito!");
                    Clean();
                    panelBuscar.Visible = false;
                    btnSerachProduct2.Visible = true;
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
            Producto p = AD_Productos.Buscar_Producto(textCodeProduct.Text);
            Cargar_Campos(p);
            panelBuscar.Visible = true;

        }

        //FUNCIONES
        private void Clean()
        {
            textNameProduct.Text = "";
            textCodeProduct.Text = "";
            textPrice.Text = "";
            panelBuscar.Visible = false;
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
        private void tablaProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaProductos.Rows[indice];
                string codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
                Producto p = AD_Productos.Buscar_Producto(codigo);
                Cargar_Campos(p);
                panelBuscar.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Seleccione una casilla dentro de la tabla!");
            }
        }

    }
}
