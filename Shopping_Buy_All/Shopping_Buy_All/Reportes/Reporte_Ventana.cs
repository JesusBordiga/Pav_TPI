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
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesMarcasTarjetas;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesClientes;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesProductos;

namespace Shopping_Buy_All
{
    public partial class Reportes_Ventana : Form
    {
        public Reportes_Ventana()
        {
            InitializeComponent();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            ReporteFacturas reporteListadoFacturas = new ReporteFacturas();
            reporteListadoFacturas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteClientes reporteListadoClientes = new ReporteClientes();
            reporteListadoClientes.Show();
        }

        private void btnMasVendido_Click(object sender, EventArgs e)
        {
            ReporteProductos reporteProductosMasVendidos = new ReporteProductos();
            reporteProductosMasVendidos.Show();
        }

        private void btn_Vehiculo_Click(object sender, EventArgs e)
        {
            ReporteVehiculos reporteVehiculos = new ReporteVehiculos();
            reporteVehiculos.Show();
        }
    }
}
