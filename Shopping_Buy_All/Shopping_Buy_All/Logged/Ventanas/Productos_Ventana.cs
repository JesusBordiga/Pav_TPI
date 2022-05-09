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
using Shopping_Buy_All.Productos;

namespace Shopping_Buy_All
{
    public partial class Productos_Ventana : Form
    {
        public Productos_Ventana()
        {
            InitializeComponent();
        }
        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            Product_Load product_Load = new Product_Load();
            product_Load.ShowDialog();
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Product_Modify product_Modify = new Product_Modify();
            product_Modify.ShowDialog();
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Product_Delete product_Delete = new Product_Delete();
            product_Delete.ShowDialog();
        }
    }
}
