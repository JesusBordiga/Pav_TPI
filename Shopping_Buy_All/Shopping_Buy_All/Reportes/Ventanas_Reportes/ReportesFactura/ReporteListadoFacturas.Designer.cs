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
            this.LabelBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewerFacturas
            // 
            this.reportViewerFacturas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reportViewerFacturas.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ListadoFactura.rdlc";
            this.reportViewerFacturas.Location = new System.Drawing.Point(12, 96);
            this.reportViewerFacturas.Name = "reportViewerFacturas";
            this.reportViewerFacturas.ServerReport.BearerToken = null;
            this.reportViewerFacturas.Size = new System.Drawing.Size(726, 497);
            this.reportViewerFacturas.TabIndex = 0;
            this.reportViewerFacturas.Load += new System.EventHandler(this.reportViewerFacturas_Load);
            // 
            // LabelBienvenido
            // 
            this.LabelBienvenido.AutoSize = true;
            this.LabelBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.LabelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBienvenido.ForeColor = System.Drawing.Color.White;
            this.LabelBienvenido.Location = new System.Drawing.Point(273, 40);
            this.LabelBienvenido.Name = "LabelBienvenido";
            this.LabelBienvenido.Size = new System.Drawing.Size(233, 29);
            this.LabelBienvenido.TabIndex = 8;
            this.LabelBienvenido.Text = "Listado de facturas";
            // 
            // ReporteListadoFacturas
            // 
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 605);
            this.Controls.Add(this.LabelBienvenido);
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
        private System.Windows.Forms.Label LabelBienvenido;
    }
}