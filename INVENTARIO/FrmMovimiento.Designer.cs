namespace INVENTARIO
{
    partial class FrmMovimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Realiza_Pedidos = new System.Windows.Forms.TabPage();
            this.Gb_detalle = new System.Windows.Forms.GroupBox();
            this.Lbl_Accion = new System.Windows.Forms.Label();
            this.BtBuscarp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Precio = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_Productos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.MaskedTextBox();
            this.Bt_Quitar = new System.Windows.Forms.Button();
            this.Bt_Agregar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Gb_Actividad = new System.Windows.Forms.GroupBox();
            this.Gb_Estado = new System.Windows.Forms.GroupBox();
            this.Rb_Cancelado = new System.Windows.Forms.RadioButton();
            this.Rb_Pendiente = new System.Windows.Forms.RadioButton();
            this.Rb_Aprobado = new System.Windows.Forms.RadioButton();
            this.CmbProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cb_Tipo = new System.Windows.Forms.ComboBox();
            this.Txt_Memo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_Responsable = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NoDocumento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Fecha1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_Detalle = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.TabPage();
            this.DgConsulta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Realiza_Pedidos.SuspendLayout();
            this.Gb_detalle.SuspendLayout();
            this.Gb_Actividad.SuspendLayout();
            this.Gb_Estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detalle)).BeginInit();
            this.Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1053, 39);
            this.toolStrip1.TabIndex = 3;
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
            this.BtGuardar.ToolTipText = "Guardar Registros";
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
            this.BtModificar.ToolTipText = "Modificar Registros";
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
            this.BnEliminar.ToolTipText = "Eliminar Registros";
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
            this.BtSalir.ToolTipText = "Salir del Formulario";
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Realiza_Pedidos);
            this.tabControl1.Controls.Add(this.Buscar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 427);
            this.tabControl1.TabIndex = 6;
            // 
            // Realiza_Pedidos
            // 
            this.Realiza_Pedidos.BackColor = System.Drawing.Color.DodgerBlue;
            this.Realiza_Pedidos.Controls.Add(this.Gb_detalle);
            this.Realiza_Pedidos.Controls.Add(this.Bt_Quitar);
            this.Realiza_Pedidos.Controls.Add(this.Bt_Agregar);
            this.Realiza_Pedidos.Controls.Add(this.label12);
            this.Realiza_Pedidos.Controls.Add(this.Txt_Total);
            this.Realiza_Pedidos.Controls.Add(this.Gb_Actividad);
            this.Realiza_Pedidos.Controls.Add(this.dg_Detalle);
            this.Realiza_Pedidos.Location = new System.Drawing.Point(4, 25);
            this.Realiza_Pedidos.Name = "Realiza_Pedidos";
            this.Realiza_Pedidos.Padding = new System.Windows.Forms.Padding(3);
            this.Realiza_Pedidos.Size = new System.Drawing.Size(1033, 398);
            this.Realiza_Pedidos.TabIndex = 0;
            this.Realiza_Pedidos.Text = "Realizar Movimiento";
            // 
            // Gb_detalle
            // 
            this.Gb_detalle.Controls.Add(this.Lbl_Accion);
            this.Gb_detalle.Controls.Add(this.BtBuscarp);
            this.Gb_detalle.Controls.Add(this.label9);
            this.Gb_detalle.Controls.Add(this.Txt_Precio);
            this.Gb_detalle.Controls.Add(this.label1);
            this.Gb_detalle.Controls.Add(this.label2);
            this.Gb_detalle.Controls.Add(this.txt_Codigo);
            this.Gb_detalle.Controls.Add(this.Txt_Productos);
            this.Gb_detalle.Controls.Add(this.label11);
            this.Gb_detalle.Controls.Add(this.txt_cantidad);
            this.Gb_detalle.Location = new System.Drawing.Point(611, 6);
            this.Gb_detalle.Name = "Gb_detalle";
            this.Gb_detalle.Size = new System.Drawing.Size(414, 200);
            this.Gb_detalle.TabIndex = 149;
            this.Gb_detalle.TabStop = false;
            this.Gb_detalle.Text = "Detalle de la Actividad";
            // 
            // Lbl_Accion
            // 
            this.Lbl_Accion.AutoSize = true;
            this.Lbl_Accion.Location = new System.Drawing.Point(348, 99);
            this.Lbl_Accion.Name = "Lbl_Accion";
            this.Lbl_Accion.Size = new System.Drawing.Size(0, 16);
            this.Lbl_Accion.TabIndex = 150;
            this.Lbl_Accion.Visible = false;
            // 
            // BtBuscarp
            // 
            this.BtBuscarp.BackgroundImage = global::INVENTARIO.Properties.Resources.buscar;
            this.BtBuscarp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtBuscarp.Location = new System.Drawing.Point(193, 21);
            this.BtBuscarp.Name = "BtBuscarp";
            this.BtBuscarp.Size = new System.Drawing.Size(63, 37);
            this.BtBuscarp.TabIndex = 147;
            this.toolTip1.SetToolTip(this.BtBuscarp, "Buscar productos");
            this.BtBuscarp.UseVisualStyleBackColor = true;
            this.BtBuscarp.Click += new System.EventHandler(this.BtBuscarp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 145;
            this.label9.Text = "Precio:";
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Location = new System.Drawing.Point(90, 162);
            this.Txt_Precio.Mask = "99999";
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Precio.Size = new System.Drawing.Size(87, 22);
            this.Txt_Precio.TabIndex = 3;
            this.Txt_Precio.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 136;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 138;
            this.label2.Text = "Productos:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(90, 24);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.ReadOnly = true;
            this.txt_Codigo.Size = new System.Drawing.Size(82, 22);
            this.txt_Codigo.TabIndex = 0;
            this.txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_Productos
            // 
            this.Txt_Productos.Location = new System.Drawing.Point(90, 74);
            this.Txt_Productos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Productos.Name = "Txt_Productos";
            this.Txt_Productos.ReadOnly = true;
            this.Txt_Productos.Size = new System.Drawing.Size(317, 22);
            this.Txt_Productos.TabIndex = 1;
            this.Txt_Productos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 143;
            this.label11.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(90, 127);
            this.txt_cantidad.Mask = "99999";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(87, 22);
            this.txt_cantidad.TabIndex = 2;
            this.txt_cantidad.ValidatingType = typeof(int);
            // 
            // Bt_Quitar
            // 
            this.Bt_Quitar.BackgroundImage = global::INVENTARIO.Properties.Resources.cancelar1;
            this.Bt_Quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Quitar.Location = new System.Drawing.Point(873, 260);
            this.Bt_Quitar.Name = "Bt_Quitar";
            this.Bt_Quitar.Size = new System.Drawing.Size(61, 48);
            this.Bt_Quitar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Bt_Quitar, "Eliminar Detalle");
            this.Bt_Quitar.UseVisualStyleBackColor = true;
            this.Bt_Quitar.Click += new System.EventHandler(this.Bt_Quitar_Click);
            // 
            // Bt_Agregar
            // 
            this.Bt_Agregar.BackgroundImage = global::INVENTARIO.Properties.Resources.button_plus_green;
            this.Bt_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Agregar.Location = new System.Drawing.Point(873, 212);
            this.Bt_Agregar.Name = "Bt_Agregar";
            this.Bt_Agregar.Size = new System.Drawing.Size(61, 42);
            this.Bt_Agregar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Bt_Agregar, "Agregar Detalle");
            this.Bt_Agregar.UseVisualStyleBackColor = true;
            this.Bt_Agregar.Click += new System.EventHandler(this.Bt_Agregar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(893, 334);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 146;
            this.label12.Text = "Total:";
            // 
            // Txt_Total
            // 
            this.Txt_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Txt_Total.ForeColor = System.Drawing.Color.Red;
            this.Txt_Total.Location = new System.Drawing.Point(862, 357);
            this.Txt_Total.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Total.Multiline = true;
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(130, 35);
            this.Txt_Total.TabIndex = 145;
            this.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gb_Actividad
            // 
            this.Gb_Actividad.Controls.Add(this.Gb_Estado);
            this.Gb_Actividad.Controls.Add(this.CmbProveedor);
            this.Gb_Actividad.Controls.Add(this.label7);
            this.Gb_Actividad.Controls.Add(this.label8);
            this.Gb_Actividad.Controls.Add(this.Cb_Tipo);
            this.Gb_Actividad.Controls.Add(this.Txt_Memo);
            this.Gb_Actividad.Controls.Add(this.label13);
            this.Gb_Actividad.Controls.Add(this.Txt_Responsable);
            this.Gb_Actividad.Controls.Add(this.pictureBox1);
            this.Gb_Actividad.Controls.Add(this.label6);
            this.Gb_Actividad.Controls.Add(this.txt_NoDocumento);
            this.Gb_Actividad.Controls.Add(this.label10);
            this.Gb_Actividad.Controls.Add(this.Fecha1);
            this.Gb_Actividad.Controls.Add(this.label4);
            this.Gb_Actividad.Controls.Add(this.label3);
            this.Gb_Actividad.Location = new System.Drawing.Point(8, 4);
            this.Gb_Actividad.Name = "Gb_Actividad";
            this.Gb_Actividad.Size = new System.Drawing.Size(597, 202);
            this.Gb_Actividad.TabIndex = 118;
            this.Gb_Actividad.TabStop = false;
            this.Gb_Actividad.Text = "Actividad";
            // 
            // Gb_Estado
            // 
            this.Gb_Estado.Controls.Add(this.Rb_Cancelado);
            this.Gb_Estado.Controls.Add(this.Rb_Pendiente);
            this.Gb_Estado.Controls.Add(this.Rb_Aprobado);
            this.Gb_Estado.Location = new System.Drawing.Point(460, 42);
            this.Gb_Estado.Name = "Gb_Estado";
            this.Gb_Estado.Size = new System.Drawing.Size(122, 115);
            this.Gb_Estado.TabIndex = 155;
            this.Gb_Estado.TabStop = false;
            this.Gb_Estado.Text = "Estado";
            this.Gb_Estado.Visible = false;
            // 
            // Rb_Cancelado
            // 
            this.Rb_Cancelado.AutoSize = true;
            this.Rb_Cancelado.Location = new System.Drawing.Point(11, 73);
            this.Rb_Cancelado.Name = "Rb_Cancelado";
            this.Rb_Cancelado.Size = new System.Drawing.Size(101, 20);
            this.Rb_Cancelado.TabIndex = 160;
            this.Rb_Cancelado.TabStop = true;
            this.Rb_Cancelado.Text = "Cancelada";
            this.Rb_Cancelado.UseVisualStyleBackColor = true;
            // 
            // Rb_Pendiente
            // 
            this.Rb_Pendiente.AutoSize = true;
            this.Rb_Pendiente.Location = new System.Drawing.Point(11, 47);
            this.Rb_Pendiente.Name = "Rb_Pendiente";
            this.Rb_Pendiente.Size = new System.Drawing.Size(96, 20);
            this.Rb_Pendiente.TabIndex = 159;
            this.Rb_Pendiente.TabStop = true;
            this.Rb_Pendiente.Text = "Pendiente";
            this.Rb_Pendiente.UseVisualStyleBackColor = true;
            // 
            // Rb_Aprobado
            // 
            this.Rb_Aprobado.AutoSize = true;
            this.Rb_Aprobado.Location = new System.Drawing.Point(11, 21);
            this.Rb_Aprobado.Name = "Rb_Aprobado";
            this.Rb_Aprobado.Size = new System.Drawing.Size(95, 20);
            this.Rb_Aprobado.TabIndex = 158;
            this.Rb_Aprobado.TabStop = true;
            this.Rb_Aprobado.Text = "Aprobado";
            this.Rb_Aprobado.UseVisualStyleBackColor = true;
            // 
            // CmbProveedor
            // 
            this.CmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProveedor.FormattingEnabled = true;
            this.CmbProveedor.Location = new System.Drawing.Point(126, 76);
            this.CmbProveedor.Name = "CmbProveedor";
            this.CmbProveedor.Size = new System.Drawing.Size(247, 32);
            this.CmbProveedor.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 151;
            this.label7.Text = "Proveedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tipo:";
            // 
            // Cb_Tipo
            // 
            this.Cb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Tipo.FormattingEnabled = true;
            this.Cb_Tipo.Items.AddRange(new object[] {
            "COTIZACION",
            "ORDEN",
            "ENTRADA"});
            this.Cb_Tipo.Location = new System.Drawing.Point(460, 12);
            this.Cb_Tipo.Name = "Cb_Tipo";
            this.Cb_Tipo.Size = new System.Drawing.Size(130, 24);
            this.Cb_Tipo.TabIndex = 0;
            this.Cb_Tipo.SelectedIndexChanged += new System.EventHandler(this.Cb_Tipo_SelectedIndexChanged);
            // 
            // Txt_Memo
            // 
            this.Txt_Memo.Location = new System.Drawing.Point(125, 152);
            this.Txt_Memo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Memo.Multiline = true;
            this.Txt_Memo.Name = "Txt_Memo";
            this.Txt_Memo.Size = new System.Drawing.Size(247, 44);
            this.Txt_Memo.TabIndex = 4;
            this.Txt_Memo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(65, 164);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "Memo:";
            // 
            // Txt_Responsable
            // 
            this.Txt_Responsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Responsable.Location = new System.Drawing.Point(125, 123);
            this.Txt_Responsable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Responsable.Name = "Txt_Responsable";
            this.Txt_Responsable.ReadOnly = true;
            this.Txt_Responsable.Size = new System.Drawing.Size(247, 21);
            this.Txt_Responsable.TabIndex = 3;
            this.Txt_Responsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INVENTARIO.Properties.Resources.cotizar;
            this.pictureBox1.Location = new System.Drawing.Point(850, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 139;
            this.label6.Text = "Fecha:";
            // 
            // txt_NoDocumento
            // 
            this.txt_NoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoDocumento.Location = new System.Drawing.Point(125, 30);
            this.txt_NoDocumento.Name = "txt_NoDocumento";
            this.txt_NoDocumento.ReadOnly = true;
            this.txt_NoDocumento.Size = new System.Drawing.Size(90, 21);
            this.txt_NoDocumento.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 15);
            this.label10.TabIndex = 105;
            this.label10.Text = "No. Documento:";
            // 
            // Fecha1
            // 
            this.Fecha1.Enabled = false;
            this.Fecha1.Location = new System.Drawing.Point(380, 174);
            this.Fecha1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Fecha1.Name = "Fecha1";
            this.Fecha1.Size = new System.Drawing.Size(210, 22);
            this.Fecha1.TabIndex = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 132;
            this.label4.Text = "Responsable:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, -18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 131;
            this.label3.Text = "Fecha:";
            // 
            // dg_Detalle
            // 
            this.dg_Detalle.AllowUserToAddRows = false;
            this.dg_Detalle.AllowUserToDeleteRows = false;
            this.dg_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Detalle.Location = new System.Drawing.Point(9, 212);
            this.dg_Detalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dg_Detalle.Name = "dg_Detalle";
            this.dg_Detalle.ReadOnly = true;
            this.dg_Detalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dg_Detalle.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Detalle.Size = new System.Drawing.Size(845, 180);
            this.dg_Detalle.TabIndex = 108;
            this.dg_Detalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Detalle_CellClick);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Buscar.Controls.Add(this.DgConsulta);
            this.Buscar.Controls.Add(this.groupBox1);
            this.Buscar.Location = new System.Drawing.Point(4, 25);
            this.Buscar.Name = "Buscar";
            this.Buscar.Padding = new System.Windows.Forms.Padding(3);
            this.Buscar.Size = new System.Drawing.Size(1033, 398);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            // 
            // DgConsulta
            // 
            this.DgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsulta.Location = new System.Drawing.Point(5, 79);
            this.DgConsulta.Name = "DgConsulta";
            this.DgConsulta.Size = new System.Drawing.Size(1020, 313);
            this.DgConsulta.TabIndex = 5;
            this.DgConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsulta_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(163, 24);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(782, 29);
            this.TxtBuscar.TabIndex = 1;
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
            // FrmMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 472);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.FrmCotizacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Realiza_Pedidos.ResumeLayout(false);
            this.Realiza_Pedidos.PerformLayout();
            this.Gb_detalle.ResumeLayout(false);
            this.Gb_detalle.PerformLayout();
            this.Gb_Actividad.ResumeLayout(false);
            this.Gb_Actividad.PerformLayout();
            this.Gb_Estado.ResumeLayout(false);
            this.Gb_Estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detalle)).EndInit();
            this.Buscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Realiza_Pedidos;
        private System.Windows.Forms.GroupBox Gb_Actividad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Productos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Fecha1;
        private System.Windows.Forms.MaskedTextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_Detalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_NoDocumento;
        private System.Windows.Forms.TabPage Buscar;
        private System.Windows.Forms.DataGridView DgConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.TextBox Txt_Memo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_Responsable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Bt_Quitar;
        private System.Windows.Forms.Button Bt_Agregar;
        private System.Windows.Forms.ComboBox Cb_Tipo;
        private System.Windows.Forms.GroupBox Gb_detalle;
        private System.Windows.Forms.Button BtBuscarp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox Txt_Precio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox Gb_Estado;
        private System.Windows.Forms.RadioButton Rb_Cancelado;
        private System.Windows.Forms.RadioButton Rb_Pendiente;
        private System.Windows.Forms.RadioButton Rb_Aprobado;
        private System.Windows.Forms.Label Lbl_Accion;
    }
}