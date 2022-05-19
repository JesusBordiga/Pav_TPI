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
    public partial class Modelo_Ventana : Form
    {
        public Modelo_Ventana()
        {
            InitializeComponent();
        }
        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            Modelo_Load Load = new Modelo_Load();
            Load.ShowDialog();
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Modelo_Modify Modify = new Modelo_Modify();
            Modify.ShowDialog();
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Modelo_Delete Delete = new Modelo_Delete();
            Delete.ShowDialog();
        }
    }
}
