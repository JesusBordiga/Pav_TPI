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
    public partial class TipoDocumento_Ventana : Form
    {
        public TipoDocumento_Ventana()
        {
            InitializeComponent();
        }

        private void Alta_Cliente(object sender, EventArgs e)
        {
            TipoDoc_Load TípoDocload = new TipoDoc_Load();
            TípoDocload.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TipoDoc_Modify TípoDocmodify = new TipoDoc_Modify();
            TípoDocmodify.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TipoDoc_Delete TípoDocdelete = new TipoDoc_Delete();
            TípoDocdelete.ShowDialog();
        }

        private void Clientes_Ventana_Load(object sender, EventArgs e)
        {

        }

    }
}
