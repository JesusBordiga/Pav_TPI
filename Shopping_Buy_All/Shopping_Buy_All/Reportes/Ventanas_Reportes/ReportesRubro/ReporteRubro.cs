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
            lblRestriccion.Visible = false;
            txt_restriccion.Visible = false;
        }

        private void rbPorLetraCheckedChanged(object sender, EventArgs e)
        {
            lblRestriccion.Text = "Ingrese letra";
            //txt_restriccion.Mask = "L";
            lblRestriccion.Visible = true;
            //txt_restriccion.Visible = true;
            comboBoxNombre.Visible = true;
            txt_restriccion.Visible = false;
            comboBoxNombre.SelectedIndex = -1;
        }

        private void rbTodosCheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                lblRestriccion.Text = "";
                lblRestriccion.Visible = false;
                txt_restriccion.Visible = false;
                comboBoxNombre.Visible = false;
                comboBoxNombre.SelectedIndex = -1;
            }
        }

        private void Restriccion()
        {
            if (rbTodos.Checked == true)
            {
                //todos
                alcance = "Todos los clientes";
                Tabla = _Rubros._Rpt_Rubros();
            }
            if (rbPorLetra.Checked == true)
            {
                //letra
                alcance = "Rubros que empiezan por la letra: " + comboBoxNombre.Text;
                Tabla = _Rubros._Rpt_Rubros(comboBoxNombre.Text);
            }
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosRubros", Tabla);
                repRub.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesRubros.ReportRubros.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("Alcance", alcance);
                repRub.LocalReport.SetParameters(parametros);
                repRub.LocalReport.DataSources.Clear();
                repRub.LocalReport.DataSources.Add(Datos);
                repRub.RefreshReport();
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
            rbPorLetra.Checked = false;
            rbTodos.Checked = false;
            lblRestriccion.Visible = false;
            txt_restriccion.Visible = false;
            comboBoxNombre.Visible = false;
            comboBoxNombre.SelectedIndex = -1;
        }

        private bool validarSeleccion()
        {
            if (rbPorLetra.Checked == false && rbTodos.Checked == false)
            {
                return false;
            }
            return true;
        }


    }
}
