using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class TClientes
    {
        public int idCliente { get; set; }
        public string NombreApellido { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Barrio { get; set; }
        public string Ciudad { get; set; }
        public string Observaciones { get; set; }
        public byte Activo { get; set; }
        public byte Eliminado { get; set; }


    }
}
