namespace INVENTARIO
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.tabProductos = new System.Windows.Forms.TabControl();
            this.TpPro = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Existencia = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtVenta = new System.Windows.Forms.MaskedTextBox();
            this.TxtCosto = new System.Windows.Forms.MaskedTextBox();
            this.CmbProveedor = new System.Windows.Forms.ComboBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TpBuscar = new System.Windows.Forms.TabPage();
            this.DgConsulta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtSalir = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabProductos.SuspendLayout();
            this.TpPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProductos
            // 
            this.tabProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabProductos.Controls.Add(this.TpPro);
            this.tabProductos.Controls.Add(this.TpBuscar);
            this.tabProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProductos.Location = new System.Drawing.Point(0, 42);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.SelectedIndex = 0;
            this.tabProductos.Size = new System.Drawing.Size(671, 303);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.SelectedIndexChanged += new System.EventHandler(this.tabProductos_SelectedIndexChanged);
            // 
            // TpPro
            // 
            this.TpPro.BackColor = System.Drawing.Color.DodgerBlue;
            this.TpPro.Controls.Add(this.label7);
            this.TpPro.Controls.Add(this.txt_Existencia);
            this.TpPro.Controls.Add(this.pictureBox1);
            this.TpPro.Controls.Add(this.TxCodigo);
            this.TpPro.Controls.Add(this.label6);
            this.TpPro.Controls.Add(this.TxtVenta);
            this.TpPro.Controls.Add(this.TxtCosto);
            this.TpPro.Controls.Add(this.CmbProveedor);
            this.TpPro.Controls.Add(this.TxtProducto);
            this.TpPro.Controls.Add(this.label4);
            this.TpPro.Controls.Add(this.label3);
            this.TpPro.Controls.Add(this.label2);
            this.TpPro.Controls.Add(this.label1);
            this.TpPro.Location = new System.Drawing.Point(4, 25);
            this.TpPro.Name = "TpPro";
            this.TpPro.Padding = new System.Windows.Forms.Padding(3);
            this.TpPro.Size = new System.Drawing.Size(663, 274);
            this.TpPro.TabIndex = 0;
            this.TpPro.Text = "Mantenimientos de Productos";
            this.TpPro.ToolTipText = "Mantenimientos de Productos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(86, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Existencia:";
            // 
            // txt_Existencia
            // 
            this.txt_Existencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Existencia.Location = new System.Drawing.Point(207, 196);
            this.txt_Existencia.Name = "txt_Existencia";
            this.txt_Existencia.ReadOnly = true;
            this.txt_Existencia.Size = new System.Drawing.Size(136, 29);
            this.txt_Existencia.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INVENTARIO.Properties.Resources.productos;
            this.pictureBox1.Location = new System.Drawing.Point(511, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // TxCodigo
            // 
            this.TxCodigo.Location = new System.Drawing.Point(207, 22);
            this.TxCodigo.Name = "TxCodigo";
            this.TxCodigo.ReadOnly = true;
            this.TxCodigo.Size = new System.Drawing.Size(100, 22);
            this.TxCodigo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(118, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Codigo:";
            // 
            // TxtVenta
            // 
            this.TxtVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVenta.Location = new System.Drawing.Point(207, 161);
            this.TxtVenta.Name = "TxtVenta";
            this.TxtVenta.Size = new System.Drawing.Size(136, 29);
            this.TxtVenta.TabIndex = 9;
            // 
            // TxtCosto
            // 
            this.TxtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCosto.Location = new System.Drawing.Point(207, 126);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(136, 29);
            this.TxtCosto.TabIndex = 8;
            // 
            // CmbProveedor
            // 
            this.CmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProveedor.FormattingEnabled = true;
            this.CmbProveedor.Location = new System.Drawing.Point(207, 85);
            this.CmbProveedor.Name = "CmbProveedor";
            this.CmbProveedor.Size = new System.Drawing.Size(276, 32);
            this.CmbProveedor.TabIndex = 7;
            this.CmbProveedor.DropDown += new System.EventHandler(this.CmbProveedor_DropDown);
            // 
            // TxtProducto
            // 
            this.TxtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProducto.Location = new System.Drawing.Point(207, 50);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(381, 29);
            this.TxtProducto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de Venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio de Costo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proveedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // TpBuscar
            // 
            this.TpBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TpBuscar.Controls.Add(this.DgConsulta);
            this.TpBuscar.Controls.Add(this.groupBox1);
            this.TpBuscar.Location = new System.Drawing.Point(4, 25);
            this.TpBuscar.Name = "TpBuscar";
            this.TpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.TpBuscar.Size = new System.Drawing.Size(663, 274);
            this.TpBuscar.TabIndex = 1;
            this.TpBuscar.Text = "Buscar";
            this.TpBuscar.ToolTipText = "Buscar";
            // 
            // DgConsulta
            // 
            this.DgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsulta.Location = new System.Drawing.Point(8, 81);
            this.DgConsulta.Name = "DgConsulta";
            this.DgConsulta.Size = new System.Drawing.Size(649, 187);
            this.DgConsulta.TabIndex = 1;
            this.DgConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsulta_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(143, 21);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(480, 29);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Buscar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtNuevo,
            this.toolStripSeparator4,
            this.BtGuardar,
            this.toolStripSeparator3,
            this.BtModificar,
            this.toolStripSeparator2,
            this.BnEliminar,
            this.toolStripSeparator1,
            this.BtSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(683, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtNuevo
            // 
            this.BtNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtNuevo.Image = global::INVENTARIO.Properties.Resources.edit_clear;
            this.BtNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(36, 36);
            this.BtNuevo.Text = "toolStripButton1";
            this.BtNuevo.ToolTipText = "Nuevo";
            this.BtNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // BtGuardar
            // 
            this.BtGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtGuardar.Image = global::INVENTARIO.Properties.Resources.guardar;
            this.BtGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(36, 36);
            this.BtGuardar.Text = "toolStripButton2";
            this.BtGuardar.ToolTipText = "Guardar";
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // BtModificar
            // 
            this.BtModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtModificar.Image = global::INVENTARIO.Properties.Resources.pedido;
            this.BtModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtModificar.Name = "BtModificar";
            this.BtModificar.Size = new System.Drawing.Size(36, 36);
            this.BtModificar.Text = "toolStripButton3";
            this.BtModificar.ToolTipText = "Modificar";
            this.BtModificar.Click += new System.EventHandler(this.BtModificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // BnEliminar
            // 
            this.BnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BnEliminar.Image = global::INVENTARIO.Properties.Resources.cancelar2;
            this.BnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BnEliminar.Name = "BnEliminar";
            this.BnEliminar.Size = new System.Drawing.Size(36, 36);
            this.BnEliminar.Text = "toolStripButton4";
            this.BnEliminar.ToolTipText = "Eliminar";
            this.BnEliminar.Click += new System.EventHandler(this.BnEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // BtSalir
            // 
            this.BtSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtSalir.Image = global::INVENTARIO.Properties.Resources.salir1;
            this.BtSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(36, 36);
            this.BtSalir.Text = "toolStripButton5";
            this.BtSalir.ToolTipText = "Salir";
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 357);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.tabProductos.ResumeLayout(false);
            this.TpPro.ResumeLayout(false);
            this.TpPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabProductos;
        private System.Windows.Forms.TabPage TpPro;
        private System.Windows.Forms.TabPage TpBuscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtNuevo;
        private System.Windows.Forms.ToolStripButton BtGuardar;
        private System.Windows.Forms.ToolStripButton BtModificar;
        private System.Windows.Forms.ToolStripButton BnEliminar;
        private System.Windows.Forms.ToolStripButton BtSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtVenta;
        private System.Windows.Forms.MaskedTextBox TxtCosto;
        private System.Windows.Forms.ComboBox CmbProveedor;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.DataGridView DgConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_Existencia;
    }
}