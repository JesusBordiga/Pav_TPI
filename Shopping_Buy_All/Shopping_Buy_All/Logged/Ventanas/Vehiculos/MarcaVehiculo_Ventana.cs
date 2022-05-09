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

namespace Shopping_Buy_All
{
    public partial class MarcaVehiculo_Ventana : Form
    {
        public MarcaVehiculo_Ventana()
        {
            InitializeComponent();
        }

        private void btnAltaVehicleType_Click(object sender, EventArgs e)
        {
            VehicleType_Load VehicleTypeLoad = new VehicleType_Load();
            VehicleTypeLoad.ShowDialog();
        }

        private void btnModificarVehicleType_Click(object sender, EventArgs e)
        {
            VehicleType_Modify VehicleTypeModify = new VehicleType_Modify();
            VehicleTypeModify.ShowDialog();
        }

        private void btnEliminarVehicleType_Click(object sender, EventArgs e)
        {
            VehicleType_Delete VehicleTypeDelete = new VehicleType_Delete();
            VehicleTypeDelete.ShowDialog();
        }
    }
}
