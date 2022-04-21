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
    public partial class btnClean : Form
    {
        public btnClean()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxDocTipe.SelectedIndex = -1;
            textNumberDoc.Text = "";
            textSurnameClient.Text = "";
            textNameClient.Text = "";
            textStreetClient.Text = "";
            radioButtonSingle.Checked = false;
            radioButtonMarried.Checked = false;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            radioButtonOther.Checked = false;
            textDateBirthDay.Text = "";
        }
    }
}
