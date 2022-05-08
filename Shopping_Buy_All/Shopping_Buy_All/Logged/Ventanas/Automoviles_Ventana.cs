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
    public partial class Automoviles_Ventana : Form
    {
        public Automoviles_Ventana()
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
    }
}
