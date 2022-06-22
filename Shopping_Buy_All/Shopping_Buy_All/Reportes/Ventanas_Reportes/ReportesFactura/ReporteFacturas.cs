using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Shopping_Buy_All.ABMS.AccesoADatos;

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura
{
    public partial class ReporteFacturas : Form
    {
        AD_Facturacion _Clientes = new AD_Facturacion();
        DataTable Tabla = new DataTable();
        string alcance = "";
        public ReporteFacturas()
        {
            InitializeComponent();
            cargarLocal();
            grbRestFecha.Visible = false;
            grbRestLocal.Visible = false;
        }
        private void cargarLocal()
        {
            try
            {
                cmbLocal.DataSource = AD_Local.ObtenerTablaLocalReducida();
                cmbLocal.DisplayMember = "Nombre";
                cmbLocal.ValueMember = "CodigoLocal";
                cmbLocal.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, no se pudieron obtener los datos de los locales\nError:\n" + ex.Message);
            }
        }
        private void rbPorLocalCheckedChanged(object sender, EventArgs e)
        {
            grbRestLocal.Visible = rbLocal.Checked;
        }
        private void rbRangoCheckedChanged(object sender, EventArgs e)
        {
            grbRestFecha.Visible = rbRangoId.Checked;
        }
        private void Restriccion()
        {
            if (rbTodos.Checked == true)
            {
                //todos
                alcance = "Todas las facturas";
                Tabla = _Clientes._Rpt_Clientes();
            }
            else if (rbRangoId.Checked == true)
            {
                //rango
                if (ComparararFechas(txtFecDesde.Text, txtFecHasta.Text))
                {
                    alcance = "Facturas entre los días: " + txtFecDesde.Text + " y: " + txtFecHasta.Text;
                    Tabla = _Clientes._Rpt_Clientes(txtFecDesde.Text, txtFecHasta.Text);
                }
                else
                {
                    alcance = "Facturas entre los días: " + txtFecHasta.Text + " y: " + txtFecDesde.Text;
                    Tabla = _Clientes._Rpt_Clientes(txtFecHasta.Text, txtFecDesde.Text);
                }
            }
            else
            {
                //letra
                alcance = "Facturas del local: " + cmbLocal.Text;
                Tabla = _Clientes._Rpt_Clientes(cmbLocal.SelectedValue.ToString());
            }
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                Restriccion();

                ReportDataSource DatosFactura = new ReportDataSource("DatosFactura", Tabla);
                ReportDataSource DatosLocal = new ReportDataSource("DatosLocal", Tabla);
                ReportDataSource DatosDocumento = new ReportDataSource("DatosDocumento", Tabla);
                repFac.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ReportFacturas.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("Alcance", alcance);
                repFac.LocalReport.SetParameters(parametros);
                repFac.LocalReport.DataSources.Clear();
                repFac.LocalReport.DataSources.Add(DatosFactura);
                repFac.LocalReport.DataSources.Add(DatosLocal);
                repFac.LocalReport.DataSources.Add(DatosDocumento);
                repFac.RefreshReport();
                clean();
            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }

        private void clean()
        {
            txtFecHasta.Text = "";
            txtFecDesde.Text = "";
            rbTodos.Checked = true;
            rbRangoId.Checked = false;
            rbLocal.Checked = false;
            comboBoxLocal.SelectedIndex = -1;
        }

        private bool validarSeleccion()
        {
            if (rbLocal.Checked == false && rbTodos.Checked == false && rbRangoId.Checked == false)
            {
                return false;
            }
            return true;
        }

        private void txtFecDesde_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtFecDesde.Select(0, 0);
            });
        }

        private void txtFecHasta_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtFecHasta.Select(0, 0);
            });
        }

        private bool ComparararFechas(string fec1, string fec2)
        {
            DateTime fecha1 = DateTime.ParseExact(fec1, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime fecha2 = DateTime.ParseExact(fec2, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            if (fecha1 <= fecha2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
