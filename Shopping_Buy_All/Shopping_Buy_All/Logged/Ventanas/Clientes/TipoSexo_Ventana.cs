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

        private void btnAltaSexo_Click(object sender, EventArgs e)
        {
            Sexo_Load sexoLoad = new Sexo_Load();
            sexoLoad.ShowDialog();
        }

        private void btnModificarSexo_Click(object sender, EventArgs e)
        {
            Sexo_Modify sexoModify = new Sexo_Modify();
            sexoModify.ShowDialog();
        }

        private void btnEliminarSexo_Click(object sender, EventArgs e)
        {
            Sexo_Delete sexoDelete = new Sexo_Delete();
            sexoDelete.ShowDialog();
        }
    }
}
