namespace FarmaciaBotiquin
{
    partial class FrmPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuesto));
            this.pnleft = new System.Windows.Forms.Panel();
            this.gbPuesto = new System.Windows.Forms.GroupBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.btnAgregarPue = new System.Windows.Forms.Button();
            this.pbCerrarPue = new System.Windows.Forms.PictureBox();
            this.btnEditarPue = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnRight = new System.Windows.Forms.Panel();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.pnleft.SuspendLayout();
            this.gbPuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnleft
            // 
            this.pnleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(112)))));
            this.pnleft.Controls.Add(this.gbPuesto);
            this.pnleft.Controls.Add(this.btnAgregarPue);
            this.pnleft.Controls.Add(this.pbCerrarPue);
            this.pnleft.Controls.Add(this.btnEditarPue);
            this.pnleft.Controls.Add(this.pbLogo);
            this.pnleft.Location = new System.Drawing.Point(346, -2);
            this.pnleft.Margin = new System.Windows.Forms.Padding(2);
            this.pnleft.Name = "pnleft";
            this.pnleft.Size = new System.Drawing.Size(306, 317);
            this.pnleft.TabIndex = 6;
            // 
            // gbPuesto
            // 
            this.gbPuesto.Controls.Add(this.lblPuesto);
            this.gbPuesto.Controls.Add(this.txtPuesto);
            this.gbPuesto.Location = new System.Drawing.Point(24, 82);
            this.gbPuesto.Name = "gbPuesto";
            this.gbPuesto.Size = new System.Drawing.Size(258, 114);
            this.gbPuesto.TabIndex = 22;
            this.gbPuesto.TabStop = false;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(5, 25);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(93, 26);
            this.lblPuesto.TabIndex = 24;
            this.lblPuesto.Text = "Puesto:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.Location = new System.Drawing.Point(9, 53);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuesto.MaxLength = 25;
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(224, 32);
            this.txtPuesto.TabIndex = 23;
            // 
            // btnAgregarPue
            // 
            this.btnAgregarPue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPue.Location = new System.Drawing.Point(75, 224);
            this.btnAgregarPue.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPue.Name = "btnAgregarPue";
            this.btnAgregarPue.Size = new System.Drawing.Size(80, 30);
            this.btnAgregarPue.TabIndex = 9;
            this.btnAgregarPue.Text = "Agregar";
            this.btnAgregarPue.UseVisualStyleBackColor = true;
            this.btnAgregarPue.Click += new System.EventHandler(this.btnAgregarPue_Click_1);
            // 
            // pbCerrarPue
            // 
            this.pbCerrarPue.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrarPue.Image")));
            this.pbCerrarPue.Location = new System.Drawing.Point(241, 2);
            this.pbCerrarPue.Margin = new System.Windows.Forms.Padding(2);
            this.pbCerrarPue.Name = "pbCerrarPue";
            this.pbCerrarPue.Size = new System.Drawing.Size(52, 58);
            this.pbCerrarPue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarPue.TabIndex = 4;
            this.pbCerrarPue.TabStop = false;
            this.pbCerrarPue.Click += new System.EventHandler(this.pbCerrarPue_Click);
            // 
            // btnEditarPue
            // 
            this.btnEditarPue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPue.Location = new System.Drawing.Point(159, 224);
            this.btnEditarPue.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarPue.Name = "btnEditarPue";
            this.btnEditarPue.Size = new System.Drawing.Size(80, 30);
            this.btnEditarPue.TabIndex = 10;
            this.btnEditarPue.Text = "Editar";
            this.btnEditarPue.UseVisualStyleBackColor = true;
            this.btnEditarPue.Click += new System.EventHandler(this.btnEditarPue_Click_1);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(2, 2);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(114, 58);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.pnRight.Controls.Add(this.dgvPuestos);
            this.pnRight.Location = new System.Drawing.Point(-4, -2);
            this.pnRight.Margin = new System.Windows.Forms.Padding(2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(353, 317);
            this.pnRight.TabIndex = 7;
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Location = new System.Drawing.Point(15, 26);
            this.dgvPuestos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.ReadOnly = true;
            this.dgvPuestos.RowHeadersWidth = 51;
            this.dgvPuestos.RowTemplate.Height = 24;
            this.dgvPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuestos.Size = new System.Drawing.Size(320, 269);
            this.dgvPuestos.TabIndex = 0;
            this.dgvPuestos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPuestos_CellMouseClick);
            // 
            // FrmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 314);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPuesto";
            this.pnleft.ResumeLayout(false);
            this.gbPuesto.ResumeLayout(false);
            this.gbPuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnleft;
        private System.Windows.Forms.Button btnAgregarPue;
        private System.Windows.Forms.PictureBox pbCerrarPue;
        private System.Windows.Forms.Button btnEditarPue;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.GroupBox gbPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
    }
}