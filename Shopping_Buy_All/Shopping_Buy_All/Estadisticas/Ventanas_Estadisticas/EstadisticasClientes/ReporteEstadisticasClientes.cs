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
        public ReporteEstadisticasClientes()
        {
            InitializeComponent();
            
        }
        private void ReporteEstadisticasClientes_Load(object sender, EventArgs e)
        {
            this.reporteCliente.RefreshReport();
        }
        private DataTable ObtenerCantidadSexo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "SELECT T.NombreSexo, COUNT(C.NroDocumento) 'CantidadClientes' FROM TipoSexo T JOIN Clientes C on C.TipoDocumento " +
                    "= T.TipoSexo WHERE C.Borrado = 0 and T.Borrado = 0 GROUP BY T.NombreSexo  ORDER BY 'CantidadClientes' DESC";
                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable cantidad = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(cantidad);
                return cantidad;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo obtener datos de clientes.\nError en la base de datos.", "ERROR");
                throw;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener datos de clientes.\nError en la base de datos.", "ERROR");
                throw;
            }
            finally
            {
                cn.Close();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteClientesXDoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteXEsCiv();
        }
    }
}
