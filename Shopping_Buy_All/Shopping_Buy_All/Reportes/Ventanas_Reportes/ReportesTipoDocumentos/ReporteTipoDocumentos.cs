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

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoDocumentos
{
    public partial class ReporteTipoDocumentos : Form
    {
        DataTable Tabla = new DataTable();
        string alcance = "";
        public ReporteTipoDocumentos()
        {
            InitializeComponent();
            lblRestriccion.Visible = false;
            comboBoxNombre.Visible = false;
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
            AD_TipoDocumento _AD = new AD_TipoDocumento();
            if (rbTodos.Checked == true)
            {
                //todos
                alcance = "Todos los Tipo Documentos";
                Tabla = _AD.obtenerDatosTipoDocumento2();
            }
            if (rbPorLetra.Checked == true)
            {
                //letra
                alcance = "Tipo Documentos que empiezan por la letra: " + comboBoxNombre.Text;
                Tabla = _AD.obtenerDatosTipoDocumentoQueEmpiezanPor(comboBoxNombre.Text);
            }
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosTipoDocumentos", Tabla);
                reporteTipoDoc.LocalReport.DataSources.Clear();
                reporteTipoDoc.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoDocumentos.ReporteTipoDocumentos.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("Alcance", alcance);
                reporteTipoDoc.LocalReport.SetParameters(parametros);
                reporteTipoDoc.LocalReport.DataSources.Add(Datos);
                reporteTipoDoc.RefreshReport();
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
