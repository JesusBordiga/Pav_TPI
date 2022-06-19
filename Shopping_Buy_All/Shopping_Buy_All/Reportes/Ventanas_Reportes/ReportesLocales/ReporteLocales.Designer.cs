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
            this.repLocales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbPorTipo = new System.Windows.Forms.RadioButton();
            this.lblRestriccion = new System.Windows.Forms.Label();
            this.txt_restriccion = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar01 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // repLocales
            // 
            this.repLocales.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repLocales.Location = new System.Drawing.Point(12, 114);
            this.repLocales.Margin = new System.Windows.Forms.Padding(4);
            this.repLocales.Name = "repLocales";
            this.repLocales.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.repLocales.ServerReport.BearerToken = null;
            this.repLocales.Size = new System.Drawing.Size(834, 433);
            this.repLocales.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 29);
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
            this.rbTodos.Location = new System.Drawing.Point(13, 52);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(4);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(178, 24);
            this.rbTodos.TabIndex = 14;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los locales";
            this.rbTodos.UseVisualStyleBackColor = false;
            // 
            // rbPorTipo
            // 
            this.rbPorTipo.AutoSize = true;
            this.rbPorTipo.BackColor = System.Drawing.Color.Transparent;
            this.rbPorTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPorTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.rbPorTipo.Location = new System.Drawing.Point(199, 52);
            this.rbPorTipo.Margin = new System.Windows.Forms.Padding(4);
            this.rbPorTipo.Name = "rbPorTipo";
            this.rbPorTipo.Size = new System.Drawing.Size(268, 24);
            this.rbPorTipo.TabIndex = 15;
            this.rbPorTipo.Text = "Restringido por tipo de local";
            this.rbPorTipo.UseVisualStyleBackColor = false;
            // 
            // lblRestriccion
            // 
            this.lblRestriccion.AutoSize = true;
            this.lblRestriccion.BackColor = System.Drawing.Color.Transparent;
            this.lblRestriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestriccion.Location = new System.Drawing.Point(626, 18);
            this.lblRestriccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestriccion.Name = "lblRestriccion";
            this.lblRestriccion.Size = new System.Drawing.Size(105, 20);
            this.lblRestriccion.TabIndex = 32;
            this.lblRestriccion.Text = "Restriccion";
            // 
            // txt_restriccion
            // 
            this.txt_restriccion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_restriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_restriccion.Location = new System.Drawing.Point(583, 42);
            this.txt_restriccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_restriccion.Mask = "LLLLLLLL";
            this.txt_restriccion.Name = "txt_restriccion";
            this.txt_restriccion.PromptChar = '⠀';
            this.txt_restriccion.Size = new System.Drawing.Size(188, 22);
            this.txt_restriccion.TabIndex = 33;
            // 
            // btn_buscar01
            // 
            this.btn_buscar01.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_buscar01.ForeColor = System.Drawing.Color.White;
            this.btn_buscar01.Location = new System.Drawing.Point(652, 78);
            this.btn_buscar01.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar01.Name = "btn_buscar01";
            this.btn_buscar01.Size = new System.Drawing.Size(100, 28);
            this.btn_buscar01.TabIndex = 34;
            this.btn_buscar01.Text = "Buscar";
            this.btn_buscar01.UseVisualStyleBackColor = false;
            // 
            // ReporteLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_buscar01);
            this.Controls.Add(this.txt_restriccion);
            this.Controls.Add(this.lblRestriccion);
            this.Controls.Add(this.rbPorTipo);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.repLocales);
            this.Name = "ReporteLocales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteLocales";
            this.Load += new System.EventHandler(this.ReporteLocales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repLocales;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbPorTipo;
        private System.Windows.Forms.Label lblRestriccion;
        private System.Windows.Forms.MaskedTextBox txt_restriccion;
        private System.Windows.Forms.Button btn_buscar01;
    }
}