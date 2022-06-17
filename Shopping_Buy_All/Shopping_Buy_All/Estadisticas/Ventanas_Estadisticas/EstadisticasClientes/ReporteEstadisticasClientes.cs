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
        public ReporteEstadisticasClientes()
        {
            InitializeComponent();
            
        }
        private void ReporteEstadisticasClientes_Load(object sender, EventArgs e)
        {
            this.reporteCliente.RefreshReport();
        }
        private DataTable ObtenerCantidadClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "SELECT COUNT(*) 'CantidadClientes'FROM Clientes C WHERE Borrado = 0";
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
        private DataTable ObtenerCantidadTipoDocumento()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "SELECT T.NombreDocumento, COUNT(C.NroDocumento) 'CantidadClientes'FROM TipoDocumento " +
                    "T JOIN Clientes C on C.TipoDocumento = T.TipoDocumento WHERE C.Borrado = 0 and T.Borrado = 0 " +
                    "GROUP BY T.NombreDocumento ORDER BY 'CantidadClientes' DESC";
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
        private DataTable ObtenerCantidadTEstadoCivil()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "SELECT T.NombreEstadoCivil, COUNT(C.NroDocumento) 'CantidadClientes' FROM TipoEstadoCivil T    " +
                    "JOIN Clientes C on C.TipoDocumento = T.TipoEstadoCivil WHERE C.Borrado = 0 and T.Borrado = 0 GROUP BY T.NombreEstadoCivil " +
                    "ORDER BY 'CantidadClientes' DESC";
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
            DataTable cantidadClientes = new DataTable();
            cantidadClientes = ObtenerCantidadClientes();
            DataTable cantidadTipoDocumento = new DataTable();
            cantidadTipoDocumento = ObtenerCantidadTipoDocumento();
            DataTable cantidadSexo = new DataTable();
            cantidadSexo = ObtenerCantidadSexo();
            DataTable cantidadEstadoCivil = new DataTable();
            cantidadEstadoCivil = ObtenerCantidadTEstadoCivil();

            ReportDataSource ds = new ReportDataSource("DatosClientes", cantidadClientes);
            ReportDataSource ds1 = new ReportDataSource("DatosTipoDocumento", cantidadTipoDocumento);
            ReportDataSource ds2 = new ReportDataSource("DatosSexo", cantidadSexo);
            ReportDataSource ds3 = new ReportDataSource("DatosEstadoCIvil", cantidadEstadoCivil);
            reporteCliente.LocalReport.DataSources.Clear();
            reporteCliente.LocalReport.DataSources.Add(ds);
            reporteCliente.LocalReport.DataSources.Add(ds1);
            reporteCliente.LocalReport.DataSources.Add(ds2);
            reporteCliente.LocalReport.DataSources.Add(ds3);
            reporteCliente.LocalReport.Refresh();
        }

    }
}
