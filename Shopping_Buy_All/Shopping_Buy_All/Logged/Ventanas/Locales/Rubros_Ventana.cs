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
    public partial class Rubro_Ventana : Form
    {
        public Rubro_Ventana()
        {
            InitializeComponent();
        }
        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            Rubro_Load Rubro_Load = new Rubro_Load();
            Rubro_Load.ShowDialog();
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Rubro_Modify Rubro_Modify = new Rubro_Modify();
            Rubro_Modify.ShowDialog();
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Rubro_Delete Rubro_Delete = new Rubro_Delete();
            Rubro_Delete.ShowDialog();
        }
    }
}
