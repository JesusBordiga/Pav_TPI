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
using Shopping_Buy_All.Productos;

namespace Shopping_Buy_All
{
    public partial class Productos_Ventana : Form
    {
        public Productos_Ventana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product_Load loadp = new Product_Load();
            loadp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product_Modify modifyp = new Product_Modify();
            modifyp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product_Delete deletep = new Product_Delete();
            deletep.ShowDialog();
        }

    }
}
