using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace INVENTARIO
{
    public partial class FrmRepProductos : Form
    {
        public FrmRepProductos()
        {
            InitializeComponent();
        }
        private static FrmRepProductos frmInstance = null;

        public static FrmRepProductos Instance()
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmRepProductos();

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
            //LocalReport reporte = new LocalReport();
            //reporte.ReportPath = @"C:\Users\Unidad de Quemados\Desktop\proyecto final modulo 3\programa\SISTEMA DE VENTAS\INVENTARIO\RepProveedor.rdlc";
            //DatPersona ds = new DatPersona();
            DatPersonaTableAdapters.ProveedorTableAdapter tabla = new DatPersonaTableAdapters.ProveedorTableAdapter();
            
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DatPersonas";
            //DatPersona ds = new DatPersona();
            rds.Value = tabla.Fill()
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Unidad de Quemados\Desktop\proyecto final modulo 3\programa\SISTEMA DE VENTAS\INVENTARIO\RepProveedor.rdlc";
            reportViewer1.LocalReport.Refresh();
            //DatPersona.PRODUCTOSDataTable productos = new DatPersona.PRODUCTOSDataTable();
            //reportViewer1.DataBindings.Add(productos);
            //this.reportViewer1.LocalReport.ReportPath = "..\\..\\RepProductos.rdlc";
            //this.reportViewer1.RefreshReport();
        }
    }
}
