using Shopping_Buy_All.ABMS.AccesoADatos;
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
    public partial class MarcaTarjeta_Load : Form
    {
        public MarcaTarjeta_Load()
        {
            InitializeComponent();
            CargarTablaMarcas();
        }

        //ACCESO A BASE DE DATOS
        private void CargarTablaMarcas()
        {
            try
            {
                tablaMarcas.DataSource = AD_MarcaTarjeta.CargarTablaMarcas();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la carga de Marcas");
            }
        }

        //BOTONES
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string marca = ObtenerNombreMarca();
                if (!AD_MarcaTarjeta.ExisteMarca(marca))
                {
                    bool resultado = AD_MarcaTarjeta.Agregar_Marca(marca);
                    if (resultado)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = (
                              " | Nombre: " + marca + "\n");

                        string titulo = "Información de Carga";

                        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Marca agregada con éxito!");
                            Clean();
                            CargarTablaMarcas();
                        }
                        else
                        {
                            textMarca.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar la Marca! \n" +
                                "Complete los campos por favor!");
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar la Marca! \n" +
                        "Esta marca ya existe!");
                }
            }
            else
            {
                MessageBox.Show("Error al cargar la Marca! \n" +
                        "Complete los campos correctamente por favor!");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        //FUNCIONES
        private void Clean()
        {
            textMarca.Text = "";
            CargarTablaMarcas();
        }
        
        private string ObtenerNombreMarca()
        {
            string rubro = textMarca.Text.Trim();
            return rubro;
        }
                
        private bool ValidarCampos()
        {
            if (textMarca.Text.Trim() == "" || textMarca.Text.Trim().Length > 50)
            {
                return false;
            }
            return true;
        }
    }
}
