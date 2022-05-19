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
    public partial class Sexo_Delete : Form
    {
        public Sexo_Delete()
        {
            InitializeComponent();
            cambiarModificador(false);
            cargarTablaSexo();
        }
        private void btnSexoDelete_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            if (nombre != "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + nombre + "|");
                string titulo = "Información de Baja";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);
                if (result == DialogResult.OK)
                {
                    eliminarSexo(nombre);
                    MessageBox.Show("Nombre de sexo dado de baja con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false);
                    cargarTablaSexo();
                }
                else
                {
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al dar de baja el nombre de sexo! \n Complete los campos por favor!");
            }
        }
        private void btnBuscarSexo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            buscarSexo(nombre);
        }
        private void tablaSexo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaSexo.Rows[indice];
                string nombre = filaSeleccionada.Cells["NombreSexo"].Value.ToString();
                buscarSexo(nombre);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Seleccione una casilla dentro de la tabla");
            }
        }
        private void cambiarModificador(bool booleano)
        {
            btnSexoDelete.Visible = booleano;
            btnLimpiar.Visible = booleano;
        }
        private void cambiarBuscador(bool booleano)
        {
            label2.Visible = booleano;
            btnBuscarSexo.Visible = booleano;
            txtNombre.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
        }
        private void cargarTablaSexo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "getTipoSexoNoBorrado";
                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
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
        private bool busquedaXNombre(string nombre)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "buscarTipoSexoNoBorrado @Nombre";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaSexo.DataSource = tabla;
                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
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
        private void buscarSexo(string nombre)
        {
            if (nombre != "")
            {
                bool resultado = busquedaXNombre(nombre);
                if (resultado)
                {
                    cambiarModificador(true);
                    cambiarBuscador(false);
                    txtNombre.Text = nombre;
                }
                else
                {
                    MessageBox.Show("No se encontró el nombre de sexo!", "Error", MessageBoxButtons.OK);
                    limpiarCampos();
                    cargarTablaSexo();
                }
            }
            else
            {
                MessageBox.Show("Error al buscar el nombre de sexo! \n Complete el campo por favor!", "Error", MessageBoxButtons.OK);
            }
        }
        private void eliminarSexo(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "borrarTipoSexo @nombre";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
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
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cambiarModificador(false);
            cambiarBuscador(true);
            cargarTablaSexo();
        }
    }
}
