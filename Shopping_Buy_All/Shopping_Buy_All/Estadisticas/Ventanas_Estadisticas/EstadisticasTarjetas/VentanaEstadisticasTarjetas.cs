using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasRecaudacion.RecaudacionPorMes;
using Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasRecaudacion.RecaudacionPorLocal;
using Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasRecaudacion.RecaudacionPorProducto;
using Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasTarjetas.UsoPorMarca;
using Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasTarjetas.UsoPorTipo;

namespace Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasRecaudacion
{
    public partial class VentanaEstadisticasTarjetas : Form
    {
        public VentanaEstadisticasTarjetas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComprasPorMarca comprasPorMarca = new ComprasPorMarca();
            comprasPorMarca.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComprasPorTipo comprasPorTipo = new ComprasPorTipo();
            comprasPorTipo.Show();
        }
    }
}
