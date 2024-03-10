using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dominio;
using System.Data.SqlClient;

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
        
        
        }
    }
}
