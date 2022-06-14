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
    public partial class Tarjetas_Ventana : Form
    {
        public Tarjetas_Ventana()
        {
            InitializeComponent();
        }
        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            MarcaTarjeta_Load Load = new MarcaTarjeta_Load();
            Load.ShowDialog();
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            MarcaTarjeta_Modify Modify = new MarcaTarjeta_Modify();
            Modify.ShowDialog();
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            MarcaTarjeta_Delete Delete = new MarcaTarjeta_Delete();
            Delete.ShowDialog();
        }
    }
}
