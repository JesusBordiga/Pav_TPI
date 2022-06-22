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

namespace Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasTipoTarjeta
{
    public partial class EstadisticasTipoTarjeta : Form
    {
        AD_Tarjeta _esTar = new AD_Tarjeta();
        public EstadisticasTipoTarjeta()
        {
            InitializeComponent();
        }

        private void EstadisticasTipoTarjeta_Load(object sender, EventArgs e)
        {

            this.repTipoTarjeta.RefreshReport();
        }

        private void repTipoTarjeta_Load(object sender, EventArgs e)
        {
            DataTable tabla = _esTar.ObtenerCantidadTiposTarjeta1();

            repTipoTarjeta.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasTipoTarjeta.ReporteEstadisticaTipoTarjeta.rdlc";

            ReportDataSource ds = new ReportDataSource("EstadisticaTipoTarjeta", tabla);

            repTipoTarjeta.LocalReport.DataSources.Clear();
            repTipoTarjeta.LocalReport.DataSources.Add(ds);
            repTipoTarjeta.RefreshReport();
        }
    }
}
