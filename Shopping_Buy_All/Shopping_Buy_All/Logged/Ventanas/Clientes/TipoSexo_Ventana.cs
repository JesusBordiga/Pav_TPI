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
using Shopping_Buy_All.ABM_Sexo;

namespace Shopping_Buy_All
{
    public partial class TipoSexo_Ventana : Form
    {
        public TipoSexo_Ventana()
        {
            InitializeComponent();
        }

        private void Alta_Cliente(object sender, EventArgs e)
        {
            Sexo_Load Sexoload = new Sexo_Load();
            Sexoload.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sexo_Modify Sexomodify = new Sexo_Modify();
            Sexomodify.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sexo_Delete Sexodelete = new Sexo_Delete();
            Sexodelete.ShowDialog();
        }
    }
}
