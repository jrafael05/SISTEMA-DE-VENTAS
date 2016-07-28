using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENTIDADES
{
    public class Movimientos
    {
        /*  Cabeza Movimiento
         * id	int
            numero_documento	int
            fecha	date
            id_Proveedor	int
            memo	varchar
            responsable	varchar
            tipo	varchar
            total	numeric
            estado	varchar
         */
        public int id { get; set; }
        public int numero_documento { get; set; }
        public DateTime fecha { get; set; }
        public int id_Proveedor { get; set; }
        public string memo { get; set; }
        public string responsable { get; set; }
        public string tipo { get; set; }
        public float total { get; set; }
        public string estado { get; set; }
        
        


    }
}
