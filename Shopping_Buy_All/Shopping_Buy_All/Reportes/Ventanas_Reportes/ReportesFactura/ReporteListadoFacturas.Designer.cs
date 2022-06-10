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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewerFacturas
            // 
            this.reportViewerFacturas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reportViewerFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewerFacturas.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ListadoFactura.rdlc";
            this.reportViewerFacturas.Location = new System.Drawing.Point(12, 78);
            this.reportViewerFacturas.Name = "reportViewerFacturas";
            this.reportViewerFacturas.ServerReport.BearerToken = null;
            this.reportViewerFacturas.Size = new System.Drawing.Size(751, 460);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Odernar por";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.BackColor = System.Drawing.Color.White;
            this.cmbOrdenar.ForeColor = System.Drawing.Color.Black;
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Location = new System.Drawing.Point(334, 50);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(119, 21);
            this.cmbOrdenar.TabIndex = 13;
            this.cmbOrdenar.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenar_SelectedIndexChanged);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOrdenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.ForeColor = System.Drawing.Color.White;
            this.btnOrdenar.Location = new System.Drawing.Point(459, 49);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 14;
            this.btnOrdenar.Text = "Odenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // ReporteListadoFacturas
            // 
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 548);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.cmbOrdenar);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.Button btnOrdenar;
    }
}