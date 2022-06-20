using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Shopping_Buy_All.ABMS.AccesoADatos;

namespace Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasRecaudacion.RecaudacionPorMes
{
    public partial class RecPorMes : Form
    {
        AD_Facturacion _DB = new AD_Facturacion();
        int anioReporte = DateTime.Today.Year;
        public RecPorMes()
        {
            InitializeComponent();
        }

        private void RecaudacionPorMes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = _DB._GetEstRecXMes(anioReporte.ToString());
            if (dt.Rows.Count > 0)
            {
                ReportDataSource ds = new ReportDataSource("DatosRecaudacion", dt);
                reportViewer1.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasRecaudacion.RecaudacionPorMes.RecaudacionPorMes.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("Anio", anioReporte.ToString());
                reportViewer1.LocalReport.SetParameters(parametros);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("No se encontraron facturas del año " + anioReporte.ToString());
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            anioReporte++;
            lblAnio.Text = anioReporte.ToString();
        }

        private void Rid_Click(object sender, EventArgs e)
        {
            anioReporte--;
            lblAnio.Text = anioReporte.ToString();
        }
    }
}
