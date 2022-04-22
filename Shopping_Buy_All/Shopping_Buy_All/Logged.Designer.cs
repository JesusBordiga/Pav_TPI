namespace Shopping_Buy_All
{
    partial class Logged
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logged));
            this.LabelBienvenido = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automovilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasDeTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelBienvenido
            // 
            this.LabelBienvenido.AutoSize = true;
            this.LabelBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.LabelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBienvenido.ForeColor = System.Drawing.Color.White;
            this.LabelBienvenido.Location = new System.Drawing.Point(-6, 421);
            this.LabelBienvenido.Name = "LabelBienvenido";
            this.LabelBienvenido.Size = new System.Drawing.Size(228, 31);
            this.LabelBienvenido.TabIndex = 7;
            this.LabelBienvenido.Text = "Bienvenido User";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.automovilesToolStripMenuItem,
            this.profesionesToolStripMenuItem,
            this.producotsToolStripMenuItem,
            this.localesToolStripMenuItem,
            this.marcasDeTarjetaToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 8;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeClienteToolStripMenuItem,
            this.modificacionDeClienteToolStripMenuItem,
            this.bajaDeClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShowShortcutKeys = false;
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.clienteToolStripMenuItem.Text = "Clientes";
            // 
            // altaDeClienteToolStripMenuItem
            // 
            this.altaDeClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.altaDeClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.altaDeClienteToolStripMenuItem.Name = "altaDeClienteToolStripMenuItem";
            this.altaDeClienteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.altaDeClienteToolStripMenuItem.Text = "Alta de Cliente";
            this.altaDeClienteToolStripMenuItem.Click += new System.EventHandler(this.altaDeClienteToolStripMenuItem_Click);
            // 
            // modificacionDeClienteToolStripMenuItem
            // 
            this.modificacionDeClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modificacionDeClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modificacionDeClienteToolStripMenuItem.Name = "modificacionDeClienteToolStripMenuItem";
            this.modificacionDeClienteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.modificacionDeClienteToolStripMenuItem.Text = "Modificacion de Cliente";
            // 
            // bajaDeClienteToolStripMenuItem
            // 
            this.bajaDeClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bajaDeClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bajaDeClienteToolStripMenuItem.Name = "bajaDeClienteToolStripMenuItem";
            this.bajaDeClienteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.bajaDeClienteToolStripMenuItem.Text = "Baja de Cliente";
            // 
            // automovilesToolStripMenuItem
            // 
            this.automovilesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.automovilesToolStripMenuItem.Name = "automovilesToolStripMenuItem";
            this.automovilesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.automovilesToolStripMenuItem.Text = "Automoviles";
            // 
            // profesionesToolStripMenuItem
            // 
            this.profesionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.profesionesToolStripMenuItem.Name = "profesionesToolStripMenuItem";
            this.profesionesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.profesionesToolStripMenuItem.Text = "Profesiones";
            // 
            // producotsToolStripMenuItem
            // 
            this.producotsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.producotsToolStripMenuItem.Name = "producotsToolStripMenuItem";
            this.producotsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.producotsToolStripMenuItem.Text = "Productos";
            // 
            // localesToolStripMenuItem
            // 
            this.localesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.localesToolStripMenuItem.Name = "localesToolStripMenuItem";
            this.localesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.localesToolStripMenuItem.Text = "Locales";
            // 
            // marcasDeTarjetaToolStripMenuItem
            // 
            this.marcasDeTarjetaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.marcasDeTarjetaToolStripMenuItem.Name = "marcasDeTarjetaToolStripMenuItem";
            this.marcasDeTarjetaToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.marcasDeTarjetaToolStripMenuItem.Text = "Marcas De Tarjeta";
            // 
            // Logged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelBienvenido);
            this.Controls.Add(this.MenuStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Logged";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logged";
            this.Load += new System.EventHandler(this.Logged_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBienvenido;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automovilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasDeTarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeClienteToolStripMenuItem;
    }
}