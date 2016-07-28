using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENTIDADES
{
     public  class Proveedor
    {
        /*
         * id_proveedor	int
            nombre	varchar
            contacto	varchar
            Telefono	varchar
            Fax	varchar
            Email	varchar
            Direccion	varchar
            Memo	varchar
                     */

           public int id_proveedor{ get; set; }
           public string nombre { get; set; }
           public string contacto { get; set; }
           public string Telefono { get; set; }
           public string Fax { get; set; }
           public string Email { get; set; }
           public string Direccion { get; set; }
           public string Memo { get; set; }
           
         


    }
}
