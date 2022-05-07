namespace Shopping_Buy_All.ABMS.ABM_TipoVehiculo
{
    partial class VehicleType_Delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodeType = new System.Windows.Forms.TextBox();
            this.btnSearchType = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.tablaTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textNameType = new System.Windows.Forms.TextBox();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnSerachType2 = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 33);
            this.label1.TabIndex = 81;
            this.label1.Text = "Eliminar tipo vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Codigo";
            // 
            // textCodeType
            // 
            this.textCodeType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textCodeType.ForeColor = System.Drawing.Color.White;
            this.textCodeType.Location = new System.Drawing.Point(147, 172);
            this.textCodeType.Margin = new System.Windows.Forms.Padding(4);
            this.textCodeType.Name = "textCodeType";
            this.textCodeType.Size = new System.Drawing.Size(60, 22);
            this.textCodeType.TabIndex = 75;
            // 
            // btnSearchType
            // 
            this.btnSearchType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchType.ForeColor = System.Drawing.Color.White;
            this.btnSearchType.Location = new System.Drawing.Point(136, 380);
            this.btnSearchType.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchType.Name = "btnSearchType";
            this.btnSearchType.Size = new System.Drawing.Size(100, 28);
            this.btnSearchType.TabIndex = 76;
            this.btnSearchType.Text = "Buscar";
            this.btnSearchType.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(244, 380);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(100, 28);
            this.btnClean.TabIndex = 77;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // tablaTipoVehiculo
            // 
            this.tablaTipoVehiculo.AllowUserToAddRows = false;
            this.tablaTipoVehiculo.AllowUserToDeleteRows = false;
            this.tablaTipoVehiculo.AllowUserToOrderColumns = true;
            this.tablaTipoVehiculo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaTipoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTipoVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaTipoVehiculo.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaTipoVehiculo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaTipoVehiculo.Location = new System.Drawing.Point(360, 42);
            this.tablaTipoVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.tablaTipoVehiculo.Name = "tablaTipoVehiculo";
            this.tablaTipoVehiculo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTipoVehiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaTipoVehiculo.RowHeadersWidth = 51;
            this.tablaTipoVehiculo.RowTemplate.Height = 24;
            this.tablaTipoVehiculo.Size = new System.Drawing.Size(421, 382);
            this.tablaTipoVehiculo.TabIndex = 85;
            this.tablaTipoVehiculo.TabStop = false;
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
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Nombre";
            // 
            // textNameType
            // 
            this.textNameType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameType.ForeColor = System.Drawing.Color.White;
            this.textNameType.Location = new System.Drawing.Point(103, 237);
            this.textNameType.Margin = new System.Windows.Forms.Padding(4);
            this.textNameType.Name = "textNameType";
            this.textNameType.Size = new System.Drawing.Size(159, 22);
            this.textNameType.TabIndex = 89;
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteType.ForeColor = System.Drawing.Color.White;
            this.btnDeleteType.Location = new System.Drawing.Point(28, 380);
            this.btnDeleteType.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteType.TabIndex = 90;
            this.btnDeleteType.Text = "Eliminar";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            // 
            // btnSerachType2
            // 
            this.btnSerachType2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerachType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerachType2.ForeColor = System.Drawing.Color.White;
            this.btnSerachType2.Location = new System.Drawing.Point(136, 330);
            this.btnSerachType2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSerachType2.Name = "btnSerachType2";
            this.btnSerachType2.Size = new System.Drawing.Size(100, 28);
            this.btnSerachType2.TabIndex = 91;
            this.btnSerachType2.Text = "Buscar";
            this.btnSerachType2.UseVisualStyleBackColor = true;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.Location = new System.Drawing.Point(379, 76);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(323, 306);
            this.SearchPanel.TabIndex = 92;
            this.SearchPanel.TabStop = false;
            // 
            // VehicleType_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 421);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.btnSerachType2);
            this.Controls.Add(this.btnDeleteType);
            this.Controls.Add(this.textNameType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaTipoVehiculo);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearchType);
            this.Controls.Add(this.textCodeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(805, 468);
            this.MinimumSize = new System.Drawing.Size(805, 468);
            this.Name = "VehicleType_Delete";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar tipo vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodeType;
        private System.Windows.Forms.Button btnSearchType;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView tablaTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNameType;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.Button btnSerachType2;
        private System.Windows.Forms.PictureBox SearchPanel;
    }
}