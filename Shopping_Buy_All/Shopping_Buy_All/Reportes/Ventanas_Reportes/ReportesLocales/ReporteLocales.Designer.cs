namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesLocales
{
    partial class ReporteLocales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteLocales));
            this.repLocales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbPorLetra = new System.Windows.Forms.RadioButton();
            this.btn_buscar01 = new System.Windows.Forms.Button();
            this.grbRestricción = new System.Windows.Forms.Panel();
            this.txt_restriccion = new System.Windows.Forms.MaskedTextBox();
            this.lblRestriccion = new System.Windows.Forms.Label();
            this.grbRestricción.SuspendLayout();
            this.SuspendLayout();
            // 
            // repLocales
            // 
            this.repLocales.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repLocales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.repLocales.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesLocales.ReportLocales.rdlc";
            this.repLocales.Location = new System.Drawing.Point(10, 69);
            this.repLocales.Name = "repLocales";
            this.repLocales.ServerReport.BearerToken = null;
            this.repLocales.Size = new System.Drawing.Size(693, 375);
            this.repLocales.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(10, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 25);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Reportes de Locales";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.SystemColors.Control;
            this.rbTodos.Location = new System.Drawing.Point(10, 42);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(153, 21);
            this.rbTodos.TabIndex = 14;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los locales";
            this.rbTodos.UseVisualStyleBackColor = false;
            // 
            // rbPorLetra
            // 
            this.rbPorLetra.AutoSize = true;
            this.rbPorLetra.BackColor = System.Drawing.Color.Transparent;
            this.rbPorLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPorLetra.ForeColor = System.Drawing.SystemColors.Control;
            this.rbPorLetra.Location = new System.Drawing.Point(169, 42);
            this.rbPorLetra.Name = "rbPorLetra";
            this.rbPorLetra.Size = new System.Drawing.Size(247, 21);
            this.rbPorLetra.TabIndex = 15;
            this.rbPorLetra.Text = "Restringido por letra (nombre)";
            this.rbPorLetra.UseVisualStyleBackColor = false;
            this.rbPorLetra.CheckedChanged += new System.EventHandler(this.rbPorLetraCheckedChanged);
            // 
            // btn_buscar01
            // 
            this.btn_buscar01.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_buscar01.ForeColor = System.Drawing.Color.White;
            this.btn_buscar01.Location = new System.Drawing.Point(628, 40);
            this.btn_buscar01.Name = "btn_buscar01";
            this.btn_buscar01.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar01.TabIndex = 34;
            this.btn_buscar01.Text = "Buscar";
            this.btn_buscar01.UseVisualStyleBackColor = false;
            this.btn_buscar01.Click += new System.EventHandler(this.btn_buscar01_Click);
            // 
            // grbRestricción
            // 
            this.grbRestricción.BackColor = System.Drawing.Color.Transparent;
            this.grbRestricción.Controls.Add(this.txt_restriccion);
            this.grbRestricción.Controls.Add(this.lblRestriccion);
            this.grbRestricción.Location = new System.Drawing.Point(424, 36);
            this.grbRestricción.Name = "grbRestricción";
            this.grbRestricción.Size = new System.Drawing.Size(198, 34);
            this.grbRestricción.TabIndex = 35;
            // 
            // txt_restriccion
            // 
            this.txt_restriccion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_restriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_restriccion.Location = new System.Drawing.Point(150, 7);
            this.txt_restriccion.Mask = "L";
            this.txt_restriccion.Name = "txt_restriccion";
            this.txt_restriccion.PromptChar = '⠀';
            this.txt_restriccion.Size = new System.Drawing.Size(41, 20);
            this.txt_restriccion.TabIndex = 28;
            this.txt_restriccion.Enter += new System.EventHandler(this.txt_restriccion_Enter);
            // 
            // lblRestriccion
            // 
            this.lblRestriccion.AutoSize = true;
            this.lblRestriccion.BackColor = System.Drawing.Color.Transparent;
            this.lblRestriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestriccion.Location = new System.Drawing.Point(7, 8);
            this.lblRestriccion.Name = "lblRestriccion";
            this.lblRestriccion.Size = new System.Drawing.Size(137, 17);
            this.lblRestriccion.TabIndex = 27;
            this.lblRestriccion.Text = "Ingrese una letra:";
            // 
            // ReporteLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 456);
            this.Controls.Add(this.grbRestricción);
            this.Controls.Add(this.btn_buscar01);
            this.Controls.Add(this.rbPorLetra);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.repLocales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReporteLocales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteLocales";
            this.Load += new System.EventHandler(this.ReporteLocales_Load);
            this.grbRestricción.ResumeLayout(false);
            this.grbRestricción.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repLocales;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbPorLetra;
        private System.Windows.Forms.Button btn_buscar01;
        private System.Windows.Forms.Panel grbRestricción;
        private System.Windows.Forms.MaskedTextBox txt_restriccion;
        private System.Windows.Forms.Label lblRestriccion;
    }
}