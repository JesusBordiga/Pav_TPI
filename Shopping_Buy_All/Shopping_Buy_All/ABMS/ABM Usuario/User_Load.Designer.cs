namespace Shopping_Buy_All
{
    partial class User_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Load));
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.NombreDeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitle = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.labelUserList = new System.Windows.Forms.Label();
            this.btnUserLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textPasswordUser = new System.Windows.Forms.TextBox();
            this.textUsernameUser = new System.Windows.Forms.TextBox();
            this.labelPasswordUser = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelConfirmPasswordUser = new System.Windows.Forms.Label();
            this.textConfirmPasswordUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
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
            this.Password,
            this.Borrado});
            this.tablaUsuarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaUsuarios.Location = new System.Drawing.Point(350, 47);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.ReadOnly = true;
            this.tablaUsuarios.RowHeadersWidth = 20;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaUsuarios.Size = new System.Drawing.Size(668, 397);
            this.tablaUsuarios.TabIndex = 0;
            this.tablaUsuarios.TabStop = false;
            // 
            // NombreDeUsuario
            // 
            this.NombreDeUsuario.DataPropertyName = "NombreDeUsuario";
            this.NombreDeUsuario.HeaderText = "Nombre de Usuario";
            this.NombreDeUsuario.Name = "NombreDeUsuario";
            this.NombreDeUsuario.ReadOnly = true;
            this.NombreDeUsuario.Width = 140;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Contraseña";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 120;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(67, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(189, 29);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Cargar Usuario";
            // 
            // labelUserList
            // 
            this.labelUserList.AutoSize = true;
            this.labelUserList.BackColor = System.Drawing.Color.Transparent;
            this.labelUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserList.ForeColor = System.Drawing.Color.White;
            this.labelUserList.Location = new System.Drawing.Point(590, 11);
            this.labelUserList.Name = "labelUserList";
            this.labelUserList.Size = new System.Drawing.Size(215, 29);
            this.labelUserList.TabIndex = 28;
            this.labelUserList.Text = "Lista de Usuarios";
            // 
            // btnUserLoad
            // 
            this.btnUserLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLoad.ForeColor = System.Drawing.Color.White;
            this.btnUserLoad.Location = new System.Drawing.Point(73, 422);
            this.btnUserLoad.Name = "btnUserLoad";
            this.btnUserLoad.Size = new System.Drawing.Size(75, 23);
            this.btnUserLoad.TabIndex = 5;
            this.btnUserLoad.Text = "Cargar";
            this.btnUserLoad.UseVisualStyleBackColor = true;
            this.btnUserLoad.Click += new System.EventHandler(this.btnCargarUsuario_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(169, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textPasswordUser
            // 
            this.textPasswordUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textPasswordUser.ForeColor = System.Drawing.Color.White;
            this.textPasswordUser.Location = new System.Drawing.Point(105, 200);
            this.textPasswordUser.Name = "textPasswordUser";
            this.textPasswordUser.PasswordChar = '*';
            this.textPasswordUser.Size = new System.Drawing.Size(110, 20);
            this.textPasswordUser.TabIndex = 2;
            // 
            // textUsernameUser
            // 
            this.textUsernameUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textUsernameUser.ForeColor = System.Drawing.Color.White;
            this.textUsernameUser.Location = new System.Drawing.Point(105, 135);
            this.textUsernameUser.Name = "textUsernameUser";
            this.textUsernameUser.Size = new System.Drawing.Size(110, 20);
            this.textUsernameUser.TabIndex = 1;
            // 
            // labelPasswordUser
            // 
            this.labelPasswordUser.AutoSize = true;
            this.labelPasswordUser.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswordUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordUser.ForeColor = System.Drawing.Color.White;
            this.labelPasswordUser.Location = new System.Drawing.Point(114, 175);
            this.labelPasswordUser.Name = "labelPasswordUser";
            this.labelPasswordUser.Size = new System.Drawing.Size(91, 17);
            this.labelPasswordUser.TabIndex = 30;
            this.labelPasswordUser.Text = "Contraseña";
            this.labelPasswordUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(86, 110);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(148, 17);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Nombre de Usuario";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelConfirmPasswordUser
            // 
            this.labelConfirmPasswordUser.AutoSize = true;
            this.labelConfirmPasswordUser.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmPasswordUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPasswordUser.ForeColor = System.Drawing.Color.White;
            this.labelConfirmPasswordUser.Location = new System.Drawing.Point(77, 240);
            this.labelConfirmPasswordUser.Name = "labelConfirmPasswordUser";
            this.labelConfirmPasswordUser.Size = new System.Drawing.Size(166, 17);
            this.labelConfirmPasswordUser.TabIndex = 31;
            this.labelConfirmPasswordUser.Text = "Confirmar Contraseña";
            this.labelConfirmPasswordUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textConfirmPasswordUser
            // 
            this.textConfirmPasswordUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textConfirmPasswordUser.ForeColor = System.Drawing.Color.White;
            this.textConfirmPasswordUser.Location = new System.Drawing.Point(105, 265);
            this.textConfirmPasswordUser.Name = "textConfirmPasswordUser";
            this.textConfirmPasswordUser.PasswordChar = '*';
            this.textConfirmPasswordUser.Size = new System.Drawing.Size(110, 20);
            this.textConfirmPasswordUser.TabIndex = 3;
            // 
            // User_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 449);
            this.Controls.Add(this.textConfirmPasswordUser);
            this.Controls.Add(this.labelConfirmPasswordUser);
            this.Controls.Add(this.labelPasswordUser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUserLoad);
            this.Controls.Add(this.labelUserList);
            this.Controls.Add(this.textUsernameUser);
            this.Controls.Add(this.textPasswordUser);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tablaUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 488);
            this.MinimumSize = new System.Drawing.Size(1043, 488);
            this.Name = "User_Load";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.Label labelTitle;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label labelUserList;
        private System.Windows.Forms.Button btnUserLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textPasswordUser;
        private System.Windows.Forms.TextBox textUsernameUser;
        private System.Windows.Forms.Label labelPasswordUser;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.Label labelConfirmPasswordUser;
        private System.Windows.Forms.TextBox textConfirmPasswordUser;
    }
}