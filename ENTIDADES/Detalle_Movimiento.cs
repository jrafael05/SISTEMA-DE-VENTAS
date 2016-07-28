using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENTIDADES
{
    public class Detalle_Movimiento
    {

        /*detalle movimiento
         * id_detalle	int
            id_Producto	int
            cantidad	numeric
            precio	numeric
            id_movimiento	int
         */
        public int id_detalle { get; set; }
        public int id_Producto { get; set; }
        public float cantidad { get; set; }
        public float precio { get; set; }
        public int id_movimiento { get; set; }
      
        
    }
}
