using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConexionProveedores
    {
        public List<TProveedores> listarProveedores()
        {
        AccesoDatos datos = new AccesoDatos();
        List<TProveedores> lista = new List<TProveedores>();

            try
            {
                datos.seterarConsulta("SELECT IdProveedores,RazonSocial,Direccion,Ciudad,Telefono,Telefono2,Activo,Eliminado FROM Proveedores");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TProveedores aux = new TProveedores();
                    aux.idProveedores = datos.Lector.GetInt32(0);
                    aux.RazonSocial = datos.Lector.GetString(1);
                    aux.Direccion = datos.Lector.GetString(2);
                    aux.Ciudad = datos.Lector.GetString(3);
                    aux.Telefono = datos.Lector.GetString(4);
                    aux.Telefono2 = datos.Lector.GetString(5);
                    aux.Activo = datos.Lector.GetByte(6);
                    aux.Eliminado = datos.Lector.GetByte(7);

                    lista.Add(aux);


                }


                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConexion(); }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }

        public void agregarProveedor(TProveedores Proveedor) 
        {
         AccesoDatos datos = new AccesoDatos();

            //ACA ME QUEDE FALTAN LOS VALORES
            try
            {
                datos.seterarConsulta("INSERT INTO Proveedores (RazonSocial,Direccion,Ciudad,Telefono,Telefono2,Activo,Eliminado) VALUES (@RazonSocial,@Direccion,@Ciudad,@Telefono,@Telefono2,@Activo,@Eliminado)");
                datos.setearParametro("@RazonSocial",Proveedor.RazonSocial);
                datos.setearParametro("@Direccion",Proveedor.Direccion);
                datos.setearParametro("@Ciudad",Proveedor.Ciudad);
                datos.setearParametro("@Telefono",Proveedor.Telefono);
                datos.setearParametro("@Telefono2",Proveedor.Telefono2);
                datos.setearParametro("@Activo",Proveedor.Activo);
                datos.setearParametro("@Eliminado",Proveedor.Eliminado);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConexion(); }
        
        
        
        }




    }
}
