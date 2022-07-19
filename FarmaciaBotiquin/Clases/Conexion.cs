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
<<<<<<< Updated upstream
        private static string connectionString = ConfigurationManager.ConnectionStrings["FarmaciaBotiquin.Properties.Settings.conexionFarmacia_Botiquin"].ConnectionString;
=======
<<<<<<< HEAD
        private static string connectionString = ConfigurationManager.ConnectionStrings["DESKTOP-FTIF23G\SQLEXPRESS.Properties.Settings.conexionFarmacia_Botiquin"].ConnectionString;
=======
        private static string connectionString = ConfigurationManager.ConnectionStrings["FarmaciaBotiquin.Properties.Settings.conexionFarmacia_Botiquin"].ConnectionString;
>>>>>>> main
>>>>>>> Stashed changes
        public SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}
