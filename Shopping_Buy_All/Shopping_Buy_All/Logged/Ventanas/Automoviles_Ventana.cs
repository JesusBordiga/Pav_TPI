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
using Shopping_Buy_All.ABMS.ABM_TipoVehiculo;
//using Shopping_Buy_All.ABMS.ABM_Estado_Civil;
//using Shopping_Buy_All.ABMS.
//using Shopping_Buy_All.ABMS.
//using Shopping_Buy_All.ABMS.
//using Shopping_Buy_All.ABMS.
//using Shopping_Buy_All.ABMS.

namespace Shopping_Buy_All
{
    public partial class Vehiculos_Ventana : Form
    {
        public Vehiculos_Ventana()
        {
            InitializeComponent();
        }

        private void Alta_Cliente(object sender, EventArgs e)
        {
            VehicleType_Load typevehicleload = new VehicleType_Load();
            typevehicleload.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VehicleType_Modify VehicleTypemodify = new VehicleType_Modify();
            VehicleTypemodify.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VehicleType_Delete VehicleTypedelete = new VehicleType_Delete();
            VehicleTypedelete.ShowDialog();
        }
    }
}
