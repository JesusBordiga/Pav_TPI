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
                alcance = "Todos los productos";
                Tabla = _Productos._Rpt_Productos();
            }
            if (rbRangoId.Checked == true)
            {
                //rango
                string[] datos = txt_restriccion.Text.Split('-');
                alcance = "Rango de precio del producto, inicio: " + datos[0].Trim().ToString() + " final: " + datos[1].Trim().ToString();
                Tabla = _Productos._Rpt_Productos(datos[0].ToString(), datos[1].ToString());
            }
            if (rbPorLetra.Checked == true)
            {
                //letra
                alcance = "Productos que empiezan por la letra: " + txt_restriccion.Text;
                Tabla = _Productos._Rpt_Productos(txt_restriccion.Text);
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

                ReportDataSource Datos = new ReportDataSource("DatosProductos", Tabla);
                repProd.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesProductos.ReportProductos.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("PR01", alcance);
                repProd.LocalReport.SetParameters(parametros);
                repProd.LocalReport.DataSources.Clear();
                repProd.LocalReport.DataSources.Add(Datos);
                repProd.RefreshReport();
            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }
    }
}
