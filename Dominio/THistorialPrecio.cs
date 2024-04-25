using System;

namespace Dominio
{
    public class THistorialPrecio
    {

        public int idHistorial { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double Final { get; set; }
        public DateTime FechaMod { get; set; }

        public int idProducto { get; set; }

    }
}
