﻿using System;
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
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "SELECT * FROM TipoSexo WHERE Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaSexo.DataSource = tabla;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
            finally
            {
                cn.Close();
            }
        }
        private bool Agregar_Sexo(Sexo sexo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO TipoSexo Values(@nombre, 0)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", sexo.NombreSexo);

                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
    }
}
