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
                string userName = TxtUser.Text.ToLower();
                string password = TxtPassword.Text;
                bool resultado = false;
                User usu = new User(userName, password);
                try
                {
                    
                    resultado = Validate_Exist(usu);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error, Base de datos no encontrada!");
                }
                if (resultado == true)
                {
                   btnEstadisticas LoggedWindow = new btnEstadisticas(usu);
                   LoggedWindow.Show();
                   Hide();
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
        private bool Validate_Exist(User usu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "getUsuarioNoBorrado @nombreUsuario, @hash";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", usu.userName);
                cmd.Parameters.AddWithValue("@hash", Utils.UserToSHA256(usu.userName, usu.password));
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable table = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                if (table.Rows.Count == 1)
                {
                    usu.permiso = (int)table.Rows[0]["Permiso"];
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
