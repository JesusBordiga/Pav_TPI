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
            grbRestricción.Visible = false;
        }

        private void ReporteLocales_Load(object sender, EventArgs e)
        {
            this.repLocales.RefreshReport();
        }

        private void rbPorLetraCheckedChanged(object sender, EventArgs e)
        {
            grbRestricción.Visible = rbPorLetra.Checked;
        }
        private void Restriccion()
        {
            if (rbTodos.Checked == true || txt_restriccion.Text == "")
            {
                //todos
                alcance = "Todos los locales.";
                Tabla = _Local._Rpt_Local();
            }
            if (rbPorLetra.Checked == true && txt_restriccion.Text != "")
            {
                //letra
                alcance = "Locales que empiezan por la letra: " + txt_restriccion.Text;
                Tabla = _Local._Rpt_Local(txt_restriccion.Text);
            }
        }

        private bool validarSeleccion()
        {
            if (rbPorLetra.Checked == false && rbTodos.Checked == false )
            {
                return false;
            }
            return true;
        }
        private void Clean()
        {
            txt_restriccion.Text = "";
            rbPorLetra.Checked = false;
            rbTodos.Checked = true;
        }
        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                Restriccion();

                ReportDataSource Datos1 = new ReportDataSource("DatosLocales", Tabla);
                ReportDataSource Datos2 = new ReportDataSource("DatosTipoComercio", Tabla);
                repLocales.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesLocales.ReportLocales.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("Alcance", alcance);
                repLocales.LocalReport.SetParameters(parametros);
                repLocales.LocalReport.DataSources.Clear();
                repLocales.LocalReport.DataSources.Add(Datos1);
                repLocales.LocalReport.DataSources.Add(Datos2);
                this.repLocales.RefreshReport();
                Clean();
            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }
        private void txt_restriccion_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txt_restriccion.Select(0, 0);
            });
        }
    }
}
