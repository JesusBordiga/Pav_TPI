namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoDocumentos
{
    partial class ReporteTipoDocumentos
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
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.lblRestriccion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbPorLetra = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.reporteTipoDoc = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
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
            this.comboBoxNombre.Location = new System.Drawing.Point(391, 57);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(77, 21);
            this.comboBoxNombre.TabIndex = 36;
            // 
            // lblRestriccion
            // 
            this.lblRestriccion.AutoSize = true;
            this.lblRestriccion.BackColor = System.Drawing.Color.Transparent;
            this.lblRestriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestriccion.Location = new System.Drawing.Point(388, 39);
            this.lblRestriccion.Name = "lblRestriccion";
            this.lblRestriccion.Size = new System.Drawing.Size(89, 17);
            this.lblRestriccion.TabIndex = 35;
            this.lblRestriccion.Text = "Restriccion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(580, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_buscar01_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(2, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 25);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "Reportes de Tipo Documentos";
            // 
            // rbPorLetra
            // 
            this.rbPorLetra.AutoSize = true;
            this.rbPorLetra.BackColor = System.Drawing.Color.Transparent;
            this.rbPorLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPorLetra.ForeColor = System.Drawing.Color.White;
            this.rbPorLetra.Location = new System.Drawing.Point(7, 63);
            this.rbPorLetra.Name = "rbPorLetra";
            this.rbPorLetra.Size = new System.Drawing.Size(220, 19);
            this.rbPorLetra.TabIndex = 30;
            this.rbPorLetra.Text = "Restringido por letra (nombre)";
            this.rbPorLetra.UseVisualStyleBackColor = false;
            this.rbPorLetra.CheckedChanged += new System.EventHandler(this.rbPorLetraCheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(8, 39);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(203, 19);
            this.rbTodos.TabIndex = 31;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los Tipo Documentos";
            this.rbTodos.UseVisualStyleBackColor = false;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodosCheckedChanged);
            // 
            // reporteTipoDoc
            // 
            this.reporteTipoDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reporteTipoDoc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.reporteTipoDoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporteTipoDoc.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoDocumentos.ReporteTipoDoc" +
    "umentos.rdlc";
            this.reporteTipoDoc.Location = new System.Drawing.Point(12, 95);
            this.reporteTipoDoc.Name = "reporteTipoDoc";
            this.reporteTipoDoc.ServerReport.BearerToken = null;
            this.reporteTipoDoc.Size = new System.Drawing.Size(643, 352);
            this.reporteTipoDoc.TabIndex = 28;
            // 
            // ReporteTipoDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 452);
            this.Controls.Add(this.comboBoxNombre);
            this.Controls.Add(this.lblRestriccion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rbPorLetra);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.reporteTipoDoc);
            this.Name = "ReporteTipoDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Tipo Documentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.Label lblRestriccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbPorLetra;
        private System.Windows.Forms.RadioButton rbTodos;
        private Microsoft.Reporting.WinForms.ReportViewer reporteTipoDoc;
    }
}