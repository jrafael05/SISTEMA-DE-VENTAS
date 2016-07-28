using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ENTIDADES;

namespace DATOS
{
    public class ProductosDAL
    {
        #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        // Constructor
        public ProductosDAL()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerProductos()
        {
            string query = "Select * From ver_id";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;

        }

        public void InsertarProductos(Productos Producto)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_PRODUCTOSInsert";
                try
                {
                    //ComandoSQL.Parameters.AddWithValue("@IdProducto", Clientes.Nombre);
                    ComandoSQL.Parameters.AddWithValue("@DescProducto", Producto.DESC_PRODUCTO);
                    ComandoSQL.Parameters.AddWithValue("@IdProveedor", Producto.ID_PROVEEDOR);
                    ComandoSQL.Parameters.AddWithValue("@Costo", Producto.COSTO);
                    ComandoSQL.Parameters.AddWithValue("@Precio", Producto.PRECIO);

                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }
            }
        
        }

        public void ActualizarProductos(Productos producto)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_PRODUCTOSUpdate";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@IdProducto", producto.ID_PRODUCTO);
                    ComandoSQL.Parameters.AddWithValue("@DescProducto", producto.DESC_PRODUCTO);
                    ComandoSQL.Parameters.AddWithValue("@IdProveedor", producto.ID_PROVEEDOR);
                    ComandoSQL.Parameters.AddWithValue("@Costo", producto.COSTO);
                    ComandoSQL.Parameters.AddWithValue("@Precio", producto.PRECIO);
                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }
            }
        }

        public DataTable BusquedaProductos(string parametro, string opcion)
        {
            AccesoDatos.ObtenerConexion().Open();
            string query = string.Empty;

           
            query = "SELECT * FROM Productos WHERE DESC_PRODUCTO LIKE @param";


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandText = query;
                ComandoSQL.CommandType = CommandType.Text;

                try
                {
                    ComandoSQL.Parameters.AddWithValue("@param", "%" + parametro + "%");


                    using (AdaptadorSQL = new SqlDataAdapter())
                    {
                        AdaptadorSQL.SelectCommand = ComandoSQL;
                        Dt = new DataTable();
                        AdaptadorSQL.Fill(Dt);
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }

                return Dt;
            }
        }
        public void EliminarProductos(Productos producto)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_PRODUCTOSDelete";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@IdProducto", producto.ID_PRODUCTO);

                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }
            }
        }
    }
}
