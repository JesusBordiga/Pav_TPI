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
    public partial class Profesiones_Ventana : Form
    {
        public Profesiones_Ventana()
        {
            InitializeComponent();
        }
        private void btnAltaProfesiones_Click(object sender, EventArgs e)
        {
            Client_Load load = new Client_Load();
            load.ShowDialog();
        }
        private void btnModificarProfesiones_Click(object sender, EventArgs e)
        {
            Client_Modify modify = new Client_Modify();
            modify.ShowDialog();
        }
        private void btnEliminarProfesiones_Click(object sender, EventArgs e)
        {
            Client_Delete delete = new Client_Delete();
            delete.ShowDialog();
        }
    }
}
