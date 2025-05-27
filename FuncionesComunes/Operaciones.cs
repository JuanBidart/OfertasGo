using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace FuncionesComunes
{
    public static class Operaciones
    {


        public static void ModificarDataProducto_Recargo(TextBox textBox, List<TProductos> lista)
        {
            ConexionProductodb productodb = new ConexionProductodb();

            double numeroIngresado = double.Parse(textBox.Text);
            foreach (var item in lista)

            {
                //Cargar datos de cada producto
                double finalactual = item.Final;
                double costoactual = item.Costo;
               
                double ivaActual = item.Iva;
                double descuentoActual = item.DescuentoCostoPorcentaje;
                double ajusteActual = item.AjustePesos;

                //Cargar variables para resultados y operaciones
                double costodescuento;
                double costoiva;
                double costorecargo;
                double finalNuevo;

                //Realizar las operaciones correspondientes

                costodescuento = ((costoactual * descuentoActual) / 100);
                costoiva = ((costoactual * ivaActual) / 100);
                costorecargo = ((costoactual * numeroIngresado) / 100);
               
                              
                finalNuevo = costoactual - costodescuento + (costoiva + costorecargo) + ajusteActual;

                //Agregar al item para su modificacion
                item.RecargoPorcentaje = numeroIngresado;
                item.FechaModificacion = item.FechaModificacion = DateTime.Now.Date.ToString("dd/MM/yy");
                item.Final = finalNuevo;


                productodb.modificarProducto(item);

            }
        }    
    }
}
