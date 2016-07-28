using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATOS;
using ENTIDADES;

namespace LOGICA
{
    public class ProveedorBL
    {
        public DataTable LlenarProveedor()
        {
            ProveedorDAL pro = new ProveedorDAL();

            return pro.ObtenerProveedor();
        }

        public void RegProveedor(Proveedor entidad)
        {
            ProveedorDAL RegistroProveedor = new ProveedorDAL();

            RegistroProveedor.InsertarProveedor(entidad);

        }
        public void ActualizarProveedor(Proveedor entidad)
        {
            ProveedorDAL ActualizacionProveedor = new ProveedorDAL();

            ActualizacionProveedor.ActualizarProveedor(entidad);

        }
        public DataTable BusquedaProveedor(string parametro, string opcion)
        {
            ProveedorDAL BusquedaProveedor = new ProveedorDAL();

            return BusquedaProveedor.BusquedaProveedor(parametro, opcion);
        }
        public DataTable busquedaid(int parametro)
        {
            ProveedorDAL BusquedaProveedor = new ProveedorDAL();

            return BusquedaProveedor.ObtenerProveedorid(parametro);
        }
        public void EliminarProveedor(Proveedor entidad)
        {
            ProveedorDAL EliminacionProveedor = new ProveedorDAL();

            EliminacionProveedor.EliminarProveedor(entidad);
        }



    }
}
