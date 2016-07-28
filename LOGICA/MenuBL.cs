using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATOS;

namespace LOGICA
{
    public class MenuBL
    {
        MenuDAL Reg = new MenuDAL();

        public DataSet MostarMenu()
        {

            return Reg.buscar_Menu();

        }
        public DataSet MostrarSubMenu()
        {
            return Reg.buscar_SubMenu();

        }

        public bool ValidarUsuario(string Usuario, string Clave)
        {
            MenuDAL Reg = new MenuDAL();
            return Reg.ValidarUsuario(Usuario, Clave);
        }

    }
}
