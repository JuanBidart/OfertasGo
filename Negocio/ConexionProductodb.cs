using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Globalization;
using System.Windows.Forms;

namespace Negocio
{

    public class ConexionProductodb
    {
        //string rutaDatabase = "./Database/dbofertas.db";


        //public List<TProductos> listarProductos(bool orden, bool ascendente)
        //{


        //    if (orden == false) ascendente = false;

        //    string consulta = "SELECT idProductos,Descripcion,Costo,[DescuentoCosto%],[Recargo%],Final,FechaModificacion,Productos.Activo,Rubro.IdRubro,Rubro.Rubro,Proveedores.idProveedores,Proveedores.RazonSocial from Productos, Rubro, Proveedores WHERE Rubro.IdRubro=Productos.idRubro AND Proveedores.idProveedores=Productos.idProveedores;";

        //    if (orden == true && ascendente == false)
        //    {
        //        consulta = "SELECT idProductos,Descripcion,Costo,[DescuentoCosto%],[Recargo%],Final,FechaModificacion,Productos.Activo,Rubro.IdRubro,Rubro.Rubro,Proveedores.idProveedores,Proveedores.RazonSocial from Productos, Rubro, Proveedores WHERE Rubro.IdRubro=Productos.idRubro AND Proveedores.idProveedores=Productos.idProveedores ORDER BY Descripcion COLLATE NOCASE DESC;";
        //    }
        //    if (orden == true && ascendente == true)
        //    {
        //        consulta = "SELECT idProductos,Descripcion,Costo,[DescuentoCosto%],[Recargo%],Final,FechaModificacion,Productos.Activo,Rubro.IdRubro,Rubro.Rubro,Proveedores.idProveedores,Proveedores.RazonSocial from Productos, Rubro, Proveedores WHERE Rubro.IdRubro=Productos.idRubro AND Proveedores.idProveedores=Productos.idProveedores ORDER BY Descripcion COLLATE NOCASE ASC;";
        //    }


        //    List<TProductos> listaProductos = new List<TProductos>();
        //    // SENTENCIA QUE FUNCIONABA = SELECT idProductos,Descripcion,Costo,[Recargo%],Final,FechaModificacion,Activo,idRubro,idProveedores from Productos
        //    //                                       0           1         2      3         4             5               6             7            8                  9                          10                            

        //    string cadenayconexion = $"data source= {rutaDatabase};Version=3";


        //    try
        //    {
        //        SQLiteConnection con = new SQLiteConnection(cadenayconexion);

        //        SQLiteCommand cmd = new SQLiteCommand();
        //        con.Open();
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = consulta;
        //        cmd.Connection = con;

        //        SQLiteDataReader lector = cmd.ExecuteReader();

        //        while (lector.Read())
        //        {
        //            TProductos productos = new TProductos();
        //            productos.idProductos = lector.GetInt32(0);
        //            productos.Descripcion = (string)lector["Descripcion"];
        //            productos.Costo = (double)lector["Costo"];
        //            productos.DescuentoCostoPorcentaje = lector.GetDouble(3);
        //            productos.RecargoPorcentaje = lector.GetDouble(4);
        //            productos.Final = (double)lector["Final"];
        //            productos.FechaModificacion = lector.GetString(6);
        //            productos.Activo = lector.GetByte(7);

        //            TRubro rubro = new TRubro();
        //            productos.Rubro = rubro;
        //            rubro.idRubro = lector.GetInt32(8);
        //            rubro.Rubro = lector.GetString(9);
        //            TProveedores proveedores = new TProveedores();
        //            productos.Proveedores = proveedores;
        //            proveedores.idProveedores = lector.GetInt32(10);
        //            proveedores.RazonSocial = lector.GetString(11);

        //            productos.Costo.ToString("C2", CultureInfo.CreateSpecificCulture("ES-ar"));
        //            listaProductos.Add(productos);

        //        }


