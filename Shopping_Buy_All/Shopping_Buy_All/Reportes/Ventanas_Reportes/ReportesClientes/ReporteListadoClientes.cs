using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Shopping_Buy_All.ABMS.ABM_Profesiones;
using Shopping_Buy_All.ABMS.AccesoADatos;


namespace Shopping_Buy_All
{
    public partial class ReporteListadoClientes : Form
    {
        public ReporteListadoClientes()
        {
            InitializeComponent();
        }
        
        private void ReporteListadoFacturas_Load(object sender, EventArgs e)
        {
            this.reportViewerClientes.RefreshReport();
        }

        private  void reportViewerClientes_Load(object sender, EventArgs e)
        {
            DataTable TablaClientes = new DataTable();
            TablaClientes = AD_Cliente.ObtenerDatosClientes();

            ReportDataSource ds = new ReportDataSource("DatosClientes", TablaClientes);

            reportViewerClientes.LocalReport.DataSources.Clear();
            reportViewerClientes.LocalReport.DataSources.Add(ds);
            reportViewerClientes.LocalReport.Refresh();
        }

    }
}
