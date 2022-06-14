using System;
using System.Windows.Forms;
using Shopping_Buy_All.ABMS.ABM_Profesiones;


namespace Shopping_Buy_All
{
    public partial class Profesiones_Ventana : Form
    {
        public Profesiones_Ventana()
        {
            InitializeComponent();
        }
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            Profesion_Load Profesion_Load = new Profesion_Load();
            Profesion_Load.ShowDialog();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Profesion_Modify Profesion_Modify = new Profesion_Modify();
            Profesion_Modify.ShowDialog();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Profesion_Delete Profesion_Delete = new Profesion_Delete();
            Profesion_Delete.ShowDialog();
        }
    }
}
