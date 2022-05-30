using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Shopping_Buy_All.ABMS.AccesoADatos;
using Shopping_Buy_All.Entidades;

namespace Shopping_Buy_All
{
    public partial class MarcaVehiculo_Load : Form
    {
        public MarcaVehiculo_Load()
        {
            InitializeComponent();
            CargarTablaMarcas();
        }
        //ACCESO A BASE DE DATOS
        private void CargarTablaMarcas()
        {
            try
            {
                tablaMarcas.DataSource = AD_MarcaVehiculo.CargarTablaMarcas();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar tabla de marcas.", "ERROR");
            }
        }
        //BOTONES
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void btnMarcaLoad_Click(object sender, EventArgs e)
        {
            MarcaVehiculo c = ObtenerDatosMarca();
            bool resultado = AD_MarcaVehiculo.Agregar_Marca(c);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = (" |Marca: " + c.MarcaVeh + "\n");

                string titulo = "Información de Carga";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Marca agregado con éxito!");
                    Clean();
                    CargarTablaMarcas();
                }
                else
                {
                    cmbMarca.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar la Marca! \n" +
                        "Complete los campos por favor!");
            }
        }

        //FUNCIONES

        private void Clean()
        {
            cmbMarca.Text = "";
            CargarTablaMarcas();

        }
        private MarcaVehiculo ObtenerDatosMarca()
        {
            MarcaVehiculo c = new MarcaVehiculo();

            c.MarcaVeh = cmbMarca.Text.Trim();

            return c;
        }


        
    }
}
