namespace INVENTARIO
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tb_Proveedor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Productos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Movimientos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Ayuda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lb_Estatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Trm_mensaje = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_Proveedor,
            this.toolStripSeparator2,
            this.tb_Productos,
            this.toolStripSeparator1,
            this.tb_Movimientos,
            this.toolStripSeparator4,
            this.tb_Ayuda,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(775, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(70, 323);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tb_Proveedor
            // 
            this.tb_Proveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Proveedor.Image = global::INVENTARIO.Properties.Resources.Proveedores;
            this.tb_Proveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Proveedor.Name = "tb_Proveedor";
            this.tb_Proveedor.Size = new System.Drawing.Size(68, 52);
            this.tb_Proveedor.Text = "Proveedor";
            this.tb_Proveedor.Click += new System.EventHandler(this.tb_Proveedor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(68, 6);
            // 
            // tb_Productos
            // 
            this.tb_Productos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Productos.Image = global::INVENTARIO.Properties.Resources.productos;
            this.tb_Productos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Productos.Name = "tb_Productos";
            this.tb_Productos.Size = new System.Drawing.Size(68, 52);
            this.tb_Productos.Text = "Productos";
            this.tb_Productos.Click += new System.EventHandler(this.tb_Productos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(68, 6);
            // 
            // tb_Movimientos
            // 
            this.tb_Movimientos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Movimientos.Image = global::INVENTARIO.Properties.Resources.orden_de_compra;
            this.tb_Movimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Movimientos.Name = "tb_Movimientos";
            this.tb_Movimientos.Size = new System.Drawing.Size(68, 52);
            this.tb_Movimientos.Text = "Movimientos";
            this.tb_Movimientos.Click += new System.EventHandler(this.tb_Movimientos_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(68, 6);
            // 
            // tb_Ayuda
            // 
            this.tb_Ayuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Ayuda.Image = global::INVENTARIO.Properties.Resources.ayuda;
            this.tb_Ayuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Ayuda.Name = "tb_Ayuda";
            this.tb_Ayuda.Size = new System.Drawing.Size(68, 52);
            this.tb_Ayuda.Text = "toolStripButton1";
            this.tb_Ayuda.ToolTipText = "Ayuda";
            this.tb_Ayuda.Click += new System.EventHandler(this.tb_Ayuda_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(68, 6);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.HotTrack;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_Estatus});
            this.status.Location = new System.Drawing.Point(0, 325);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(775, 22);
            this.status.TabIndex = 2;
            this.status.Text = "statusStrip1";
            // 
            // lb_Estatus
            // 
            this.lb_Estatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Estatus.Name = "lb_Estatus";
            this.lb_Estatus.Size = new System.Drawing.Size(0, 17);
            //this.lb_Estatus.TextChanged += new System.EventHandler(this.lb_Estatus_TextChanged);
            // 
            // Trm_mensaje
            // 
            this.Trm_mensaje.Tick += new System.EventHandler(this.Trm_mensaje_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::INVENTARIO.Properties.Resources.ppt3179_pptm__Autoguardado_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 347);
            this.Controls.Add(this.status);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "Form 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripButton tb_Ayuda;
        private System.Windows.Forms.ToolStripButton tb_Proveedor;
        private System.Windows.Forms.ToolStripButton tb_Productos;
        private System.Windows.Forms.ToolStripButton tb_Movimientos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Timer Trm_mensaje;
        public System.Windows.Forms.ToolStripStatusLabel lb_Estatus;
    }
}