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
    public partial class Profesiones_Load : Form
    {
        public Profesiones_Load()
        {
            InitializeComponent();
            CargarTablaProfesiones();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            textNombreProfesion.Text = "";
            CargarTablaProfesiones();
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
        private Profesion ObtenerDatosProfesion()
        {
            Profesion p = new Profesion();

            if (textNombreProfesion.Text.Equals(""))
            {
                MessageBox.Show("Error al cargar la profesion \n" +
                                 "Complete el campo por favor!");
                textNombreProfesion.Focus();
            }
            else
            {
                //Nombre De Profesion
                p.NombreProfesion = textNombreProfesion.Text.Trim(); ;
            }

            return p;
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            Profesion p = ObtenerDatosProfesion();
            bool resultado = Agregar_Profesion(p);
            if (resultado)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    String mensajeCarga = (" |Nombre: " + p.NombreProfesion + "|");

                    string titulo = "Información de Carga";

                    DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Profesion agregada con éxito!");
                        Clean();
                        CargarTablaProfesiones();
                    }
                    else
                    {
                        textNombreProfesion.Focus();
                    }
                }
            else
            {
                MessageBox.Show("Error al cargar la profesion!");
            }
        }

        private bool Agregar_Profesion(Profesion prof)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Profesiones(Nombre)" + "Values(@nomProfesion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomProfesion", prof.NombreProfesion);
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

        private void Profesiones_Load_Load(object sender, EventArgs e)
        {
            this.profesionesTableAdapter.Fill(this.bD3K7G01_2022DataSet.Profesiones);

        }
    }
}
