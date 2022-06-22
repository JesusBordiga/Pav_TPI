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

namespace Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasTipoDocumento
{
    public partial class EstadisticaMarcasTarjeta : Form
    {
        AD_Tarjeta _esTar = new AD_Tarjeta();
        public EstadisticaMarcasTarjeta()
        {
            InitializeComponent();
        }

        private void EstadisticaTipoTarjeta_Load(object sender, EventArgs e)
        {

            this.repEstadisticasMarcasTarjeta.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = _esTar.ObtenerCantidadMarcasTarjeta1();

            repEstadisticasMarcasTarjeta.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasTarjeta.EstadisticaMarcaTarjeta.rdlc";

            ReportDataSource ds = new ReportDataSource("DatosEstadisticaMarcaTarjeta", tabla);

            repEstadisticasMarcasTarjeta.LocalReport.DataSources.Clear();
            repEstadisticasMarcasTarjeta.LocalReport.DataSources.Add(ds);
            repEstadisticasMarcasTarjeta.RefreshReport();
        }
    }
}
