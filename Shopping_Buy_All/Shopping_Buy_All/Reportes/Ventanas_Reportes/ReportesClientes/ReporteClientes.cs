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

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesClientes
{
    public partial class ReporteClientes : Form
    {
        AD_Cliente _Clientes = new AD_Cliente();
        DataTable Tabla = new DataTable();
        string alcance = "";
        public ReporteClientes()
        {
            InitializeComponent();
            lblRestriccion.Visible = false;
            txt_restriccion.Visible = false;
            comboBoxNombre.Visible = false;
        }
        private void rbPorLetraCheckedChanged(object sender, EventArgs e)
        {
            lblRestriccion.Text = "Ingrese letra";
            //txt_restriccion.Mask = "L";
            lblRestriccion.Visible = true;
            //txt_restriccion.Visible = true;
            comboBoxNombre.Visible = true;
            txt_restriccion.Visible = false;
            comboBoxNombre.SelectedIndex = -1;
        }
        private void rbRangoCheckedChanged(object sender, EventArgs e)
        {
            lblRestriccion.Text = "Ingrese rango";
            lblRestriccion.Visible = true;
            txt_restriccion.Mask = "99/99/9999-99/99/9999";
            txt_restriccion.Visible = true;
            comboBoxNombre.Visible = false;
            comboBoxNombre.SelectedIndex = -1;
        }
        private void rbTodosCheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                lblRestriccion.Text = "";
                lblRestriccion.Visible = false;
                txt_restriccion.Visible = false;
                comboBoxNombre.Visible = false;
                comboBoxNombre.SelectedIndex = -1;
            }
        }
        private void Restriccion()
        {
            if (rbTodos.Checked == true)
            {
                //todos
                alcance = "Todos los clientes";
                Tabla = _Clientes._Rpt_Clientes();
            }
            if (rbRangoId.Checked == true)
            {
                //rango
                string[] datos = txt_restriccion.Text.Split('-');
                alcance = "Clientes que nacieron entre: " + datos[0].Trim().ToString() + " y: " + datos[1].Trim().ToString();
                Tabla = _Clientes._Rpt_Clientes(datos[0].ToString(), datos[1].ToString());
            }
            if (rbPorLetra.Checked == true)
            {
                //letra
                alcance = "Productos que empiezan por la letra: " + comboBoxNombre.Text;
                Tabla = _Clientes._Rpt_Clientes(comboBoxNombre.Text);
            }
        }
        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (validarSeleccion())
            {
                Restriccion();

                ReportDataSource Datos = new ReportDataSource("DatosClientes", Tabla);
                repProd.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesClientes.ReportClientes.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("Alcance", alcance);
                repProd.LocalReport.SetParameters(parametros);
                repProd.LocalReport.DataSources.Clear();
                repProd.LocalReport.DataSources.Add(Datos);
                repProd.RefreshReport();
                clean();
            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }
        private void clean()
        {
            txt_restriccion.Text = "";
            rbPorLetra.Checked = false;
            rbRangoId.Checked = false;
            rbTodos.Checked = false;
            lblRestriccion.Visible = false;
            txt_restriccion.Visible = false;
            comboBoxNombre.Visible = false;
            comboBoxNombre.SelectedIndex = -1;
        }
        private bool validarSeleccion()
        {
            if (rbPorLetra.Checked == false && rbTodos.Checked == false && rbRangoId.Checked == false)
            {
                return false;
            }
            return true;
        }
    }
}
