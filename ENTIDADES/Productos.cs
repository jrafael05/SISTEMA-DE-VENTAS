using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENTIDADES
{
    public class Productos
    {
        /*
         * ID_PRODUCTO	int
            DESC_PRODUCTO	varchar
            ID_FABRICANTE	int
            COSTO	float
            PRECIO	float
         */
        public int ID_PRODUCTO { get; set; }
        public string DESC_PRODUCTO { get; set; }
        public int ID_PROVEEDOR { get; set; }
        public decimal COSTO { get; set; }
        public decimal PRECIO  { get; set; }


    }
}
