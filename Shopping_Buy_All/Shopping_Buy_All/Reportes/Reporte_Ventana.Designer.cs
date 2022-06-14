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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMasVendido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnreporteFacturas
            // 
            this.btnreporteFacturas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnreporteFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreporteFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporteFacturas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnreporteFacturas.Location = new System.Drawing.Point(85, 22);
            this.btnreporteFacturas.Name = "btnreporteFacturas";
            this.btnreporteFacturas.Size = new System.Drawing.Size(126, 26);
            this.btnreporteFacturas.TabIndex = 0;
            this.btnreporteFacturas.Text = "Listado facturas";
            this.btnreporteFacturas.UseVisualStyleBackColor = false;
            this.btnreporteFacturas.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(85, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listado clientes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMasVendido
            // 
            this.btnMasVendido.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMasVendido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMasVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasVendido.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMasVendido.Location = new System.Drawing.Point(85, 108);
            this.btnMasVendido.Name = "btnMasVendido";
            this.btnMasVendido.Size = new System.Drawing.Size(126, 26);
            this.btnMasVendido.TabIndex = 2;
            this.btnMasVendido.Text = "Listado Productos";
            this.btnMasVendido.UseVisualStyleBackColor = false;
            this.btnMasVendido.Click += new System.EventHandler(this.btnMasVendido_Click);
            // 
            // Reportes_Ventana
            // 
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 168);
            this.Controls.Add(this.btnMasVendido);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMasVendido;
    }
}