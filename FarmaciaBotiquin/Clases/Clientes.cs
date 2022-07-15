using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBotiquin.Clases
{
    class Clientes
    {
        public int IdCliente { get; set; }
        public string DNICliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdEstado { get; set; }

        Conexion conexion = new Conexion();
    }
}
