using System;
using Shopping_Buy_All.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All
{
    public partial class Logged : Form
    {
        public Logged(User usu)
        {
            InitializeComponent();
            LabelBienvenido.Text = "Bienvenido \n"+ usu.userName;
        }

        private void Logged_Load(object sender, EventArgs e)
        {
        }

        private void altaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Client_Load load = new Client_Load();
            load.ShowDialog();
        }

        private void modificacionDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client_Modify modify = new Client_Modify();
            modify.ShowDialog();
        }

        private void bajaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Client delete = new Delete_Client();
            delete.ShowDialog();
        }
    }
}
