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
    public class ProveedorDAL
    {
      #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        // Constructor
        public ProveedorDAL()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerProveedor()
        {
            string query = "Select * From Proveedor";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;

        }
        public DataTable ObtenerProveedorid(int id)
        {
            string query = "Select Nombre From Proveedor where id_proveedor="+ id;
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;

        }
        public void InsertarProveedor(Proveedor proveedor)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_ProveedorInsert";
                try
                {
                    //ComandoSQL.Parameters.AddWithValue("@IdProveedor ", proveedor.id_proveedor);
                    ComandoSQL.Parameters.AddWithValue("@Nombre", proveedor.nombre);
                    ComandoSQL.Parameters.AddWithValue("@Contacto", proveedor.contacto);
                    ComandoSQL.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                    ComandoSQL.Parameters.AddWithValue("@Fax", proveedor.Fax);
                    ComandoSQL.Parameters.AddWithValue("@Email",proveedor.Email);
                    ComandoSQL.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                    ComandoSQL.Parameters.AddWithValue("@Memo", proveedor.Memo);

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
        public void ActualizarProveedor(Proveedor proveedor)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_ProveedorUpdate";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@IdProveedor ", proveedor.id_proveedor);
                    ComandoSQL.Parameters.AddWithValue("@Nombre", proveedor.nombre);
                    ComandoSQL.Parameters.AddWithValue("@Contacto", proveedor.contacto);
                    ComandoSQL.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                    ComandoSQL.Parameters.AddWithValue("@Fax", proveedor.Fax);
                    ComandoSQL.Parameters.AddWithValue("@Email", proveedor.Email);
                    ComandoSQL.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                    ComandoSQL.Parameters.AddWithValue("@Memo", proveedor.Memo);
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
        public DataTable BusquedaProveedor(string parametro, string opcion)
        {
            AccesoDatos.ObtenerConexion().Open();
            string query = string.Empty;


            query = "SELECT * FROM Proveedor WHERE nombre LIKE @param";


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
        public void EliminarProveedor(Proveedor proveedor)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_ProveedorDelete";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@IdProveedor", proveedor.id_proveedor);

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
