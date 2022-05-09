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
    public partial class Tarjeta_Delete : Form
    {
        public Tarjeta_Delete()
        {
            InitializeComponent();

        }
        private void Tarjeta_Delete_Load(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            btnDeleteTarjeta.Visible = false;
            CargarTablaTarjetas();
        }
        private void CargarTablaTarjetas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM TarjetaXCliente WHERE Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaTarjetas.DataSource = tabla;
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
            textNroTarjeta.Text = "";
        }
        private Tarjeta Cargar_Tarjeta(string NroTarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Tarjeta card = new Tarjeta();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TarjetaXCliente where NroTarjeta like @nroTarjeta AND Borrado = 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTarjeta", NroTarjeta);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    card.TipoDocumentoTarjeta = int.Parse(DataReader["TipoDocumento"].ToString());
                    card.NroDocumentoTarjeta = DataReader["NroDocumento"].ToString();
                    card.NroTarjetaCliente = DataReader["NroTarjeta"].ToString();
                    card.IdMarcaTarjeta = int.Parse(DataReader["IdMarca"].ToString());
                    card.IdTipoTarjeta = int.Parse(DataReader["IdTipo"].ToString());
                    
                }
                cn.Close();

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                tablaTarjetas.DataSource = tabla;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return card;

        }
        private bool Buscar_Tarjeta1(string NroTarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Tarjeta card = new Tarjeta();
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TarjetaXCliente where NroTarjeta like @nroTarjeta AND Borrado = 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTarjeta", NroTarjeta);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    card.TipoDocumentoTarjeta = int.Parse(DataReader["TipoDocumento"].ToString());
                    card.NroDocumentoTarjeta = DataReader["NroDocumento"].ToString();
                    card.NroTarjetaCliente = DataReader["NroTarjeta"].ToString();
                    card.IdMarcaTarjeta = int.Parse(DataReader["IdMarca"].ToString());
                    card.IdTipoTarjeta = int.Parse(DataReader["IdTipo"].ToString());
                    cn.Close();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    tablaTarjetas.DataSource = tabla;
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
              CargarTablaTarjetas();
              btnDeleteTarjeta.Visible = false;
              btnSearch.Visible = true;
            }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textNroTarjeta.Text.Trim().Equals(""))
                {
                MessageBox.Show("Error, Debe completar los campos!!");
                }
            else
                {
                bool existe = Buscar_Tarjeta1(textNroTarjeta.Text.Trim());
                if (existe)
                    {
                    tablaTarjetas.Visible = true;
                    btnDeleteTarjeta.Visible = true;
                    btnSearch.Visible = false;
                    }
                else
                    {
                    MessageBox.Show("La tarjeta que busca no existe o fue borrado!");
                    }
                }
        }
        private bool BorrarTarjeta(string NroTarjeta, int Borrado)
        {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE TarjetaXCliente SET Borrado = @borrado WHERE NroTarjeta Like @nroTarjeta AND Borrado like 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTarjeta", NroTarjeta);
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

        private void btnDeleteTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta c = Cargar_Tarjeta(textNroTarjeta.Text.Trim());
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = (
                  " |Tipo Documento: " + c.TipoDocumentoTarjeta + " |Numero Documento: " + c.NroDocumentoTarjeta + "|" + "\n"
                + " |Nro Tarjeta: " + c.NroTarjetaCliente + " |Marca: " + c.IdMarcaTarjeta + "|" + "\n"
                + " |Tipo: " + c.IdTipoTarjeta + "\n" + "\n" + " |Desea eliminar a esta tarjeta??");

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                bool resultado = BorrarTarjeta(textNroTarjeta.Text.Trim(), 1);
                if (resultado)
                {
                    MessageBox.Show("Tarjeta Borrado con éxito!");
                    Clean();
                    btnDeleteTarjeta.Visible = false;
                    btnSearch.Visible = true;
                    CargarTablaTarjetas();
                    textNroTarjeta.Focus();
                }
                else
                {
                    MessageBox.Show("La Tarjeta No fue Borrado!");
                }
            }
            else
            {
                textNroTarjeta.Focus();
            }
        }

        private void Cargar_Campos(Tarjeta c)
        {

            //Cargar Documento
            textNroTarjeta.Text  = c.NroDocumentoTarjeta;
        }
        private Tarjeta Buscar_Tarjeta2(string NroTarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Tarjeta card = new Tarjeta();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TarjetaXCliente WHERE NroTarjeta like @nroTarjeta AND Borrado = 0 ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTarjeta", NroTarjeta);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader != null && DataReader.Read())
                {
                    card.TipoDocumentoTarjeta = int.Parse(DataReader["TipoDocumento"].ToString());
                    card.NroDocumentoTarjeta = DataReader["NroDocumento"].ToString();
                    card.NroTarjetaCliente = DataReader["NroTarjeta"].ToString();
                    card.IdMarcaTarjeta = int.Parse(DataReader["IdMarca"].ToString());
                    card.IdTipoTarjeta = int.Parse(DataReader["IdTipo"].ToString());
                    cn.Close();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    tablaTarjetas.DataSource = tabla;
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
            return card;

        }

        private void tablaTarjetas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaTarjetas.Rows[indice];
            string nroTarjeta = filaSeleccionada.Cells["NroTarjeta"].Value.ToString();
            Tarjeta c = Buscar_Tarjeta2(nroTarjeta);
            Clean();
            Cargar_Campos(c);
            btnDeleteTarjeta.Visible = true;
        }
    }
}

