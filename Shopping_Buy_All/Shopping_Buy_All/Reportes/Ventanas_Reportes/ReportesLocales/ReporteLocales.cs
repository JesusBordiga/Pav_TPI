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

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesLocales
{
    public partial class ReporteLocales : Form
    {
        AD_Local _Local = new AD_Local();
        DataTable Tabla = new DataTable();
        string alcance = "";

        public ReporteLocales()
        {
            InitializeComponent();
            lblRestriccion.Visible = false;
            txt_restriccion.Visible = false;
        }

        private void ReporteLocales_Load(object sender, EventArgs e)
        {

            this.repLocales.RefreshReport();
        }

        private void rbRangoCheckedChanged(object sender, EventArgs e)
        {
            lblRestriccion.Text = "Ingrese tipo de local";
            lblRestriccion.Visible = true;
            txt_restriccion.Mask = "xxxxxxxx";
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
                alcance = "Todos los locales";
                Tabla = _Local._Rpt_Local();
            }
            if (rbPorTipo.Checked == true)
            {
                //letra
                alcance = "Locales que empiezan por la letra: " + txt_restriccion.Text;
                Tabla = _Local._Rpt_Local(txt_restriccion.Text);
            }
        }

        private bool validarSeleccion()
        {
            if (rbPorTipo.Checked == false && rbTodos.Checked == false )
            {
                return false;
            }
            return true;
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosLocales", Tabla);
                repLocales.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesLocales.ReportLocales.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("PR01", alcance);
                repLocales.LocalReport.SetParameters(parametros);
                repLocales.LocalReport.DataSources.Clear();
                repLocales.LocalReport.DataSources.Add(Datos);
                repLocales.RefreshReport();
            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }
    }
}
