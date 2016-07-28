using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATOS;
using ENTIDADES;

namespace LOGICA
{
    public class Detalle_MovimientoBL
    {
        public DataTable LlenarDetalleMovimiento()
        {
            Detalle_MovimientoDAL pro = new Detalle_MovimientoDAL();

            return pro.ObtenerDetalleMovimiento();
        }

        public void RegDetalleMovimiento(Detalle_Movimiento entidad)
        {
            Detalle_MovimientoDAL RegistroDetalleMovimiento = new Detalle_MovimientoDAL();

            RegistroDetalleMovimiento.InsertarDetalleMovimiento(entidad);

        }
        public void ActualizarDt_Movimiento(Detalle_Movimiento entidad)
        {
            Detalle_MovimientoDAL ActualizacionDt_Movimiento = new Detalle_MovimientoDAL();

            ActualizacionDt_Movimiento.ActualizarDt_Movimiento(entidad);

        }
        public void EliminarDt_Movimiento(Detalle_Movimiento entidad)
        {
            Detalle_MovimientoDAL EliminacionDt_Movimiento = new Detalle_MovimientoDAL();

            EliminacionDt_Movimiento.EliminarDetalle_Movimiento(entidad);
        }

    }
}
