namespace FarmaciaBotiquin
{
    partial class FrmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedor));
            this.pnleft = new System.Windows.Forms.Panel();
            this.pbCerrarProveedor = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbProvedor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoProveedot = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.cmbEstadoProveedor = new System.Windows.Forms.ComboBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbProvedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.pnRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnleft
            // 
            this.pnleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(112)))));
            this.pnleft.Controls.Add(this.pbCerrarProveedor);
            this.pnleft.Controls.Add(this.pbLogo);
            this.pnleft.Controls.Add(this.gbProvedor);
            this.pnleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnleft.Location = new System.Drawing.Point(0, 0);
            this.pnleft.Margin = new System.Windows.Forms.Padding(2);
            this.pnleft.Name = "pnleft";
            this.pnleft.Size = new System.Drawing.Size(377, 550);
            this.pnleft.TabIndex = 4;
            // 
            // pbCerrarProveedor
            // 
            this.pbCerrarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrarProveedor.Image")));
            this.pbCerrarProveedor.Location = new System.Drawing.Point(317, 10);
            this.pbCerrarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.pbCerrarProveedor.Name = "pbCerrarProveedor";
            this.pbCerrarProveedor.Size = new System.Drawing.Size(52, 58);
            this.pbCerrarProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarProveedor.TabIndex = 4;
            this.pbCerrarProveedor.TabStop = false;
            this.pbCerrarProveedor.Click += new System.EventHandler(this.pbCerrarProveedor_Click);
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
            // gbProvedor
            // 
            this.gbProvedor.Controls.Add(this.label2);
            this.gbProvedor.Controls.Add(this.txtCodigoProveedot);
            this.gbProvedor.Controls.Add(this.txtDireccion);
            this.gbProvedor.Controls.Add(this.label1);
            this.gbProvedor.Controls.Add(this.txtRTN);
            this.gbProvedor.Controls.Add(this.cmbEstadoProveedor);
            this.gbProvedor.Controls.Add(this.lbEstado);
            this.gbProvedor.Controls.Add(this.lbTelefono);
            this.gbProvedor.Controls.Add(this.lbCorreo);
            this.gbProvedor.Controls.Add(this.lbApellido);
            this.gbProvedor.Controls.Add(this.lbNombre);
            this.gbProvedor.Controls.Add(this.txtCorreoProveedor);
            this.gbProvedor.Controls.Add(this.txtTelefono);
            this.gbProvedor.Controls.Add(this.txtNombreProveedor);
            this.gbProvedor.Location = new System.Drawing.Point(9, 72);
            this.gbProvedor.Margin = new System.Windows.Forms.Padding(2);
            this.gbProvedor.Name = "gbProvedor";
            this.gbProvedor.Padding = new System.Windows.Forms.Padding(2);
            this.gbProvedor.Size = new System.Drawing.Size(350, 467);
            this.gbProvedor.TabIndex = 0;
            this.gbProvedor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Código de Proveedor:";
            // 
            // txtCodigoProveedot
            // 
            this.txtCodigoProveedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProveedot.Location = new System.Drawing.Point(18, 43);
            this.txtCodigoProveedot.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProveedot.MaxLength = 25;
            this.txtCodigoProveedot.Name = "txtCodigoProveedot";
            this.txtCodigoProveedot.Size = new System.Drawing.Size(320, 32);
            this.txtCodigoProveedot.TabIndex = 25;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(15, 365);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.MaxLength = 25;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(320, 32);
            this.txtDireccion.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "RTN:";
            // 
            // txtRTN
            // 
            this.txtRTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTN.Location = new System.Drawing.Point(17, 105);
            this.txtRTN.Margin = new System.Windows.Forms.Padding(2);
            this.txtRTN.MaxLength = 25;
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(320, 32);
            this.txtRTN.TabIndex = 1;
            this.txtRTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRTN_KeyPress);
            // 
            // cmbEstadoProveedor
            // 
            this.cmbEstadoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoProveedor.FormattingEnabled = true;
            this.cmbEstadoProveedor.Location = new System.Drawing.Point(16, 426);
            this.cmbEstadoProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstadoProveedor.Name = "cmbEstadoProveedor";
            this.cmbEstadoProveedor.Size = new System.Drawing.Size(194, 34);
            this.cmbEstadoProveedor.TabIndex = 6;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.BackColor = System.Drawing.Color.Transparent;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.ForeColor = System.Drawing.Color.White;
            this.lbEstado.Location = new System.Drawing.Point(11, 398);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(93, 26);
            this.lbEstado.TabIndex = 15;
            this.lbEstado.Text = "Estado:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.Color.White;
            this.lbTelefono.Location = new System.Drawing.Point(11, 337);
            this.lbTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(119, 26);
            this.lbTelefono.TabIndex = 14;
            this.lbTelefono.Text = "Dirección:";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.ForeColor = System.Drawing.Color.White;
            this.lbCorreo.Location = new System.Drawing.Point(11, 268);
            this.lbCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(91, 26);
            this.lbCorreo.TabIndex = 13;
            this.lbCorreo.Text = "Correo:";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.BackColor = System.Drawing.Color.Transparent;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.Color.White;
            this.lbApellido.Location = new System.Drawing.Point(11, 207);
            this.lbApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(110, 26);
            this.lbApellido.TabIndex = 12;
            this.lbApellido.Text = "Teléfono:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(11, 138);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(103, 26);
            this.lbNombre.TabIndex = 11;
            this.lbNombre.Text = "Nombre:";
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoProveedor.Location = new System.Drawing.Point(15, 297);
            this.txtCorreoProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoProveedor.MaxLength = 25;
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(320, 32);
            this.txtCorreoProveedor.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(15, 235);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.MaxLength = 25;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(320, 32);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(15, 166);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProveedor.MaxLength = 25;
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(320, 32);
            this.txtNombreProveedor.TabIndex = 2;
            this.txtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProveedor_KeyPress);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.ForeColor = System.Drawing.Color.White;
            this.lbBuscar.Location = new System.Drawing.Point(14, 11);
            this.lbBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(63, 20);
            this.lbBuscar.TabIndex = 12;
            this.lbBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(78, 11);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(563, 23);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(18, 38);
            this.dgvProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedor.Size = new System.Drawing.Size(622, 458);
            this.dgvProveedor.TabIndex = 0;
            this.dgvProveedor.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProveedor_CellMouseClick);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.Location = new System.Drawing.Point(18, 503);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(80, 30);
            this.btnAgregarProveedor.TabIndex = 7;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProveedor.Location = new System.Drawing.Point(102, 503);
            this.btnEditarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(80, 30);
            this.btnEditarProveedor.TabIndex = 8;
            this.btnEditarProveedor.Text = "Editar";
            this.btnEditarProveedor.UseVisualStyleBackColor = true;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.pnRight.Controls.Add(this.lbBuscar);
            this.pnRight.Controls.Add(this.txtBuscar);
            this.pnRight.Controls.Add(this.dgvProveedor);
            this.pnRight.Controls.Add(this.btnAgregarProveedor);
            this.pnRight.Controls.Add(this.btnEditarProveedor);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(377, 0);
            this.pnRight.Margin = new System.Windows.Forms.Padding(2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(643, 550);
            this.pnRight.TabIndex = 5;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 550);
            this.Controls.Add(this.pnleft);
            this.Controls.Add(this.pnRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProveedor";
            this.pnleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbProvedor.ResumeLayout(false);
            this.gbProvedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnleft;
        private System.Windows.Forms.PictureBox pbCerrarProveedor;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbProvedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRTN;
        private System.Windows.Forms.ComboBox cmbEstadoProveedor;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoProveedot;
    }
}