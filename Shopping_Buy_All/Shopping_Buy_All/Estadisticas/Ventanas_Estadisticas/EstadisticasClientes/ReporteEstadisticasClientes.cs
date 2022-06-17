using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Shopping_Buy_All.ABMS.AccesoADatos;

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReporteEstadisticasClientes
{
    public partial class ReporteEstadisticasClientes : Form
    {
        public ReporteEstadisticasClientes()
        {
            InitializeComponent();
            
        }

        private void CargarReporte_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Cliente.ObtenerDatosClientes();

            ReportDataSource ds = new ReportDataSource("DatosTiposDocumento", tabla);
            reporteCliente.LocalReport.DataSources.Clear();
            reporteCliente.LocalReport.DataSources.Add(ds);
            reporteCliente.LocalReport.Refresh();
        }

        private void ReporteEstadisticasClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
