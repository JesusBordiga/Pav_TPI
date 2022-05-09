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

        private void btnAltaTipoVehiculo_Click(object sender, EventArgs e)
        {
            VehicleType_Load VehicleTypeLoad = new VehicleType_Load();
            VehicleTypeLoad.ShowDialog();
        }

        private void btnModificarTipoVehiculo_Click(object sender, EventArgs e)
        {
            VehicleType_Modify VehicleTypeModify = new VehicleType_Modify();
            VehicleTypeModify.ShowDialog();
        }

        private void btnEliminarTipoVehiculo_Click(object sender, EventArgs e)
        {
            VehicleType_Delete VehicleTypeDelete = new VehicleType_Delete();
            VehicleTypeDelete.ShowDialog();
        }

        private void btnAltaVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarcaVehiculo_Ventana MarcaVehiculo = new MarcaVehiculo_Ventana();
            MarcaVehiculo.ShowDialog();
        }
    }
}
