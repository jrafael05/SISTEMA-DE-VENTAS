using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Referencias

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ENTIDADES;

namespace DATOS
{

    public class UsuarioDAL
    {
        #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;


        // Constructor
        public UsuarioDAL()
        {
            AccesoDatos = new Acceso();
        }


        public DataTable ObtenerUsuario()
        {
            string query = "Select * From usuario_t";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public Boolean Login(string Usuario, string Clave)
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
    }

}
    

