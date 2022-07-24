using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaBotiquin
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pbCliente_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmCliente();
            this.Hide();
            formulario.ShowDialog();
            this.Show();
        }

        private void pbEmpleado_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmEmpleado();
            this.Hide();
            formulario.ShowDialog();
            this.Show();
        }

        private void pbProducto_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmProducto();
            this.Hide();
            formulario.ShowDialog();
            this.Show();
        }

        private void pbUsuario_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmUsuario();
            this.Hide();
            formulario.ShowDialog();
            this.Show();
        }

        private void pbProveedor_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmProveedor();
            this.Hide();
            formulario.ShowDialog();
            this.Show();
        }

        private void pbFactura_Click(object sender, EventArgs e)
        {
            Form formulario = new DetalleFactura();
            this.Hide();
            formulario.ShowDialog();
            //this.Show();
        }

        private void pcFactura_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmPuesto();
            this.Hide();
            formulario.ShowDialog();
            this.Show();
        }

        private void pbCerrarPrinci_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmLogin();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            
        }
    }
}
