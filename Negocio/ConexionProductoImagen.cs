using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    internal class ConexionProductoImagen
    {

        public void agregarProductoimagen(TProductos_imagen nuevaImagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterarConsulta("INSERT INTO Productos_Imagen (Ruta,OtrosDatos,Activo) VALUES ('" + nuevaImagen.Ruta + "',null,1)");
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}
