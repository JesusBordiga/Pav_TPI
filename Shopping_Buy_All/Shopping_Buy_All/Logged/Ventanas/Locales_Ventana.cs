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
    public partial class Locales_Ventana : Form
    {
        public Locales_Ventana()
        {
            InitializeComponent();
        }
        private void btnAltaLocal_btn(object sender, EventArgs e)
        {
            Local_Load Localload = new Local_Load();
            Localload.ShowDialog();
        }
        private void btnModificarLocal_btn(object sender, EventArgs e)
        {
            Local_Modify Localmodify = new Local_Modify();
            Localmodify.ShowDialog();
        }
        private void btnEliminarLocal_Click(object sender, EventArgs e)
        {
            Local_Delete Localdelete = new Local_Delete();
            Localdelete.ShowDialog();
        }

        private void btnAltaTipoComercio_Click(object sender, EventArgs e)
        {
            TipoComercio_Load TipoComercioload = new TipoComercio_Load();
            TipoComercioload.ShowDialog();
        }

        private void btnModificarTipoComercio_Click(object sender, EventArgs e)
        {
            TipoComercio_Modify TipoComerciomodify = new TipoComercio_Modify();
            TipoComerciomodify.ShowDialog();
        }

        private void btnEliminarTipoComercio_Click(object sender, EventArgs e)
        {
            TipoComercio_Delete TipoComerciodelete = new TipoComercio_Delete();
            TipoComerciodelete.ShowDialog();
        }
    }
}
