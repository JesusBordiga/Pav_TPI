namespace Shopping_Buy_All
{
    partial class ReporteListadoFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteListadoFacturas));
            this.reportViewerFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LabelFactura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewerFacturas
            // 
            this.reportViewerFacturas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reportViewerFacturas.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ListadoFactura.rdlc";
            this.reportViewerFacturas.Location = new System.Drawing.Point(12, 41);
            this.reportViewerFacturas.Name = "reportViewerFacturas";
            this.reportViewerFacturas.ServerReport.BearerToken = null;
            this.reportViewerFacturas.Size = new System.Drawing.Size(751, 497);
            this.reportViewerFacturas.TabIndex = 0;
            this.reportViewerFacturas.Load += new System.EventHandler(this.reportViewerFacturas_Load);
            // 
            // LabelFactura
            // 
            this.LabelFactura.AutoSize = true;
            this.LabelFactura.BackColor = System.Drawing.Color.Transparent;
            this.LabelFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFactura.ForeColor = System.Drawing.Color.White;
            this.LabelFactura.Location = new System.Drawing.Point(276, 9);
            this.LabelFactura.Name = "LabelFactura";
            this.LabelFactura.Size = new System.Drawing.Size(233, 29);
            this.LabelFactura.TabIndex = 8;
            this.LabelFactura.Text = "Listado de facturas";
            // 
            // ReporteListadoFacturas
            // 
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 548);
            this.Controls.Add(this.LabelFactura);
            this.Controls.Add(this.reportViewerFacturas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteListadoFacturas";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Facturas";
            this.Load += new System.EventHandler(this.ReporteListadoFacturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFacturas;
        private System.Windows.Forms.Label LabelFactura;
    }
}