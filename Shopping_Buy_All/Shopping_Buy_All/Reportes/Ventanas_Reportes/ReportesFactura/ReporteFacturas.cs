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
            lblRestriccion.Visible = false;
            txt_restriccion.Visible = false;
        }
        private void rbPorLocalCheckedChanged(object sender, EventArgs e)
        {
            lblRestriccion.Text = "Ingrese local";
            txt_restriccion.Mask = "99";
            lblRestriccion.Visible = true;
            txt_restriccion.Visible = true;
        }
        private void rbRangoCheckedChanged(object sender, EventArgs e)
        {
            lblRestriccion.Text = "Ingrese rango";
            lblRestriccion.Visible = true;
            txt_restriccion.Mask = "99/99/9999-99/99/9999";
            txt_restriccion.Visible = true;
        }
        private void rbTodosCheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                lblRestriccion.Text = "";
                lblRestriccion.Visible = false;
                txt_restriccion.Visible = false;
            }
        }
        private void Restriccion()
        {
            if (rbTodos.Checked == true)
            {
                //todos
                alcance = "Todas las facturas";
                Tabla = _Clientes._Rpt_Clientes();
            }
            if (rbRangoId.Checked == true)
            {
                //rango
                string[] datos = txt_restriccion.Text.Split('-');
                alcance = "Facturas entre los días: " + datos[0].Trim().ToString() + " y: " + datos[1].Trim().ToString();
                Tabla = _Clientes._Rpt_Clientes(datos[0].ToString(), datos[1].ToString());
            }
            if (rbLocal.Checked == true)
            {
                //letra
                alcance = "Facturas del local: " + txt_restriccion.Text;
                Tabla = _Clientes._Rpt_Clientes(txt_restriccion.Text);
            }
        }
        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosFactura", Tabla);
                repFac.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ReportFacturas.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("Alcance", alcance);
                repFac.LocalReport.SetParameters(parametros);
                repFac.LocalReport.DataSources.Clear();
                repFac.LocalReport.DataSources.Add(Datos);
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
            txt_restriccion.Text = "";
            rbLocal.Checked = false;
            rbRangoId.Checked = false;
            rbTodos.Checked = false;
            lblRestriccion.Visible = false;
            txt_restriccion.Visible = false;
        }

        private bool validarSeleccion()
        {
            if (rbLocal.Checked == false && rbTodos.Checked == false && rbRangoId.Checked == false)
            {
                return false;
            }
            return true;
        }
    }
}
