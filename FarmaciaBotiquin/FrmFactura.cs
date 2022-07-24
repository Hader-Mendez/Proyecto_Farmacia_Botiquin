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
    public partial class FrmFactura : Form
    {
        Conexion conexion = new Conexion();
        public FrmFactura()
        {
            InitializeComponent();
            Mostrar(dgvFactura);
        }

        private void lbBuscar_Click(object sender, EventArgs e)
        {
            //
        }

        public void Mostrar(DataGridView dataGridView)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Factura", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@accion", "mostrar");
                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Form formulario = new DetalleFactura();
            this.Close();
            formulario.Show();
        }
    }
}
