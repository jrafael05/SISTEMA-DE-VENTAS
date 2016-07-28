using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace DATOS
{
   public class MenuDAL
    {
        public DataSet buscar_Menu()
        {
            SqlCommand ComandoSQL = new SqlCommand();
            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                Acceso AccesoDatos;
                AccesoDatos = new Acceso();

                DataSet ds = new DataSet();

                ComandoSQL = new SqlCommand("proc_MenuLoadAll", AccesoDatos.ObtenerConexion());
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                AdaptadorSQL.SelectCommand = ComandoSQL;
                AdaptadorSQL.Fill(ds, "MenuOpciones");

                return ds;

            }
            catch (Exception )
            {
                throw;
            }

        }

        public DataSet buscar_SubMenu()
        {
            SqlCommand ComandoSQL = new SqlCommand();
            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                Acceso AccesoDatos;
                AccesoDatos = new Acceso();

                DataSet ds = new DataSet();

                ComandoSQL = new SqlCommand("proc_SubMenuLoadAll", AccesoDatos.ObtenerConexion());
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                AdaptadorSQL.SelectCommand = ComandoSQL;
                AdaptadorSQL.Fill(ds, "SubMenuOpciones");

                return ds;

            }
            catch (Exception)
            {
                throw;
            }

        }


        private SqlConnection conn;
        private SqlDataReader Reader;

        public bool ValidarUsuario(string usuario, string clave)
        {
            bool existe = false;
            int i = 0;

            conn = new SqlConnection(DATOS.Properties.Settings.Default.conectar.ToString());
            using (SqlCommand cmd = new SqlCommand("usp_ValidarUsuario", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@USU", usuario);
                    cmd.Parameters.AddWithValue("@Cla", clave);

                    Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        i++;
                    }

                    if (i >= 1) { existe = true; }
                    else { existe = false; }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Reader.Close();
                    cmd.Connection.Close();
                }
                return existe;
            }
        }

    }
}
