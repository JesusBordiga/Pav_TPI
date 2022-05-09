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
using Shopping_Buy_All.ABM_Estado_Civil;

namespace Shopping_Buy_All
{
    public partial class EstadoCivil_Ventana : Form
    {
        public EstadoCivil_Ventana()
        {
            InitializeComponent();
        }

        private void btnAltaEstadoCivil_Click(object sender, EventArgs e)
        {
            EstadoCivil_Load estadoCivilLoad = new EstadoCivil_Load();
            estadoCivilLoad.ShowDialog();
        }

        private void btnModificarEstadoCivil_Click(object sender, EventArgs e)
        {
            EstadoCivil_Modify estadoCivilModify = new EstadoCivil_Modify();
            estadoCivilModify.ShowDialog();
        }

        private void btnEliminarEstadoCivil_Click(object sender, EventArgs e)
        {
            EstadoCivil_Delete estadoCivilDelete = new EstadoCivil_Delete();
            estadoCivilDelete.ShowDialog();
        }
    }
}
