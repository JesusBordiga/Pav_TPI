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
            rbTodos.Checked = true;
            grbRangoPrecio.Visible = false;
            grbLetra.Visible = false;
        }

        private void rbPorLetraCheckedChanged(object sender, EventArgs e)
        {
            grbLetra.Visible = rbPorLetra.Checked; 
        }
        
        private void rbRangoCheckedChanged(object sender, EventArgs e)
        {
            grbRangoPrecio.Visible = rbRangoId.Checked;
        }

        /// <summary>
        /// Construye el alcance del producto y obtiene los datos necesarios para el reporte
        /// </summary>
        private void Restriccion()
        {
            if (rbTodos.Checked == true)
            {
                //todos
                alcance = "Todos los productos";
                Tabla = _Productos._Rpt_Productos();
            }
            else if (rbRangoId.Checked == true)
            {
                //rango
                if (Convert.ToUInt32(txtPrecDesde.Text.Trim()) <= Convert.ToUInt32(txtPrecHasta.Text.Trim()))
                {
                    alcance = "Rango de precio del producto, inicio: " + txtPrecDesde.Text + " final: " + txtPrecHasta.Text;
                    Tabla = _Productos._Rpt_Productos(txtPrecDesde.Text, txtPrecHasta.Text);
                }
                else
                {
                    alcance = "Rango de precio del producto, inicio: " + txtPrecHasta.Text + " final: " + txtPrecDesde.Text;
                    Tabla = _Productos._Rpt_Productos(txtPrecHasta.Text, txtPrecDesde.Text);
                }   
            }
            else
            {
                //letra
                alcance = "Productos que empiezan por la letra: " + txtLetra.Text;
                Tabla = _Productos._Rpt_Productos(txtLetra.Text);
            }
        }

        /// <summary>
        /// Valida que al menos un rb se haya seleccionado
        /// </summary>
        /// <returns></returns>
        private bool validarSeleccion()
        {
            if (rbPorLetra.Checked == false && rbTodos.Checked == false && rbRangoId.Checked == false)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Manda los datos al reporte y lo muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                Clear();
            }
            else
            {
                MessageBox.Show("Seleccione una restricción!", "Error");
            }
        }

        /// <summary>
        /// Limpia los campos
        /// </summary>
        private void Clear()
        {
            rbTodos.Checked = true;
            grbRangoPrecio.Visible = false;
            grbLetra.Visible = false;
            txtLetra.Text = "";
            txtPrecHasta.Text = "";
            txtPrecDesde.Text = "";
        }

        /// <summary>
        /// Lleva al puntero al comienzo del textBox cuando se entra en él
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaskedTextBox1_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtLetra.Select(0, 0);
            });
        }

        /// <summary>
        /// Lleva al puntero al comienzo del textBox cuando se entra en él
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPrecHasta_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtPrecHasta.Select(0, 0);
            });
        }

        /// <summary>
        /// Lleva al puntero al comienzo del textBox cuando se entra en él
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPrecDesde_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtPrecDesde.Select(0, 0);
            });
        }
    }
}
