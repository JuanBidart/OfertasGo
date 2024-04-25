using Newtonsoft.Json;
using System.Net;

namespace ConexionesExternas
{
    public class apiDolar
    {


        public string Compra { get; set; }
        public string Venta { get; set; }
        public string Casa { get; set; }
        public string Nombre { get; set; }
        public string Moneda { get; set; }
        public string Fecha { get; set; }

        public apiDolar()
        {

            actualizarData();


        }

        public void actualizarData()
        {
            // Crear un cliente web
            var client = new WebClient();

            // Descargar la respuesta


            var data = client.DownloadString("https://dolarapi.com/v1/dolares/blue");

            // Procesar la respuesta
            var dataObject = JsonConvert.DeserializeObject<object>(data);

            Moneda = dataObject.ToString().Trim().Split(',')[0].Remove(0, 5);
            Casa = dataObject.ToString().Split(',')[1].Remove(0, 5);
            Nombre = dataObject.ToString().Split(',')[2].Remove(0, 5);
            Compra = dataObject.ToString().Split(',')[3].Remove(0, 5);
            Venta = dataObject.ToString().Split(',')[4].Remove(0, 5);
            Fecha = dataObject.ToString().Split(',')[5].Remove(0, 5);
        }
    }
}
