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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            User usu = new User(TxtUser.Text,TxtPassword.Text);

            Logged LoggedWindow = new Logged(usu);
            LoggedWindow.Show();
            this.Hide();


            ClearLogin();
        }
        private void ClearLogin()
        {
            TxtUser.Text = "";
            TxtPassword.Text = "";
        }
        private bool Validate_Exist()
        {
            if (Validate())
            {
                return true;
            }
            return false; 
        }

        private bool Validate()
        {
            if (TxtUser.Text.Equals("") || TxtPassword.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
