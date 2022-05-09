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
    public partial class MarcaVeh_Delete : Form
    {
        public MarcaVeh_Delete()
        {
            InitializeComponent();

        }
        private void Marca_Delete_Load(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            btnDeleteMarca.Visible = false;
            CargarMarcasVeh();
            CargarTablaMarcasVeh();
        }
        private void CargarTablaMarcasVeh()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Marcas WHERE Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaMarcas.DataSource = tabla;
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
        private void CargarMarcasVeh()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Marcas where Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                cmbMarcaVeh.DataSource = tabla;
                cmbMarcaVeh.DisplayMember = "Descripcion";
                cmbMarcaVeh.ValueMember = "Id";
                cmbMarcaVeh.SelectedIndex = -1;
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
            cmbMarcaVeh.SelectedIndex = -1;
        }
        private MarcaVehiculo Cargar_Marca(string MarcaVeh)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            MarcaVehiculo mark = new MarcaVehiculo();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Marcas where Descripcion like @marca AND Borrado = 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marca", MarcaVeh);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {

                    mark.MarcaVeh = DataReader["Descripcion"].ToString();
                    
                }
                cn.Close();

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                tablaMarcas.DataSource = tabla;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return mark;

        }
        private bool Buscar_Marca1(string MarcaVeh)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            MarcaVehiculo mark = new MarcaVehiculo();
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Marcas where Descripcion like @marca AND Borrado = 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marca", MarcaVeh);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    mark.MarcaVeh = DataReader["TipoDocumento"].ToString();

                    cn.Close();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    tablaMarcas.DataSource = tabla;
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
              CargarTablaMarcasVeh();
              btnDeleteMarca.Visible = false;
              btnSearch.Visible = true;
            }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((int)cmbMarcaVeh.SelectedValue == 0)
                {
                MessageBox.Show("Error, Debe completar los campos!!");
                }
            else
                {
                bool existe = Buscar_Marca1(cmbMarcaVeh.SelectedValue.ToString());
                if (existe)
                    {
                    tablaMarcas.Visible = true;
                    btnDeleteMarca.Visible = true;
                    btnSearch.Visible = false;
                    }
                else
                    {
                    MessageBox.Show("La marca que busca no existe o fue borrado!");
                    }
                }
        }
        private bool BorrarMarca(string MarcaVeh)
        {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE * FROM Marcas where Descripcion like @marca AND Borrado = 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marca", MarcaVeh);

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

        private void btnDeleteMarca_Click(object sender, EventArgs e)
        {
            MarcaVehiculo c = Cargar_Marca(cmbMarcaVeh.SelectedValue.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = (
                  " |Marca: " + c.MarcaVeh + "\n" + "\n" + " |Desea eliminar a esta marca??");

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                bool resultado = BorrarMarca(cmbMarcaVeh.SelectedValue.ToString());
                if (resultado)
                {
                    MessageBox.Show("Marca Borrada con éxito!");
                    Clean();
                    CargarMarcasVeh();
                    btnDeleteMarca.Visible = false;
                    btnSearch.Visible = true;
                    CargarTablaMarcasVeh();
                    cmbMarcaVeh.Focus();
                }
                else
                {
                    MessageBox.Show("La Marca No fue Borrada!");
                }
            }
            else
            {
                cmbMarcaVeh.Focus();
            }
        }

        private void Cargar_Campos(MarcaVehiculo c)
        {

            cmbMarcaVeh.SelectedValue = c.MarcaVeh;

        }
        private MarcaVehiculo Buscar_Marca2(string MarcaVeh)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            MarcaVehiculo mark = new MarcaVehiculo();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Marcas WHERE Descripcion like @marca AND Borrado = 0 ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marca", MarcaVeh);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    mark.MarcaVeh = DataReader["Descripcion"].ToString();

                    cn.Close();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    tablaMarcas.DataSource = tabla;
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
            return mark;

        }

        private void tablaMarcas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaMarcas.Rows[indice];
            string marca = filaSeleccionada.Cells["Marca"].Value.ToString();
            MarcaVehiculo c = Buscar_Marca2(marca);
            Clean();
            Cargar_Campos(c);
            btnDeleteMarca.Visible = true;
        }
    }
}

