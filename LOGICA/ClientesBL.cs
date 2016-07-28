using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATOS;
using ENTIDADES;


namespace LOGICA
{
   public  class ClientesBL
    {

        public DataTable LlenarClientes()
        {
            ClientesDAL cli = new ClientesDAL();

            return cli.ObtenerClientes();
        }

        public void RegClientes(Clientes entidad)
        {
            ClientesDAL RegistroCliente = new ClientesDAL();

            RegistroCliente.InsertarClientes(entidad);

        }
        public void ActualizarClientes(Clientes entidad)
        {
            ClientesDAL ActualizacionCliente = new ClientesDAL();

            ActualizacionCliente.ActualizarClientes(entidad);

        }
        public DataTable BusquedaClientes(string parametro, string opcion)
        {
            ClientesDAL BusquedaCliente = new ClientesDAL();

            return BusquedaCliente.BusquedaClientes(parametro, opcion);
        }
        public void EliminarClientes(Clientes entidad)
        {
            ClientesDAL EliminacionCliente = new ClientesDAL();

            EliminacionCliente.EliminarClientes(entidad);
        }


                     
    }
}
