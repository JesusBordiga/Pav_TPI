﻿using Shopping_Buy_All.Entidades;
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
    public partial class User_Modify : Form
    {
        public User_Modify()
        {
            InitializeComponent();
            CargarTablaUsuarios();
        }

        private void Clean()
        {
            textUsernameUser.Text = "";
            textNewUsernameUser.Text = "";
            textPasswordUser.Text = "";
            textConfirmPasswordUser.Text = "";
            textUsernameUser.Visible = true;
            textNewUsernameUser.Visible = false;
            textPasswordUser.Visible = false;
            textConfirmPasswordUser.Visible = false;
            btnUserLoad.Visible = false;
            labelPw1.Visible = false;
            labelPw2.Visible = false;
            btnSearchUser.Visible = true;
        }

        private void Cargar_Campos(string username)
        {
            //Cargar Nombre Original
            textUsernameUser.Text = username;
            //Cargar Nombre Nuevo
            textNewUsernameUser.Text = username;
            textPasswordUser.Text = "";
            textConfirmPasswordUser.Text = "";
            btnUserLoad.Visible = true;
            textUsernameUser.Visible = false;
            textNewUsernameUser.Visible = true;
            textPasswordUser.Visible = true;
            textConfirmPasswordUser.Visible = true;
            labelPw1.Visible = true;
            labelPw2.Visible = true;
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
                MessageBox.Show("Error en la base de datos","ERROR");
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
                MessageBox.Show("Error en la base de datos", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return result;
        }

        private User ObtenerDatos()
        {
            User u = new User(textNewUsernameUser.Text.Trim(),textPasswordUser.Text.Trim());
            return u;
        }

        private bool ModificarUsuario(User u,string old_username)
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
                cmd.Parameters.AddWithValue("@hash", Utils.UserToSHA256(u.userName,u.password));
                cmd.Parameters.AddWithValue("@olduser", old_username);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo modificar el Usuario.\nError en la base de datos.", "ERROR");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (textUsernameUser.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                string username = textUsernameUser.Text.Trim().ToLower();
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
            if (ValidarCampos())
            {
                User u = ObtenerDatos();
                string oldUser = textUsernameUser.Text.Trim().ToLower();
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

        private bool ValidarCampos()
        {
            // Validar que usuario no esté vacío y no tenga más de 50 caracteres (por base de datos)
            if (textNewUsernameUser.Text.Trim() == "" || textNewUsernameUser.Text.Trim().Length > 50)
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

        private void tablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaUsuarios.Rows[indice];
                string username = filaSeleccionada.Cells["NombreDeUsuario"].Value.ToString();
                Cargar_Campos(username);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una casilla dentro de la tabla", "ERROR");
            }
        }
    }
}
