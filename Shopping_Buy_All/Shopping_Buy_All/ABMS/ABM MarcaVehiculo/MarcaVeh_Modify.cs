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
    public partial class MarcaVeh_Modify : Form
    {
        public MarcaVeh_Modify()
        {
            InitializeComponent();
            CargarTablaMarcasVeh();
            CargarMarcasVeh();

        }

        private void btnBuscarMarca_click(object sender, EventArgs e)
        {
            if (cmbMarcaVeh.SelectedIndex != 0)
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                MarcaVehiculo c = Buscar_Marca(cmbMarcaVeh.Text.Trim());
                Cargar_Campos(c);
                btnBuscarMarca.Visible = false;
            }
        }
        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            Clean();
            btnBuscarMarca.Visible = true;

        }
        private void Clean()
        {
            cmbMarcaVeh.SelectedIndex = -1;

        }
        private void Cargar_Campos(MarcaVehiculo c)
        {

            cmbMarcaVeh.Text = c.MarcaVeh;
            textMarcaNew.Text = c.MarcaVeh;
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
        private void CargarTablaMarcasVeh()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Marcas WHERE Borrado like 0";

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
        private MarcaVehiculo Buscar_Marca(string Marca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            MarcaVehiculo mark = new MarcaVehiculo();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Marcas where Descripcion like @marcaVeh AND Borrado = 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marcaVeh", Marca);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader !=null && DataReader.Read())
                {

                    mark.MarcaVeh = DataReader["TipoDocumento"].ToString();

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
            return mark;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private MarcaVehiculo ObtenerMarcaOld()
        {
            MarcaVehiculo c = new MarcaVehiculo();

            c.MarcaVeh = cmbMarcaVeh.Text.Trim();

            return c;
        }

        private MarcaVehiculo ObtenerMarcaNew()
        {
            MarcaVehiculo c = new MarcaVehiculo();

            c.MarcaVeh = textMarcaNew.Text.Trim();

            return c;
        }

        private bool ModificarMarca(MarcaVehiculo marcaNew, MarcaVehiculo marcaOld)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Marcas SET Descripcion = @marcaNew WHERE Descripcion = @marcaOld";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marcaNew", marcaNew.MarcaVeh);
                cmd.Parameters.AddWithValue("@marcaOld", marcaOld.MarcaVeh);
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

        //private void btnMarcaMod_Click_1(object sender, EventArgs e)
        //{
        //    MarcaVehiculo oldM = ObtenerMarcaOld();
        //    MarcaVehiculo newM = ObtenerMarcaNew();
        //    bool resultado = ModificarMarca();
        //    if (resultado)
        //    {
        //        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        //        String mensajeCarga = (
        //              " |Marca: " + c.MarcaVeh + "\n");

        //        string titulo = "Información de Carga";

        //        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

        //        if (result == DialogResult.OK)
        //        {
        //            MessageBox.Show("Marca agregada con éxito!");
        //            Clean();
        //            CargarTablaMarcasVeh();
        //            CargarMarcasVeh();
        //        }
        //        else
        //        {
        //            textMarcaOld.Focus();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error al modificar la persona!");
        //    }
        //}

        private void tablaMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaMarcas.Rows[indice];
                string marcaVeh = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                MarcaVehiculo c = Buscar_Marca(marcaVeh);
                Clean();
                btnBuscarMarca.Visible = false;
                cmbMarcaVeh.Visible = true;
                Cargar_Campos(c);
            }
            catch (Exception)
            {

                MessageBox.Show("Error! Seleccione una casilla dentro de la tabla");
            }
        }

        private void btnMarcaMod_Click(object sender, EventArgs e)
        {

        }
    }
}
