using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FarmaciaBotiquin.Clases;

namespace FarmaciaBotiquin
{
    public partial class DetalleFactura : Form
    {
        DetalleFactura detallefactura = new DetalleFactura();
        public DetalleFactura()
        {
            InitializeComponent();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmPrincipal();
            this.Close();
            this.Show();
        }
    }
}
