﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
using System.Runtime;

namespace Shopping_Buy_All
{
    public partial class MarcaVeh_Load : Form
    {
        public MarcaVeh_Load()
        {
            InitializeComponent();
            CargarTablaMarcas();
            CargarMarcaVeh();



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            cmbMarca.SelectedIndex = -1;
            CargarTablaMarcas();

        }
        private void CargarMarcaVeh()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Marcas where Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                cmbMarca.DataSource = tabla;
                cmbMarca.DisplayMember = "Descripcion";
                cmbMarca.ValueMember = "Id";
                cmbMarca.SelectedIndex = -1;
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

        private void CargarTablaMarcas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Marcas WHERE Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaMarcas.DataSource = tabla;
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
        private MarcaVehiculo ObtenerDatosMarca()
        {
            MarcaVehiculo c = new MarcaVehiculo();

            c.MarcaVeh = cmbMarca.SelectedValue.ToString();

            return c;
        }

        private bool Agregar_Marca(MarcaVehiculo mark)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Marcas" +
                                               "Values(@descripcion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", mark.MarcaVeh);
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

        private void btnMarcaLoad_Click(object sender, EventArgs e)
        {
            MarcaVehiculo c = ObtenerDatosMarca();
            bool resultado = Agregar_Marca(c);
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
                    CargarMarcaVeh();


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
    }
}
