using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shopping_Buy_All.Entidades;

namespace Shopping_Buy_All
{
    public partial class Reportes_Ventana : Form
    {
        public Reportes_Ventana()
        {
            InitializeComponent();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            ReporteListadoFacturas reporteListadoFacturas = new ReporteListadoFacturas();
            reporteListadoFacturas.Show();
        }
    }
}
