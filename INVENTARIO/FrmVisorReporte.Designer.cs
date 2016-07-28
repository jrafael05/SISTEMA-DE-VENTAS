namespace INVENTARIO
{
    partial class FrmVisorReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatPersona = new INVENTARIO.DatPersona();
            this.ReporteEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RpView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteCotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteOrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRODUCTOSTableAdapter = new INVENTARIO.DatPersonaTableAdapters.PRODUCTOSTableAdapter();
            this.ReporteOrdenTableAdapter = new INVENTARIO.DatPersonaTableAdapters.ReporteOrdenTableAdapter();
            this.ReporteCotizacionTableAdapter = new INVENTARIO.DatPersonaTableAdapters.ReporteCotizacionTableAdapter();
            this.ReporteEntradaTableAdapter = new INVENTARIO.DatPersonaTableAdapters.ReporteEntradaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCotizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteOrdenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PRODUCTOSBindingSource
            // 
            this.PRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.PRODUCTOSBindingSource.DataSource = this.DatPersona;
            // 
            // DatPersona
            // 
            this.DatPersona.DataSetName = "DatPersona";
            this.DatPersona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteEntradaBindingSource
            // 
            this.ReporteEntradaBindingSource.DataMember = "ReporteEntrada";
            this.ReporteEntradaBindingSource.DataSource = this.DatPersona;
            // 
            // RpView
            // 
            this.RpView.AutoSize = true;
            this.RpView.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatEntrada";
            reportDataSource1.Value = this.ReporteEntradaBindingSource;
            this.RpView.LocalReport.DataSources.Add(reportDataSource1);
            this.RpView.LocalReport.ReportEmbeddedResource = "INVENTARIO.Reportes.RepEntrada.rdlc";
            this.RpView.Location = new System.Drawing.Point(0, 0);
            this.RpView.Name = "RpView";
            this.RpView.Size = new System.Drawing.Size(839, 367);
            this.RpView.TabIndex = 0;
            this.RpView.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // ReporteCotizacionBindingSource
            // 
            this.ReporteCotizacionBindingSource.DataMember = "ReporteCotizacion";
            this.ReporteCotizacionBindingSource.DataSource = this.DatPersona;
            // 
            // ReporteOrdenBindingSource
            // 
            this.ReporteOrdenBindingSource.DataMember = "ReporteOrden";
            this.ReporteOrdenBindingSource.DataSource = this.DatPersona;
            // 
            // PRODUCTOSTableAdapter
            // 
            this.PRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteOrdenTableAdapter
            // 
            this.ReporteOrdenTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCotizacionTableAdapter
            // 
            this.ReporteCotizacionTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEntradaTableAdapter
            // 
            this.ReporteEntradaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVisorReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 367);
            this.Controls.Add(this.RpView);
            this.Name = "FrmVisorReporte";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmRepProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCotizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteOrdenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpView;
        private System.Windows.Forms.BindingSource PRODUCTOSBindingSource;
        private DatPersona DatPersona;
        private DatPersonaTableAdapters.PRODUCTOSTableAdapter PRODUCTOSTableAdapter;
       // private DatPersonaTableAdapters.VtodascotizacionTableAdapter VtodascotizacionTableAdapter;
        private System.Windows.Forms.BindingSource ReporteOrdenBindingSource;
        private DatPersonaTableAdapters.ReporteOrdenTableAdapter ReporteOrdenTableAdapter;
        private System.Windows.Forms.BindingSource ReporteCotizacionBindingSource;
        private DatPersonaTableAdapters.ReporteCotizacionTableAdapter ReporteCotizacionTableAdapter;
        private System.Windows.Forms.BindingSource ReporteEntradaBindingSource;
        private DatPersonaTableAdapters.ReporteEntradaTableAdapter ReporteEntradaTableAdapter;
    }
}