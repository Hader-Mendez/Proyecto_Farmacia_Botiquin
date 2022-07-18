using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FarmaciaBotiquin.Clases
{
    
    class Puesto
    {
        public int IdPuesto { get; set; }
        public string Puestos { get; set; }

        Conexion conexion = new Conexion();
        public void MostrarPuestos(DataGridView dataGrid)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Puesto", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@accion", "mostrar");
                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGrid.DataSource = dataTable;
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
        public void CargarComboboxPuesto(ComboBox comboBox, int estado)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Puesto", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accion", "mostrar");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    comboBox.DisplayMember = "Puesto";
                    comboBox.ValueMember = "IdPuesto";
                    comboBox.DataSource = dataTable.DefaultView;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.sqlConnection.Close();
            }

        }
    }
}
