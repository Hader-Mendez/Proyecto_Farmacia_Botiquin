using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace FarmaciaBotiquin.Clases
{
    public class Login
    {
        Conexion conexion = new Conexion();
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contra { get; set; }
        public int IdEmpleado { get; set; }
        public int IdEstado { get; set; }

        public void ObtenerUsuario(string usuario, Login login)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Sp_Usuario", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Usuario", usuario.ToLower());
                sqlCommand.Parameters.AddWithValue("@accion", "obtenerUsuario");

                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        login.IdUsuario = Convert.ToInt32(rdr["IdUsuario"]);
                        login.Usuario = rdr["Usuario"].ToString();
                        login.Contra = rdr["Contra"].ToString();
                        login.IdEmpleado = Convert.ToInt32(rdr["IdEmpleado"]);
                        login.IdEstado = Convert.ToInt32(rdr["IdEstado"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }



    }
}
