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

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoTarjeta
{
    public partial class ReporteTipoTarjeta : Form
    {
        AD_TipoTarjeta _TiposTarjeta = new AD_TipoTarjeta();
        DataTable Tabla = new DataTable();
        string alcance = "";

        public ReporteTipoTarjeta()
        {
            InitializeComponent();
        }

        private void ReporteTipoTarjeta_Load(object sender, EventArgs e)
        {
            labelLetra.Visible = false;
            mtbLetra.Visible = false;
            this.repTipoTarjeta.RefreshReport();
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
                alcance = "Todos los Tipos de Tarjeta";
                Tabla = _TiposTarjeta._Rpt_TipoTarjeta();
            }

            if (rbPorLetra.Checked == true)
            {
                //letra
                alcance = "Tipos de Tarjeta que empiezan por la letra: " + mtbLetra.Text;
                Tabla = _TiposTarjeta._Rpt_TipoTarjeta(mtbLetra.Text);
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

        private void repTipoDocumento_Load(object sender, EventArgs e)
        {
            this.repTipoTarjeta.RefreshReport();
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                rbTodos.Checked = false;
                rbPorLetra.Checked = false;
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosClientes", Tabla);
                repTipoTarjeta.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoTarjeta.ReportTipoTarjeta.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("@Alcance", alcance);
                repTipoTarjeta.LocalReport.SetParameters(parametros);
                repTipoTarjeta.LocalReport.DataSources.Clear();
                repTipoTarjeta.LocalReport.DataSources.Add(Datos);
                repTipoTarjeta.RefreshReport();
                Limpiar();

            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }
    }
}
