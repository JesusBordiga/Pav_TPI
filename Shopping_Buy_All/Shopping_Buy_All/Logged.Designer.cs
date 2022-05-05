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
            this.detalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeSexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeSexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDeSexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeTipoDeDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeTipoDeDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDeTipoDeDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoCivilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeEstadoCivilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeEstadoCivilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDeEstadoCivilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automovilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDeLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeTipoComercioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDeTipoComercioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeTipoComercioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.bajaDeClienteToolStripMenuItem,
            this.detalleToolStripMenuItem});
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
            this.modificacionDeClienteToolStripMenuItem.Click += new System.EventHandler(this.modificacionDeClienteToolStripMenuItem_Click);
            // 
            // bajaDeClienteToolStripMenuItem
            // 
            this.bajaDeClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bajaDeClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bajaDeClienteToolStripMenuItem.Name = "bajaDeClienteToolStripMenuItem";
            this.bajaDeClienteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.bajaDeClienteToolStripMenuItem.Text = "Baja de Cliente";
            this.bajaDeClienteToolStripMenuItem.Click += new System.EventHandler(this.bajaDeClienteToolStripMenuItem_Click);
            // 
            // detalleToolStripMenuItem
            // 
            this.detalleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.detalleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sexoToolStripMenuItem,
            this.tipoDeDocumentoToolStripMenuItem,
            this.estadoCivilToolStripMenuItem});
            this.detalleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.detalleToolStripMenuItem.Name = "detalleToolStripMenuItem";
            this.detalleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.detalleToolStripMenuItem.Text = "Detalle";
            // 
            // sexoToolStripMenuItem
            // 
            this.sexoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sexoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeSexoToolStripMenuItem,
            this.bajaDeSexoToolStripMenuItem,
            this.modificacionDeSexoToolStripMenuItem});
            this.sexoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sexoToolStripMenuItem.Name = "sexoToolStripMenuItem";
            this.sexoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sexoToolStripMenuItem.Text = "Sexo";
            // 
            // altaDeSexoToolStripMenuItem
            // 
            this.altaDeSexoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.altaDeSexoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.altaDeSexoToolStripMenuItem.Name = "altaDeSexoToolStripMenuItem";
            this.altaDeSexoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.altaDeSexoToolStripMenuItem.Text = "Alta de Sexo";
            this.altaDeSexoToolStripMenuItem.Click += new System.EventHandler(this.altaDeSexoToolStripMenuItem_Click);
            // 
            // bajaDeSexoToolStripMenuItem
            // 
            this.bajaDeSexoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bajaDeSexoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bajaDeSexoToolStripMenuItem.Name = "bajaDeSexoToolStripMenuItem";
            this.bajaDeSexoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.bajaDeSexoToolStripMenuItem.Text = "Baja de Sexo";
            // 
            // modificacionDeSexoToolStripMenuItem
            // 
            this.modificacionDeSexoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modificacionDeSexoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modificacionDeSexoToolStripMenuItem.Name = "modificacionDeSexoToolStripMenuItem";
            this.modificacionDeSexoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.modificacionDeSexoToolStripMenuItem.Text = "Modificacion de Sexo";
            // 
            // tipoDeDocumentoToolStripMenuItem
            // 
            this.tipoDeDocumentoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipoDeDocumentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeTipoDeDocumentoToolStripMenuItem,
            this.bajaDeTipoDeDocumentoToolStripMenuItem,
            this.modificacionDeTipoDeDocumentoToolStripMenuItem});
            this.tipoDeDocumentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tipoDeDocumentoToolStripMenuItem.Name = "tipoDeDocumentoToolStripMenuItem";
            this.tipoDeDocumentoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tipoDeDocumentoToolStripMenuItem.Text = "Tipo de Documento";
            // 
            // altaDeTipoDeDocumentoToolStripMenuItem
            // 
            this.altaDeTipoDeDocumentoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.altaDeTipoDeDocumentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.altaDeTipoDeDocumentoToolStripMenuItem.Name = "altaDeTipoDeDocumentoToolStripMenuItem";
            this.altaDeTipoDeDocumentoToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.altaDeTipoDeDocumentoToolStripMenuItem.Text = "Alta de Tipo de Documento";
            this.altaDeTipoDeDocumentoToolStripMenuItem.Click += new System.EventHandler(this.altaDeTipoDeDocumentoToolStripMenuItem_Click);
            // 
            // bajaDeTipoDeDocumentoToolStripMenuItem
            // 
            this.bajaDeTipoDeDocumentoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bajaDeTipoDeDocumentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bajaDeTipoDeDocumentoToolStripMenuItem.Name = "bajaDeTipoDeDocumentoToolStripMenuItem";
            this.bajaDeTipoDeDocumentoToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.bajaDeTipoDeDocumentoToolStripMenuItem.Text = "Baja de Tipo de Documento";
            // 
            // modificacionDeTipoDeDocumentoToolStripMenuItem
            // 
            this.modificacionDeTipoDeDocumentoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modificacionDeTipoDeDocumentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modificacionDeTipoDeDocumentoToolStripMenuItem.Name = "modificacionDeTipoDeDocumentoToolStripMenuItem";
            this.modificacionDeTipoDeDocumentoToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.modificacionDeTipoDeDocumentoToolStripMenuItem.Text = "Modificacion de Tipo de Documento";
            // 
            // estadoCivilToolStripMenuItem
            // 
            this.estadoCivilToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.estadoCivilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeEstadoCivilToolStripMenuItem,
            this.bajaDeEstadoCivilToolStripMenuItem,
            this.modificacionDeEstadoCivilToolStripMenuItem});
            this.estadoCivilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.estadoCivilToolStripMenuItem.Name = "estadoCivilToolStripMenuItem";
            this.estadoCivilToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.estadoCivilToolStripMenuItem.Text = "Estado Civil";
            // 
            // altaDeEstadoCivilToolStripMenuItem
            // 
            this.altaDeEstadoCivilToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.altaDeEstadoCivilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.altaDeEstadoCivilToolStripMenuItem.Name = "altaDeEstadoCivilToolStripMenuItem";
            this.altaDeEstadoCivilToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.altaDeEstadoCivilToolStripMenuItem.Text = "Alta de Estado Civil";
            this.altaDeEstadoCivilToolStripMenuItem.Click += new System.EventHandler(this.altaDeEstadoCivilToolStripMenuItem_Click);
            // 
            // bajaDeEstadoCivilToolStripMenuItem
            // 
            this.bajaDeEstadoCivilToolStripMenuItem.AutoToolTip = true;
            this.bajaDeEstadoCivilToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bajaDeEstadoCivilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bajaDeEstadoCivilToolStripMenuItem.Name = "bajaDeEstadoCivilToolStripMenuItem";
            this.bajaDeEstadoCivilToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.bajaDeEstadoCivilToolStripMenuItem.Text = "Baja de Estado Civil";
            // 
            // modificacionDeEstadoCivilToolStripMenuItem
            // 
            this.modificacionDeEstadoCivilToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modificacionDeEstadoCivilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modificacionDeEstadoCivilToolStripMenuItem.Name = "modificacionDeEstadoCivilToolStripMenuItem";
            this.modificacionDeEstadoCivilToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.modificacionDeEstadoCivilToolStripMenuItem.Text = "Modificacion de Estado Civil";
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
            this.producotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaProductoToolStripMenuItem,
            this.modificaciónProductosToolStripMenuItem,
            this.bajaProductosToolStripMenuItem});
            this.producotsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.producotsToolStripMenuItem.Name = "producotsToolStripMenuItem";
            this.producotsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.producotsToolStripMenuItem.Text = "Productos";
            // 
            // altaProductoToolStripMenuItem
            // 
            this.altaProductoToolStripMenuItem.Name = "altaProductoToolStripMenuItem";
            this.altaProductoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.altaProductoToolStripMenuItem.Text = "Alta Productos";
            this.altaProductoToolStripMenuItem.Click += new System.EventHandler(this.altaProductoToolStripMenuItem_Click);
            // 
            // modificaciónProductosToolStripMenuItem
            // 
            this.modificaciónProductosToolStripMenuItem.Name = "modificaciónProductosToolStripMenuItem";
            this.modificaciónProductosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.modificaciónProductosToolStripMenuItem.Text = "Modificación Productos";
            this.modificaciónProductosToolStripMenuItem.Click += new System.EventHandler(this.modificaciónProductosToolStripMenuItem_Click);
            // 
            // bajaProductosToolStripMenuItem
            // 
            this.bajaProductosToolStripMenuItem.Name = "bajaProductosToolStripMenuItem";
            this.bajaProductosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.bajaProductosToolStripMenuItem.Text = "Baja Productos";
            this.bajaProductosToolStripMenuItem.Click += new System.EventHandler(this.bajaProductosToolStripMenuItem_Click);
            // 
            // localesToolStripMenuItem
            // 
            this.localesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaLocalToolStripMenuItem,
            this.modificacionDeLocalToolStripMenuItem,
            this.bajaDeLocalToolStripMenuItem,
            this.altaDeTipoComercioToolStripMenuItem,
            this.modificacionDeTipoComercioToolStripMenuItem,
            this.bajaDeTipoComercioToolStripMenuItem});
            this.localesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.localesToolStripMenuItem.Name = "localesToolStripMenuItem";
            this.localesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.localesToolStripMenuItem.Text = "Locales";
            // 
            // altaLocalToolStripMenuItem
            // 
            this.altaLocalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.altaLocalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.altaLocalToolStripMenuItem.Name = "altaLocalToolStripMenuItem";
            this.altaLocalToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.altaLocalToolStripMenuItem.Text = "Alta de Local";
            this.altaLocalToolStripMenuItem.Click += new System.EventHandler(this.altaLocalToolStripMenuItem_Click);
            // 
            // modificacionDeLocalToolStripMenuItem
            // 
            this.modificacionDeLocalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modificacionDeLocalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modificacionDeLocalToolStripMenuItem.Name = "modificacionDeLocalToolStripMenuItem";
            this.modificacionDeLocalToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.modificacionDeLocalToolStripMenuItem.Text = "Modificacion de Local";
            this.modificacionDeLocalToolStripMenuItem.Click += new System.EventHandler(this.modificacionDeLocalToolStripMenuItem_Click);
            // 
            // bajaDeLocalToolStripMenuItem
            // 
            this.bajaDeLocalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bajaDeLocalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bajaDeLocalToolStripMenuItem.Name = "bajaDeLocalToolStripMenuItem";
            this.bajaDeLocalToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.bajaDeLocalToolStripMenuItem.Text = "Baja de Local";
            this.bajaDeLocalToolStripMenuItem.Click += new System.EventHandler(this.bajaDeLocalToolStripMenuItem_Click);
            // 
            // altaDeTipoComercioToolStripMenuItem
            // 
            this.altaDeTipoComercioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.altaDeTipoComercioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.altaDeTipoComercioToolStripMenuItem.Name = "altaDeTipoComercioToolStripMenuItem";
            this.altaDeTipoComercioToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.altaDeTipoComercioToolStripMenuItem.Text = "Alta de Tipo Comercio";
            this.altaDeTipoComercioToolStripMenuItem.Click += new System.EventHandler(this.altaDeTipoComercioToolStripMenuItem_Click);
            // 
            // modificacionDeTipoComercioToolStripMenuItem
            // 
            this.modificacionDeTipoComercioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modificacionDeTipoComercioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modificacionDeTipoComercioToolStripMenuItem.Name = "modificacionDeTipoComercioToolStripMenuItem";
            this.modificacionDeTipoComercioToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.modificacionDeTipoComercioToolStripMenuItem.Text = "Modificacion de Tipo Comercio";
            this.modificacionDeTipoComercioToolStripMenuItem.Click += new System.EventHandler(this.modificacionDeTipoComercioToolStripMenuItem_Click);
            // 
            // bajaDeTipoComercioToolStripMenuItem
            // 
            this.bajaDeTipoComercioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bajaDeTipoComercioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bajaDeTipoComercioToolStripMenuItem.Name = "bajaDeTipoComercioToolStripMenuItem";
            this.bajaDeTipoComercioToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.bajaDeTipoComercioToolStripMenuItem.Text = "Baja de Tipo Comercio";
            this.bajaDeTipoComercioToolStripMenuItem.Click += new System.EventHandler(this.bajaDeTipoComercioToolStripMenuItem_Click);
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
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ToolStripMenuItem altaLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDeLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeTipoComercioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDeTipoComercioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeTipoComercioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoCivilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeSexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeSexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDeSexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeTipoDeDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeTipoDeDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDeTipoDeDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeEstadoCivilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeEstadoCivilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDeEstadoCivilToolStripMenuItem;
    }
}