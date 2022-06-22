namespace Shopping_Buy_All.Reportes.Ventanas_Reportes
{
    partial class ReporteTipoDocumento
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
            this.rbPorLetra = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.mtbLetra = new System.Windows.Forms.MaskedTextBox();
            this.labelLetra = new System.Windows.Forms.Label();
            this.repTiposDocumento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(149, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 25);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Reportes de Tipos Documento";
            // 
            // rbPorLetra
            // 
            this.rbPorLetra.AutoSize = true;
            this.rbPorLetra.BackColor = System.Drawing.Color.Transparent;
            this.rbPorLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPorLetra.ForeColor = System.Drawing.Color.White;
            this.rbPorLetra.Location = new System.Drawing.Point(12, 73);
            this.rbPorLetra.Name = "rbPorLetra";
            this.rbPorLetra.Size = new System.Drawing.Size(220, 19);
            this.rbPorLetra.TabIndex = 17;
            this.rbPorLetra.Text = "Restringido por letra (nombre)";
            this.rbPorLetra.UseVisualStyleBackColor = false;
            this.rbPorLetra.CheckedChanged += new System.EventHandler(this.rbPorLetra_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(12, 48);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(203, 19);
            this.rbTodos.TabIndex = 18;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los Tipos Documento";
            this.rbTodos.UseVisualStyleBackColor = false;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttnBuscar.ForeColor = System.Drawing.Color.White;
            this.bttnBuscar.Location = new System.Drawing.Point(477, 73);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttnBuscar.TabIndex = 20;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // mtbLetra
            // 
            this.mtbLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbLetra.Location = new System.Drawing.Point(531, 41);
            this.mtbLetra.Mask = "a";
            this.mtbLetra.Name = "mtbLetra";
            this.mtbLetra.Size = new System.Drawing.Size(21, 23);
            this.mtbLetra.TabIndex = 21;
            // 
            // labelLetra
            // 
            this.labelLetra.AutoSize = true;
            this.labelLetra.BackColor = System.Drawing.Color.Transparent;
            this.labelLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetra.ForeColor = System.Drawing.Color.White;
            this.labelLetra.Location = new System.Drawing.Point(474, 48);
            this.labelLetra.Name = "labelLetra";
            this.labelLetra.Size = new System.Drawing.Size(51, 17);
            this.labelLetra.TabIndex = 22;
            this.labelLetra.Text = "Letra:";
            // 
            // repTiposDocumento
            // 
            this.repTiposDocumento.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repTiposDocumento.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoDocumento.ReportTipoDocum" +
    "ento.rdlc";
            this.repTiposDocumento.Location = new System.Drawing.Point(46, 102);
            this.repTiposDocumento.Name = "repTiposDocumento";
            this.repTiposDocumento.ServerReport.BearerToken = null;
            this.repTiposDocumento.Size = new System.Drawing.Size(479, 246);
            this.repTiposDocumento.TabIndex = 23;
            this.repTiposDocumento.Load += new System.EventHandler(this.repTiposDocumento_Load);
            // 
            // ReporteTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 373);
            this.Controls.Add(this.repTiposDocumento);
            this.Controls.Add(this.labelLetra);
            this.Controls.Add(this.mtbLetra);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rbPorLetra);
            this.Controls.Add(this.rbTodos);
            this.Name = "ReporteTipoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Tipo Documento";
            this.Load += new System.EventHandler(this.ReporteTipoDocumento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbPorLetra;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.MaskedTextBox mtbLetra;
        private System.Windows.Forms.Label labelLetra;
        private Microsoft.Reporting.WinForms.ReportViewer repTiposDocumento;
    }
}