using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FarmaciaBotiquin.Clases;

namespace FarmaciaBotiquin.Clases
{
    
    class Estado
    {
        Conexion conexion = new Conexion();
        public void CargarComboboxEstado(ComboBox comboBox)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Estado", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accion", "mostrar");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    comboBox.DisplayMember = "Estado";
                    comboBox.ValueMember = "IdEstado";
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
