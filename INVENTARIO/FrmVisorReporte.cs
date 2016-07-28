using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Using para los reportes
using Microsoft.Reporting.WinForms;

namespace INVENTARIO
{
    public partial class FrmVisorReporte : Form
    {
        public FrmVisorReporte()
        {
            InitializeComponent();
        }

        string _reporte;
        ReportDataSource db = new ReportDataSource(); //Aqui declaramos la fuente de datos para usar en los reportes

        public FrmVisorReporte(string reporte)
        {
            InitializeComponent();
            _reporte = reporte;
        }
        private static FrmVisorReporte frmInstance = null;

        public static FrmVisorReporte Instance(string reporte)
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmVisorReporte(reporte);

            }
            else
            {
                frmInstance.BringToFront();
                return frmInstance;
            }

            return frmInstance;
        }

        private void FrmRepProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatPersona.PRODUCTOS' table. You can move, or remove it, as needed.

            try
            {
              if (_reporte == "Productos")
            {
                this.PRODUCTOSTableAdapter.Fill(this.DatPersona.PRODUCTOS);

                db.Name = "DatProductos";
                db.Value = this.PRODUCTOSBindingSource;
                this.RpView.LocalReport.DataSources.Add(db);
                this.RpView.LocalReport.ReportEmbeddedResource = "INVENTARIO.Reportes.RepProductos.rdlc";
                this.RpView.RefreshReport();
                return;
            }

            if (_reporte == "Cotizacion")
            {
                this.ReporteCotizacionTableAdapter.Fill(this.DatPersona.ReporteCotizacion);
                db.Name = "DatCotizacion";
                db.Value = this.ReporteCotizacionBindingSource;
                this.RpView.LocalReport.DataSources.Add(db);
                this.RpView.LocalReport.ReportEmbeddedResource = "INVENTARIO.Reportes.RepCotizacion.rdlc";
                this.RpView.RefreshReport();
                return;
            }

            if (_reporte == "Orden")
            {
                this.ReporteOrdenTableAdapter.Fill(this.DatPersona.ReporteOrden);
                db.Name = "DatOrden";
                db.Value = this.ReporteOrdenBindingSource;
                this.RpView.LocalReport.DataSources.Add(db);
                this.RpView.LocalReport.ReportEmbeddedResource = "INVENTARIO.Reportes.RepOrden.rdlc";
                this.RpView.RefreshReport();
                return;
            }

            if (_reporte == "Entrada")
            {
                this.ReporteEntradaTableAdapter.Fill(this.DatPersona.ReporteEntrada);
                db.Name = "DatOrden";
                db.Value = this.ReporteEntradaBindingSource;
                this.RpView.LocalReport.DataSources.Add(db);
                this.RpView.LocalReport.ReportEmbeddedResource = "INVENTARIO.Reportes.RepEntrada.rdlc";
                this.RpView.RefreshReport();
                return;
            }
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
