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

        private void Alta_Cliente(object sender, EventArgs e)
        {
            EstadoCivil_Load EstadoCivilload = new EstadoCivil_Load();
            EstadoCivilload.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EstadoCivil_Modify EstadoCivilmodify = new EstadoCivil_Modify();
            EstadoCivilmodify.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EstadoCivil_Delete EstadoCivildelete = new EstadoCivil_Delete();
            EstadoCivildelete.ShowDialog();
        }
    }
}
