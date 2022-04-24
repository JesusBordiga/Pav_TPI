﻿using System;
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

namespace Shopping_Buy_All
{
    public partial class Client_Load : Form
    {
        public Client_Load()
        {
            InitializeComponent();
            Tipo_Doc_Initialize();
            ConexionTablaClientes();


        }
        private void Tipo_Doc_Initialize()
        {
            comboBoxDocType.Items.Add("1-DNI");
            comboBoxDocType.Items.Add("2-Pasaporte");
            comboBoxDocType.Items.Add("3-Libreta Universitaria");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            comboBoxDocType.SelectedIndex = -1;
            textNumberDoc.Text = "";
            textSurnameClient.Text = "";
            textNameClient.Text = "";
            textStreetClient.Text = "";
            textStreetHeight.Text = "";
            radioButtonSingle.Checked = false;
            radioButtonMarried.Checked = false;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            radioButtonOther.Checked = false;
            textDateBirthDay.Text = "";

        }
        private void btnClientLoad_Click(object sender, EventArgs e)
        {
            int tipoDocumento = 0;
            int nroDocumento = int.Parse(textNumberDoc.Text);
            string apellido = textSurnameClient.Text;
            string nombres = textNameClient.Text;
            string calle = textStreetClient.Text;
            int nroCalle = int.Parse(textStreetHeight.Text);
            DateTime fechaNacimiento = DateTime.Parse(textDateBirthDay.Text);
            string estadoCivil = "";
            int estadoCivilInt = 0;
            string sexo = "";
            int sexoInt = 0;

        bool estadoCivilOK = true;
            if (comboBoxDocType.GetItemText(comboBoxDocType.SelectedItem).Equals("DNI"))
            {
                tipoDocumento = 1;
            }
            else
            {
                if (comboBoxDocType.GetItemText(comboBoxDocType.SelectedItem).Equals("Pasaporte"))
                {
                    tipoDocumento = 2;
                }
                else
                {
                    if (comboBoxDocType.GetItemText(comboBoxDocType.SelectedItem).Equals("Pasaporte"))
                    {
                        tipoDocumento = 3;
                    }
                }
            }
            if (radioButtonSingle.Checked && radioButtonMarried.Checked)
                {
                    MessageBox.Show("Error, Ingrese solo una opcion en estado Civil!");
                    radioButtonSingle.Focus();
                    estadoCivilOK = false;
                }
            else
                {
                    if (radioButtonSingle.Checked)
                    {
                        estadoCivil = "Soltero";
                        estadoCivilInt = 1;
                    }
                    if (radioButtonMarried.Checked)
                    {
                        estadoCivil = "Casado";
                        estadoCivilInt = 2;
                }
                }
            if (radioButtonMale.Checked)
                {
                    sexo = "Hombre";
                    sexoInt = 1;    
                }
            if(radioButtonFemale.Checked)
                {
                    sexo = "Mujer";
                    sexoInt = 2;
            }
            if (radioButtonOther.Checked)
                {
                    sexo = "Otro";
                    sexoInt = 3;

            }
            if(estadoCivilOK)
                {  
                    if (tipoDocumento.Equals("") ||nroDocumento.Equals("")||apellido.Equals("") ||nombres.Equals("") ||calle.Equals("") ||NroCalle.Equals("") ||
                        sexo.Equals("") ||estadoCivil.Equals("")||fechaNacimiento.Equals(""))
                    {
                        MessageBox.Show("Error \n" +
                            "Por Favor Complete todos los campos!");
                        comboBoxDocType.Focus();
                    }
                    else
                    { 
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = (
                             " |Tipo Documento: " + tipoDocumento + " |Numero Documento: " + nroDocumento +"|"+"\n"
                            + " |Apellido: " + apellido + " |Nombre: " + nombres + "|" + "\n"
                            + " |Calle: " + calle + " |Nro Calle: " + nroCalle + "|" + "\n"
                            + " |Estado Civil: " + estadoCivil + " |Sexo: " + sexo + "|" + "\n"
                            + " |Fecha Nacimiento: " + fechaNacimiento+"|"+"\n");

                        string titulo = "Información de Carga";

                        DialogResult resultado = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (resultado == DialogResult.OK)
                        {
                            Agegrar_Ciente(tipoDocumento, nroDocumento, apellido, nombres, calle, 
                                nroCalle,estadoCivilInt,sexoInt, fechaNacimiento);
                            Clean();
                        }
                        else
                        {
                            comboBoxDocType.Focus();
                    }
                }
            }
        }
        public void ConexionTablaClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "Select * FROM Clientes";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaClientes.DataSource = tabla;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        private void Agegrar_Ciente(int tipoDocumento, int nroDocumento, string apellido, string nombres, string calle,
                                    int nroCalle, int estadoCivilInt, int sexoInt, DateTime fechaNacimiento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Clientes(TipoDocumento,NroDocumento,Apellido,Nombres,Calle,NroCalle,EstadoCivil,Sexo,FechaNacimiento)" +
                                               "Values(@tipoDocumento, @nroDocumento, @apellido, @nombres, @calle, @nroCalle, @estadoCivil,@sexo, @fechaNacimiento)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocumento", nroDocumento);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@nombres", nombres);
                cmd.Parameters.AddWithValue("@calle", calle);
                cmd.Parameters.AddWithValue("@nroCalle", nroCalle);
                cmd.Parameters.AddWithValue("@estadoCivil", estadoCivilInt);
                cmd.Parameters.AddWithValue("@sexo", sexoInt);
                cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        private void Client_Load_Load(object sender, EventArgs e)
        {

        }

        private void Client_Load_Load_1(object sender, EventArgs e)
        {

        }
    }   
}
