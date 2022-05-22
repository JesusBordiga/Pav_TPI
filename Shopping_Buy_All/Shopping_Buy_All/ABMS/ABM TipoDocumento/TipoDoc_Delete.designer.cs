namespace Shopping_Buy_All.ABM_Tipo_Documento
{
    partial class TipoDoc_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoDoc_Delete));
            this.btnTipDocDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarTipDoc = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tablaTipDoc = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTipDocDelete
            // 
            this.btnTipDocDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTipDocDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipDocDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipDocDelete.ForeColor = System.Drawing.Color.White;
            this.btnTipDocDelete.Location = new System.Drawing.Point(76, 233);
            this.btnTipDocDelete.Name = "btnTipDocDelete";
            this.btnTipDocDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTipDocDelete.TabIndex = 3;
            this.btnTipDocDelete.Text = "Dar de Baja";
            this.btnTipDocDelete.UseVisualStyleBackColor = false;
            this.btnTipDocDelete.Click += new System.EventHandler(this.btnTipDocDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 126;
            this.label2.Text = "Nombre";
            // 
            // btnBuscarTipDoc
            // 
            this.btnBuscarTipDoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBuscarTipDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarTipDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTipDoc.ForeColor = System.Drawing.Color.White;
            this.btnBuscarTipDoc.Location = new System.Drawing.Point(76, 233);
            this.btnBuscarTipDoc.Name = "btnBuscarTipDoc";
            this.btnBuscarTipDoc.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTipDoc.TabIndex = 2;
            this.btnBuscarTipDoc.Text = "Buscar";
            this.btnBuscarTipDoc.UseVisualStyleBackColor = false;
            this.btnBuscarTipDoc.Click += new System.EventHandler(this.btnBuscarTipDoc_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(67, 126);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // tablaTipDoc
            // 
            this.tablaTipDoc.AllowUserToAddRows = false;
            this.tablaTipDoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablaTipDoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaTipDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaTipDoc.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaTipDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaTipDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTipDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.NombreDocumento,
            this.Borrado});
            this.tablaTipDoc.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaTipDoc.Location = new System.Drawing.Point(220, 42);
            this.tablaTipDoc.Name = "tablaTipDoc";
            this.tablaTipDoc.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTipDoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaTipDoc.RowHeadersWidth = 10;
            this.tablaTipDoc.Size = new System.Drawing.Size(235, 248);
            this.tablaTipDoc.TabIndex = 129;
            this.tablaTipDoc.TabStop = false;
            this.tablaTipDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaTipDoc_CellContentClick);
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.HeaderText = "Id";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NombreDocumento
            // 
            this.NombreDocumento.DataPropertyName = "NombreDocumento";
            this.NombreDocumento.HeaderText = "Nombre";
            this.NombreDocumento.Name = "NombreDocumento";
            this.NombreDocumento.ReadOnly = true;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 44);
            this.label1.TabIndex = 131;
            this.label1.Text = "Buscar Tipos de\r\nDocumento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(236, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 22);
            this.label15.TabIndex = 130;
            this.label15.Text = "Tipos de Documento";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(76, 262);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 148;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // TipoDoc_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 297);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tablaTipDoc);
            this.Controls.Add(this.btnTipDocDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarTipDoc);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TipoDoc_Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Tipo de Documento";
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTipDocDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarTipDoc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView tablaTipDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnLimpiar;
    }
}