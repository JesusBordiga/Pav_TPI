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
            this.reporteCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteCliente
            // 
            this.reporteCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reporteCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporteCliente.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Estadisticas.Ventanas_Reportes.EstadisticasClientes.EstadisticaC" +
    "lientes.rdlc";
            this.reporteCliente.Location = new System.Drawing.Point(7, 8);
            this.reporteCliente.Name = "reporteCliente";
            this.reporteCliente.ServerReport.BearerToken = null;
            this.reporteCliente.Size = new System.Drawing.Size(944, 423);
            this.reporteCliente.TabIndex = 11;
            // 
            // ReporteEstadisticasFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 443);
            this.Controls.Add(this.reporteCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReporteEstadisticasFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Estadisticas de Facturacion";
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reporteCliente;
    }
}