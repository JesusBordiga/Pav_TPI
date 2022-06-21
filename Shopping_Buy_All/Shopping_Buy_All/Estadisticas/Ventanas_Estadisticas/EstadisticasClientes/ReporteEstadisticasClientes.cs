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
using Microsoft.Reporting.WinForms;
using Shopping_Buy_All.ABMS.AccesoADatos;

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReporteEstadisticasClientes
{
    public partial class ReporteEstadisticasClientes : Form
    {
        AD_TipoDocumento _tipDoc = new AD_TipoDocumento();
        AD_EstadoCivil _esCiv = new AD_EstadoCivil();
        AD_Sexo _Sex = new AD_Sexo();

        public ReporteEstadisticasClientes()
        {
            InitializeComponent();
            
        }
        private void ReporteEstadisticasClientes_Load(object sender, EventArgs e)
        {
            this.reporteCliente.RefreshReport();
        }
       
        private void CargarReporte_Load(object sender, EventArgs e)
        {
            

        }
        private void ReporteXEsCiv()
        {
            DataTable cantidadEsCiv = _esCiv.ObtenerClientesPorEsCiv();

            ReportDataSource ds = new ReportDataSource("DataClientesEstadoCivil", cantidadEsCiv);

            reporteCliente.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasClientes.Clientes_EstadoCivil.EstadisticasClientesEstadoCivil.rdlc";

            reporteCliente.LocalReport.DataSources.Clear();
            reporteCliente.LocalReport.DataSources.Add(ds);
            this.reporteCliente.RefreshReport();
        }
        private void ReporteClientesXDoc()
        {
            DataTable cantidadTipoDocumento = _tipDoc.ObtenerCantidadTipoDocumento();

            ReportDataSource ds = new ReportDataSource("DatosDocumento", cantidadTipoDocumento);

            reporteCliente.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasClientes.Clientes_TipoDocumento.EstadisticasClientesTipoDocumento.rdlc";

            reporteCliente.LocalReport.DataSources.Clear();
            reporteCliente.LocalReport.DataSources.Add(ds);
            this.reporteCliente.RefreshReport();
        }
        private void ReporteXSexo()
        {
            DataTable cantidadSex = _Sex.ObtenerClientesPorSex();

            ReportDataSource ds = new ReportDataSource("DataClientesSexo", cantidadSex);

            reporteCliente.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasClientes.Clientes_Sexo.EstadisticasClientesSexo.rdlc";

            reporteCliente.LocalReport.DataSources.Clear();
            reporteCliente.LocalReport.DataSources.Add(ds);
            this.reporteCliente.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteClientesXDoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteXEsCiv();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReporteXSexo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
