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
    public class MovimientoDAL
    {
        #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        // Constructor
        public MovimientoDAL()
        {
            AccesoDatos = new Acceso();
        }


        public DataTable ObtenerMovimiento()
        {
            string query = "Select * From Movimientos";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public DataTable ObtenerTipo(string tipo)
        {
            string query = "Select * From " + tipo;
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public DataTable ObtenerDetalle(string tabla, int ID)
        {
            string query = "Select * From " + tabla + " where ID =" + ID;
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public DataTable ObtenerNumero()
        {
            string query = "select IDENT_CURRENT('Movimientos') as ID1, ISNULL(MAX(Movimientos.id),0) as ID2 from Movimientos";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public void InsertarMovimiento(Movimientos movimiento, Detalle_Movimiento dt)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "sp_Movimientos";
                try
                {
                    //ComandoSQL.Parameters.AddWithValue("@IdProveedor ", proveedor.id_proveedor);
                    ComandoSQL.Parameters.AddWithValue("@NumDoc", movimiento.numero_documento);
                    ComandoSQL.Parameters.AddWithValue("@Fecha", movimiento.fecha);
                    ComandoSQL.Parameters.AddWithValue("@IdProveedor", movimiento.id_Proveedor);
                    ComandoSQL.Parameters.AddWithValue("@Memo", movimiento.memo);
                    ComandoSQL.Parameters.AddWithValue("@Responsable", movimiento.responsable);
                    ComandoSQL.Parameters.AddWithValue("@Tipo ", movimiento.tipo);
                    ComandoSQL.Parameters.AddWithValue("@Total", movimiento.total);
                    ComandoSQL.Parameters.AddWithValue("@Estado", movimiento.estado);

                    ///////detalle////////////

                    ComandoSQL.Parameters.AddWithValue("@IdProducto", dt.id_Producto);
                    ComandoSQL.Parameters.AddWithValue("@Cantidad", dt.cantidad);
                    ComandoSQL.Parameters.AddWithValue("@Precio", dt.precio);
                    ComandoSQL.Parameters.AddWithValue("@IdMovimiento", dt.id_movimiento);



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
        public void ActualizarMovimiento(Movimientos movimiento)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_MovimientosUpdate";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@Id", movimiento.id);
                    ComandoSQL.Parameters.AddWithValue("@NumeroDocumento", movimiento.numero_documento);
                    ComandoSQL.Parameters.AddWithValue("@Fecha", movimiento.fecha);
                    ComandoSQL.Parameters.AddWithValue("@IdProveedor", movimiento.id_Proveedor);
                    ComandoSQL.Parameters.AddWithValue("@Memo", movimiento.memo);
                    ComandoSQL.Parameters.AddWithValue("@Responsable", movimiento.responsable);
                    ComandoSQL.Parameters.AddWithValue("@Tipo", movimiento.tipo);
                    ComandoSQL.Parameters.AddWithValue("@Total", movimiento.total);
                    ComandoSQL.Parameters.AddWithValue("@Estado", movimiento.estado);

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
        public void ActualizarEstado(float Cantidad, int ID)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_ActualizarExistencia";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID", ID);
                    ComandoSQL.Parameters.AddWithValue("@CANTIDAD", Cantidad);

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
        public void EliminarMovimeinto(Movimientos movimiento)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_MovimientosDelete";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@Id", movimiento.id);

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
