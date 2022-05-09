using Shopping_Buy_All.Entidades;
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


namespace Shopping_Buy_All
{
    public partial class User_Load : Form
    {
        public User_Load()
        {
            InitializeComponent();
            CargarTablaUsuarios();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            textUsernameUser.Text = "";
            textPasswordUser.Text = "";
            textConfirmPasswordUser.Text = "";
            CargarTablaUsuarios();
        }

        private void CargarTablaUsuarios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Users WHERE Borrado like 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaUsuarios.DataSource = tabla;
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

        private User ObtenerDatosUsuario()
        {
            User u = new User(textUsernameUser.Text, textPasswordUser.Text);
            return u;
        }
        
        private void btnCargarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                User u = ObtenerDatosUsuario();
                bool resultado = Agregar_Usuario(u);
                if (resultado)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    String mensajeCarga = (
                          " |Nombre de Usuario: " + u.userName + "\n");

                    string titulo = "Información de Carga";

                    DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Usuario agregado con éxito!");
                        Clean();
                        CargarTablaUsuarios();
                    }
                    else
                    {
                        textUsernameUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar el Usuario! \n" +
                            "Complete los campos por favor!");
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el Usuario! \n" +
                        "Complete los campos correctamente por favor!");
            }
        }
        
        private bool Agregar_Usuario(User u)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Users(NombreDeUsuario,PasswordHash)" +
                                               "VALUES(@userName,@hash)";
                                               //"Values(@userName,'@userName'+':'+'@password')";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@userName", u.userName);
                cmd.Parameters.AddWithValue("@hash", Utils.UserToSHA256(u.userName, u.password));
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }

        private bool ValidarCampos()
        {
            if (textUsernameUser.Text.Trim() == "")
            {
                return false;
            }
            if (textPasswordUser.Text.Trim() == "")
            {
                return false;
            }
            if (textConfirmPasswordUser.Text.Trim() == "")
            {
                return false;
            }
            if (textConfirmPasswordUser.Text.Trim() != textPasswordUser.Text.Trim())
            {
                return false;
            }
            return true;
        }
    }
}
