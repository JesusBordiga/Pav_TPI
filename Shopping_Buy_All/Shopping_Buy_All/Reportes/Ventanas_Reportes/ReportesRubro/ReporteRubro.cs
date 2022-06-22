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

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesRubro
{
    public partial class ReporteRubro : Form
    {
        AD_Rubros _Rubros = new AD_Rubros();
        DataTable Tabla = new DataTable();
        string alcance = "";
        public ReporteRubro()
        {
            InitializeComponent();
            grbRestricción.Visible = false;
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
                alcance = "Todos los Rubros";
                Tabla = _Rubros._Rpt_Rubros();
            }
            if (rbPorLetra.Checked == true && txt_restriccion.Text != "")
            {
                //letra
                alcance = "Rubros que empiezan por la letra: " + txt_restriccion.Text;
                Tabla = _Rubros._Rpt_Rubros(txt_restriccion.Text);
            }
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccion())
            {
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosRubros", Tabla);
                repRub.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesRubro.ReportRubro.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("Alcance", alcance);
                repRub.LocalReport.SetParameters(parametros);
                repRub.LocalReport.DataSources.Clear();
                repRub.LocalReport.DataSources.Add(Datos);
                repRub.RefreshReport();
                Clean();
            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }

        private void Clean()
        {
            txt_restriccion.Text = "";
            rbPorLetra.Checked = false;
            rbTodos.Checked = true;
        }

        private bool ValidarSeleccion()
        {
            if (rbPorLetra.Checked == false && rbTodos.Checked == false)
            {
                return false;
            }
            return true;
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