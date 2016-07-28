using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ENTIDADES;

namespace DATOS
{     
     public class ClientesDAL
    {

         #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        // Constructor
        public ClientesDAL()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerClientes()
        {
            string query = "Select * From Clientes";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public void InsertarClientes(Clientes Clientes)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "INSERTARCLIENTES";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@Nombre", Clientes.NOMB_CLIENTE);
                    ComandoSQL.Parameters.AddWithValue("@Direccion", Clientes.DIRECCION);
                    ComandoSQL.Parameters.AddWithValue("@Pais", Clientes.PAIS);
                    ComandoSQL.Parameters.AddWithValue("@SaldoInicial", Clientes.SALDO_INIC);
                    ComandoSQL.Parameters.AddWithValue("@SaldoActual", Clientes.SALDO_AC);

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
        public void ActualizarClientes(Clientes Clientes)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_CLIENTESUpdate";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@IdCliente", Clientes.ID_CLIENTE);
                    ComandoSQL.Parameters.AddWithValue("@NombCliente", Clientes.NOMB_CLIENTE);
                    ComandoSQL.Parameters.AddWithValue("@Direccion", Clientes.DIRECCION);
                    ComandoSQL.Parameters.AddWithValue("@Pais", Clientes.PAIS);
                    ComandoSQL.Parameters.AddWithValue("@SaldoInic", Clientes.SALDO_INIC);
                    ComandoSQL.Parameters.AddWithValue("@SaldoAct", Clientes.SALDO_AC);

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
        public DataTable BusquedaClientes(string parametro, string opcion)
        {
            AccesoDatos.ObtenerConexion().Open();
            string query = string.Empty;

            query = "SELECT * FROM CLIENTES WHERE NOMB_CLIENTE LIKE @param";

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
        public void EliminarClientes(Clientes Clientes)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_CLIENTESDelete";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@IdCliente", Clientes.ID_CLIENTE);

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
