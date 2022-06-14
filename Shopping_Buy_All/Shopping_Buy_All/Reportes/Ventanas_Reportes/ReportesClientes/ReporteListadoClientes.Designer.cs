namespace Shopping_Buy_All
{
    partial class ReporteListadoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteListadoClientes));
            this.reportViewerClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LabelClientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewerClientes
            // 
            this.reportViewerClientes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reportViewerClientes.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesClientes.ListadoCliente.rdlc";
            this.reportViewerClientes.Location = new System.Drawing.Point(0, 41);
            this.reportViewerClientes.Name = "reportViewerClientes";
            this.reportViewerClientes.ServerReport.BearerToken = null;
            this.reportViewerClientes.Size = new System.Drawing.Size(958, 507);
            this.reportViewerClientes.TabIndex = 0;
            this.reportViewerClientes.Load += new System.EventHandler(this.reportViewerClientes_Load);
            // 
            // LabelClientes
            // 
            this.LabelClientes.AutoSize = true;
            this.LabelClientes.BackColor = System.Drawing.Color.Transparent;
            this.LabelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClientes.ForeColor = System.Drawing.Color.White;
            this.LabelClientes.Location = new System.Drawing.Point(362, 9);
            this.LabelClientes.Name = "LabelClientes";
            this.LabelClientes.Size = new System.Drawing.Size(233, 29);
            this.LabelClientes.TabIndex = 8;
            this.LabelClientes.Text = "Listado de clientes";
            // 
            // ReporteListadoClientes
            // 
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 546);
            this.Controls.Add(this.LabelClientes);
            this.Controls.Add(this.reportViewerClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteListadoClientes";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Clientes";
            this.Load += new System.EventHandler(this.ReporteListadoFacturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerClientes;
        private System.Windows.Forms.Label LabelClientes;
    }
}