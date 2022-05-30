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
    public partial class MarcaTarjeta_Delete : Form
    {
        public MarcaTarjeta_Delete()
        {
            InitializeComponent();
        }
        private void Marca_Delete_Load(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            btnDelete.Visible = false;
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
        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textMarca.Text.Trim() == "")
            {
                MessageBox.Show("Error, Debe completar los campos!!");
            }
            else
            {
                string marca = textMarca.Text.Trim();
                bool existe = AD_MarcaTarjeta.ExisteMarca(marca);
                if (existe)
                {
                    Cargar_Campos(marca);
                }
                else
                {
                    MessageBox.Show("La marca que busca no existe o fue borrado!");
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string marca = textMarca.Text.Trim();
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = (
                  " | Nombre: " + marca + " |" + "\n" + "\n" + " | Desea eliminar a esta marca??");

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                bool resultado = AD_MarcaTarjeta.BorrarMarca(marca);
                if (resultado)
                {
                    MessageBox.Show("Marca Borrada con éxito!");
                    Clean();
                    btnDelete.Visible = false;
                    btnSearch.Visible = true;
                    CargarTablaMarcas();
                    textMarca.Focus();
                }
                else
                {
                    MessageBox.Show("La Marca No fue Borrado!");
                }
            }
            else
            {
                textMarca.Focus();
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

        //FUNCIONES
        private void Clean()
        {
            textMarca.Text = "";
            btnDelete.Visible = false;
            btnSearch.Visible = true;
            textMarca.Enabled = true;
            textMarca.Focus();
        }
        private void Cargar_Campos(string marca)
        {
            textMarca.Text = marca;
            btnDelete.Visible = true;
            btnSearch.Visible = false;
            textMarca.Enabled = false;
        }

    }
}
