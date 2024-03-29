﻿using System;
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
    public partial class Usuarios_Ventana : Form
    {
        public Usuarios_Ventana()
        {
            InitializeComponent();
        }
        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            User_Load Userload = new User_Load();
            Userload.ShowDialog();
        }

        private void btnModifyUsuario_Click(object sender, EventArgs e)
        {
            User_Modify user_modify = new User_Modify();
            user_modify.ShowDialog();
        }

        private void btnDeleteUsuario_Click(object sender, EventArgs e)
        {
            User_Delete user_delete = new User_Delete();
            user_delete.ShowDialog();
        }
    }
}
