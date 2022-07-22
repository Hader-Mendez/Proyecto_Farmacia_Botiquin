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
    class Usuarios
    {
        Conexion conexion = new Conexion();
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contra { get; set; }
        public int IdEmpleado { get; set; }
        public int IdEstado { get; set; }

        public void MostrarUsuario(DataGridView dataGridView)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Usuario", conexion.sqlConnection);
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
        public void CargarComboboxUsuarios(ComboBox comboBox)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Empleados", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accion", "mostrar");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    comboBox.DisplayMember = "Nombre";
                    comboBox.ValueMember = "IdEmpleado";
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
        public void BuscarUsuario(DataGridView dataGridView, string buscarTexto)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Usuario", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@BuscarUsuario", buscarTexto);
                sqlCommand.Parameters.AddWithValue("@accion", "buscar");

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
        public void AgregarUsuario(Usuarios usuarios)
        {
            try
            {
               
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Usuario", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                sqlCommand.Parameters.AddWithValue("@Contra", usuarios.Contra);
                sqlCommand.Parameters.AddWithValue("@IdEmpleado", usuarios.IdEmpleado);
                sqlCommand.Parameters.AddWithValue("@IdEstado", usuarios.IdEstado);
                sqlCommand.Parameters.AddWithValue("@accion", "insertar");
                sqlCommand.ExecuteNonQuery();
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
        public void EditarUsuario(Usuarios usuarios)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Usuario", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@IdUsuario", usuarios.IdUsuario);
                sqlCommand.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                sqlCommand.Parameters.AddWithValue("@Contra", usuarios.Contra);
                sqlCommand.Parameters.AddWithValue("@IdEmpleado", usuarios.IdEmpleado);
                sqlCommand.Parameters.AddWithValue("@IdEstado", usuarios.IdEstado);
                sqlCommand.Parameters.AddWithValue("@accion", "editar");
                sqlCommand.ExecuteNonQuery();
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
    }
}
