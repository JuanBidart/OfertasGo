using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TProductos
    {

        public int idProductos { get; set; }
        public string Descripcion { get; set; }
        public TRubro Rubro { get; set; }
        public double Costo { get; set; }
        public int DescuentoCostoProcentaje { get; set; }
        public double Iva { get; set; }
        public double RecargoPesos { get; set; }
        public double RecargoPorcentaje { get; set; }
        public double Final { get; set; }
        public DateTime FechaModificacion { get; set; }
        public byte Activo { get; set; }
        public byte Eliminado { get; set; }
        public string Observaciones { get; set; }
    }
}
