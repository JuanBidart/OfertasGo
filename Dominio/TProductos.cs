using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TProductos
    {
        [DisplayName("Id")]
        public int idProductos { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public TRubro Rubro { get; set; }
        [DisplayName("Provedor")]
        public TProveedores Proveedores { get; set; }
        public double Costo { get; set; }
        [DisplayName("% Desc.")]
        public int DescuentoCostoProcentaje { get; set; }
        public double Iva { get; set; }
        public double RecargoPesos { get; set; }
        [DisplayName("% Recargo")]
        public double RecargoPorcentaje { get; set; }
        public double Final { get; set; }
        [DisplayName("Ultima Modificación")]
        public string FechaModificacion { get; set; }
        public byte Activo { get; set; }
        public byte Eliminado { get; set; }
        public string Observaciones { get; set; }
        

        //public override string ToString()
        //{
        //    return Costo.ToString(CultureInfo.CreateSpecificCulture("ES-AR"));
        //}


    }
    
}
