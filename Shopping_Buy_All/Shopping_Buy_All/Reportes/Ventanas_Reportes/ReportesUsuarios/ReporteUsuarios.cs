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
    public partial class ReporteUsuarios : Form
    {
        AD_Usuario _Usuarios = new AD_Usuario();
        DataTable Tabla = new DataTable();
        string alcance = "";
        public ReporteUsuarios()
        {
            InitializeComponent();
            lblRestriccion.Visible = false;
            txt_restriccion.Visible = false;
        }
        private void ReporteUsuarios_Load(object sender, EventArgs e)
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
                alcance = "Todos los usuarios";
                Tabla = _Usuarios._Rpt_Usuarios();
            }
            if (rbRangoId.Checked == true)
            {
                //rango
                string[] datos = txt_restriccion.Text.Split('-');
                alcance = "Rango de ID del usuario, inicio: " + datos[0].Trim().ToString() + " final: " + datos[1].Trim().ToString();
                Tabla = _Usuarios._Rpt_Usuarios(int.Parse(datos[0]), int.Parse(datos[1]));
            }
            if (rbPorLetra.Checked == true)
            {
                //letra
                alcance = "Usuarios que empiezan por la letra: " + txt_restriccion.Text;
                Tabla = _Usuarios._Rpt_Usuarios(txt_restriccion.Text);
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

                ReportDataSource Datos = new ReportDataSource("DatosUsuarios", Tabla);
                repUsu.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesUsuarios.ReportUsuarios.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("PR01", alcance);
                repUsu.LocalReport.SetParameters(parametros);
                repUsu.LocalReport.DataSources.Clear();
                repUsu.LocalReport.DataSources.Add(Datos);
                repUsu.RefreshReport();
            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }
    }
}
