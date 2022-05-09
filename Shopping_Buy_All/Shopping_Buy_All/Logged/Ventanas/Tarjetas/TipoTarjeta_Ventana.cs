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
using Shopping_Buy_All.ABM_Tipo_Documento;

namespace Shopping_Buy_All
{
    public partial class TipoTarjeta_Ventana : Form
    {
        public TipoTarjeta_Ventana()
        {
            InitializeComponent();
        }

        private void btnAltaTipoTarjeta_Click(object sender, EventArgs e)
        {
            TipoDoc_Load tipoDocLoad = new TipoDoc_Load();
            tipoDocLoad.ShowDialog();
        }

        private void btnModificarTipoTarjeta_Click(object sender, EventArgs e)
        {
            TipoDoc_Modify tipoDocModify = new TipoDoc_Modify();
            tipoDocModify.ShowDialog();
        }

        private void btnEliminarTipoTarjeta_Click(object sender, EventArgs e)
        {
            TipoDoc_Delete tipoDocDelete = new TipoDoc_Delete();
            tipoDocDelete.ShowDialog();
        }
    }
}
