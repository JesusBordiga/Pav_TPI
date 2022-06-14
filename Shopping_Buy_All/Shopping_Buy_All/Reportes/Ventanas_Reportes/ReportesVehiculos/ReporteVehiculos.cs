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

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesProductos
{
    public partial class ReporteVehiculos : Form
    {
        AD_Vehiculos _Vehiculos = new AD_Vehiculos();
        DataTable Tabla = new DataTable();
        string alcance = "";

        public ReporteVehiculos()
        {
            InitializeComponent();
            lblRestriccion.Visible = false;
            txt_restriccion.Visible = false;
            text_patente.Visible = false;
        }
        private void rbPorPatenteCheckedChanged(object sender, EventArgs e)
        {
            text_patente.Visible = true;
            lblRestriccion.Text = "Ingrese patente";
            text_patente.Text = "";
            lblRestriccion.Visible = true;
            txt_restriccion.Visible = false;
        }
        private void rbDocCheckedChanged(object sender, EventArgs e)
        {
            text_patente.Visible = false;
            lblRestriccion.Text = "Ingrese Documento";
            txt_restriccion.Mask = "99999999";
            lblRestriccion.Visible = true;
            txt_restriccion.Visible = true;
        }
        private void rbTodosCheckedChanged(object sender, EventArgs e)
        {
            if (rb_todos.Checked == true)
            {
                text_patente.Visible = false;
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
                alcance = "Todos los vehiculos";
                Tabla = _Vehiculos._Rpt_Vehiculos();
            }
            if (rb_doc_id.Checked == true)
            {
                //documento
                alcance = "Documento nro:" + txt_restriccion.Text;
                Tabla = _Vehiculos._Rpt_Vehiculos1(txt_restriccion.Text);
            }
           if (rb_x_letra.Checked == true)
            {
                //letra
                alcance = "Vehiculos que la patente empieza con: " + text_patente.Text;
                Tabla = _Vehiculos._Rpt_Vehiculos(text_patente.Text);
            }
        }
        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (validarSeleccion()){
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosVehiculos", Tabla);
                rv01.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesVehiculos.ReportVehiculos.rdlc";
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
            if (rb_x_letra.Checked == false && rb_todos.Checked == false && rb_doc_id.Checked == false)
            {
                return false;
            }
            return true;
        }

    }
}
