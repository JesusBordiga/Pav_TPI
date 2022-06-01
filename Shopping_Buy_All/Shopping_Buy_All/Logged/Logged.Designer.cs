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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logged));
            this.LabelBienvenido = new System.Windows.Forms.Label();
            this.btnMenu1 = new System.Windows.Forms.Button();
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonFacturacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureAutomoviles = new System.Windows.Forms.PictureBox();
            this.pictureTarjetas = new System.Windows.Forms.PictureBox();
            this.pictureProductos = new System.Windows.Forms.PictureBox();
            this.pictureLocales = new System.Windows.Forms.PictureBox();
            this.pictureProfesiones = new System.Windows.Forms.PictureBox();
            this.pictureClientes = new System.Windows.Forms.PictureBox();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnMarcasTarjetas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnLocales = new System.Windows.Forms.Button();
            this.btnProfesiones = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.HourTime = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAutomoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLocales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelBienvenido
            // 
            this.LabelBienvenido.AutoSize = true;
            this.LabelBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.LabelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBienvenido.ForeColor = System.Drawing.Color.White;
            this.LabelBienvenido.Location = new System.Drawing.Point(297, 22);
            this.LabelBienvenido.Name = "LabelBienvenido";
            this.LabelBienvenido.Size = new System.Drawing.Size(206, 29);
            this.LabelBienvenido.TabIndex = 7;
            this.LabelBienvenido.Text = "Bienvenido User";
            // 
            // btnMenu1
            // 
            this.btnMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu1.ForeColor = System.Drawing.Color.White;
            this.btnMenu1.Location = new System.Drawing.Point(356, 364);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(87, 24);
            this.btnMenu1.TabIndex = 14;
            this.btnMenu1.Text = "Abrir Menu";
            this.btnMenu1.UseVisualStyleBackColor = false;
            this.btnMenu1.Click += new System.EventHandler(this.btnClientLoad_Click);
            // 
            // btnMenu2
            // 
            this.btnMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu2.ForeColor = System.Drawing.Color.White;
            this.btnMenu2.Location = new System.Drawing.Point(356, 364);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(86, 24);
            this.btnMenu2.TabIndex = 34;
            this.btnMenu2.Text = "Cerrar Menu";
            this.btnMenu2.UseVisualStyleBackColor = false;
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.White;
            this.labelHora.Location = new System.Drawing.Point(693, 434);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(108, 15);
            this.labelHora.TabIndex = 37;
            this.labelHora.Text = "Hora: ss:mm:hh";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(707, 417);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(87, 15);
            this.labelFecha.TabIndex = 38;
            this.labelFecha.Text = "dd/mm/aaaa";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.buttonFacturacion);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.pictureAutomoviles);
            this.panelMenu.Controls.Add(this.pictureTarjetas);
            this.panelMenu.Controls.Add(this.pictureProductos);
            this.panelMenu.Controls.Add(this.pictureLocales);
            this.panelMenu.Controls.Add(this.pictureProfesiones);
            this.panelMenu.Controls.Add(this.pictureClientes);
            this.panelMenu.Controls.Add(this.btnVehiculos);
            this.panelMenu.Controls.Add(this.btnMarcasTarjetas);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnLocales);
            this.panelMenu.Controls.Add(this.btnProfesiones);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Location = new System.Drawing.Point(234, 68);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(334, 286);
            this.panelMenu.TabIndex = 41;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.fritzing;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(197, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 57);
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.buttonFacturacion_Click);
            // 
            // buttonFacturacion
            // 
            this.buttonFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFacturacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacturacion.ForeColor = System.Drawing.Color.White;
            this.buttonFacturacion.Location = new System.Drawing.Point(189, 252);
            this.buttonFacturacion.Name = "buttonFacturacion";
            this.buttonFacturacion.Size = new System.Drawing.Size(75, 23);
            this.buttonFacturacion.TabIndex = 55;
            this.buttonFacturacion.Text = "Facturación";
            this.buttonFacturacion.UseVisualStyleBackColor = false;
            this.buttonFacturacion.Click += new System.EventHandler(this.buttonFacturacion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(81, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 55);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(61, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "Usuarios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pictureAutomoviles
            // 
            this.pictureAutomoviles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureAutomoviles.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.vnote;
            this.pictureAutomoviles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureAutomoviles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAutomoviles.Location = new System.Drawing.Point(250, 101);
            this.pictureAutomoviles.Name = "pictureAutomoviles";
            this.pictureAutomoviles.Size = new System.Drawing.Size(58, 55);
            this.pictureAutomoviles.TabIndex = 52;
            this.pictureAutomoviles.TabStop = false;
            this.pictureAutomoviles.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // pictureTarjetas
            // 
            this.pictureTarjetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureTarjetas.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.terminator;
            this.pictureTarjetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTarjetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureTarjetas.Location = new System.Drawing.Point(134, 102);
            this.pictureTarjetas.Name = "pictureTarjetas";
            this.pictureTarjetas.Size = new System.Drawing.Size(58, 55);
            this.pictureTarjetas.TabIndex = 51;
            this.pictureTarjetas.TabStop = false;
            this.pictureTarjetas.Click += new System.EventHandler(this.btnMarcasTarjetas_Click);
            // 
            // pictureProductos
            // 
            this.pictureProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureProductos.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.icons;
            this.pictureProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureProductos.Location = new System.Drawing.Point(22, 101);
            this.pictureProductos.Name = "pictureProductos";
            this.pictureProductos.Size = new System.Drawing.Size(58, 55);
            this.pictureProductos.TabIndex = 50;
            this.pictureProductos.TabStop = false;
            this.pictureProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pictureLocales
            // 
            this.pictureLocales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureLocales.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.software_manager;
            this.pictureLocales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLocales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLocales.Location = new System.Drawing.Point(250, 8);
            this.pictureLocales.Name = "pictureLocales";
            this.pictureLocales.Size = new System.Drawing.Size(58, 55);
            this.pictureLocales.TabIndex = 49;
            this.pictureLocales.TabStop = false;
            this.pictureLocales.Click += new System.EventHandler(this.btnLocales_Click);
            // 
            // pictureProfesiones
            // 
            this.pictureProfesiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureProfesiones.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.menu_editor1;
            this.pictureProfesiones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureProfesiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureProfesiones.Location = new System.Drawing.Point(134, 8);
            this.pictureProfesiones.Name = "pictureProfesiones";
            this.pictureProfesiones.Size = new System.Drawing.Size(58, 55);
            this.pictureProfesiones.TabIndex = 48;
            this.pictureProfesiones.TabStop = false;
            this.pictureProfesiones.Click += new System.EventHandler(this.btnProfesiones_Click);
            // 
            // pictureClientes
            // 
            this.pictureClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureClientes.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.users;
            this.pictureClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClientes.Location = new System.Drawing.Point(22, 8);
            this.pictureClientes.Name = "pictureClientes";
            this.pictureClientes.Size = new System.Drawing.Size(58, 55);
            this.pictureClientes.TabIndex = 47;
            this.pictureClientes.TabStop = false;
            this.pictureClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehiculos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.ForeColor = System.Drawing.Color.White;
            this.btnVehiculos.Location = new System.Drawing.Point(242, 162);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(75, 23);
            this.btnVehiculos.TabIndex = 46;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = false;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnMarcasTarjetas
            // 
            this.btnMarcasTarjetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMarcasTarjetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcasTarjetas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMarcasTarjetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcasTarjetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcasTarjetas.ForeColor = System.Drawing.Color.White;
            this.btnMarcasTarjetas.Location = new System.Drawing.Point(114, 162);
            this.btnMarcasTarjetas.Name = "btnMarcasTarjetas";
            this.btnMarcasTarjetas.Size = new System.Drawing.Size(106, 23);
            this.btnMarcasTarjetas.TabIndex = 45;
            this.btnMarcasTarjetas.Text = "Marcas de Tarjeta";
            this.btnMarcasTarjetas.UseVisualStyleBackColor = false;
            this.btnMarcasTarjetas.Click += new System.EventHandler(this.btnMarcasTarjetas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(14, 162);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(75, 23);
            this.btnProductos.TabIndex = 44;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnLocales
            // 
            this.btnLocales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLocales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLocales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocales.ForeColor = System.Drawing.Color.White;
            this.btnLocales.Location = new System.Drawing.Point(242, 68);
            this.btnLocales.Name = "btnLocales";
            this.btnLocales.Size = new System.Drawing.Size(75, 23);
            this.btnLocales.TabIndex = 43;
            this.btnLocales.Text = "Locales";
            this.btnLocales.UseVisualStyleBackColor = false;
            this.btnLocales.Click += new System.EventHandler(this.btnLocales_Click);
            // 
            // btnProfesiones
            // 
            this.btnProfesiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfesiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesiones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfesiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesiones.ForeColor = System.Drawing.Color.White;
            this.btnProfesiones.Location = new System.Drawing.Point(126, 68);
            this.btnProfesiones.Name = "btnProfesiones";
            this.btnProfesiones.Size = new System.Drawing.Size(75, 23);
            this.btnProfesiones.TabIndex = 42;
            this.btnProfesiones.Text = "Profesiones";
            this.btnProfesiones.UseVisualStyleBackColor = false;
            this.btnProfesiones.Click += new System.EventHandler(this.btnProfesiones_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(14, 68);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 23);
            this.btnClientes.TabIndex = 41;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // HourTime
            // 
            this.HourTime.Tick += new System.EventHandler(this.HourTime_Tick);
            // 
            // Logged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.btnMenu1);
            this.Controls.Add(this.LabelBienvenido);
            this.Controls.Add(this.btnMenu2);
            this.Controls.Add(this.panelMenu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Logged";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logged";
            this.Load += new System.EventHandler(this.Logged_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAutomoviles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLocales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBienvenido;
        private System.Windows.Forms.Button btnMenu1;
        private System.Windows.Forms.Button btnMenu2;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureAutomoviles;
        private System.Windows.Forms.PictureBox pictureTarjetas;
        private System.Windows.Forms.PictureBox pictureProductos;
        private System.Windows.Forms.PictureBox pictureLocales;
        private System.Windows.Forms.PictureBox pictureProfesiones;
        private System.Windows.Forms.PictureBox pictureClientes;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnMarcasTarjetas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnLocales;
        private System.Windows.Forms.Button btnProfesiones;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Timer HourTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonFacturacion;
    }
}