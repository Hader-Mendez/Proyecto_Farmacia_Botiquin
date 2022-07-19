using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace FarmaciaBotiquin.Clases
{
    class Conexion
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DESKTOP-GII3E9E\\SQLEXPRESS.Properties.Settings.conexionFarmacia_Botiquin"].ConnectionString;
        public SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}
