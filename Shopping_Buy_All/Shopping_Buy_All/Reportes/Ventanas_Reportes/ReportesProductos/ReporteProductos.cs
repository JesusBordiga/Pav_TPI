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

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesMarcasTarjetas
{
    public partial class ReporteProductos : Form
    {
        AD_Productos _Productos = new AD_Productos();
        DataTable Tabla = new DataTable();
        string alcance = "";
        public ReporteProductos()
        {
            InitializeComponent();
            lblRestriccion.Visible = false;
            txt_restriccion.Visible = false;
        }
        private void ReporteProductos_Load(object sender, EventArgs e)
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
            if (rb_todos.Checked == true)
            {
                lblRestriccion.Text = "";
                lblRestriccion.Visible = false;
                txt_restriccion.Visible = false;
            }
        }
        private void Restriccion()
        {
            if (rb_todos.Checked == true)
            {
                //todos
                alcance = "Todos los productos";
                Tabla = _Productos._Rpt_Productos();
            }
            if (rb_rango_id.Checked == true)
            {
                //rango
                string[] datos = txt_restriccion.Text.Split('-');
                alcance = "Rango de precio del producto, inicio: " + datos[0].Trim().ToString() + " final: " + datos[1].Trim().ToString();
                Tabla = _Productos._Rpt_Productos(datos[0].ToString(), datos[1].ToString());
            }
            if (rb_x_letra.Checked == true)
            {
                //letra
                alcance = "Productos que empiezan por la letra: " + txt_restriccion.Text;
                Tabla = _Productos._Rpt_Productos(txt_restriccion.Text);
            }
        }
        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (validarSeleccion()){
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosProductos", Tabla);
                rv01.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesProductos.ReportProductos.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("PR01", alcance);
                rv01.LocalReport.SetParameters(parametros);
                rv01.LocalReport.DataSources.Clear();
                rv01.LocalReport.DataSources.Add(Datos);
                rv01.RefreshReport();
            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }
        private bool validarSeleccion()
        {
            if (rb_x_letra.Checked == false && rb_todos.Checked == false && rb_rango_id.Checked == false)
            {
                return false;
            }
            return true;
        }
    }
}
