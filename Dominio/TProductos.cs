using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography;

namespace Dominio
{
    public class TProductos
    {
        public int IndiceFila;
        //private double descuentoCostoPorcentaje;

        [DisplayName("Id")]
        public int idProductos { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public TRubro Rubro { get; set; }
        [DisplayName("Provedor")]
        public TProveedores Proveedores { get; set; }
      
        public double Costo { get; set; }
        [DisplayName("Desc.%")]
        public double DescuentoCostoPorcentaje { get; set; }
        
        public double Iva { get; set; }
        [DisplayName("Ajuste")]
        public double AjustePesos { get; set; }
        [DisplayName("% Recargo")]
        public double RecargoPorcentaje { get; set; }
        public double Final { get; set; }
        [DisplayName("Ultima Modificación")]
        public string FechaModificacion { get; set; }
        public byte Activo { get; set; }
        public byte Eliminado { get; set; }
        public string Observaciones { get; set; }




    }

}
