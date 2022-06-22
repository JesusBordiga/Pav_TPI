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

namespace Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasRecaudacion.RecaudacionPorProducto
{
    public partial class RecPorProducto : Form
    {
        AD_Facturacion _DB = new AD_Facturacion();
        int anioReporte = DateTime.Today.Year;
        int mesReporte = DateTime.Today.Month;
        public RecPorProducto()
        {
            InitializeComponent();
            lblAnio.Text = anioReporte.ToString();
            lblMes.Text = Capitalize(mesReporte);
        }

        private void RecPorProducto_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = _DB._GetEstRecXProducto(anioReporte.ToString(), mesReporte.ToString());
            if (dt.Rows.Count > 0)
            {
                ReportDataSource ds = new ReportDataSource("DatosRecaudacion", dt);
                reportViewer1.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasRecaudacion.RecaudacionPorProducto.RecaudacionPorProducto.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("Anio", anioReporte.ToString());
                parametros[1] = new ReportParameter("Mes", Capitalize(mesReporte));
                reportViewer1.LocalReport.SetParameters(parametros);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("No se encontraron facturas del año " + anioReporte.ToString() + " y del mes " + Capitalize(mesReporte));
            }
        }
        private void AddMonth_Click(object sender, EventArgs e)
        {
            if(mesReporte <= 11)
            {
                mesReporte++;
            }
            else
            {
                mesReporte = 1;
            }
            lblMes.Text = Capitalize(mesReporte);
        }

        private void RidMonth_Click(object sender, EventArgs e)
        {
            if (mesReporte >= 2)
            {
                mesReporte--;
            }
            else
            {
                mesReporte = 12;
            }
            lblMes.Text = Capitalize(mesReporte);
        }

        private void AddYear_Click(object sender, EventArgs e)
        {
            anioReporte++;
            lblAnio.Text = anioReporte.ToString();
        }

        private void RidYear_Click(object sender, EventArgs e)
        {
            anioReporte--;
            lblAnio.Text = anioReporte.ToString();
        }
        /// <summary>
        /// Convierte un número de mes en una cadena con el mes correspondiente y su primera letra mayúscula
        /// </summary>
        /// <param name="mesReporte"></param>
        private string Capitalize(int mesReporte)
        {
            string Mes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mesReporte);
            Mes = char.ToUpper(Mes[0]) + Mes.Substring(1);
            return Mes;
        }
    }
}
