using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Shopping_Buy_All.ABMS.ABM_Profesiones;
using Shopping_Buy_All.ABMS.AccesoADatos;


namespace Shopping_Buy_All
{
    public partial class ReporteListadoFacturas : Form
    {
        public ReporteListadoFacturas()
        {
            InitializeComponent();
        }
        public DataTable ObtenerFacturas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * From ComprasPorCliente";
                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                return tabla;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo obtener facturas.\nError en la base de datos.", "ERROR");
                throw;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener facturas.\nError en la base de datos.", "ERROR");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        private void ReporteListadoFacturas_Load(object sender, EventArgs e)
        {
            this.reportViewerFacturas.RefreshReport();
        }

        private  void reportViewerFacturas_Load(object sender, EventArgs e)
        {
            DataTable TablaFacturas = new DataTable();
            TablaFacturas = ObtenerFacturas();

            ReportDataSource ds = new ReportDataSource("DatosFacturas", TablaFacturas);

            reportViewerFacturas.LocalReport.DataSources.Clear();
            reportViewerFacturas.LocalReport.DataSources.Add(ds);
            reportViewerFacturas.LocalReport.Refresh();
        }
    }
}
