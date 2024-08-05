using Dominio;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class ConexionProveedores
    {
        public List<TProveedores> listarProveedores(bool activo)
        {
           
            AccesoDatos datos = new AccesoDatos();
            List<TProveedores> lista = new List<TProveedores>();
            string consulta = "SELECT IdProveedores,RazonSocial,Direccion,Ciudad,Email,Telefono,Telefono2,Activo,Eliminado FROM Proveedores";
            if (activo)
            {
                consulta += " WHERE Activo = 1";
            }
            consulta += " ORDER BY RazonSocial ASC";
            try
            {
                datos.seterarConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TProveedores aux = new TProveedores();
                    aux.idProveedores = datos.Lector.GetInt32(0);
                    aux.RazonSocial = datos.Lector.GetString(1);
                    aux.Direccion = datos.Lector.GetString(2);
                    aux.Ciudad = datos.Lector.GetString(3);
                    aux.Email = datos.Lector.GetString(4);
                    aux.Telefono = datos.Lector.GetString(5);
                    aux.Telefono2 = datos.Lector.GetString(6);
                    aux.Activo = datos.Lector.GetByte(7);
                    aux.Eliminado = datos.Lector.GetByte(8);

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


            try
            {
                datos.seterarConsulta("INSERT INTO Proveedores (RazonSocial,Direccion,Ciudad,Email,Telefono,Telefono2,Activo,Eliminado) VALUES (@RazonSocial,@Direccion,@Ciudad,@Email,@Telefono,@Telefono2,@Activo,@Eliminado)");
                datos.setearParametro("@RazonSocial", Proveedor.RazonSocial);
                datos.setearParametro("@Direccion", Proveedor.Direccion);
                datos.setearParametro("@Ciudad", Proveedor.Ciudad);
                datos.setearParametro("@Email", Proveedor.Email);
                datos.setearParametro("@Telefono", Proveedor.Telefono);
                datos.setearParametro("@Telefono2", Proveedor.Telefono2);
                datos.setearParametro("@Activo", Proveedor.Activo);
                datos.setearParametro("@Eliminado", Proveedor.Eliminado);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConexion(); }



        }
        public void modificarproveedor(TProveedores Proveedor) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
               // int seleccion;
                

                datos.seterarConsulta("UPDATE Proveedores SET RazonSocial = @RazonSocial, Direccion=@Direccion, Ciudad=@Ciudad, Email=@Email, Telefono=@Telefono, Telefono2=@Telefono2, Activo=@Activo WHERE idProveedores = @idProveedores;");

                datos.setearParametro("idProveedores",Proveedor.idProveedores);
                datos.setearParametro("@RazonSocial",Proveedor.RazonSocial);
                datos.setearParametro("@Direccion", Proveedor.Direccion);
                datos.setearParametro("@Ciudad", Proveedor.Ciudad);
                datos.setearParametro("@Email",Proveedor.Email);
                datos.setearParametro("@Telefono", Proveedor.Telefono);
                datos.setearParametro("@Telefono2", Proveedor.Telefono2);
                datos.setearParametro("@Activo", Proveedor.Activo);
                
                datos.ejecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConexion(); }

        }
        public void desactivar(TProveedores Proveedor) 
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterarConsulta("UPDATE Proveedores SET Activo = @Activo WHERE idProveedores = @idProveedores;");

                datos.setearParametro("@idProveedores", Proveedor.idProveedores);
                datos.setearParametro("@Activo",0);

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