        //        con.Close();
        //        return listaProductos;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally { }
        //}
        public List<TProductos> listarProductosActivos(bool activo_desactivo = true, bool orden=true, bool ascOdes=true)
        {
            string act = "";
            string consulta = "";
            AccesoDatos datos = new AccesoDatos();
            List<TProductos> listaProductos = new List<TProductos>();
            try
            {
                if (activo_desactivo == true) { act = "1"; } else { act = "0"; }
                consulta = "SELECT idProductos,Descripcion,Costo,[DescuentoCosto%],Iva,[Recargo%],Final,FechaModificacion,Productos.Activo,Rubro.IdRubro,Rubro.Rubro,Proveedores.idProveedores,Proveedores.RazonSocial from Productos, Rubro, Proveedores WHERE Rubro.IdRubro=Productos.idRubro AND Proveedores.idProveedores=Productos.idProveedores AND Productos.activo = " + act + "";

                if (orden == true)
                {
                    consulta.Replace(";", "");
                    consulta += " ORDER BY Productos.Descripcion ";
                    if(ascOdes == true) 
                    {
                        consulta += "COLLATE NOCASE ASC;";
                    }
                    else
                    {
                        consulta += "COLLATE NOCASE DESC;";
                    }
                }
                //if (orden == true && ascendente == true)
                //{
                //    consulta += consulta.Replace(";", "") + " ORDER BY Productos.Descripcion COLLATE NOCASE ASC;";
                //}



                datos.seterarConsulta(consulta);



                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TProductos productos = new TProductos();
                    productos.idProductos = datos.Lector.GetInt32(0);
                    productos.Descripcion = (string)datos.Lector["Descripcion"];
                    productos.Costo = (double)datos.Lector["Costo"];
                   
                    if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("[DescuentoCosto%]")))
                    {
                        productos.DescuentoCostoPorcentaje = (datos.Lector.GetDouble(3));
                    }
                   

                    if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Iva")))
                    {
                        productos.Iva = datos.Lector.GetDouble(4);
                    }
                    
                    productos.RecargoPorcentaje = datos.Lector.GetDouble(5);
                    productos.Final = (double)datos.Lector["Final"];
                    productos.FechaModificacion = datos.Lector.GetString(7);
                    productos.Activo = datos.Lector.GetByte(8);

                    TRubro rubro = new TRubro();
                    productos.Rubro = rubro;
                    rubro.idRubro = datos.Lector.GetInt32(9);
                    rubro.Rubro = datos.Lector.GetString(10);
                    TProveedores proveedores = new TProveedores();
                    productos.Proveedores = proveedores;
                    proveedores.idProveedores = datos.Lector.GetInt32(11);
                    proveedores.RazonSocial = datos.Lector.GetString(12);


                    productos.Costo.ToString("C2", CultureInfo.CreateSpecificCulture("ES-ar"));
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
        public List<TProductos> ordenarSegunColumna(string Columna)
        {
            List<TProductos> temp = null;
            return  temp;
        }
        public void agregarProducto(TProductos productonuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //convertir datos duble en string para la base de datos(sqlite)
                string costo = productonuevo.Costo.ToString().Replace(",", ".");
                string descuentoCostoPorcentaje = productonuevo.DescuentoCostoPorcentaje.ToString().Replace(",",".");
                string recargoPorcentaje = productonuevo.RecargoPorcentaje.ToString().Replace(",", ".");
                string final = productonuevo.Final.ToString().Replace(",", ".");
                string iva = productonuevo.Iva.ToString().Replace(",", ".");    

                datos.seterarConsulta("INSERT INTO Productos (Descripcion,Costo,[DescuentoCosto%],Iva,[Recargo%],Final,FechaModificacion,Activo,idRubro,idProveedores) VALUES ('" + productonuevo.Descripcion + "','" + costo + "','"+ descuentoCostoPorcentaje +"','"+ iva +"' ,'"+ recargoPorcentaje + "','" + final + "','" + productonuevo.FechaModificacion + "','" + productonuevo.Activo + "',@idRubro,@idProveedores)");
                
                datos.setearParametro("@idProveedores", productonuevo.Proveedores.idProveedores);
                datos.setearParametro("@idRubro", productonuevo.Rubro.idRubro);
                datos.ejecutarAccion();
            }
            catch (System.NullReferenceException) { return; }
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
                datos.seterarConsulta("UPDATE Productos SET Descripcion = @Descripcion, Costo = @Costo,[DescuentoCosto%] = @DescuentoCosto, Iva = @Iva, [Recargo%] = @Recargo, Final = @Final, FechaModificacion = @FechaModificacion, Activo = @Activo, idRubro = @idRubro, idProveedores = @idProveedores WHERE idProductos = @idProducto");


                datos.setearParametro("@Descripcion", productoModificar.Descripcion);
                datos.setearParametro("@Costo", productoModificar.Costo);
                datos.setearParametro("@DescuentoCosto", productoModificar.DescuentoCostoPorcentaje);
                datos.setearParametro("@Iva",productoModificar.Iva);
                datos.setearParametro("@Recargo", productoModificar.RecargoPorcentaje);
                datos.setearParametro("@Final", productoModificar.Final);
                datos.setearParametro("@FechaModificacion", productoModificar.FechaModificacion);
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
        public void desOactProducto(TProductos Producto, bool trueActivar_falseDesativar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterarConsulta("UPDATE Productos SET Activo = @activo WHERE idProductos = @idProducto");
                if (trueActivar_falseDesativar)
                { datos.setearParametro("activo", 1); }
                else { datos.setearParametro("activo", 0); };

                datos.setearParametro("idProducto", Producto.idProductos);
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
