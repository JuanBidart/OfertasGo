﻿namespace Dominio
{
    public class TRubro
    {
        //Idrubro:int Rubro:text Activo:bool Eliminado:bool
        public int idRubro { get; set; }
        public string Rubro { get; set; }
        public byte Activo { get; set; }
        public byte Eliminado { get; set; }




        public override string ToString()
        {
            return Rubro.ToString();
        }
    }

}
