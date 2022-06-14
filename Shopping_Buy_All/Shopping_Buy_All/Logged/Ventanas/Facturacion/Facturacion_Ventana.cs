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
    public partial class Facturacion_Ventana : Form
    {
        public Facturacion_Ventana()
        {
            InitializeComponent();
        }


        private void btnCargarFactura(object sender, EventArgs e)
        {
            Facturacion_Load factura_load = new Facturacion_Load();
            factura_load.Show();
        }

        private void btnMostrarFacturas_Click(object sender, EventArgs e)
        {
            Facturacion_View factura_view = new Facturacion_View();
            factura_view.Show();
        }
    }
}
