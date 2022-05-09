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

namespace Shopping_Buy_All.ABM_Tipo_Documento
{
    public partial class TipoDoc_Load : Form
    {
        public TipoDoc_Load()
        {
            InitializeComponent();
            CargarTablaTipoDocumento();
        }
        private void limpiarCampos()
        {
            txtTipoDoc.Text = "";
        }
        private void CargarTablaTipoDocumento()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "select TipoDocumento, NombreDocumento from TipoDocumento where Borrado = 0";
                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaTipDoc.DataSource = tabla;
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
        }
        private bool Agregar_Sexo(TipoDocumento tipDoc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO TipoDocumento Values(@nombre, 0)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", tipDoc.NombreTipDoc);

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

        private void btnSexoLoad_Click_1(object sender, EventArgs e)
        {
            TipoDocumento tipDoc = new TipoDocumento(txtTipoDoc.Text.Trim(), 0);
            bool resultado = Agregar_Sexo(tipDoc);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + tipDoc.NombreTipDoc + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Tipo de Documento agregado con éxito!");
                    limpiarCampos();
                    CargarTablaTipoDocumento();
                }
                else
                {
                    txtTipoDoc.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el tipo de documento! \n Complete los campos por favor!");
            }
        }
    }
}