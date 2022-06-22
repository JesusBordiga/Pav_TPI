using Microsoft.Reporting.WinForms;
using Shopping_Buy_All.ABMS.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasLocales
{
    public partial class EstadisticaLocalesPorRubro : Form
    {
        public EstadisticaLocalesPorRubro()
        {
            InitializeComponent();
        }

        private void EstadisticaLocalesPorRubro_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            AD_Local _AD = new AD_Local();
            DataTable tabla = _AD.ObtenerEstadisticaLocalesPorRubro();

            ReportDataSource ds = new ReportDataSource("DatosLocalPorRubro", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
