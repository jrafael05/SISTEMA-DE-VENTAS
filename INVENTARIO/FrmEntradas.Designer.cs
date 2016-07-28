namespace INVENTARIO
{
    partial class FrmEntradas
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.MaskedTextBox();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bmt_Buscar = new System.Windows.Forms.Button();
            this.dg_pedidos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Nopedido = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.TabPage();
            this.DgConsulta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Realiza_Pedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pedidos)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1020, 39);
            this.toolStrip1.TabIndex = 4;
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
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Realiza_Pedidos);
            this.tabControl1.Controls.Add(this.Buscar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 408);
            this.tabControl1.TabIndex = 7;
            // 
            // Realiza_Pedidos
            // 
            this.Realiza_Pedidos.BackColor = System.Drawing.Color.DodgerBlue;
            this.Realiza_Pedidos.Controls.Add(this.pictureBox1);
            this.Realiza_Pedidos.Controls.Add(this.groupBox2);
            this.Realiza_Pedidos.Controls.Add(this.dg_pedidos);
            this.Realiza_Pedidos.Controls.Add(this.label10);
            this.Realiza_Pedidos.Controls.Add(this.txt_Nopedido);
            this.Realiza_Pedidos.Location = new System.Drawing.Point(4, 25);
            this.Realiza_Pedidos.Name = "Realiza_Pedidos";
            this.Realiza_Pedidos.Padding = new System.Windows.Forms.Padding(3);
            this.Realiza_Pedidos.Size = new System.Drawing.Size(1001, 379);
            this.Realiza_Pedidos.TabIndex = 0;
            this.Realiza_Pedidos.Text = "Realizar Entradas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INVENTARIO.Properties.Resources.corregir1;
            this.pictureBox1.Location = new System.Drawing.Point(831, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.date1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_cantidad);
            this.groupBox2.Controls.Add(this.txt_departamento);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bmt_Buscar);
            this.groupBox2.Location = new System.Drawing.Point(8, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 160);
            this.groupBox2.TabIndex = 118;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de la Actividad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 141;
            this.label7.Text = "Proveedor:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(563, 108);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(194, 21);
            this.textBox2.TabIndex = 140;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 139;
            this.label6.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 138;
            this.label2.Text = "Productos:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(378, 22);
            this.textBox1.TabIndex = 137;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 136;
            this.label1.Text = "Codigo:";
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(498, 11);
            this.date1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(280, 22);
            this.date1.TabIndex = 135;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 111;
            this.label8.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(93, 111);
            this.txt_cantidad.Mask = "99999";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(78, 22);
            this.txt_cantidad.TabIndex = 117;
            // 
            // txt_departamento
            // 
            this.txt_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_departamento.Location = new System.Drawing.Point(281, 115);
            this.txt_departamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.ReadOnly = true;
            this.txt_departamento.Size = new System.Drawing.Size(194, 21);
            this.txt_departamento.TabIndex = 134;
            this.txt_departamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(93, 44);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(262, 22);
            this.txt_nombre.TabIndex = 113;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 132;
            this.label4.Text = "Responsable:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 115;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
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
            // bmt_Buscar
            // 
            this.bmt_Buscar.Location = new System.Drawing.Point(363, 44);
            this.bmt_Buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bmt_Buscar.Name = "bmt_Buscar";
            this.bmt_Buscar.Size = new System.Drawing.Size(50, 21);
            this.bmt_Buscar.TabIndex = 114;
            this.bmt_Buscar.Text = "...";
            this.bmt_Buscar.UseVisualStyleBackColor = true;
            // 
            // dg_pedidos
            // 
            this.dg_pedidos.AllowUserToAddRows = false;
            this.dg_pedidos.AllowUserToDeleteRows = false;
            this.dg_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pedidos.Location = new System.Drawing.Point(9, 170);
            this.dg_pedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dg_pedidos.Name = "dg_pedidos";
            this.dg_pedidos.ReadOnly = true;
            this.dg_pedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dg_pedidos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_pedidos.Size = new System.Drawing.Size(983, 203);
            this.dg_pedidos.TabIndex = 108;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(828, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 15);
            this.label10.TabIndex = 105;
            this.label10.Text = "No. Pedido";
            // 
            // txt_Nopedido
            // 
            this.txt_Nopedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nopedido.Location = new System.Drawing.Point(926, 7);
            this.txt_Nopedido.Name = "txt_Nopedido";
            this.txt_Nopedido.ReadOnly = true;
            this.txt_Nopedido.Size = new System.Drawing.Size(57, 21);
            this.txt_Nopedido.TabIndex = 104;
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Buscar.Controls.Add(this.DgConsulta);
            this.Buscar.Controls.Add(this.groupBox1);
            this.Buscar.Location = new System.Drawing.Point(4, 25);
            this.Buscar.Name = "Buscar";
            this.Buscar.Padding = new System.Windows.Forms.Padding(3);
            this.Buscar.Size = new System.Drawing.Size(1001, 379);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            // 
            // DgConsulta
            // 
            this.DgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsulta.Location = new System.Drawing.Point(5, 79);
            this.DgConsulta.Name = "DgConsulta";
            this.DgConsulta.Size = new System.Drawing.Size(988, 262);
            this.DgConsulta.TabIndex = 5;
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
            // FrmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 446);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmEntradas";
            this.Text = "Entradas al Almacen";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Realiza_Pedidos.ResumeLayout(false);
            this.Realiza_Pedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pedidos)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bmt_Buscar;
        private System.Windows.Forms.DataGridView dg_pedidos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Nopedido;
        private System.Windows.Forms.TabPage Buscar;
        private System.Windows.Forms.DataGridView DgConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label5;
    }
}