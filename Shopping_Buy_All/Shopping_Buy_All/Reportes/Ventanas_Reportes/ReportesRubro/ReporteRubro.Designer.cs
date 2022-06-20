namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesRubro
{
    partial class ReporteRubro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbPorLetra = new System.Windows.Forms.RadioButton();
            this.repRub = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblRestriccion = new System.Windows.Forms.Label();
            this.txt_restriccion = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(13, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(256, 29);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Reportes de Rubros";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(18, 72);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(4);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(165, 22);
            this.rbTodos.TabIndex = 17;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los Rubros";
            this.rbTodos.UseVisualStyleBackColor = false;
            // 
            // rbPorLetra
            // 
            this.rbPorLetra.AutoSize = true;
            this.rbPorLetra.BackColor = System.Drawing.Color.Transparent;
            this.rbPorLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPorLetra.ForeColor = System.Drawing.Color.White;
            this.rbPorLetra.Location = new System.Drawing.Point(214, 72);
            this.rbPorLetra.Margin = new System.Windows.Forms.Padding(4);
            this.rbPorLetra.Name = "rbPorLetra";
            this.rbPorLetra.Size = new System.Drawing.Size(257, 22);
            this.rbPorLetra.TabIndex = 18;
            this.rbPorLetra.Text = "Restringido por letra (nombre)";
            this.rbPorLetra.UseVisualStyleBackColor = false;
            // 
            // repRub
            // 
            this.repRub.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repRub.Cursor = System.Windows.Forms.Cursors.Default;
            this.repRub.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ListadoDetalle.rdlc";
            this.repRub.Location = new System.Drawing.Point(70, 120);
            this.repRub.Margin = new System.Windows.Forms.Padding(4);
            this.repRub.Name = "repRub";
            this.repRub.ServerReport.BearerToken = null;
            this.repRub.Size = new System.Drawing.Size(920, 300);
            this.repRub.TabIndex = 19;
            // 
            // lblRestriccion
            // 
            this.lblRestriccion.AutoSize = true;
            this.lblRestriccion.BackColor = System.Drawing.Color.Transparent;
            this.lblRestriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestriccion.Location = new System.Drawing.Point(848, 22);
            this.lblRestriccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestriccion.Name = "lblRestriccion";
            this.lblRestriccion.Size = new System.Drawing.Size(105, 20);
            this.lblRestriccion.TabIndex = 27;
            this.lblRestriccion.Text = "Restriccion";
            // 
            // txt_restriccion
            // 
            this.txt_restriccion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_restriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_restriccion.Location = new System.Drawing.Point(807, 46);
            this.txt_restriccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_restriccion.Mask = "LLLLLLLL";
            this.txt_restriccion.Name = "txt_restriccion";
            this.txt_restriccion.PromptChar = '⠀';
            this.txt_restriccion.Size = new System.Drawing.Size(183, 22);
            this.txt_restriccion.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(932, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.AutoCompleteCustomSource.AddRange(new string[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "y",
            "z"});
            this.comboBoxNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNombre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxNombre.DropDownHeight = 70;
            this.comboBoxNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.IntegralHeight = false;
            this.comboBoxNombre.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "Y",
            "Z"});
            this.comboBoxNombre.Location = new System.Drawing.Point(807, 76);
            this.comboBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(101, 24);
            this.comboBoxNombre.TabIndex = 30;
            // 
            // ReporteRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1277, 545);
            this.Controls.Add(this.comboBoxNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_restriccion);
            this.Controls.Add(this.lblRestriccion);
            this.Controls.Add(this.repRub);
            this.Controls.Add(this.rbPorLetra);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ReporteRubro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteRubro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbPorLetra;
        private Microsoft.Reporting.WinForms.ReportViewer repRub;
        private System.Windows.Forms.Label lblRestriccion;
        private System.Windows.Forms.MaskedTextBox txt_restriccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxNombre;
    }
}