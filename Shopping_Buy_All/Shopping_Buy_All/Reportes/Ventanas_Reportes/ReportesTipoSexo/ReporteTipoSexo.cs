using Microsoft.Reporting.WinForms;
using Shopping_Buy_All.ABMS.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoSexo
{
    public partial class ReporteTipoSexo : Form
    {
        DataTable Tabla = new DataTable();
        string alcance = "";
        public ReporteTipoSexo()
        {
            InitializeComponent();
            lblRestriccion.Visible = false;
            comboBoxNombre.Visible = false;
        }

        private void ReporteTipoSexo_Load(object sender, EventArgs e)
        {

        }

        private void rbPorLetraCheckedChanged(object sender, EventArgs e)
        {
            lblRestriccion.Text = "Ingrese letra";
            lblRestriccion.Visible = true;
            comboBoxNombre.Visible = true;
            comboBoxNombre.SelectedIndex = -1;
        }
        private void rbTodosCheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                lblRestriccion.Text = "";
                lblRestriccion.Visible = false;
                comboBoxNombre.Visible = false;
                comboBoxNombre.SelectedIndex = -1;
            }
        }
        private void Restriccion()
        {
            if (rbTodos.Checked == true)
            {
                //todos
                alcance = "Todos los Tipo Sexo";
                Tabla = AD_Sexo.obtenerDatosSexo2();
            }
            if (rbPorLetra.Checked == true)
            {
                //letra
                alcance = "Tipo Sexo que empiezan por la letra: " + comboBoxNombre.Text;
                Tabla = AD_Sexo.obtenerDatosTipoSexoQueEmpiezanPor(comboBoxNombre.Text);
            }
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosTipoSexo", Tabla);
                reporteTipoSex.LocalReport.DataSources.Clear();
                reporteTipoSex.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoSexo.ReporteTipoSexo.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("Alcance", alcance);
                reporteTipoSex.LocalReport.SetParameters(parametros);
                reporteTipoSex.LocalReport.DataSources.Add(Datos);
                reporteTipoSex.RefreshReport();
                clean();
            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }

        private void clean()
        {
            rbPorLetra.Checked = false;
            rbTodos.Checked = false;
            lblRestriccion.Visible = false;
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
