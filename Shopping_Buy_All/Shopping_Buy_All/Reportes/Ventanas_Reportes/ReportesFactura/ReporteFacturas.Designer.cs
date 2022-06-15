namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura
{
    partial class ReporteFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteFacturas));
            this.button1 = new System.Windows.Forms.Button();
            this.lblRestriccion = new System.Windows.Forms.Label();
            this.txt_restriccion = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbRangoId = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.repFac = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxLocal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(568, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_buscar01_Click);
            // 
            // lblRestriccion
            // 
            this.lblRestriccion.AutoSize = true;
            this.lblRestriccion.BackColor = System.Drawing.Color.Transparent;
            this.lblRestriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestriccion.Location = new System.Drawing.Point(513, 8);
            this.lblRestriccion.Name = "lblRestriccion";
            this.lblRestriccion.Size = new System.Drawing.Size(89, 17);
            this.lblRestriccion.TabIndex = 25;
            this.lblRestriccion.Text = "Restriccion";
            // 
            // txt_restriccion
            // 
            this.txt_restriccion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_restriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_restriccion.Location = new System.Drawing.Point(501, 27);
            this.txt_restriccion.Mask = "LLLLLLLL";
            this.txt_restriccion.Name = "txt_restriccion";
            this.txt_restriccion.PromptChar = '⠀';
            this.txt_restriccion.Size = new System.Drawing.Size(142, 20);
            this.txt_restriccion.TabIndex = 24;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(2, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 25);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Reportes de Facturas";
            // 
            // rbRangoId
            // 
            this.rbRangoId.AutoSize = true;
            this.rbRangoId.BackColor = System.Drawing.Color.Transparent;
            this.rbRangoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRangoId.ForeColor = System.Drawing.SystemColors.Control;
            this.rbRangoId.Location = new System.Drawing.Point(168, 27);
            this.rbRangoId.Name = "rbRangoId";
            this.rbRangoId.Size = new System.Drawing.Size(235, 19);
            this.rbRangoId.TabIndex = 20;
            this.rbRangoId.Text = "Restringido por fecha de compra";
            this.rbRangoId.UseVisualStyleBackColor = false;
            this.rbRangoId.CheckedChanged += new System.EventHandler(this.rbRangoCheckedChanged);
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.BackColor = System.Drawing.Color.Transparent;
            this.rbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLocal.ForeColor = System.Drawing.SystemColors.Control;
            this.rbLocal.Location = new System.Drawing.Point(7, 50);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(159, 19);
            this.rbLocal.TabIndex = 21;
            this.rbLocal.Text = "Restringido por local";
            this.rbLocal.UseVisualStyleBackColor = false;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.rbPorLocalCheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.SystemColors.Control;
            this.rbTodos.Location = new System.Drawing.Point(7, 27);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(146, 19);
            this.rbTodos.TabIndex = 22;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todas las Facturas";
            this.rbTodos.UseVisualStyleBackColor = false;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodosCheckedChanged);
            // 
            // repFac
            // 
            this.repFac.BackColor = System.Drawing.Color.DimGray;
            this.repFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.repFac.Cursor = System.Windows.Forms.Cursors.Default;
            this.repFac.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ListadoDetalle.rdlc";
            this.repFac.Location = new System.Drawing.Point(7, 86);
            this.repFac.Name = "repFac";
            this.repFac.ServerReport.BearerToken = null;
            this.repFac.Size = new System.Drawing.Size(637, 352);
            this.repFac.TabIndex = 19;
            // 
            // comboBoxLocal
            // 
            this.comboBoxLocal.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.comboBoxLocal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxLocal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxLocal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxLocal.DropDownHeight = 70;
            this.comboBoxLocal.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxLocal.FormattingEnabled = true;
            this.comboBoxLocal.IntegralHeight = false;
            this.comboBoxLocal.Items.AddRange(new object[] {
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
            this.comboBoxLocal.Location = new System.Drawing.Point(501, 25);
            this.comboBoxLocal.Name = "comboBoxLocal";
            this.comboBoxLocal.Size = new System.Drawing.Size(144, 21);
            this.comboBoxLocal.TabIndex = 28;
            // 
            // ReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 444);
            this.Controls.Add(this.comboBoxLocal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_restriccion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rbRangoId);
            this.Controls.Add(this.rbLocal);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.repFac);
            this.Controls.Add(this.lblRestriccion);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteFacturas";
            this.Text = "Reportes de Facturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRestriccion;
        private System.Windows.Forms.MaskedTextBox txt_restriccion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbRangoId;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbTodos;
        private Microsoft.Reporting.WinForms.ReportViewer repFac;
        private System.Windows.Forms.ComboBox comboBoxLocal;
    }
}