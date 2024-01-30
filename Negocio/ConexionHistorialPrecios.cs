using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConexionHistorialPrecios
    {


        public List<THistorialPrecio> listar()
        {
            List<THistorialPrecio> listaHistorial = new List<THistorialPrecio>(); 
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterarConsulta("SELECT idHistorial,Descripcion,Costo,Final,FechaMod FROM HistorialPrecios");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    THistorialPrecio aux = new THistorialPrecio();
                    aux.idHistorial = (int)datos.Lector["idHistorial"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Costo = (double)datos.Lector["Costo"];
                    aux.Final = (double)datos.Lector["Final"];
                    aux.FechaMod = (DateTime)datos.Lector["FechaMod"];

                    listaHistorial.Add(aux);
                }

                return listaHistorial;

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
