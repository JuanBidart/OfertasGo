using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dominio;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Negocio
{

    public class ConexionProductodb
    {
    string rutaDatabase = "./Database/dbofertas.db";


        public List<TProductos> listarProductos()

        {
         List<TProductos> listaProductos = new List<TProductos>();
            // SENTENCIA QUE FUNCIONABA = SELECT idProductos,Descripcion,Costo,[Recargo%],Final,FechaModificacion,Activo,idRubro,idProveedores from Productos
            //                         0           1         2      3         4             5               6             7            8                  9                          10                            
         string consulta = "SELECT idProductos,Descripcion,Costo,[Recargo%],Final,FechaModificacion,Productos.Activo,Rubro.IdRubro,Rubro.Rubro,Proveedores.idProveedores,Proveedores.RazonSocial from Productos, Rubro, Proveedores WHERE Rubro.IdRubro=Productos.idRubro AND Proveedores.idProveedores=Productos.idProveedores;";
         string cadenayconexion = $"data source= {rutaDatabase};Version=3";
           

            try
            {
                SQLiteConnection con = new SQLiteConnection(cadenayconexion);

                SQLiteCommand cmd = new SQLiteCommand();
                con.Open();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Connection = con;
                
                SQLiteDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    TProductos productos = new TProductos();
                    productos.idProductos = lector.GetInt32(0);
                    productos.Descripcion = (string)lector["Descripcion"];
                    productos.Costo = (double)lector["Costo"];
                    productos.RecargoPorcentaje = lector.GetDouble(3);
                    productos.Final = (double)lector["Final"];
                    productos.FechaModificacion = lector.GetString(5);
                    productos.Activo = lector.GetByte(6);

                    TRubro rubro = new TRubro();
                    productos.Rubro = rubro;
                    rubro.idRubro = lector.GetInt32(7);
                    rubro.Rubro = lector.GetString(8);
                    TProveedores proveedores = new TProveedores();
                    productos.Proveedores = proveedores;
                    proveedores.idProveedores = lector.GetInt32(9);
                    proveedores.RazonSocial = lector.GetString(10);

                    listaProductos.Add(productos);

                }


                con.Close();
                return listaProductos;
            }
            catch (Exception)
            {

                throw;
            }
            finally { }
        }
        public List<TProductos> listarProductosActivos(bool activo_desactivo)
        {
            string act = "";
            AccesoDatos datos = new AccesoDatos();
            List<TProductos> listaProductos = new List<TProductos>();
            try
            {
                if (activo_desactivo == true) { act = "1"; } else { act = "0"; }    

                datos.seterarConsulta("SELECT idProductos,Descripcion,Costo,[Recargo%],Final,FechaModificacion,Productos.Activo,Rubro.IdRubro,Rubro.Rubro,Proveedores.idProveedores,Proveedores.RazonSocial from Productos, Rubro, Proveedores WHERE Rubro.IdRubro=Productos.idRubro AND Proveedores.idProveedores=Productos.idProveedores AND Productos.activo = "+ act +" ;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TProductos productos = new TProductos();
                    productos.idProductos = datos.Lector.GetInt32(0);
                    productos.Descripcion = (string)datos.Lector["Descripcion"];
                    productos.Costo = (double)datos.Lector["Costo"];
                    productos.RecargoPorcentaje = datos.Lector.GetDouble(3);
                    productos.Final = (double)datos.Lector["Final"];
                    productos.FechaModificacion = datos.Lector.GetString(5);
                    productos.Activo = datos.Lector.GetByte(6);

                    TRubro rubro = new TRubro();
                    productos.Rubro = rubro;
                    rubro.idRubro = datos.Lector.GetInt32(7);
                    rubro.Rubro = datos.Lector.GetString(8);
                    TProveedores proveedores = new TProveedores();
                    productos.Proveedores = proveedores;
                    proveedores.idProveedores = datos.Lector.GetInt32(9);
                    proveedores.RazonSocial = datos.Lector.GetString(10);

                    listaProductos.Add(productos);

                    
                }
                return listaProductos;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
            
        }
        public void agregarProducto(TProductos productonuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //convertir datos duble en string para la base de datos(sqlite)
                string costo = productonuevo.Costo.ToString().Replace(",",".");
                string recargoPorcentaje = productonuevo.RecargoPorcentaje.ToString().Replace(",", ".");
                string final = productonuevo.Final.ToString().Replace(",", ".");

                datos.seterarConsulta("INSERT INTO Productos (Descripcion,Costo,[Recargo%],Final,FechaModificacion,Activo,idRubro,idProveedores) VALUES ('" + productonuevo.Descripcion + "','" + costo + "','" + recargoPorcentaje + "','" + final + "','" + productonuevo.FechaModificacion + "','"+productonuevo.Activo+ "',@idRubro,@idProveedores)");
                datos.setearParametro("@idProveedores",productonuevo.Proveedores.idProveedores);
                datos.setearParametro("@idRubro",productonuevo.Rubro.idRubro);
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
        public void modificarProducto(TProductos productoModificar)
        { 
        AccesoDatos datos = new AccesoDatos();
            
            

            try
            {
                //convertir datos duble en string para la base de datos(sqlite)
                //string costo = productoModificar.Costo.ToString().Replace(",", ".");
                //string recargoPorcentaje = productoModificar.RecargoPorcentaje.ToString().Replace(",", ".");
                //string final = productoModificar.Final.ToString().Replace(",", ".");
                datos.seterarConsulta("UPDATE Productos SET Descripcion = @Descripcion, Costo = @Costo, [Recargo%] = @Recargo, Final = @Final, FechaModificacion = @FechaModificacion, Activo = @Activo, idRubro = @idRubro, idProveedores = @idProveedores WHERE idProductos = @idProducto");


                datos.setearParametro("@Descripcion",productoModificar.Descripcion);
                datos.setearParametro("@Costo",productoModificar.Costo);
                datos.setearParametro("@Recargo",productoModificar.RecargoPorcentaje);
                datos.setearParametro("@Final",productoModificar.Final);
                datos.setearParametro("@FechaModificacion",productoModificar.FechaModificacion);
                datos.setearParametro("@Activo", productoModificar.Activo);
                datos.setearParametro("@idRubro", productoModificar.Rubro.idRubro);
                datos.setearParametro("@idProveedores", productoModificar.Proveedores.idProveedores);
                datos.setearParametro("idProducto", productoModificar.idProductos);


                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }

           

        }
        public void desactivarProducto(TProductos Producto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterarConsulta("UPDATE Productos SET Activo = @activo WHERE idProductos = @idProducto");
                datos.setearParametro("activo",0);
                datos.setearParametro("idProducto",Producto.idProductos);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }  


        }
    }
}
