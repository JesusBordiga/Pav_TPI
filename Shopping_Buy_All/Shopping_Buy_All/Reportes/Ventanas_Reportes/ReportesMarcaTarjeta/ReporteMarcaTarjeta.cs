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
    public partial class ReporteMarcaTarjeta : Form
    {
        AD_MarcaTarjeta _MarcaTarjeta = new AD_MarcaTarjeta();
        DataTable Tabla = new DataTable();
        string alcance = "";

        public ReporteMarcaTarjeta()
        {
            InitializeComponent();
            lblRestriccion.Visible = false;
            text_restriccion.Visible = false;
        }

        private void rbTodosCheckedChanged(object sender, EventArgs e)
        {
            if (rb_todos.Checked == true)
            {
                text_restriccion.Visible = false;
                lblRestriccion.Text = "";
                lblRestriccion.Visible = false;
            }
        }
        private void rb_x_letraCheckedChanged(object sender, EventArgs e)
        {
            text_restriccion.Visible = true;
            lblRestriccion.Text = "Ingrese Letra";
            text_restriccion.Mask = "L";
            lblRestriccion.Visible = true;
            
        }
        private void rbIdCheckedChanged(object sender, EventArgs e)
        {
            text_restriccion.Visible = false;
            lblRestriccion.Text = "Ingrese Id";
            text_restriccion.Mask = "99999999";
            lblRestriccion.Visible = true;
            text_restriccion.Visible = true;
        }
        private void Restriccion()
        {
            if (rb_todos.Checked == true)
            {
                //todos
                alcance = "Todos las Marcas de Tarjeta";
                Tabla = _MarcaTarjeta._Rpt_MarcaTarjeta ();
            }
            if (rb_x_id.Checked == true)
            {
                //Id
                alcance = "Id de marca:" + text_restriccion.Text;
                Tabla = _MarcaTarjeta._Rpt_MarcaTarjeta1(text_restriccion.Text);
            }
           if (rb_x_letra.Checked == true)
            {
                //letra
                alcance = "Marcas de Tarjeta que empiezan con: " + text_restriccion.Text;
                Tabla = _MarcaTarjeta._Rpt_MarcaTarjeta(text_restriccion.Text);
            }
        }
        private bool validarSeleccion()
        {
            if (rb_x_letra.Checked == false && rb_todos.Checked == false && rb_x_id.Checked == false)
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosMarcaTarjeta", Tabla);
                rv01.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesMarcaTarjeta.ReportMarcaTarjeta.rdlc";
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

    }
}
