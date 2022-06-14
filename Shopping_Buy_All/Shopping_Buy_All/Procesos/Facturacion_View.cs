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
using Shopping_Buy_All.Productos;

namespace Shopping_Buy_All
{
    public partial class Facturacion_View : Form
    {
        public Facturacion_View()
        {
            InitializeComponent();
        }
        private DataTable ObtenerFacturas(string nroFactura)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * From ComprasPorCliente";
                comand.Parameters.Clear();
                comand.Parameters.AddWithValue("@nroFactura", nroFactura);
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                return tabla;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo obtener facturas.\nError en la base de datos.", "ERROR");
                throw;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener facturas.\nError en la base de datos.", "ERROR");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void buttonTarjeta_Click(object sender, EventArgs e)
        {
            if (textNroFactura.Text != "")
            {
                tablaFacturas.DataSource = ObtenerFacturas(textNroFactura.Text);
                if (tablaFacturas.Rows.Count == 0)
                {
                    MessageBox.Show("La factura no existe");
                }
            }
            else
            {
                MessageBox.Show("Complete el campo");
            }
        }
    }
}
