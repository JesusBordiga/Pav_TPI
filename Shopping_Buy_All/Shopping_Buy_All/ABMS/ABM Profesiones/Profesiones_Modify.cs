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

namespace Shopping_Buy_All
{
    public partial class Profesiones_Modify : Form
    {
        public Profesiones_Modify()
        {
            InitializeComponent();
            CargarTablaProfesiones();
        }

        private void btnBuscarCliente_click(object sender, EventArgs e)
        {
            if (textNombreProfesion.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
            Profesion p = Buscar_Profesion(textNombreProfesion.Text);
            Cargar_Campos(p);
            SearchPanel.Visible=false;
            btnSearchProfesion.Visible=false;
            label2.Visible = true;
            textNuevoNombre.Visible = true;
            }
        }
        private void btnSearchClient2_Click(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnSearchProfesion.Visible = true;
            label2.Visible = false;
            textNuevoNombre.Visible = false;

        }
        private void Clean()
        {
            textNombreProfesion.Text = "";
            textNuevoNombre.Text = "";
            label2.Visible = false;
            textNuevoNombre.Visible = false;
            btnProfesionLoad.Visible = false;

        }
        private void Cargar_Campos(Profesion p)
        {
            //Cargar Nombre de la profesion
            textNombreProfesion.Text = p.NombreProfesion;
        }
  
        
        private void CargarTablaProfesiones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Profesiones WHERE Borrado like 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
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
        }
        private Profesion Buscar_Profesion(string Nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Profesion prof = new Profesion();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Profesiones where Nombre like @nombre AND Borrado like 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", Nombre);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader !=null && DataReader.Read())
                {
                    prof.NombreProfesion = DataReader["Nombre"].ToString();
                }
            }
            catch (Exception )
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return prof;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        public void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaProfesiones.Rows[indice];
            string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
            Profesion p = Buscar_Profesion(nombre);
            Clean();
            SearchPanel.Visible = false;
            btnSearchProfesion.Visible = false;
            label4.Visible = true;
            Cargar_Campos(p);
        }

        private Profesion ObtenerDatosProfesion()
        {
            Profesion p = new Profesion();

            //Nombre de la profesion
            p.NombreProfesion = textNuevoNombre.Text.Trim();

            return p;

        }

        private bool ModificarProfesion(Profesion prof)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Profesiones SET Nombre = @nombre WHERE Nombre Like @nombreViejo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", prof.NombreProfesion);
                cmd.Parameters.AddWithValue("@nombreViejo", textNombreProfesion.Text);
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

        private void btnClientLoad_Click_1(object sender, EventArgs e)
        {
            Profesion p = ObtenerDatosProfesion();
            bool resultado = ModificarProfesion(p);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (
                      " |Nuevo Nombre: " + p.NombreProfesion + " |");

                string titulo = "Información de Carga";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Profesion agregado con éxito!");
                    Clean();
                    CargarTablaProfesiones();
                    label2.Visible = false;
                    textNuevoNombre.Visible = false;
                    btnProfesionLoad.Visible = false;


                }
                else
                {
                    textNombreProfesion.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar la persona!");
            }
        }
    }
}
