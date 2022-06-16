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

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesMarcasTarjetas
{
    public partial class ReporteMarcasAutomovil : Form
    {
        AD_MarcaVehiculo _Marcas = new AD_MarcaVehiculo();
        DataTable Tabla = new DataTable();
        string alcance = "";
        public ReporteMarcasAutomovil()
        {
            InitializeComponent();
            lblRestriccion.Visible = false;
            txt_restriccion.Visible = false;
        }
        private void ReporteMarcasAutomovil_Load(object sender, EventArgs e)
        {
        }
        private void rbPorLetraCheckedChanged(object sender, EventArgs e)
        {
            lblRestriccion.Text = "Ingrese letra";
            txt_restriccion.Mask = "L";
            lblRestriccion.Visible = true;
            txt_restriccion.Visible = true;
        }
        private void rbRangoCheckedChanged(object sender, EventArgs e)
        {
            lblRestriccion.Text = "Ingrese rango";
            lblRestriccion.Visible = true;
            txt_restriccion.Mask = "9999999999-9999999999";
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
                alcance = "Todas los marcas";
                Tabla = _Marcas._Rpt_Marcas();
            }
            if (rbRangoId.Checked == true)
            {
                //rango
                string[] datos = txt_restriccion.Text.Split('-');
                alcance = "Rango de ID de la marca, inicio: " + datos[0].Trim().ToString() + " final: " + datos[1].Trim().ToString();
                Tabla = _Marcas._Rpt_Marcas(int.Parse(datos[0]),int.Parse(datos[1]));
            }
            if (rbPorLetra.Checked == true)
            {
                //letra
                alcance = "Marcas que empiezan por la letra: " + txt_restriccion.Text;
                Tabla = _Marcas._Rpt_Marcas(txt_restriccion.Text);
            }
        }
        private bool validarSeleccion()
        {
            if (rbPorLetra.Checked == false && rbTodos.Checked == false && rbRangoId.Checked == false)
            {
                return false;
            }
            return true;
        }

        private void btn_buscar01_Click_1(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosMarcas", Tabla);
                repMarc.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesMarcasAutomovil.ReportMarcasAutomovil.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("PR01", alcance);
                repMarc.LocalReport.SetParameters(parametros);
                repMarc.LocalReport.DataSources.Clear();
                repMarc.LocalReport.DataSources.Add(Datos);
                repMarc.RefreshReport();
            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }
    }
}
