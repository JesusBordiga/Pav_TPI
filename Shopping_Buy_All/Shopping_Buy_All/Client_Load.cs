using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All
{
    public partial class Client_Load : Form
    {
        public Client_Load()
        {
            InitializeComponent();
            comboBoxDocType.Items.Add("DNI");
            comboBoxDocType.Items.Add("Pasaporte");
            comboBoxDocType.Items.Add("Libreta Universitaria");

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
            string tipoDocumento = comboBoxDocType.GetItemText(comboBoxDocType.SelectedItem);
            string nroDocumento = textNumberDoc.Text;
            string apellido = textSurnameClient.Text;
            string nombre = textNameClient.Text;
            string domicilio = textStreetClient.Text;
            string altura = textStreetHeight.Text;
            string sexo = "";
            string estadoCivil = "";
            string fechaNacimiento = textDateBirthDay.Text;
            bool estadoCivilOK = true;
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
                    }
                    if (radioButtonMarried.Checked)
                    {
                        estadoCivil = "Casado";
                    }
                }
            if (radioButtonMale.Checked)
                {
                    sexo = "Hombre";
                }
            if(radioButtonFemale.Checked)
                {
                    sexo = "Mujer";
                }
            if (radioButtonOther.Checked)
                {
                    sexo = "Otro";

                }
            if(estadoCivilOK)
                {  
                    if (tipoDocumento.Equals("") ||nroDocumento.Equals("")||apellido.Equals("") ||nombre.Equals("") ||domicilio.Equals("") ||altura.Equals("") ||
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
                            + " |Apellido: " + apellido + " |Nombre: " + nombre + "|" + "\n"
                            + " |Domicilio: " + domicilio + " |Altura: " + altura + "|" + "\n"
                            + " |Sexo: " + sexo + " |Estado Civil: " + estadoCivil + "|" + "\n"
                            + " |Fecha Nacimiento: " + fechaNacimiento+"|");
                        string titulo = "Iformación de Carga";
                        DialogResult resultado = MessageBox.Show(mensajeCarga, titulo, buttons);
                        if (resultado == DialogResult.OK)
                        {
                            Clean();
                        }
                        else
                        {
                            comboBoxDocType.Focus();
                        }
                }
            }
        }

    }
}
