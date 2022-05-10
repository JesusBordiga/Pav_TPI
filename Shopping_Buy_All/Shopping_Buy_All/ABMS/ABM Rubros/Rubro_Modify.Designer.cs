namespace Shopping_Buy_All
{
    partial class Rubro_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rubro_Modify));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUserLoad = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.labelRubro = new System.Windows.Forms.Label();
            this.textRubroOld = new System.Windows.Forms.TextBox();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.NombreDeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textRubroNew = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(189, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUserLoad
            // 
            this.btnUserLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLoad.ForeColor = System.Drawing.Color.White;
            this.btnUserLoad.Location = new System.Drawing.Point(29, 316);
            this.btnUserLoad.Name = "btnUserLoad";
            this.btnUserLoad.Size = new System.Drawing.Size(75, 23);
            this.btnUserLoad.TabIndex = 6;
            this.btnUserLoad.Text = "Modificar";
            this.btnUserLoad.UseVisualStyleBackColor = true;
            this.btnUserLoad.Visible = false;
            this.btnUserLoad.Click += new System.EventHandler(this.btnUserLoad_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(281, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(215, 29);
            this.label15.TabIndex = 68;
            this.label15.Text = "Lista de Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Modificar usuario";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Location = new System.Drawing.Point(109, 316);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Buscar";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // labelRubro
            // 
            this.labelRubro.AutoSize = true;
            this.labelRubro.BackColor = System.Drawing.Color.Transparent;
            this.labelRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRubro.ForeColor = System.Drawing.Color.White;
            this.labelRubro.Location = new System.Drawing.Point(106, 120);
            this.labelRubro.Name = "labelRubro";
            this.labelRubro.Size = new System.Drawing.Size(52, 17);
            this.labelRubro.TabIndex = 73;
            this.labelRubro.Text = "Rubro";
            // 
            // textRubroOld
            // 
            this.textRubroOld.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textRubroOld.ForeColor = System.Drawing.Color.White;
            this.textRubroOld.Location = new System.Drawing.Point(77, 140);
            this.textRubroOld.Name = "textRubroOld";
            this.textRubroOld.Size = new System.Drawing.Size(110, 20);
            this.textRubroOld.TabIndex = 90;
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.AllowUserToAddRows = false;
            this.tablaUsuarios.AllowUserToDeleteRows = false;
            this.tablaUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreDeUsuario,
            this.PasswordHash,
            this.Id,
            this.Password,
            this.dataGridViewTextBoxColumn1});
            this.tablaUsuarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaUsuarios.Location = new System.Drawing.Point(286, 36);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.ReadOnly = true;
            this.tablaUsuarios.RowHeadersWidth = 20;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaUsuarios.Size = new System.Drawing.Size(205, 310);
            this.tablaUsuarios.TabIndex = 91;
            this.tablaUsuarios.TabStop = false;
            this.tablaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUsuarios_CellContentClick);
            // 
            // NombreDeUsuario
            // 
            this.NombreDeUsuario.DataPropertyName = "NombreDeUsuario";
            this.NombreDeUsuario.HeaderText = "Nombre de Usuario";
            this.NombreDeUsuario.Name = "NombreDeUsuario";
            this.NombreDeUsuario.ReadOnly = true;
            this.NombreDeUsuario.Width = 180;
            // 
            // PasswordHash
            // 
            this.PasswordHash.DataPropertyName = "PasswordHash";
            this.PasswordHash.HeaderText = "PasswordHash";
            this.PasswordHash.Name = "PasswordHash";
            this.PasswordHash.ReadOnly = true;
            this.PasswordHash.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Contraseña";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            this.Password.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Borrado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Borrado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // textRubroNew
            // 
            this.textRubroNew.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textRubroNew.ForeColor = System.Drawing.Color.White;
            this.textRubroNew.Location = new System.Drawing.Point(77, 140);
            this.textRubroNew.Name = "textRubroNew";
            this.textRubroNew.Size = new System.Drawing.Size(110, 20);
            this.textRubroNew.TabIndex = 94;
            this.textRubroNew.Visible = false;
            // 
            // Rubro_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 350);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.textRubroOld);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.labelRubro);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUserLoad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRubroNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(541, 389);
            this.MinimumSize = new System.Drawing.Size(541, 389);
            this.Name = "Rubro_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUserLoad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Label labelRubro;
        private System.Windows.Forms.TextBox textRubroOld;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textRubroNew;
    }
}