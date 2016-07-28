using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENTIDADES
{
    public class Clientes
    {

        /*
         * ID_CLIENTE	int
                //NOMB_CLIENTE	varchar
                //DIRECCION	varchar
                //PAIS	varchar
                //SALDO_INIC	float
                //SALDO_ACT	float
                //        */
        //Llave primaria
        public int ID_CLIENTE { get; set; }

        //Datos del cliente
        public string NOMB_CLIENTE { get; set; }
        public string DIRECCION { get; set; }
        public string PAIS { get; set; }

        // Saldos
        public decimal SALDO_INIC { get; set; }
        public decimal SALDO_AC { get; set; }
    }
}
