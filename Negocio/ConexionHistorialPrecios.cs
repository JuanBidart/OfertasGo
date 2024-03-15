using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConexionHistorialPrecios
    {


        public List<THistorialPrecio> listarhistorial()
        {
            List<THistorialPrecio> listaHistorial = new List<THistorialPrecio>(); 
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterarConsulta("SELECT idHistorial,Descripcion,Costo,Final,FechaMod,idProducto FROM HistorialPrecios");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    THistorialPrecio aux = new THistorialPrecio();
                    aux.idHistorial = datos.Lector.GetInt32(0);
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Costo = (double)datos.Lector["Costo"];
                    aux.Final = (double)datos.Lector["Final"];
                    var fecha = datos.Lector.GetString(4);
                    aux.idProducto = datos.Lector.GetInt32(5);

                    aux.FechaMod = DateTime.ParseExact(fecha,"dd/MM/yy",null); 

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
        public List<THistorialPrecio> listarhistorialDesendiente()
        {

            List<THistorialPrecio> listaHistorial = new List<THistorialPrecio>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterarConsulta("SELECT idHistorial,Descripcion,Costo,Final,FechaMod,idProducto FROM HistorialPrecios ORDER BY idHistorial DESC");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    THistorialPrecio aux = new THistorialPrecio();
                    aux.idHistorial = datos.Lector.GetInt32(0);
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Costo = (double)datos.Lector["Costo"];
                    aux.Final = (double)datos.Lector["Final"];
                    var fecha = datos.Lector.GetString(4);
                    aux.idProducto = datos.Lector.GetInt32(5);

                    aux.FechaMod = DateTime.ParseExact(fecha, "dd/MM/yy", null);

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
