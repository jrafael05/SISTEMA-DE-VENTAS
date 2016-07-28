using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATOS;
using ENTIDADES;

namespace LOGICA
{
    public class ProductosBL
    {
        public DataTable LlenarProductos()
        {
            ProductosDAL pro = new ProductosDAL();

            return pro.ObtenerProductos();
        }

        public void RegProducto(Productos entidad)
        {
            ProductosDAL RegistroProducto = new ProductosDAL();

            RegistroProducto.InsertarProductos(entidad);

        }

        public void ActualizarProductos(Productos entidad)
        {
            ProductosDAL ActualizacionProductos = new ProductosDAL();

            ActualizacionProductos.ActualizarProductos(entidad);

        }
        public DataTable BusquedaProdusctos(string parametro, string opcion)
        {
            ProductosDAL BusquedaProductos = new ProductosDAL();

            return BusquedaProductos.BusquedaProductos(parametro, opcion);
        }

        public void EliminarProductos(Productos entidad)
        {
            ProductosDAL EliminacionProductos = new ProductosDAL();

            EliminacionProductos.EliminarProductos(entidad);
        }





    }
}
