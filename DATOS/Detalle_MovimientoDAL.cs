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
    public class Detalle_MovimientoDAL
    {
        #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        // Constructor
        public Detalle_MovimientoDAL()
        {
            AccesoDatos = new Acceso();
        }

    
        public DataTable ObtenerDetalleMovimiento()
        {
            string query = "Select * From detalle_movimiento";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }





        public void InsertarDetalleMovimiento(Detalle_Movimiento det_mov)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_detalle_movimientoInsert";
                try
                {
                    //ComandoSQL.Parameters.AddWithValue("@IdProveedor ", proveedor.id_proveedor);
                    ComandoSQL.Parameters.AddWithValue("@IdProducto", det_mov.id_Producto);
                    ComandoSQL.Parameters.AddWithValue("@Cantidad", det_mov.cantidad);
                    ComandoSQL.Parameters.AddWithValue("@Precio", det_mov.precio);
                    ComandoSQL.Parameters.AddWithValue("@IdMovimiento", det_mov.id_movimiento);
                    

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
        public void ActualizarDt_Movimiento(Detalle_Movimiento det_mov)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_detalle_movimientoUpdate";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@IdDetalle", det_mov.id_detalle);
                    ComandoSQL.Parameters.AddWithValue("@IdProducto", det_mov.id_Producto);
                    ComandoSQL.Parameters.AddWithValue("@Cantidad", det_mov.cantidad);
                    ComandoSQL.Parameters.AddWithValue("@Precio", det_mov.precio);
                    ComandoSQL.Parameters.AddWithValue("@IdMovimiento", det_mov.id_movimiento);
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
        public void EliminarDetalle_Movimiento(Detalle_Movimiento dt_Movimiento)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_detalle_movimientoDelete";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@IdDetalle", dt_Movimiento.id_detalle);

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
