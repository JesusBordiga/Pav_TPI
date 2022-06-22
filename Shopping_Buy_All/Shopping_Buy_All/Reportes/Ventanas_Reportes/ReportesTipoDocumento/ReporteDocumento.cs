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
using Microsoft.Reporting.WinForms;

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes
{
    public partial class ReporteTipoDocumento : Form
    {
        AD_TipoDocumento _TiposDocumento = new AD_TipoDocumento();
        DataTable Tabla = new DataTable();
        string alcance = "";


        public ReporteTipoDocumento()
        {
            InitializeComponent();
        }

        private void ReporteTipoDocumento_Load(object sender, EventArgs e)
        {
            labelLetra.Visible = false;
            mtbLetra.Visible=false;
            this.repTiposDocumento.RefreshReport();
        }

        private void Limpiar()
        {
            mtbLetra.Text = "";
            labelLetra.Visible = false;
            mtbLetra.Visible = false;
        }

        private void Restriccion()
        {
            if (rbTodos.Checked == true)
            {
                //todos
                alcance = "Todos los Tipos de Documento";
                Tabla = _TiposDocumento._Rpt_TipoDocumento();
            }

            if (rbPorLetra.Checked == true)
            {
                //letra
                alcance = "Tipos de Documento que empiezan por la letra: " + mtbLetra.Text;
                Tabla = _TiposDocumento._Rpt_TipoDocumento(mtbLetra.Text);
            }
        }

        private void rbPorLetra_CheckedChanged(object sender, EventArgs e)
        {
            labelLetra.Visible = true;
            mtbLetra.Visible = true;
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool validarSeleccion()
        {
            if (rbPorLetra.Checked == false && rbTodos.Checked == false)
            {
                return false;
            }
            return true;
        }
        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                rbTodos.Checked = false;
                rbPorLetra.Checked = false; 
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosClientes", Tabla);
                repTiposDocumento.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoDocumento.ReportTipoDocumento.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("@Alcance", alcance);
                repTiposDocumento.LocalReport.SetParameters(parametros);
                repTiposDocumento.LocalReport.DataSources.Clear();
                repTiposDocumento.LocalReport.DataSources.Add(Datos);
                repTiposDocumento.RefreshReport();
                Limpiar();

            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }

        private void repTiposDocumento_Load(object sender, EventArgs e)
        {
            this.repTiposDocumento.RefreshReport();
        }
    }
}
