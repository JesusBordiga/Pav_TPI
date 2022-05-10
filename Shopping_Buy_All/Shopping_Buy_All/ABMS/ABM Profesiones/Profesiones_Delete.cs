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
using Shopping_Buy_All.ABM_Cliente;

namespace Shopping_Buy_All
{
    public partial class Profesiones_Delete : Form
    {
        public Profesiones_Delete()
        {
            InitializeComponent();
        }
        private void Client_Delete_Load(object sender, EventArgs e)
        {
            tablaProfesiones.Visible = false;
            btnSearch.Visible = true;
            btnDeleteProfesion.Visible = false;
        }


        private void Clean()
        {
            textNombreProfesion.Text = "";
        }

        private Profesion Cargar_Profesion(string Nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Profesion prof = new Profesion();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Profesiones where Nombre like @nombre AND Borrado Like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", Nombre);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {

                    prof.NombreProfesion = DataReader["Nombre"].ToString();

                }
                cn.Close();

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                tablaProfesiones.DataSource = tabla;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return prof;

        }
        private bool Buscar_Profesion(string Nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Profesion prof = new Profesion();
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Profesiones WHERE Nombre like @nombre AND Borrado Like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", Nombre);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {

                    prof.NombreProfesion = DataReader["Nombre"].ToString();
                    cn.Close();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    tablaProfesiones.DataSource = tabla;
                    resultado = true;
                }
  
            }
            catch (Exception)
            {

                throw;
                resultado = false;
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
              tablaProfesiones.Visible = false;
              btnDeleteProfesion.Visible = false;
              btnSearch.Visible = true;
            }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textNombreProfesion.Text.Trim().Equals(""))
                {
                MessageBox.Show("Error, Debe completar los campos!!");
                }
            else
                {
                bool existe = Buscar_Profesion(textNombreProfesion.Text.Trim());
                if (existe)
                    {
                    tablaProfesiones.Visible = true;
                    btnDeleteProfesion.Visible = true;
                    btnSearch.Visible = false;
                    }
                else
                    {
                    MessageBox.Show("La profesion que busca no existe o fue borrado!");
                    }
                }
        }
        private bool BorrarProfesion(string Nombre, int Borrado)
        {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Profesiones SET Borrado = @borrado WHERE Nombre like @nombre AND Borrado Like 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@borrado", Borrado);
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
            Profesion p = Cargar_Profesion(textNombreProfesion.Text.Trim());
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = (
                  " |Nombre: " + p.NombreProfesion + "| \n Desea eliminar esta profesion?");

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                bool resultado = BorrarProfesion(textNombreProfesion.Text.Trim(),1);
                if (resultado)
                {
                    MessageBox.Show("Cliente Borrado con éxito!");
                    Clean();
                    //BorrarCliente(c);
                    tablaProfesiones.Visible = false;
                    btnDeleteProfesion.Visible = false;
                    btnSearch.Visible = true;
                    textNombreProfesion.Focus();
                }
                else
                {
                    MessageBox.Show("La profesion no fue borrada!");
                }
            }
            else
            {
                textNombreProfesion.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Grilla_Profesiones tabla = new Grilla_Profesiones();
            tabla.Show();
            bool creado = true;

        }
    }
}

