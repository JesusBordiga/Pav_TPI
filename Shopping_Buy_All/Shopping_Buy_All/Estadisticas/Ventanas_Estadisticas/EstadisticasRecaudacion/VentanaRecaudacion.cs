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

namespace Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasRecaudacion
{
    public partial class VentanaRecaudacion : Form
    {
        public VentanaRecaudacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecPorMes recaudacionPorMes = new RecPorMes();
            recaudacionPorMes.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecPorProducto recPorProducto = new RecPorProducto();
            recPorProducto.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecPorLocal recPorLocal = new RecPorLocal();
            recPorLocal.Show();
            this.Close();
        }

    }
}
