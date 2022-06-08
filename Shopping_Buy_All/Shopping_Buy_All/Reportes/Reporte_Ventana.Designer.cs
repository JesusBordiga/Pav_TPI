namespace Shopping_Buy_All
{
    partial class Reportes_Ventana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes_Ventana));
            this.btnreporteFacturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnreporteFacturas
            // 
            this.btnreporteFacturas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnreporteFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreporteFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporteFacturas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnreporteFacturas.Location = new System.Drawing.Point(84, 80);
            this.btnreporteFacturas.Name = "btnreporteFacturas";
            this.btnreporteFacturas.Size = new System.Drawing.Size(126, 26);
            this.btnreporteFacturas.TabIndex = 0;
            this.btnreporteFacturas.Text = "Listado facturas";
            this.btnreporteFacturas.UseVisualStyleBackColor = false;
            this.btnreporteFacturas.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // Reportes_Ventana
            // 
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 168);
            this.Controls.Add(this.btnreporteFacturas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reportes_Ventana";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button btnreporteFacturas;
    }
}