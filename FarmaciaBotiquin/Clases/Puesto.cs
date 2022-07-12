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
    
    class Puesto
    {
        Conexion conexion = new Conexion();
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
