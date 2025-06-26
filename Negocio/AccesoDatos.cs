using System;
using System.Data.SQLite;
using System.IO;
using System.Configuration;

namespace Negocio
{
    public class AccesoDatos
    {
        // Ruta leída desde App.config
        private string rutaDatabase;
        private SQLiteConnection conexion;
        private SQLiteCommand comando;
        private SQLiteDataReader lector;

        public SQLiteDataReader Lector => lector;

        public AccesoDatos()
        {
            // Lee la ruta desde App.config
            rutaDatabase = ConfigurationManager.AppSettings["RutaDB"];

            // Si no existe la carpeta, la crea (en caso de que sea por ej: C:\OfertasGo\Database)
            string carpetaDB = Path.GetDirectoryName(rutaDatabase);
            if (!Directory.Exists(carpetaDB))
            {
                Directory.CreateDirectory(carpetaDB);
            }

            conexion = new SQLiteConnection($"Data Source={rutaDatabase};Version=3;");
            comando = new SQLiteCommand();
        }

        public void seterarConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar lectura", ex);
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar acción", ex);
            }
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }


        // -------------------------
        // Código anterior comentado:
        /*
        string rutaDatabase = "./Database/dbofertas.db";

        public AccesoDatos()
        {
            conexion = new SQLiteConnection($"data source= {rutaDatabase};Version=3");
            comando = new SQLiteCommand();
        }
        */
        // -------------------------
    }
}
