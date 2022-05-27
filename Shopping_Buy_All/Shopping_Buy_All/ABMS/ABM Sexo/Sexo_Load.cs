using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Shopping_Buy_All.Entidades;
using Shopping_Buy_All.ABMS.AccesoADatos;

namespace Shopping_Buy_All.ABM_Sexo
{
    public partial class Sexo_Load : Form
    {
        public Sexo_Load()
        {
            InitializeComponent();
            CargarTablaSexo();
        }
        private void btnSexoLoad_Click(object sender, EventArgs e)
        {
            Sexo sexo = new Sexo(txtNombreSexo.Text.Trim(), 0);
            bool resultado = Agregar_Sexo(sexo);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + sexo.NombreSexo + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Sexo agregado con éxito!");
                    limpiarCampos();
                    CargarTablaSexo();
                }
                else
                {
                    txtNombreSexo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el Sexo! \n Complete los campos por favor!");
            }
        }
        private void limpiarCampos()
        {
            txtNombreSexo.Text = "";
        }
        private void CargarTablaSexo()
        {
            try
            {
                tablaSexo.DataSource = AD_Sexo.obtenerDatosSexo();
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Otener Datos del Cliente");
            }
        }
        private bool Agregar_Sexo(Sexo sexo)
        {
            bool resultado = AD_Sexo.agregarSexo(sexo);
            return resultado;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
