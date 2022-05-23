namespace Shopping_Buy_All
{
    partial class Client_Modify
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_Modify));
            this.textStreetHeight = new System.Windows.Forms.MaskedTextBox();
            this.textNumberDoc = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClientLoad = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Label();
            this.textStreetClient = new System.Windows.Forms.TextBox();
            this.textDateBirthDay = new System.Windows.Forms.MaskedTextBox();
            this.textSurnameClient = new System.Windows.Forms.TextBox();
            this.textNameClient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.btnSearchClient2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PanelEstadoCivil = new System.Windows.Forms.Panel();
            this.radioButtonMarried = new System.Windows.Forms.RadioButton();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.tablaClientes = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.PanelEstadoCivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textStreetHeight
            // 
            this.textStreetHeight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textStreetHeight.ForeColor = System.Drawing.SystemColors.Window;
            this.textStreetHeight.Location = new System.Drawing.Point(200, 109);
            this.textStreetHeight.Mask = "9999";
            this.textStreetHeight.Name = "textStreetHeight";
            this.textStreetHeight.Size = new System.Drawing.Size(30, 20);
            this.textStreetHeight.TabIndex = 42;
            this.textStreetHeight.ValidatingType = typeof(int);
            // 
            // textNumberDoc
            // 
            this.textNumberDoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNumberDoc.ForeColor = System.Drawing.Color.White;
            this.textNumberDoc.Location = new System.Drawing.Point(139, 110);
            this.textNumberDoc.Mask = "99999999";
            this.textNumberDoc.Name = "textNumberDoc";
            this.textNumberDoc.Size = new System.Drawing.Size(55, 20);
            this.textNumberDoc.TabIndex = 33;
            this.textNumberDoc.ValidatingType = typeof(int);
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxDocType.ForeColor = System.Drawing.Color.White;
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Location = new System.Drawing.Point(112, 70);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(119, 21);
            this.comboBoxDocType.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(191, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 17);
            this.label16.TabIndex = 60;
            this.label16.Text = "Altura";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(83, 284);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClientLoad
            // 
            this.btnClientLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClientLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientLoad.ForeColor = System.Drawing.Color.White;
            this.btnClientLoad.Location = new System.Drawing.Point(2, 284);
            this.btnClientLoad.Name = "btnClientLoad";
            this.btnClientLoad.Size = new System.Drawing.Size(75, 23);
            this.btnClientLoad.TabIndex = 52;
            this.btnClientLoad.Text = "Modificar";
            this.btnClientLoad.UseVisualStyleBackColor = false;
            this.btnClientLoad.Click += new System.EventHandler(this.btnClientLoad_Click_1);
            // 
            // panelSearch
            // 
            this.panelSearch.AutoSize = true;
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSearch.ForeColor = System.Drawing.Color.White;
            this.panelSearch.Location = new System.Drawing.Point(622, 20);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(173, 25);
            this.panelSearch.TabIndex = 59;
            this.panelSearch.Text = "Lista de Clientes";
            // 
            // textStreetClient
            // 
            this.textStreetClient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textStreetClient.ForeColor = System.Drawing.Color.White;
            this.textStreetClient.Location = new System.Drawing.Point(37, 109);
            this.textStreetClient.Name = "textStreetClient";
            this.textStreetClient.Size = new System.Drawing.Size(140, 20);
            this.textStreetClient.TabIndex = 40;
            // 
            // textDateBirthDay
            // 
            this.textDateBirthDay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textDateBirthDay.ForeColor = System.Drawing.Color.White;
            this.textDateBirthDay.Location = new System.Drawing.Point(115, 257);
            this.textDateBirthDay.Mask = "00/00/0000";
            this.textDateBirthDay.Name = "textDateBirthDay";
            this.textDateBirthDay.Size = new System.Drawing.Size(64, 20);
            this.textDateBirthDay.TabIndex = 51;
            this.textDateBirthDay.ValidatingType = typeof(System.DateTime);
            // 
            // textSurnameClient
            // 
            this.textSurnameClient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textSurnameClient.ForeColor = System.Drawing.Color.White;
            this.textSurnameClient.Location = new System.Drawing.Point(95, 18);
            this.textSurnameClient.Name = "textSurnameClient";
            this.textSurnameClient.Size = new System.Drawing.Size(100, 20);
            this.textSurnameClient.TabIndex = 36;
            // 
            // textNameClient
            // 
            this.textNameClient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameClient.ForeColor = System.Drawing.Color.White;
            this.textNameClient.Location = new System.Drawing.Point(95, 63);
            this.textNameClient.Name = "textNameClient";
            this.textNameClient.Size = new System.Drawing.Size(100, 20);
            this.textNameClient.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(70, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Fecha de Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(119, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(101, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Estado Civil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(70, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(103, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nro de Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(103, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tipo de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(113, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Buscar cliente";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient.ForeColor = System.Drawing.Color.White;
            this.btnSearchClient.Location = new System.Drawing.Point(186, 414);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient.TabIndex = 62;
            this.btnSearchClient.Text = "Buscar";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnBuscarCliente_click);
            // 
            // btnSearchClient2
            // 
            this.btnSearchClient2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearchClient2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchClient2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient2.ForeColor = System.Drawing.Color.White;
            this.btnSearchClient2.Location = new System.Drawing.Point(163, 284);
            this.btnSearchClient2.Name = "btnSearchClient2";
            this.btnSearchClient2.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient2.TabIndex = 63;
            this.btnSearchClient2.Text = "Buscar";
            this.btnSearchClient2.UseVisualStyleBackColor = false;
            this.btnSearchClient2.Click += new System.EventHandler(this.btnSearchClient2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(144, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 54;
            this.label10.Text = "Casado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(67, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 55;
            this.label11.Text = "Soltero";
            // 
            // PanelEstadoCivil
            // 
            this.PanelEstadoCivil.BackColor = System.Drawing.Color.Transparent;
            this.PanelEstadoCivil.Controls.Add(this.radioButtonMarried);
            this.PanelEstadoCivil.Controls.Add(this.radioButtonSingle);
            this.PanelEstadoCivil.Location = new System.Drawing.Point(57, 153);
            this.PanelEstadoCivil.Name = "PanelEstadoCivil";
            this.PanelEstadoCivil.Size = new System.Drawing.Size(162, 19);
            this.PanelEstadoCivil.TabIndex = 7;
            // 
            // radioButtonMarried
            // 
            this.radioButtonMarried.AutoSize = true;
            this.radioButtonMarried.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMarried.Location = new System.Drawing.Point(145, 3);
            this.radioButtonMarried.Name = "radioButtonMarried";
            this.radioButtonMarried.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMarried.TabIndex = 8;
            this.radioButtonMarried.TabStop = true;
            this.radioButtonMarried.UseVisualStyleBackColor = false;
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSingle.Location = new System.Drawing.Point(64, 3);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(14, 13);
            this.radioButtonSingle.TabIndex = 7;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.UseVisualStyleBackColor = false;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxSex.ForeColor = System.Drawing.Color.White;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(80, 201);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(119, 21);
            this.comboBoxSex.TabIndex = 8;
            // 
            // tablaClientes
            // 
            this.tablaClientes.AllowUserToAddRows = false;
            this.tablaClientes.AllowUserToDeleteRows = false;
            this.tablaClientes.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.NroDocumento,
            this.Apellido,
            this.Nombres,
            this.Calle,
            this.NroCalle,
            this.EstadoCivil,
            this.Sexo,
            this.FechaNacimiento,
            this.Borrado,
            this.TipoDoc,
            this.EstadoCiv,
            this.Sex});
            this.tablaClientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaClientes.Location = new System.Drawing.Point(368, 48);
            this.tablaClientes.MultiSelect = false;
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.ReadOnly = true;
            this.tablaClientes.RowHeadersWidth = 10;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaClientes.Size = new System.Drawing.Size(654, 397);
            this.tablaClientes.TabIndex = 66;
            this.tablaClientes.TabStop = false;
            this.tablaClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaClientes_CellContentClick);
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 70;
            // 
            // NroDocumento
            // 
            this.NroDocumento.DataPropertyName = "NroDocumento";
            this.NroDocumento.HeaderText = "Nro Documento";
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            this.NroDocumento.Width = 70;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 70;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 80;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "Calle";
            this.Calle.HeaderText = "Domicilio";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // NroCalle
            // 
            this.NroCalle.DataPropertyName = "NroCalle";
            this.NroCalle.HeaderText = "Nro Calle";
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.ReadOnly = true;
            this.NroCalle.Width = 50;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.DataPropertyName = "EstadoCivil";
            this.EstadoCivil.HeaderText = "Estado Civil";
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.ReadOnly = true;
            this.EstadoCivil.Width = 50;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 60;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 80;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // TipoDoc
            // 
            this.TipoDoc.DataPropertyName = "TipoDoc";
            this.TipoDoc.HeaderText = "TipoDoc";
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.ReadOnly = true;
            this.TipoDoc.Visible = false;
            // 
            // EstadoCiv
            // 
            this.EstadoCiv.DataPropertyName = "EstadoCiv";
            this.EstadoCiv.HeaderText = "EstadoCiv";
            this.EstadoCiv.Name = "EstadoCiv";
            this.EstadoCiv.ReadOnly = true;
            this.EstadoCiv.Visible = false;
            this.EstadoCiv.Width = 5;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Visible = false;
            this.Sex.Width = 5;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.textNameClient);
            this.searchPanel.Controls.Add(this.btnClear);
            this.searchPanel.Controls.Add(this.btnSearchClient2);
            this.searchPanel.Controls.Add(this.comboBoxSex);
            this.searchPanel.Controls.Add(this.PanelEstadoCivil);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.textStreetHeight);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.label6);
            this.searchPanel.Controls.Add(this.label7);
            this.searchPanel.Controls.Add(this.label8);
            this.searchPanel.Controls.Add(this.label16);
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Controls.Add(this.btnClientLoad);
            this.searchPanel.Controls.Add(this.textSurnameClient);
            this.searchPanel.Controls.Add(this.textDateBirthDay);
            this.searchPanel.Controls.Add(this.label11);
            this.searchPanel.Controls.Add(this.textStreetClient);
            this.searchPanel.Controls.Add(this.label10);
            this.searchPanel.Location = new System.Drawing.Point(23, 130);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(245, 314);
            this.searchPanel.TabIndex = 67;
            // 
            // Client_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 449);
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.textNumberDoc);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 488);
            this.MinimumSize = new System.Drawing.Size(1043, 488);
            this.Name = "Client_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Clientes";
            this.PanelEstadoCivil.ResumeLayout(false);
            this.PanelEstadoCivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textStreetHeight;
        private System.Windows.Forms.MaskedTextBox textNumberDoc;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClientLoad;
        private System.Windows.Forms.Label panelSearch;
        private System.Windows.Forms.TextBox textStreetClient;
        private System.Windows.Forms.MaskedTextBox textDateBirthDay;
        private System.Windows.Forms.TextBox textSurnameClient;
        private System.Windows.Forms.TextBox textNameClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Button btnSearchClient2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel PanelEstadoCivil;
        private System.Windows.Forms.RadioButton radioButtonMarried;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.DataGridView tablaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.Panel searchPanel;
    }
}