namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReporteEstadisticasClientes
{
    partial class ReporteEstadisticasFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEstadisticasFacturacion));
            this.reporteFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteFactura
            // 
            this.reporteFactura.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reporteFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporteFactura.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasFacturacion.Estad" +
    "isticaFacturacion.rdlc";
            this.reporteFactura.Location = new System.Drawing.Point(7, 8);
            this.reporteFactura.Name = "reporteFactura";
            this.reporteFactura.ServerReport.BearerToken = null;
            this.reporteFactura.Size = new System.Drawing.Size(944, 423);
            this.reporteFactura.TabIndex = 11;
            // 
            // ReporteEstadisticasFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 443);
            this.Controls.Add(this.reporteFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReporteEstadisticasFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Estadisticas de Facturacion";
            this.Load += new System.EventHandler(this.ReporteEstadisticasFacturacion_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reporteFactura;
    }
}