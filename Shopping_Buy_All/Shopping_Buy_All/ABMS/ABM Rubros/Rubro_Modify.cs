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
    public partial class Rubro_Modify : Form
    {
        public Rubro_Modify()
        {
            InitializeComponent();
            CargarTablaUsuarios();
        }

        private void Clean()
        {
            textRubroOld.Text = "";
            textRubroNew.Text = "";
            textRubroOld.Visible = true;
            textRubroNew.Visible = false;
            btnUserLoad.Visible = false;
            btnSearchUser.Visible = true;
        }

        private void Cargar_Campos(string username)
        {
            //Cargar Nombre Original
            textRubroOld.Text = username;
            //Cargar Nombre Nuevo
            textRubroNew.Text = username;
            btnUserLoad.Visible = true;
            textRubroOld.Visible = false;
            textRubroNew.Visible = true;
            btnSearchUser.Visible = false;
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

        private bool Buscar_Usuario(string username)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Users WHERE NombreDeUsuario = @username AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", username);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    result = true;
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
            return result;
        }

        private User ObtenerDatos()
        {
            User u = new User(textRubroNew.Text.Trim());
            return u;
        }

        private bool ModificarUsuario(User u, string old_username)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Users SET NombreDeUsuario = @username,PasswordHash = @hash WHERE NombreDeUsuario = @olduser";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", u.userName);
                cmd.Parameters.AddWithValue("@hash", Utils.UserToSHA256(u.userName, u.password));
                cmd.Parameters.AddWithValue("@olduser", old_username);
                cmd.CommandType = CommandType.Text;
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

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (textRubroOld.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                string username = textRubroOld.Text.Trim().ToLower();
                bool existe = Buscar_Usuario(username);
                if (existe)
                {
                    Cargar_Campos(username);
                }
                else
                {
                    Clean();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnUserLoad_Click(object sender, EventArgs e)
        {
            if (textRubroNew.Text.Trim() != "" && textPasswordUser.Text.Trim() != "" && textConfirmPasswordUser.Text.Trim() == textPasswordUser.Text.Trim())
            {
                User u = ObtenerDatos();
                string oldUser = textRubroOld.Text.Trim().ToLower();
                bool resultado = ModificarUsuario(u, oldUser);
                if (resultado)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    String mensajeCarga = (
                          " | Nombre de Usuario: " + u.userName + " |" + "\n");

                    string titulo = "Información de Producto";

                    DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Usuario modificado con éxito!");
                        Clean();
                        CargarTablaUsuarios();
                    }
                    else
                    {
                        textRubroOld.Focus();
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
                            "Complete los campos por favor!");
            }
        }

        private void tablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaUsuarios.Rows[indice];
            string username = filaSeleccionada.Cells["NombreDeUsuario"].Value.ToString();
            Cargar_Campos(username);
        }
    }
}
