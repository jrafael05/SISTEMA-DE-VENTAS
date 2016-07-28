using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATOS;
using ENTIDADES;

namespace LOGICA
{
    public class MovimientoBL
    {
        public DataTable LlenarMovimiento()
        {
            MovimientoDAL pro = new MovimientoDAL();

            return pro.ObtenerMovimiento();
        }


        public DataTable ObtenerID()
        {
            MovimientoDAL pro = new MovimientoDAL();

            return pro.ObtenerNumero();
        }
        public DataTable ObtenerTipo(string tipo)
        {
            MovimientoDAL pro = new MovimientoDAL();

            return pro.ObtenerTipo(tipo);
        }
        public DataTable ObtenerDetalle(string tabla,int ID)
        {
            MovimientoDAL pro = new MovimientoDAL();

            return pro.ObtenerDetalle(tabla,ID);
        }


        public void RegMovimiento(Movimientos entidad, Detalle_Movimiento dt)
        {
            MovimientoDAL RegistroMovimiento = new MovimientoDAL();

            RegistroMovimiento.InsertarMovimiento(entidad, dt);

        }
        public void ActualizarMovimiento(Movimientos entidad)
        {
            MovimientoDAL ActualizacionMovimiento = new MovimientoDAL();

            ActualizacionMovimiento.ActualizarMovimiento(entidad);

        }
        public void ActualizarEstado(float Cantidad, int ID)
        {
            MovimientoDAL ActualizacionEstado = new MovimientoDAL();

            ActualizacionEstado.ActualizarEstado(Cantidad, ID);
              
        }

        public void ActualizarCambio(string estado, int id_mov)
        {
            MovimientoDAL ActualizacionEstado = new MovimientoDAL();

            ActualizacionEstado.ActualizarCambio(estado, id_mov);

        }
        public void EliminarMovimiento(Movimientos entidad)
        {
            MovimientoDAL EliminacionMovimiento = new MovimientoDAL();

            EliminacionMovimiento.EliminarMovimeinto(entidad);
        }


    }
}
