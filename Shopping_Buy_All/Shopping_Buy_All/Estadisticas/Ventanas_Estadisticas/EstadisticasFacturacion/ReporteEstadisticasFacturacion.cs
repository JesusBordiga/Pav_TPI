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

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReporteEstadisticasClientes
{
    public partial class ReporteEstadisticasFacturacion : Form
    {
        public ReporteEstadisticasFacturacion()
        {
            InitializeComponent();
            reporteFactura.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasFacturacion.EstadisticaFacturacion.rdlc";
            DataTable cantidadFacturas = ObtenerCantidadFacturas();
            DataTable cantidadLocalesMayorFacturas = ObtenerLocalesMayorFacturas();
            DataTable cantidadClientesMayorFacturas = ObtenerClientesMayorFacturas();
            int cantidadFac = (int)cantidadFacturas.Rows[0]["CantidadFacturas"];

            ReportDataSource ds = new ReportDataSource("DatosFacturaClientes", cantidadClientesMayorFacturas);
            ReportDataSource ds1 = new ReportDataSource("DatosFacturaLocales", cantidadLocalesMayorFacturas);
            ReportParameter[] lista = new ReportParameter[1];
            lista[0] = new ReportParameter("Parametro", cantidadFac.ToString());
            reporteFactura.LocalReport.SetParameters(lista);
            reporteFactura.LocalReport.DataSources.Clear();
            reporteFactura.LocalReport.DataSources.Add(ds);
            reporteFactura.LocalReport.DataSources.Add(ds1);
            this.reporteFactura.RefreshReport();
        }
        private void ReporteEstadisticasFacturacion_Load(object sender, EventArgs e)
        {
            this.reporteFactura.RefreshReport();
        }
        private DataTable ObtenerCantidadFacturas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "SELECT COUNT(*) 'CantidadFacturas' FROM ComprasPorCliente WHERE Borrado = 0 ORDER BY 'CantidadFacturas'";
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
        private DataTable ObtenerLocalesMayorFacturas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "SELECT L.Nombre, COUNT(F.Numero_Factura) 'CantidadFacturas' FROM Locales L    " +
                    "JOIN ComprasPorCliente F ON F.Codigo_Local = L.CodigoLocal WHERE L.Borrado = 0 and F.Borrado = 0  " +
                    "GROUP BY L.Nombre ORDER BY 'CantidadFacturas' DESC";
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
        private DataTable ObtenerClientesMayorFacturas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "SELECT (C.Nombres + ' ' + C.Apellido) 'Cliente', COUNT(F.Numero_Factura) 'CantidadFacturas' " +
                    "FROM Clientes C    JOIN ComprasPorCliente F ON(F.Numero_Documento = C.NroDocumento AND " +
                    "F.Tipo_Documento = C.TipoDocumento)  WHERE C.Borrado = 0 and F.Borrado = 0 " +
                    "GROUP BY(C.Nombres +' ' + C.Apellido) ORDER BY 'CantidadFacturas' DESC";
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
    }
}
