using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dominio;

namespace Negocio
{

    public class ConexionProductodb
    {
    string rutaDatabase = "./Database/dbofertas.db";


        public List<TProductos> listarProductos()

        {
         List<TProductos> listaProductos = new List<TProductos>();
         string consulta = "SELECT idProductos,Descripcion,Costo,[Recargo%],Final,FechaModificacion,Rubro.Rubro from Productos, Rubro";
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
                    //TRubro rubro = new TRubro();
                    productos.Rubro.Rubro = lector.GetString(1);
                    productos.Descripcion = (string)lector["Description"];
                    productos.Costo = (double)lector["Costo"];
                    productos.RecargoPorcentaje = (double)lector["[Recargo%]"];
                    productos.Final = (double)lector["Final"];
                    productos.FechaModificacion = (DateTime)lector["FechaModificcion"];

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
                datos.seterarConsulta("INSERT INTO Productos (Descripcion,Costo,[Recargo%],Final,FechaModificacion,Activo) VALUES ('" + productonuevo.Descripcion + "'," + productonuevo.Costo + "," + productonuevo.RecargoPorcentaje + "," + productonuevo.Final + ",'" + productonuevo.FechaModificacion + "',1)");
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
