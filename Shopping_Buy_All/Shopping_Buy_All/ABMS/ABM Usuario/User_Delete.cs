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
    public partial class User_Delete : Form
    {
        public User_Delete()
        {
            InitializeComponent();
        }
        private void User_Delete_Load(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            btnDeleteUser.Visible = false;
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

        private void Clean()
        {
            textUsernameUser.Text = "";
        }
        
        private bool Buscar_Usuario_Nombre(string username)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Users where NombreDeUsuario like @username AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    cn.Close();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    tablaUsuarios.DataSource = tabla;
                    resultado = true;
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
            return resultado;

        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
            CargarTablaUsuarios();
            btnDeleteUser.Visible = false;
            btnSearch.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textUsernameUser.Text.Trim() == "")
            {
                MessageBox.Show("Error, Debe completar los campos!!");
            }
            else
            {
                bool existe = Buscar_Usuario_Nombre(textUsernameUser.Text.Trim());
                if (existe)
                {
                    tablaUsuarios.Visible = true;
                    btnDeleteUser.Visible = true;
                    btnSearch.Visible = false;
                }
                else
                {
                    MessageBox.Show("El usuario que busca no existe o fue borrado!");
                }
            }
        }
        private bool BorrarUsuario(string username)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Users SET Borrado = 1 WHERE NombreDeUsuario = @username AND Borrado like 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", username);
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

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            string username = textUsernameUser.Text.Trim();
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = (
                  " | Nombre de Usuario: " + username + " |" + "\n" + "\n" + " | Desea eliminar a este usuario??");

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                bool resultado = BorrarUsuario(username);
                if (resultado)
                {
                    MessageBox.Show("Usuario Borrado con éxito!");
                    Clean();
                    btnDeleteUser.Visible = false;
                    btnSearch.Visible = true;
                    CargarTablaUsuarios();
                    textUsernameUser.Focus();
                }
                else
                {
                    MessageBox.Show("El Usuario No fue Borrado!");
                }
            }
            else
            {
                textUsernameUser.Focus();
            }
        }

        private void tablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaUsuarios.Rows[indice];
            string username = filaSeleccionada.Cells["NombreDeUsuario"].Value.ToString();
            Clean();
            Cargar_Campos(username);
            btnDeleteUser.Visible = true;
        }

        private void Cargar_Campos(string username)
        {
            textUsernameUser.Text = username;
        }
    }
}
