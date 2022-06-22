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
using Shopping_Buy_All.Productos;

namespace Shopping_Buy_All
{
    public partial class Facturacion_View : Form
    {
        AD_Facturacion _datos = new AD_Facturacion();
        public Facturacion_View()
        {
            InitializeComponent();
        }

        private void buttonTarjeta_Click(object sender, EventArgs e)
        {
            if (textNroFactura.Text != "")
            {
                tablaFacturas.DataSource = _datos._GetFacturaPorNro(textNroFactura.Text.ToString());
                if (tablaFacturas.Rows.Count == 0)
                {
                    MessageBox.Show("La factura no existe");
                }
            }
            else
            {
                MessageBox.Show("Complete el campo");
            }
        }
    }
}
