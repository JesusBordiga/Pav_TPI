﻿namespace Shopping_Buy_All
{
    partial class Client_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_Load));
            this.tablaClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textDateBirthDay = new System.Windows.Forms.MaskedTextBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClientLoad = new System.Windows.Forms.Button();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.radioButtonSingle = new System.Windows.Forms.CheckBox();
            this.radioButtonMarried = new System.Windows.Forms.CheckBox();
            this.textNumberDoc = new System.Windows.Forms.MaskedTextBox();
            this.textStreetHeight = new System.Windows.Forms.MaskedTextBox();
            this.textStreetClient = new System.Windows.Forms.TextBox();
            this.textNameClient = new System.Windows.Forms.TextBox();
            this.textSurnameClient = new System.Windows.Forms.TextBox();
            this.DocTipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CivilStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaClientes
            // 
            this.tablaClientes.AllowUserToAddRows = false;
            this.tablaClientes.AllowUserToDeleteRows = false;
            this.tablaClientes.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocTipe,
            this.DocNumber,
            this.Lastname,
            this.Names,
            this.street,
            this.height,
            this.CivilStatus,
            this.Sex,
            this.birthDate,
            this.Estado});
            this.tablaClientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaClientes.Location = new System.Drawing.Point(262, 49);
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.ReadOnly = true;
            this.tablaClientes.Size = new System.Drawing.Size(724, 396);
            this.tablaClientes.TabIndex = 0;
            this.tablaClientes.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(85, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nro de Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(84, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Domicilio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(115, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Estado Civil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(137, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sexo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(84, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fecha de Nacimiento";
            // 
            // textDateBirthDay
            // 
            this.textDateBirthDay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textDateBirthDay.ForeColor = System.Drawing.Color.White;
            this.textDateBirthDay.Location = new System.Drawing.Point(128, 396);
            this.textDateBirthDay.Mask = "00/00/0000";
            this.textDateBirthDay.Name = "textDateBirthDay";
            this.textDateBirthDay.Size = new System.Drawing.Size(65, 20);
            this.textDateBirthDay.TabIndex = 12;
            this.textDateBirthDay.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(158, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Casado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(81, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Soltero";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(70, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Masculino";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(159, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Femenino";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(136, 356);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Otro";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(468, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(232, 31);
            this.label15.TabIndex = 28;
            this.label15.Text = "Lista de Clientes";
            // 
            // btnClientLoad
            // 
            this.btnClientLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientLoad.ForeColor = System.Drawing.Color.White;
            this.btnClientLoad.Location = new System.Drawing.Point(73, 422);
            this.btnClientLoad.Name = "btnClientLoad";
            this.btnClientLoad.Size = new System.Drawing.Size(75, 23);
            this.btnClientLoad.TabIndex = 13;
            this.btnClientLoad.Text = "Cargar";
            this.btnClientLoad.UseVisualStyleBackColor = true;
            this.btnClientLoad.Click += new System.EventHandler(this.btnClientLoad_Click);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMale.Location = new System.Drawing.Point(143, 338);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMale.TabIndex = 9;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.UseVisualStyleBackColor = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFemale.Location = new System.Drawing.Point(230, 338);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(14, 13);
            this.radioButtonFemale.TabIndex = 10;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOther.Location = new System.Drawing.Point(169, 358);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(14, 13);
            this.radioButtonOther.TabIndex = 11;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(169, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(205, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "Altura";
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxDocType.ForeColor = System.Drawing.Color.White;
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Location = new System.Drawing.Point(100, 74);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(119, 21);
            this.comboBoxDocType.TabIndex = 1;
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(133, 296);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(15, 14);
            this.radioButtonSingle.TabIndex = 7;
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarried
            // 
            this.radioButtonMarried.AutoSize = true;
            this.radioButtonMarried.Location = new System.Drawing.Point(213, 296);
            this.radioButtonMarried.Name = "radioButtonMarried";
            this.radioButtonMarried.Size = new System.Drawing.Size(15, 14);
            this.radioButtonMarried.TabIndex = 8;
            this.radioButtonMarried.UseVisualStyleBackColor = true;
            // 
            // textNumberDoc
            // 
            this.textNumberDoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNumberDoc.ForeColor = System.Drawing.Color.White;
            this.textNumberDoc.Location = new System.Drawing.Point(133, 114);
            this.textNumberDoc.Mask = "99999999";
            this.textNumberDoc.Name = "textNumberDoc";
            this.textNumberDoc.Size = new System.Drawing.Size(55, 20);
            this.textNumberDoc.TabIndex = 2;
            this.textNumberDoc.ValidatingType = typeof(int);
            // 
            // textStreetHeight
            // 
            this.textStreetHeight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textStreetHeight.ForeColor = System.Drawing.SystemColors.Window;
            this.textStreetHeight.Location = new System.Drawing.Point(212, 248);
            this.textStreetHeight.Mask = "9999";
            this.textStreetHeight.Name = "textStreetHeight";
            this.textStreetHeight.Size = new System.Drawing.Size(29, 20);
            this.textStreetHeight.TabIndex = 6;
            // 
            // textStreetClient
            // 
            this.textStreetClient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textStreetClient.ForeColor = System.Drawing.Color.White;
            this.textStreetClient.Location = new System.Drawing.Point(48, 248);
            this.textStreetClient.Name = "textStreetClient";
            this.textStreetClient.Size = new System.Drawing.Size(140, 20);
            this.textStreetClient.TabIndex = 5;
            // 
            // textNameClient
            // 
            this.textNameClient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameClient.ForeColor = System.Drawing.Color.White;
            this.textNameClient.Location = new System.Drawing.Point(109, 202);
            this.textNameClient.Name = "textNameClient";
            this.textNameClient.Size = new System.Drawing.Size(100, 20);
            this.textNameClient.TabIndex = 4;
            // 
            // textSurnameClient
            // 
            this.textSurnameClient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textSurnameClient.ForeColor = System.Drawing.Color.White;
            this.textSurnameClient.Location = new System.Drawing.Point(109, 157);
            this.textSurnameClient.Name = "textSurnameClient";
            this.textSurnameClient.Size = new System.Drawing.Size(100, 20);
            this.textSurnameClient.TabIndex = 3;
            // 
            // DocTipe
            // 
            this.DocTipe.DataPropertyName = "Tipo_Doc";
            this.DocTipe.Frozen = true;
            this.DocTipe.HeaderText = "Tipo Doc";
            this.DocTipe.Name = "DocTipe";
            this.DocTipe.ReadOnly = true;
            // 
            // DocNumber
            // 
            this.DocNumber.DataPropertyName = "Num_Doc";
            this.DocNumber.Frozen = true;
            this.DocNumber.HeaderText = "Nro Documento";
            this.DocNumber.Name = "DocNumber";
            this.DocNumber.ReadOnly = true;
            this.DocNumber.Width = 70;
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "Apellido";
            this.Lastname.Frozen = true;
            this.Lastname.HeaderText = "Apellido";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // Names
            // 
            this.Names.DataPropertyName = "Domicilio";
            this.Names.Frozen = true;
            this.Names.HeaderText = "Nombres";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 80;
            // 
            // street
            // 
            this.street.DataPropertyName = "Domicilio";
            this.street.Frozen = true;
            this.street.HeaderText = "Domicilio";
            this.street.Name = "street";
            this.street.ReadOnly = true;
            // 
            // height
            // 
            this.height.DataPropertyName = "altura";
            this.height.Frozen = true;
            this.height.HeaderText = "Altura";
            this.height.Name = "height";
            this.height.ReadOnly = true;
            this.height.Width = 50;
            // 
            // CivilStatus
            // 
            this.CivilStatus.DataPropertyName = "Estado_Civil";
            this.CivilStatus.Frozen = true;
            this.CivilStatus.HeaderText = "Estado    Civil";
            this.CivilStatus.Name = "CivilStatus";
            this.CivilStatus.ReadOnly = true;
            this.CivilStatus.Width = 50;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sexo";
            this.Sex.Frozen = true;
            this.Sex.HeaderText = "Sexo";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 50;
            // 
            // birthDate
            // 
            this.birthDate.DataPropertyName = "Fecha_Nacimiento";
            this.birthDate.Frozen = true;
            this.birthDate.HeaderText = "Fecha Nacimiento";
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            this.birthDate.Width = 80;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // Client_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 449);
            this.Controls.Add(this.textStreetHeight);
            this.Controls.Add(this.textNumberDoc);
            this.Controls.Add(this.radioButtonMarried);
            this.Controls.Add(this.radioButtonSingle);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.radioButtonOther);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.btnClientLoad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textStreetClient);
            this.Controls.Add(this.textDateBirthDay);
            this.Controls.Add(this.textSurnameClient);
            this.Controls.Add(this.textNameClient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1007, 488);
            this.MinimumSize = new System.Drawing.Size(1007, 488);
            this.Name = "Client_Load";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox textDateBirthDay;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClientLoad;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.CheckBox radioButtonSingle;
        private System.Windows.Forms.CheckBox radioButtonMarried;
        private System.Windows.Forms.MaskedTextBox textNumberDoc;
        private System.Windows.Forms.MaskedTextBox textStreetHeight;
        private System.Windows.Forms.TextBox textStreetClient;
        private System.Windows.Forms.TextBox textNameClient;
        private System.Windows.Forms.TextBox textSurnameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocTipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn CivilStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}