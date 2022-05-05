namespace Shopping_Buy_All.ABMS.ABM_TipoVehiculo
{
    partial class VehicleType_Load
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablaTipoAuto = new System.Windows.Forms.DataGridView();
            this.CargarTipoVehiculo = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.textNameVehicle = new System.Windows.Forms.TextBox();
            this.butVehicleLoad = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.listavehiculos = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaTipoAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaTipoAuto
            // 
            this.TablaTipoAuto.AllowUserToAddRows = false;
            this.TablaTipoAuto.AllowUserToDeleteRows = false;
            this.TablaTipoAuto.AllowUserToOrderColumns = true;
            this.TablaTipoAuto.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.TablaTipoAuto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablaTipoAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaTipoAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Nombre,
            this.Borrado});
            this.TablaTipoAuto.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TablaTipoAuto.Location = new System.Drawing.Point(356, 55);
            this.TablaTipoAuto.Margin = new System.Windows.Forms.Padding(4);
            this.TablaTipoAuto.Name = "TablaTipoAuto";
            this.TablaTipoAuto.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaTipoAuto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaTipoAuto.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.TablaTipoAuto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaTipoAuto.RowTemplate.Height = 24;
            this.TablaTipoAuto.Size = new System.Drawing.Size(421, 382);
            this.TablaTipoAuto.TabIndex = 87;
            this.TablaTipoAuto.TabStop = false;
            // 
            // CargarTipoVehiculo
            // 
            this.CargarTipoVehiculo.AutoSize = true;
            this.CargarTipoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.CargarTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarTipoVehiculo.ForeColor = System.Drawing.Color.White;
            this.CargarTipoVehiculo.Location = new System.Drawing.Point(31, 74);
            this.CargarTipoVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CargarTipoVehiculo.Name = "CargarTipoVehiculo";
            this.CargarTipoVehiculo.Size = new System.Drawing.Size(295, 33);
            this.CargarTipoVehiculo.TabIndex = 32;
            this.CargarTipoVehiculo.Text = "Cargar tipo vehiculo";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.Window;
            this.name.Location = new System.Drawing.Point(143, 154);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(74, 20);
            this.name.TabIndex = 34;
            this.name.Text = "Nombre";
            // 
            // textNameVehicle
            // 
            this.textNameVehicle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameVehicle.ForeColor = System.Drawing.SystemColors.Window;
            this.textNameVehicle.Location = new System.Drawing.Point(94, 200);
            this.textNameVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.textNameVehicle.Name = "textNameVehicle";
            this.textNameVehicle.Size = new System.Drawing.Size(176, 22);
            this.textNameVehicle.TabIndex = 38;
            // 
            // butVehicleLoad
            // 
            this.butVehicleLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butVehicleLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butVehicleLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butVehicleLoad.ForeColor = System.Drawing.Color.White;
            this.butVehicleLoad.Location = new System.Drawing.Point(63, 329);
            this.butVehicleLoad.Margin = new System.Windows.Forms.Padding(4);
            this.butVehicleLoad.Name = "butVehicleLoad";
            this.butVehicleLoad.Size = new System.Drawing.Size(100, 28);
            this.butVehicleLoad.TabIndex = 52;
            this.butVehicleLoad.Text = "Cargar";
            this.butVehicleLoad.UseVisualStyleBackColor = false;
            this.butVehicleLoad.Click += new System.EventHandler(this.butVehicleLoad_Click);
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClear.ForeColor = System.Drawing.Color.White;
            this.butClear.Location = new System.Drawing.Point(197, 329);
            this.butClear.Margin = new System.Windows.Forms.Padding(4);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(100, 28);
            this.butClear.TabIndex = 53;
            this.butClear.Text = "Limpiar";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // listavehiculos
            // 
            this.listavehiculos.AutoSize = true;
            this.listavehiculos.BackColor = System.Drawing.Color.Transparent;
            this.listavehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listavehiculos.ForeColor = System.Drawing.Color.White;
            this.listavehiculos.Location = new System.Drawing.Point(438, 9);
            this.listavehiculos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listavehiculos.Name = "listavehiculos";
            this.listavehiculos.Size = new System.Drawing.Size(266, 33);
            this.listavehiculos.TabIndex = 59;
            this.listavehiculos.Text = "Lista de vehiculos";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "cod_tipo";
            this.codigo.HeaderText = "codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.MinimumWidth = 6;
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            this.Borrado.Width = 125;
            // 
            // VehicleType_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listavehiculos);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butVehicleLoad);
            this.Controls.Add(this.textNameVehicle);
            this.Controls.Add(this.name);
            this.Controls.Add(this.CargarTipoVehiculo);
            this.Controls.Add(this.TablaTipoAuto);
            this.Name = "VehicleType_Load";
            this.Text = "VehicleType_Load";
            ((System.ComponentModel.ISupportInitialize)(this.TablaTipoAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaTipoAuto;
        private System.Windows.Forms.Label CargarTipoVehiculo;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textNameVehicle;
        private System.Windows.Forms.Button butVehicleLoad;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Label listavehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}