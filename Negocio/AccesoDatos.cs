using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Negocio
{
    public class AccesoDatos
    {
        string rutaDatabase = "./Database/dbofertas.db";
        private SQLiteConnection conexion;
        private SQLiteCommand comando;
        private SQLiteDataReader lector;
        public SQLiteDataReader Lector
        {
            get { return lector; }
        }


        public AccesoDatos() 
    {
           conexion = new SQLiteConnection($"data source= {rutaDatabase};Version=3");
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
            catch (Exception)
            {

                throw;
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

                throw ex;
            }
        
        }

        public void setearParametro(string nombre, object valor) 
        {

            comando.Parameters.AddWithValue(nombre,valor);
        
        }
        public void cerrarConexion() 
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        
        }

    }
    
}
