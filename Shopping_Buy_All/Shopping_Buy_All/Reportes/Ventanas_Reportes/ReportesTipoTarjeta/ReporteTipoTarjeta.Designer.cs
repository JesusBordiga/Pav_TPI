namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoTarjeta
{
    partial class ReporteTipoTarjeta
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
            this.labelLetra = new System.Windows.Forms.Label();
            this.mtbLetra = new System.Windows.Forms.MaskedTextBox();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbPorLetra = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.repTipoTarjeta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // labelLetra
            // 
            this.labelLetra.AutoSize = true;
            this.labelLetra.BackColor = System.Drawing.Color.Transparent;
            this.labelLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetra.ForeColor = System.Drawing.Color.White;
            this.labelLetra.Location = new System.Drawing.Point(486, 48);
            this.labelLetra.Name = "labelLetra";
            this.labelLetra.Size = new System.Drawing.Size(51, 17);
            this.labelLetra.TabIndex = 28;
            this.labelLetra.Text = "Letra:";
            // 
            // mtbLetra
            // 
            this.mtbLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbLetra.Location = new System.Drawing.Point(543, 41);
            this.mtbLetra.Mask = "a";
            this.mtbLetra.Name = "mtbLetra";
            this.mtbLetra.Size = new System.Drawing.Size(21, 23);
            this.mtbLetra.TabIndex = 27;
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttnBuscar.ForeColor = System.Drawing.Color.White;
            this.bttnBuscar.Location = new System.Drawing.Point(489, 73);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttnBuscar.TabIndex = 26;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(161, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(262, 25);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Reportes de Tipos Tarjeta";
            // 
            // rbPorLetra
            // 
            this.rbPorLetra.AutoSize = true;
            this.rbPorLetra.BackColor = System.Drawing.Color.Transparent;
            this.rbPorLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPorLetra.ForeColor = System.Drawing.Color.White;
            this.rbPorLetra.Location = new System.Drawing.Point(24, 73);
            this.rbPorLetra.Name = "rbPorLetra";
            this.rbPorLetra.Size = new System.Drawing.Size(220, 19);
            this.rbPorLetra.TabIndex = 23;
            this.rbPorLetra.Text = "Restringido por letra (nombre)";
            this.rbPorLetra.UseVisualStyleBackColor = false;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(24, 48);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(175, 19);
            this.rbTodos.TabIndex = 24;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los Tipos Tarjeta";
            this.rbTodos.UseVisualStyleBackColor = false;
            // 
            // repTipoTarjeta
            // 
            this.repTipoTarjeta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repTipoTarjeta.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoTarjeta.ReportTipoTarjeta" +
    ".rdlc";
            this.repTipoTarjeta.Location = new System.Drawing.Point(40, 115);
            this.repTipoTarjeta.Name = "repTipoTarjeta";
            this.repTipoTarjeta.ServerReport.BearerToken = null;
            this.repTipoTarjeta.Size = new System.Drawing.Size(514, 275);
            this.repTipoTarjeta.TabIndex = 29;
            this.repTipoTarjeta.Load += new System.EventHandler(this.repTipoDocumento_Load);
            // 
            // ReporteTipoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 411);
            this.Controls.Add(this.repTipoTarjeta);
            this.Controls.Add(this.labelLetra);
            this.Controls.Add(this.mtbLetra);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rbPorLetra);
            this.Controls.Add(this.rbTodos);
            this.Name = "ReporteTipoTarjeta";
            this.Text = "ReporteTipoTarjeta";
            this.Load += new System.EventHandler(this.ReporteTipoTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLetra;
        private System.Windows.Forms.MaskedTextBox mtbLetra;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbPorLetra;
        private System.Windows.Forms.RadioButton rbTodos;
        private Microsoft.Reporting.WinForms.ReportViewer repTipoTarjeta;
    }
}