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
using Shopping_Buy_All.ABM_Tipo_Tarjeta;

namespace Shopping_Buy_All
{
    public partial class MarcaTarjeta_Ventana : Form
    {
        public MarcaTarjeta_Ventana()
        {
            InitializeComponent();
        }

        private void Alta_Cliente(object sender, EventArgs e)
        {
            Client_Load load = new Client_Load();
            load.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client_Modify modify = new Client_Modify();
            modify.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client_Delete delete = new Client_Delete();
            delete.ShowDialog();
        }

        private void Clientes_Ventana_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            TipoTarjeta_Load TipoTarjetadelete = new TipoTarjeta_Load();
            TipoTarjetadelete.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TipoTarjeta_Modify TipoTarjetaModify = new TipoTarjeta_Modify();
            TipoTarjetaModify.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TipoTarjeta_Delete TipoTarjetadelete = new TipoTarjeta_Delete();
            TipoTarjetadelete.ShowDialog();
        }
    }
}
