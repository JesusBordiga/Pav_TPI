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

namespace Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasTipoComercio
{
    public partial class EstadisticasTipoComercio : Form
    {
        public EstadisticasTipoComercio()
        {
            InitializeComponent();
        }

        private void EstadisticasTipoComercio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = AD_Local.ObtenerEstadisticaLocalesPorTipoComercio();

            ReportDataSource ds = new ReportDataSource("DatosTipoComercioEstadisticos", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
