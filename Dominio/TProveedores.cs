using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TProveedores
    {
        /*"idProveedores" INT; "RazonSocial" TEXT;"Direccion" TEXT; "Ciudad" TEXT; "Telefono" TEXT
        "Telefono2" TEXT; "Activo" BLOB; "Eliminado" BLOB*/

        public int idProveedores { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public byte Activo { get; set; }
        public byte Eliminado { get; set; }

        public override string ToString()
        {
            return RazonSocial.ToString();
        }
    } 
}
