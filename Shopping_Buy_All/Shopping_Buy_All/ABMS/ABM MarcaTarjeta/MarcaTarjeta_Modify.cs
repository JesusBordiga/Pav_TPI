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
    public partial class MarcaTarjeta_Modify : Form
    {
        public MarcaTarjeta_Modify()
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textMarcaOld.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
                string rubro = textMarcaOld.Text.Trim();
                bool existe = AD_MarcaTarjeta.ExisteRubro(rubro);
                if (existe)
                {
                    Cargar_Campos(rubro);
                }
                else
                {
                    Clean();
                }
            }
        }
        private void tablaMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaMarcas.Rows[indice];
                string marca = filaSeleccionada.Cells["Nombre"].Value.ToString();
                Cargar_Campos(marca);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una casilla dentro de la tabla", "ERROR");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string newM = ObtenerDatos();
                if (!AD_MarcaTarjeta.ExisteRubro(newM))
                {
                    string oldM = textMarcaOld.Text.Trim().ToLower();
                    bool resultado = AD_MarcaTarjeta.ModificarMarca(newM, oldM);
                    if (resultado)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = (
                              " | Marca: " + newM + " |" + "\n");

                        string titulo = "Información de Marca";

                        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Marca modificada con éxito!");
                            Clean();
                            CargarTablaMarcas();
                        }
                        else
                        {
                            textMarcaOld.Focus();
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
                    MessageBox.Show("Error al modificar la Marca! \n" +
                            "Ya existe una marca con ese nombre!");
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
            textMarcaOld.Text = "";
            textMarcaNew.Text = "";
            textMarcaOld.Visible = true;
            textMarcaNew.Visible = false;
            btnModify.Visible = false;
            btnSearch.Visible = true;
            labelMarca.Visible = true;
            labelMod.Visible = false;
            textMarcaOld.Focus();
        }
        private void Cargar_Campos(string marca)
        {
            //Cargar Nombre Original
            textMarcaOld.Text = marca;
            //Cargar Nombre Nuevo
            textMarcaNew.Text = marca;
            btnModify.Visible = true;
            textMarcaOld.Visible = false;
            textMarcaNew.Visible = true;
            btnSearch.Visible = false;
            labelMarca.Visible = false;
            labelMod.Visible = true;
            textMarcaNew.Focus();
        }
        private string ObtenerDatos()
        {
            string m = textMarcaNew.Text.Trim();
            return m;
        }
        private bool ValidarCampos()
        {
            if (textMarcaNew.Text.Trim() == "" || textMarcaNew.Text.Trim().Length > 50)
            {
                return false;
            }
            return true;
        }
        
    }
}
