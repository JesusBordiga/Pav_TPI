﻿namespace Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasTipoDocumento
{
    partial class EstadisticaMarcasTarjeta
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
            this.label1 = new System.Windows.Forms.Label();
            this.repEstadisticasMarcasTarjeta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Marcas de Tarjeta por Cliente";
            // 
            // repEstadisticasMarcasTarjeta
            // 
            this.repEstadisticasMarcasTarjeta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repEstadisticasMarcasTarjeta.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasTarjeta.Estadisti" +
    "caMarcaTarjeta.rdlc";
            this.repEstadisticasMarcasTarjeta.Location = new System.Drawing.Point(25, 37);
            this.repEstadisticasMarcasTarjeta.Name = "repEstadisticasMarcasTarjeta";
            this.repEstadisticasMarcasTarjeta.ServerReport.BearerToken = null;
            this.repEstadisticasMarcasTarjeta.Size = new System.Drawing.Size(430, 314);
            this.repEstadisticasMarcasTarjeta.TabIndex = 16;
            this.repEstadisticasMarcasTarjeta.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // EstadisticaMarcasTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 370);
            this.Controls.Add(this.repEstadisticasMarcasTarjeta);
            this.Controls.Add(this.label1);
            this.Name = "EstadisticaMarcasTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica Tipo Documento";
            this.Load += new System.EventHandler(this.EstadisticaTipoTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer repEstadisticasMarcasTarjeta;
    }
}