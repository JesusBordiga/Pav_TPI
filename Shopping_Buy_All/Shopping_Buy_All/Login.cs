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
using System.Data.SqlClient;

namespace Shopping_Buy_All
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text.Equals("") || TxtPassword.Text.Equals(""))
            {
                MessageBox.Show("Por favor complete los campos!!");
            }
            else
            {
                string userName = TxtUser.Text;
                string password = TxtPassword.Text;
                bool resultado = false;

                resultado = Validate_Exist(userName, password);
                if (resultado = true)
                {
                   User usu = new User (userName, password);
                   Logged LoggedWindow = new Logged(usu);
                   LoggedWindow.Show();
                   this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario Inexistente!");
                }
            }



            ClearLogin();
        }
        private void ClearLogin()
        {
            TxtUser.Text = "";
            TxtPassword.Text = "";
        }
        private bool Validate_Exist(string userName, string password)
        {
            
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];

            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            string consulta = "Select * FROM Users WHERE NombreDeUsuario like '"+userName+"' AND Password like '"+password+"'";
            
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable table = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);

            if (table.Rows.Count == 1)
            {
                
                return true;
            }
            else
            {
                return false;
            }
             
        }


    }
}
