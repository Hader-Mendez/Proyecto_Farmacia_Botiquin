namespace FarmaciaBotiquin
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.pnRight = new System.Windows.Forms.Panel();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtCorreoClientes = new System.Windows.Forms.TextBox();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbEmpleado = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.dtpFechaNacClientes = new System.Windows.Forms.DateTimePicker();
            this.lbNombre = new System.Windows.Forms.Label();
            this.pnleft = new System.Windows.Forms.Panel();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbEmpleado.SuspendLayout();
            this.pnleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.pnRight.Controls.Add(this.lbBuscar);
            this.pnRight.Controls.Add(this.txtBuscar);
            this.pnRight.Controls.Add(this.dgvClientes);
            this.pnRight.Controls.Add(this.btnAgregar);
            this.pnRight.Controls.Add(this.btnEditar);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(377, 0);
            this.pnRight.Margin = new System.Windows.Forms.Padding(2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(643, 508);
            this.pnRight.TabIndex = 3;
            this.pnRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnRight_Paint);
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
            this.lbBuscar.Click += new System.EventHandler(this.lbBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(72, 15);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(563, 23);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 42);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(622, 423);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientes_CellMouseClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 470);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 30);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(96, 470);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 30);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(9, 364);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(194, 34);
            this.cmbEstado.TabIndex = 6;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.BackColor = System.Drawing.Color.Transparent;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.ForeColor = System.Drawing.Color.White;
            this.lbEstado.Location = new System.Drawing.Point(4, 336);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(93, 26);
            this.lbEstado.TabIndex = 15;
            this.lbEstado.Text = "Estado:";
            this.lbEstado.Click += new System.EventHandler(this.lbEstado_Click);
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.Color.White;
            this.lbTelefono.Location = new System.Drawing.Point(4, 275);
            this.lbTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(244, 26);
            this.lbTelefono.TabIndex = 14;
            this.lbTelefono.Text = "Fecha de Nacimiento:";
            this.lbTelefono.Click += new System.EventHandler(this.lbTelefono_Click);
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.ForeColor = System.Drawing.Color.White;
            this.lbCorreo.Location = new System.Drawing.Point(4, 206);
            this.lbCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(91, 26);
            this.lbCorreo.TabIndex = 13;
            this.lbCorreo.Text = "Correo:";
            this.lbCorreo.Click += new System.EventHandler(this.lbCorreo_Click);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.BackColor = System.Drawing.Color.Transparent;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.Color.White;
            this.lbApellido.Location = new System.Drawing.Point(4, 145);
            this.lbApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(117, 26);
            this.lbApellido.TabIndex = 12;
            this.lbApellido.Text = "Apellidos:";
            this.lbApellido.Click += new System.EventHandler(this.lbApellido_Click);
            // 
            // txtCorreoClientes
            // 
            this.txtCorreoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoClientes.Location = new System.Drawing.Point(8, 235);
            this.txtCorreoClientes.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoClientes.MaxLength = 25;
            this.txtCorreoClientes.Name = "txtCorreoClientes";
            this.txtCorreoClientes.Size = new System.Drawing.Size(320, 32);
            this.txtCorreoClientes.TabIndex = 4;
            this.txtCorreoClientes.TextChanged += new System.EventHandler(this.txtCorreoClientes_TextChanged);
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosCliente.Location = new System.Drawing.Point(8, 173);
            this.txtApellidosCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidosCliente.MaxLength = 25;
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.Size = new System.Drawing.Size(320, 32);
            this.txtApellidosCliente.TabIndex = 3;
            this.txtApellidosCliente.TextChanged += new System.EventHandler(this.txtApellidosCliente_TextChanged);
            this.txtApellidosCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidosCliente_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(8, 104);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.MaxLength = 25;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(320, 32);
            this.txtNombreCliente.TabIndex = 2;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(317, 10);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(52, 58);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 4;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
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
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // gbEmpleado
            // 
            this.gbEmpleado.Controls.Add(this.label1);
            this.gbEmpleado.Controls.Add(this.txtDniCliente);
            this.gbEmpleado.Controls.Add(this.dtpFechaNacClientes);
            this.gbEmpleado.Controls.Add(this.cmbEstado);
            this.gbEmpleado.Controls.Add(this.lbEstado);
            this.gbEmpleado.Controls.Add(this.lbTelefono);
            this.gbEmpleado.Controls.Add(this.lbCorreo);
            this.gbEmpleado.Controls.Add(this.lbApellido);
            this.gbEmpleado.Controls.Add(this.lbNombre);
            this.gbEmpleado.Controls.Add(this.txtCorreoClientes);
            this.gbEmpleado.Controls.Add(this.txtApellidosCliente);
            this.gbEmpleado.Controls.Add(this.txtNombreCliente);
            this.gbEmpleado.Location = new System.Drawing.Point(9, 72);
            this.gbEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.gbEmpleado.Name = "gbEmpleado";
            this.gbEmpleado.Padding = new System.Windows.Forms.Padding(2);
            this.gbEmpleado.Size = new System.Drawing.Size(350, 428);
            this.gbEmpleado.TabIndex = 0;
            this.gbEmpleado.TabStop = false;
            this.gbEmpleado.Enter += new System.EventHandler(this.gbEmpleado_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "DNI Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniCliente.Location = new System.Drawing.Point(10, 43);
            this.txtDniCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDniCliente.MaxLength = 25;
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(320, 32);
            this.txtDniCliente.TabIndex = 1;
            this.txtDniCliente.TextChanged += new System.EventHandler(this.txtDniCliente_TextChanged);
            this.txtDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniCliente_KeyPress);
            // 
            // dtpFechaNacClientes
            // 
            this.dtpFechaNacClientes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpFechaNacClientes.AllowDrop = true;
            this.dtpFechaNacClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFechaNacClientes.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaNacClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacClientes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacClientes.Location = new System.Drawing.Point(9, 304);
            this.dtpFechaNacClientes.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacClientes.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacClientes.Name = "dtpFechaNacClientes";
            this.dtpFechaNacClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaNacClientes.Size = new System.Drawing.Size(193, 29);
            this.dtpFechaNacClientes.TabIndex = 5;
            this.dtpFechaNacClientes.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacClientes.ValueChanged += new System.EventHandler(this.dtpFechaNacClientes_ValueChanged);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(4, 76);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(115, 26);
            this.lbNombre.TabIndex = 11;
            this.lbNombre.Text = "Nombres:";
            this.lbNombre.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // pnleft
            // 
            this.pnleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(112)))));
            this.pnleft.Controls.Add(this.pbCerrar);
            this.pnleft.Controls.Add(this.pbLogo);
            this.pnleft.Controls.Add(this.gbEmpleado);
            this.pnleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnleft.Location = new System.Drawing.Point(0, 0);
            this.pnleft.Margin = new System.Windows.Forms.Padding(2);
            this.pnleft.Name = "pnleft";
            this.pnleft.Size = new System.Drawing.Size(377, 508);
            this.pnleft.TabIndex = 2;
            this.pnleft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnleft_Paint);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 508);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbEmpleado.ResumeLayout(false);
            this.gbEmpleado.PerformLayout();
            this.pnleft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox txtCorreoClientes;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbEmpleado;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Panel pnleft;
        public System.Windows.Forms.DateTimePicker dtpFechaNacClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDniCliente;
    }
}