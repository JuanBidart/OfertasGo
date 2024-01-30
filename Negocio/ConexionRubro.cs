using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dominio;
using Negocio;

namespace Negocio
{
   public class ConexionRubro
    {

        public List<TRubro> listarRubro() 
        {
            List<TRubro> rubro = new List<TRubro>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.seterarConsulta("SELECT idRubro,Rubro,Activo,Eliminado FROM Rubro");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                    {
                        TRubro aux = new TRubro();
                        aux.idRubro =  datos.Lector.GetInt32(0);
                        aux.Rubro = datos.Lector.GetString(1);
                        aux.Activo = datos.Lector.GetByte(2);
                        aux.Eliminado = datos.Lector.GetByte(3) ;

                        rubro.Add(aux);
                    }
                


                return rubro;

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

        public void agregarRubro(TRubro nuevorubro) 
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterarConsulta("INSERT INTO Rubro(Rubro,Activo,Eliminado) VALUES ('"+nuevorubro.Rubro+"',1,0)");
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            { 
            datos .cerrarConexion();
            }

        }
    }
}
