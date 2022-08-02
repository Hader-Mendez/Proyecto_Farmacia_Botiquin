namespace FarmaciaBotiquin
{
    partial class DetalleFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleFactura));
            this.txtCant = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.pnRight = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnleft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.pnRight.SuspendLayout();
            this.pnleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(115, 411);
            this.txtCant.Margin = new System.Windows.Forms.Padding(2);
            this.txtCant.MaxLength = 25;
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(148, 32);
            this.txtCant.TabIndex = 22;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(9, 2);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(114, 58);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cantidad";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(7, 450);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(80, 26);
            this.lbNombre.TabIndex = 11;
            this.lbNombre.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(115, 447);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.MaxLength = 25;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(148, 32);
            this.txtPrecio.TabIndex = 1;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(542, 454);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(80, 30);
            this.btnFacturar.TabIndex = 7;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(11, 19);
            this.dgvDetalleFactura.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.ReadOnly = true;
            this.dgvDetalleFactura.RowHeadersWidth = 51;
            this.dgvDetalleFactura.RowTemplate.Height = 24;
            this.dgvDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(600, 277);
            this.dgvDetalleFactura.TabIndex = 0;
            this.dgvDetalleFactura.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDetalleFactura_CellMouseClick);
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.pnRight.Controls.Add(this.dgvDetalleFactura);
            this.pnRight.Location = new System.Drawing.Point(9, 64);
            this.pnRight.Margin = new System.Windows.Forms.Padding(2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(624, 317);
            this.pnRight.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(542, 420);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 30);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditardetalle_Click);
            // 
            // pnleft
            // 
            this.pnleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(112)))));
            this.pnleft.Controls.Add(this.pictureBox1);
            this.pnleft.Controls.Add(this.pnRight);
            this.pnleft.Controls.Add(this.label1);
            this.pnleft.Controls.Add(this.txtCant);
            this.pnleft.Controls.Add(this.btnEditar);
            this.pnleft.Controls.Add(this.lbNombre);
            this.pnleft.Controls.Add(this.pbLogo);
            this.pnleft.Controls.Add(this.btnFacturar);
            this.pnleft.Controls.Add(this.txtPrecio);
            this.pnleft.Location = new System.Drawing.Point(0, 0);
            this.pnleft.Margin = new System.Windows.Forms.Padding(2);
            this.pnleft.Name = "pnleft";
            this.pnleft.Size = new System.Drawing.Size(645, 510);
            this.pnleft.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 503);
            this.Controls.Add(this.pnleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleFactura";
            this.Text = "DetalleFactura";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.pnRight.ResumeLayout(false);
            this.pnleft.ResumeLayout(false);
            this.pnleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnleft;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}