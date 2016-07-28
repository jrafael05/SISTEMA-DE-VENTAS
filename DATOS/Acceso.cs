using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
namespace DATOS
{
    public class Acceso
    {

        // Clase de acceso a datos.

        #region "Variables (Clases) de Conexion"
        private SqlConnection Conexion;
        #endregion

        //Constructor
        public Acceso()
        {
            Conexion = new SqlConnection(CadenaConexion);
        }

        private string CadenaConexion
        {
            get
            {
                //string j = DATOS.Properties.Settings.Default.conectar.ToString();
                return DATOS.Properties.Settings.Default.conectar.ToString();
                //return ConfigurationManager.ConnectionStrings["DATOS.Properties.Settings.conectar"].ToString();
            }

        }

        public SqlConnection ObtenerConexion()
        {
            return Conexion;
        }


    }
}
