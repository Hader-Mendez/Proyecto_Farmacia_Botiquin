namespace FarmaciaBotiquin
{
    partial class FrmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            this.pnRight = new System.Windows.Forms.Panel();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtBuscarPro = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarPro = new System.Windows.Forms.Button();
            this.btnEditarPro = new System.Windows.Forms.Button();
            this.pnleft = new System.Windows.Forms.Panel();
            this.pbCerrarPro = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.dtpVencimientoPro = new System.Windows.Forms.DateTimePicker();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.lbDescripcionPro = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lbEstadoPro = new System.Windows.Forms.Label();
            this.lbVencimientoPro = new System.Windows.Forms.Label();
            this.lbExistenciaPro = new System.Windows.Forms.Label();
            this.lbNombrePro = new System.Windows.Forms.Label();
            this.txtExistenciaPro = new System.Windows.Forms.TextBox();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.pnRight.Controls.Add(this.lbBuscar);
            this.pnRight.Controls.Add(this.txtBuscarPro);
            this.pnRight.Controls.Add(this.dgvProductos);
            this.pnRight.Controls.Add(this.btnAgregarPro);
            this.pnRight.Controls.Add(this.btnEditarPro);
            this.pnRight.Location = new System.Drawing.Point(0, 0);
            this.pnRight.Margin = new System.Windows.Forms.Padding(2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(694, 596);
            this.pnRight.TabIndex = 2;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.ForeColor = System.Drawing.Color.White;
            this.lbBuscar.Location = new System.Drawing.Point(8, 15);
            this.lbBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(63, 20);
            this.lbBuscar.TabIndex = 12;
            this.lbBuscar.Text = "Buscar:";
            // 
            // txtBuscarPro
            // 
            this.txtBuscarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPro.Location = new System.Drawing.Point(72, 15);
            this.txtBuscarPro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarPro.Name = "txtBuscarPro";
            this.txtBuscarPro.Size = new System.Drawing.Size(368, 23);
            this.txtBuscarPro.TabIndex = 9;
            this.txtBuscarPro.TextChanged += new System.EventHandler(this.txtBuscarPro_TextChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 42);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(653, 494);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductos_CellMouseClick);
            // 
            // btnAgregarPro
            // 
            this.btnAgregarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPro.Location = new System.Drawing.Point(501, 552);
            this.btnAgregarPro.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPro.Name = "btnAgregarPro";
            this.btnAgregarPro.Size = new System.Drawing.Size(80, 30);
            this.btnAgregarPro.TabIndex = 7;
            this.btnAgregarPro.Text = "Agregar";
            this.btnAgregarPro.UseVisualStyleBackColor = true;
            this.btnAgregarPro.Click += new System.EventHandler(this.btnAgregarPro_Click);
            // 
            // btnEditarPro
            // 
            this.btnEditarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPro.Location = new System.Drawing.Point(585, 552);
            this.btnEditarPro.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarPro.Name = "btnEditarPro";
            this.btnEditarPro.Size = new System.Drawing.Size(80, 30);
            this.btnEditarPro.TabIndex = 8;
            this.btnEditarPro.Text = "Editar";
            this.btnEditarPro.UseVisualStyleBackColor = true;
            this.btnEditarPro.Click += new System.EventHandler(this.btnEditarPro_Click_1);
            // 
            // pnleft
            // 
            this.pnleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(112)))));
            this.pnleft.Controls.Add(this.pbCerrarPro);
            this.pnleft.Controls.Add(this.pbLogo);
            this.pnleft.Controls.Add(this.gbProducto);
            this.pnleft.Location = new System.Drawing.Point(689, 0);
            this.pnleft.Margin = new System.Windows.Forms.Padding(2);
            this.pnleft.Name = "pnleft";
            this.pnleft.Size = new System.Drawing.Size(388, 596);
            this.pnleft.TabIndex = 3;
            // 
            // pbCerrarPro
            // 
            this.pbCerrarPro.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrarPro.Image")));
            this.pbCerrarPro.Location = new System.Drawing.Point(317, 10);
            this.pbCerrarPro.Margin = new System.Windows.Forms.Padding(2);
            this.pbCerrarPro.Name = "pbCerrarPro";
            this.pbCerrarPro.Size = new System.Drawing.Size(52, 58);
            this.pbCerrarPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarPro.TabIndex = 4;
            this.pbCerrarPro.TabStop = false;
            this.pbCerrarPro.Click += new System.EventHandler(this.pbCerrarPro_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(9, 10);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(114, 58);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.dtpVencimientoPro);
            this.gbProducto.Controls.Add(this.lblCodigo);
            this.gbProducto.Controls.Add(this.txtCodPro);
            this.gbProducto.Controls.Add(this.lbDescripcionPro);
            this.gbProducto.Controls.Add(this.txtDescripcion);
            this.gbProducto.Controls.Add(this.cmbEstado);
            this.gbProducto.Controls.Add(this.lbEstadoPro);
            this.gbProducto.Controls.Add(this.lbVencimientoPro);
            this.gbProducto.Controls.Add(this.lbExistenciaPro);
            this.gbProducto.Controls.Add(this.lbNombrePro);
            this.gbProducto.Controls.Add(this.txtExistenciaPro);
            this.gbProducto.Controls.Add(this.txtNombrePro);
            this.gbProducto.Location = new System.Drawing.Point(9, 72);
            this.gbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Padding = new System.Windows.Forms.Padding(2);
            this.gbProducto.Size = new System.Drawing.Size(360, 510);
            this.gbProducto.TabIndex = 0;
            this.gbProducto.TabStop = false;
            // 
            // dtpVencimientoPro
            // 
            this.dtpVencimientoPro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpVencimientoPro.AllowDrop = true;
            this.dtpVencimientoPro.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpVencimientoPro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpVencimientoPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimientoPro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimientoPro.Location = new System.Drawing.Point(19, 382);
            this.dtpVencimientoPro.MaxDate = new System.DateTime(2024, 12, 25, 0, 0, 0, 0);
            this.dtpVencimientoPro.MinDate = new System.DateTime(2022, 7, 12, 0, 0, 0, 0);
            this.dtpVencimientoPro.Name = "dtpVencimientoPro";
            this.dtpVencimientoPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpVencimientoPro.Size = new System.Drawing.Size(193, 29);
            this.dtpVencimientoPro.TabIndex = 20;
            this.dtpVencimientoPro.Value = new System.DateTime(2022, 7, 12, 0, 0, 0, 0);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(12, 15);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(94, 26);
            this.lblCodigo.TabIndex = 19;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodPro
            // 
            this.txtCodPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPro.Location = new System.Drawing.Point(16, 43);
            this.txtCodPro.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodPro.MaxLength = 25;
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(320, 32);
            this.txtCodPro.TabIndex = 18;
            // 
            // lbDescripcionPro
            // 
            this.lbDescripcionPro.AutoSize = true;
            this.lbDescripcionPro.BackColor = System.Drawing.Color.Transparent;
            this.lbDescripcionPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcionPro.ForeColor = System.Drawing.Color.White;
            this.lbDescripcionPro.Location = new System.Drawing.Point(14, 163);
            this.lbDescripcionPro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescripcionPro.Name = "lbDescripcionPro";
            this.lbDescripcionPro.Size = new System.Drawing.Size(144, 26);
            this.lbDescripcionPro.TabIndex = 17;
            this.lbDescripcionPro.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(17, 191);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.MaxLength = 25;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(320, 76);
            this.txtDescripcion.TabIndex = 16;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(18, 455);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(194, 34);
            this.cmbEstado.TabIndex = 6;
            // 
            // lbEstadoPro
            // 
            this.lbEstadoPro.AutoSize = true;
            this.lbEstadoPro.BackColor = System.Drawing.Color.Transparent;
            this.lbEstadoPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstadoPro.ForeColor = System.Drawing.Color.White;
            this.lbEstadoPro.Location = new System.Drawing.Point(14, 426);
            this.lbEstadoPro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstadoPro.Name = "lbEstadoPro";
            this.lbEstadoPro.Size = new System.Drawing.Size(93, 26);
            this.lbEstadoPro.TabIndex = 15;
            this.lbEstadoPro.Text = "Estado:";
            // 
            // lbVencimientoPro
            // 
            this.lbVencimientoPro.AutoSize = true;
            this.lbVencimientoPro.BackColor = System.Drawing.Color.Transparent;
            this.lbVencimientoPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVencimientoPro.ForeColor = System.Drawing.Color.White;
            this.lbVencimientoPro.Location = new System.Drawing.Point(14, 353);
            this.lbVencimientoPro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVencimientoPro.Name = "lbVencimientoPro";
            this.lbVencimientoPro.Size = new System.Drawing.Size(151, 26);
            this.lbVencimientoPro.TabIndex = 14;
            this.lbVencimientoPro.Text = "Vencimiento:";
            // 
            // lbExistenciaPro
            // 
            this.lbExistenciaPro.AutoSize = true;
            this.lbExistenciaPro.BackColor = System.Drawing.Color.Transparent;
            this.lbExistenciaPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExistenciaPro.ForeColor = System.Drawing.Color.White;
            this.lbExistenciaPro.Location = new System.Drawing.Point(14, 276);
            this.lbExistenciaPro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExistenciaPro.Name = "lbExistenciaPro";
            this.lbExistenciaPro.Size = new System.Drawing.Size(129, 26);
            this.lbExistenciaPro.TabIndex = 12;
            this.lbExistenciaPro.Text = "Existencia:";
            // 
            // lbNombrePro
            // 
            this.lbNombrePro.AutoSize = true;
            this.lbNombrePro.BackColor = System.Drawing.Color.Transparent;
            this.lbNombrePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePro.ForeColor = System.Drawing.Color.White;
            this.lbNombrePro.Location = new System.Drawing.Point(13, 87);
            this.lbNombrePro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombrePro.Name = "lbNombrePro";
            this.lbNombrePro.Size = new System.Drawing.Size(115, 26);
            this.lbNombrePro.TabIndex = 11;
            this.lbNombrePro.Text = "Nombres:";
            // 
            // txtExistenciaPro
            // 
            this.txtExistenciaPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistenciaPro.Location = new System.Drawing.Point(18, 304);
            this.txtExistenciaPro.Margin = new System.Windows.Forms.Padding(2);
            this.txtExistenciaPro.MaxLength = 25;
            this.txtExistenciaPro.Name = "txtExistenciaPro";
            this.txtExistenciaPro.Size = new System.Drawing.Size(194, 32);
            this.txtExistenciaPro.TabIndex = 2;
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePro.Location = new System.Drawing.Point(17, 115);
            this.txtNombrePro.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrePro.MaxLength = 25;
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(320, 32);
            this.txtNombrePro.TabIndex = 1;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 593);
            this.Controls.Add(this.pnleft);
            this.Controls.Add(this.pnRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProducto";
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox txtBuscarPro;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarPro;
        private System.Windows.Forms.Button btnEditarPro;
        private System.Windows.Forms.Panel pnleft;
        private System.Windows.Forms.PictureBox pbCerrarPro;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lbEstadoPro;
        private System.Windows.Forms.Label lbVencimientoPro;
        private System.Windows.Forms.Label lbExistenciaPro;
        private System.Windows.Forms.Label lbNombrePro;
        private System.Windows.Forms.TextBox txtExistenciaPro;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.Label lbDescripcionPro;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodPro;
        public System.Windows.Forms.DateTimePicker dtpVencimientoPro;
    }
}