using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LOGICA;
using ENTIDADES;

namespace INVENTARIO
{
    public partial class FrmMovimiento : Form
    {
        int ID;
        string _estado;
        int Proximo;

        private static bool modificar = false;
        public string _usuario;
        public FrmMovimiento()
        {
            InitializeComponent();
            LlenarCombo();
           
        }


        public FrmMovimiento(string sesion)
        {
            InitializeComponent();
            _usuario = sesion;
            LlenarCombo();
        }

        private static FrmMovimiento frmInstance = null;

        public static FrmMovimiento Instance()
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmMovimiento();
                
            }
            else
            {
                frmInstance.BringToFront();
                return frmInstance;
            }

            return frmInstance;
        }

        public void LlenarGrid()
        {
            Detalle_MovimientoBL pro = new Detalle_MovimientoBL();

            DgConsulta.DataSource = pro.LlenarDetalleMovimiento();
        }


       public void Deshabilitar()
        {
            foreach (Control c in Gb_Actividad.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false;
                }

                if (c is ComboBox)
                {
                    c.Enabled = false;
                }

                if (c is ComboBox && c.Name=="Cb_Tipo")
                {
                    c.Enabled = true;
                }
               
            }
        }
       public void Habilitar()
       {
           foreach (Control c in Gb_Actividad.Controls)
           {
               if (c is TextBox)
               {
                   c.Enabled = true;
               }

               if (c is ComboBox)
               {
                   c.Enabled = true;
               }

           }
       }

        private void FrmCotizacion_Load(object sender, EventArgs e)
        {
            
            //MovimientoBL m = new MovimientoBL();
            //DataRow row = m.ObtenerID().Rows[0];

            //dg_pedidos.DataSource = m.ObtenerID();
            //MessageBox.Show(row["ID1"].ToString());
            try
            {
                LlenarGrid();

            }
            catch (Exception)
            {

                throw;
            }

        }
        
        

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool validar()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(Txt_Responsable.Text)
                && !string.IsNullOrWhiteSpace(Txt_Memo.Text)
                && !string.IsNullOrWhiteSpace(Cb_Tipo.Text)
                && !string.IsNullOrWhiteSpace(CmbProveedor.Text))
            {
                valor = true;
            }
            return valor;

        }

        public bool validarDetalle()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(txt_Codigo.Text)
                && !string.IsNullOrWhiteSpace(Txt_Productos.Text)
                && !string.IsNullOrWhiteSpace(txt_cantidad.Text)
                && !string.IsNullOrWhiteSpace(Txt_Precio.Text))
            {
                valor = true;
            }
            return valor;

        }

        
        void ObtenerEstado()
        {


            if (Rb_Aprobado.Checked)
            {
                _estado = Rb_Aprobado.Text;
                return;
            }

            else
            {
                if (Rb_Pendiente.Checked)
                {
                    _estado = Rb_Pendiente.Text;
                    return;
                }
                _estado = Rb_Cancelado.Text;
            }
        }

        void ObtenerNumero()
        {
            MovimientoBL mov = new MovimientoBL();
            int id;
            id = Convert.ToInt16(mov.ObtenerID().Rows[0]["ID2"].ToString());
            if (id == 0)
            {
                id++;
            }
            else
            {
                id = id + 1;
            }

            Proximo = id;
        }

        public void LlenarCombo()
        {
            ProveedorBL pro = new ProveedorBL();

            CmbProveedor.DataSource = pro.LlenarProveedor();
            CmbProveedor.DisplayMember = "nombre";
            CmbProveedor.ValueMember = "id_proveedor";
            CmbProveedor.SelectedIndex = -1;

        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                ObtenerEstado();
                if (Cb_Tipo.SelectedIndex == 2)
                {



                    if (validar())
                    {
                        MovimientoBL pro = new MovimientoBL();
                        Movimientos entidades = new Movimientos();

                        entidades.estado = _estado;
                        entidades.numero_documento = Convert.ToInt16(txt_NoDocumento.Text);
                        entidades.fecha = Fecha1.Value;
                        entidades.id_Proveedor = Convert.ToInt16(CmbProveedor.SelectedValue.ToString());
                        entidades.memo = Txt_Memo.Text;
                        entidades.responsable = Txt_Responsable.Text;
                        entidades.tipo = Cb_Tipo.Text;
                        entidades.total = float.Parse(Txt_Total.Text);


                        ///////////Validar el detalle del movimiento///////////////

                        if (validar())
                        {
                            Detalle_MovimientoBL pr = new Detalle_MovimientoBL();
                            Detalle_Movimiento entidadess = new Detalle_Movimiento();


                            ObtenerNumero();
                            entidadess.id_movimiento = Proximo;
                            int _IdMov = Proximo;

                            if (dg_Detalle.Rows.Count > 0)
                            {
                                for (int i = 0; i < dg_Detalle.Rows.Count; i++) //Verificar que sea la primera linea del detalle
                                {

                                    entidadess.id_Producto = Convert.ToInt16(dg_Detalle.Rows[i].Cells["id_Producto"].Value);
                                    entidadess.precio = float.Parse(dg_Detalle.Rows[i].Cells["precio"].Value.ToString());
                                    entidadess.cantidad = float.Parse(dg_Detalle.Rows[i].Cells["cantidad"].Value.ToString());

                                    if (i >= 1) //Verificar que sea la segunda linea de detalle
                                    {
                                        entidadess.id_movimiento = _IdMov;
                                        pr.RegDetalleMovimiento(entidadess);
                                        pro.ActualizarEstado(entidadess.cantidad, entidadess.id_Producto);
                                    }
                                    else
                                    {
                                        pro.RegMovimiento(entidades, entidadess);
                                        pro.ActualizarEstado(entidadess.cantidad, entidadess.id_Producto);
                                    }

                                }
                            }


                            MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            BtNuevo.PerformClick();
                        }
                        else //Validar Detalle
                        {
                            MessageBox.Show("Hay campos que son obligatorios que se encuentran vacios.", "Error de validación", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }


                }
                else 
                {
                    ObtenerEstado();
                    if (validar())
                    {
                        MovimientoBL pro = new MovimientoBL();
                        Movimientos entidades = new Movimientos();

                        entidades.estado = _estado;
                        entidades.numero_documento = Convert.ToInt16(txt_NoDocumento.Text);
                        entidades.fecha = Fecha1.Value;
                        entidades.id_Proveedor = Convert.ToInt16(CmbProveedor.SelectedValue.ToString());
                        entidades.memo = Txt_Memo.Text;
                        entidades.responsable = Txt_Responsable.Text;
                        entidades.tipo = Cb_Tipo.Text;
                        entidades.total = float.Parse(Txt_Total.Text);


                        ///////////Validar el detalle del movimiento///////////////

                        if (validar())
                        {
                            Detalle_MovimientoBL pr = new Detalle_MovimientoBL();
                            Detalle_Movimiento entidadess = new Detalle_Movimiento();


                            ObtenerNumero();
                            entidadess.id_movimiento = Proximo;
                            int _IdMov = Proximo;

                            if (dg_Detalle.Rows.Count > 0)
                            {
                                for (int i = 0; i < dg_Detalle.Rows.Count; i++) //Verificar que sea la primera linea del detalle
                                {

                                    entidadess.id_Producto = Convert.ToInt16(dg_Detalle.Rows[i].Cells["id_Producto"].Value);
                                    entidadess.precio = float.Parse(dg_Detalle.Rows[i].Cells["precio"].Value.ToString());
                                    entidadess.cantidad = float.Parse(dg_Detalle.Rows[i].Cells["cantidad"].Value.ToString());

                                    if (i >= 1) //Verificar que sea la segunda linea de detalle
                                    {
                                        entidadess.id_movimiento = _IdMov;
                                        pr.RegDetalleMovimiento(entidadess);
                                    }
                                    else
                                    {
                                        pro.RegMovimiento(entidades, entidadess);
                                    }

                                }
                            }


                            MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            BtNuevo.PerformClick();
                        }
                    }
                }
            }
                

            catch (Exception)
            {
                
                throw;
            }

            }

        //Quite dos llaves }}

        private void Llenar()
        {
            if (dg_Detalle.ColumnCount <= 0)
            {
                dg_Detalle.Columns.Add("id_Producto", "Id_Producto");
                dg_Detalle.Columns.Add("cantidad", "Cantidad");
                dg_Detalle.Columns.Add("precio", "Precio");
                dg_Detalle.Columns.Add("SubTotal", "SubTotal");
            }
            else
                return;
            

        }

        private void Bt_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Codigo.Text) || string.IsNullOrEmpty(txt_cantidad.Text) || string.IsNullOrEmpty(Txt_Precio.Text))
                {
                    MessageBox.Show("DEBES LLENAR TODOS LOS CAMPOS ");
                    return;
                }
                else
                {
                    if (!modificar)
                    {
                        BtGuardar.Enabled = true;
                         if (dg_Detalle.Rows.Count < 1)
                            {
                                Llenar();
                                dg_Detalle.Rows.Add(txt_Codigo.Text, txt_cantidad.Text, Txt_Precio.Text, Convert.ToDouble(Txt_Precio.Text) * Convert.ToDouble(txt_cantidad.Text));
                                double sumar = 0;
                                foreach (DataGridViewRow row in dg_Detalle.Rows)
                                {
                                    sumar += Convert.ToDouble(row.Cells["SubTotal"].Value);
                                }
                                Txt_Total.Text = sumar.ToString();
                                return;
                            }
                         else
                         {
                             dg_Detalle.Rows.Add(txt_Codigo.Text, txt_cantidad.Text, Txt_Precio.Text, Convert.ToDouble(Txt_Precio.Text) * Convert.ToDouble(txt_cantidad.Text));
                             double sumar = 0;
                             foreach (DataGridViewRow row in dg_Detalle.Rows)
                             {
                                 sumar += Convert.ToDouble(row.Cells["SubTotal"].Value);
                             }
                             Txt_Total.Text = sumar.ToString();
                         }
                       
                    }
                    else
                    {
                        BtGuardar.Enabled = false;
                        DataTable dt = (DataTable)dg_Detalle.DataSource;
                        DataRow row = dt.NewRow();
                        row["ID"] = txt_NoDocumento.Text;
                        row["id_detalle"] = 0;
                        row["ID_PRODUCTO"] = txt_Codigo.Text;
                        row["DESC_PRODUCTO"] = Txt_Productos.Text;
                        row["cantidad"] = txt_cantidad.Text;
                        row["precio"] = Txt_Precio.Text;
                        row["tipo"] = Cb_Tipo.Text;
                        dt.Rows.Add(row);
                        dg_Detalle.DataSource = dt;

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del Sistema... \r" + ex.Message.ToString(), "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }

        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(txt_Codigo, Txt_Memo);
            txt_cantidad.Clear();
            Txt_Precio.Clear();
            Txt_Total.Clear();
            txt_NoDocumento.Clear();
            Txt_Productos.Clear();
            Txt_Responsable.Clear();
            CmbProveedor.SelectedIndex = -1;
            Cb_Tipo.SelectedIndex = -1;
            Gb_Estado.Visible = false;
            DgConsulta.Columns.Clear();
            dg_Detalle.Columns.Clear();
            txt_NoDocumento.Focus();
            BtGuardar.Enabled = true;
            Habilitar();
            dg_Detalle.DataSource = null;
            tabControl1.SelectTab(0);
            
        }
        public void PaginarDetalle()
        {
            int fila = dg_Detalle.CurrentRow.Index;

            try
            {
                if (Cb_Tipo.SelectedIndex==1)
                {
                    return;
                }
                else
                {
                    ID = Convert.ToInt32(dg_Detalle.Rows[fila].Cells["id_Producto"].Value);
                    txt_Codigo.Text = dg_Detalle.Rows[fila].Cells["id_Producto"].Value.ToString();
                    Txt_Productos.Text = dg_Detalle.Rows[fila].Cells["DESC_PRODUCTO"].Value.ToString();
                    txt_cantidad.Text = dg_Detalle.Rows[fila].Cells["cantidad"].Value.ToString();
                    Txt_Precio.Text = dg_Detalle.Rows[fila].Cells["precio"].Value.ToString();
                    

                }

               

            }

            catch (Exception) { }
        }

        public void PaginarProductos()
        {
            int fila = DgConsulta.CurrentRow.Index;

            try
            {
                //ID = Convert.ToInt32(DgConsulta.Rows[fila].Cells["id_Producto"].Value);
                txt_Codigo.Text = DgConsulta.Rows[fila].Cells["id_Producto"].Value.ToString();
                Txt_Productos.Text = DgConsulta.Rows[fila].Cells["DESC_PRODUCTO"].Value.ToString();
                Txt_Precio.Text = DgConsulta.Rows[fila].Cells["precio"].Value.ToString();
                tabControl1.SelectTab(0);
                txt_cantidad.Focus();
                txt_cantidad.SelectAll();
            }

            catch (Exception) { }
        }


        private void Bt_Quitar_Click(object sender, EventArgs e)
        {
            try
            {


                if (modificar)
                {
                    Detalle_MovimientoBL db = new Detalle_MovimientoBL();
                    Detalle_Movimiento dt = new Detalle_Movimiento();

                      if (dg_Detalle.Rows.Count > 0) //Eliminamos el detalle de la base de datos
                        {
                            dt.id_detalle = Convert.ToInt16(dg_Detalle.CurrentRow.Cells["id_detalle"].Value.ToString());
                            DialogResult resultado = MessageBox.Show("Realmente desea eliminar esta linea de detalle? ",
                                        "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (resultado == DialogResult.Yes)
                            {
                                db.EliminarDt_Movimiento(dt);
                                dg_Detalle.Rows.RemoveAt(dg_Detalle.CurrentRow.Index);
                                MessageBox.Show("Registro Eliminado.", "Eliminación", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                                BtGuardar.Enabled = false;
                                return;
                            }
                            else 
                            {
                                return;
                            }
                        }
                        else
                        {
                            dg_Detalle.Columns.Clear();
                            MessageBox.Show("Ningún dato para borrar", "Error");
                            return;
                        }
                }
                else
                {
                    if (dg_Detalle.Rows.Count > 0) //Eliminamos el detalle de forma local
                    {
                        dg_Detalle.Rows.RemoveAt(dg_Detalle.CurrentRow.Index);
                        return;
                    }
                    else
                    {
                        dg_Detalle.Columns.Clear();
                        MessageBox.Show("Ningún dato para borrar", "Error");
                        return;
                    }
                }

              


            }
            catch (Exception)
            {
                
                throw;
            }

        }


        public void PaginarTipo()
        {
            int fila = DgConsulta.CurrentRow.Index;

            ID = Convert.ToInt32(DgConsulta.Rows[fila].Cells["No. Doc"].Value.ToString());
            modificar = true;

            MovimientoBL pr = new MovimientoBL();
            try
            {
                if (Cb_Tipo.SelectedIndex == 0) 
                {
                    txt_NoDocumento.Text = DgConsulta.Rows[fila].Cells["No. Doc"].Value.ToString();
                    CmbProveedor.SelectedValue = DgConsulta.Rows[fila].Cells["id_proveedor"].Value;
                    Txt_Responsable.Text = DgConsulta.Rows[fila].Cells["responsable"].Value.ToString();
                    Txt_Memo.Text = DgConsulta.Rows[fila].Cells["memo"].Value.ToString();
                    Txt_Total.Text = DgConsulta.Rows[fila].Cells["total"].Value.ToString();
                    
                    ///////filtrar dgdetalle////////
                    dg_Detalle.DataSource = pr.ObtenerDetalle("Vdetalle", Convert.ToInt16(txt_NoDocumento.Text));
                    tabControl1.SelectTab(0);
                    return;

                } if ( (Cb_Tipo.SelectedIndex == 1))
                {
                    txt_NoDocumento.Text = DgConsulta.Rows[fila].Cells["No. Doc"].Value.ToString();
                    CmbProveedor.SelectedValue = DgConsulta.Rows[fila].Cells["id_proveedor"].Value;
                    Txt_Responsable.Text = DgConsulta.Rows[fila].Cells["responsable"].Value.ToString();
                    Txt_Memo.Text = DgConsulta.Rows[fila].Cells["memo"].Value.ToString();
                    Txt_Total.Text = DgConsulta.Rows[fila].Cells["total"].Value.ToString();
                    dg_Detalle.DataSource = pr.ObtenerDetalle("Vdetalle", Convert.ToInt16(txt_NoDocumento.Text));
                    tabControl1.SelectTab(0);
                    return;

                }
                else
                {
                    //Cb_Tipo.SelectedIndex = 2;

                    txt_NoDocumento.Text = DgConsulta.Rows[fila].Cells["No. Doc"].Value.ToString();
                    CmbProveedor.SelectedValue = DgConsulta.Rows[fila].Cells["id_proveedor"].Value;
                    Txt_Responsable.Text = DgConsulta.Rows[fila].Cells["responsable"].Value.ToString();
                    Txt_Memo.Text = DgConsulta.Rows[fila].Cells["memo"].Value.ToString();
                    Txt_Total.Text = DgConsulta.Rows[fila].Cells["total"].Value.ToString();
                    if (Rb_Aprobado.Text==DgConsulta.Rows[fila].Cells["estado"].Value.ToString())
                    {
                        Rb_Aprobado.Checked = true;
                        dg_Detalle.DataSource = pr.ObtenerDetalle("Vdetalle", Convert.ToInt16(txt_NoDocumento.Text));
                        tabControl1.SelectTab(0);
                        return;
                    }

                    if (Rb_Cancelado.Text == DgConsulta.Rows[fila].Cells["estado"].Value.ToString())
                    {
                        Rb_Cancelado.Checked = true;
                        dg_Detalle.DataSource = pr.ObtenerDetalle("Vdetalle", Convert.ToInt16(txt_NoDocumento.Text));
                        tabControl1.SelectTab(0);
                        return;
                    }
                    else
                    {
                        Rb_Pendiente.Checked = true;
                        dg_Detalle.DataSource = pr.ObtenerDetalle("Vdetalle", Convert.ToInt16(txt_NoDocumento.Text));
                        tabControl1.SelectTab(0);
                    }

                 


                }

            }

            catch (Exception) { }
        }

        private void DgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgConsulta.Tag.ToString()=="Producto")
            {
                PaginarProductos();
            }
            else
            PaginarTipo();

        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            Movimientos entidad = new Movimientos();
            MovimientoBL actualizar = new MovimientoBL();
            Detalle_Movimiento dt = new Detalle_Movimiento();
            Detalle_MovimientoBL db = new Detalle_MovimientoBL();

            ID = Convert.ToInt16(txt_NoDocumento.Text);
            if (ID < 1)
            {
                MessageBox.Show("Debe seleccionar un registro valido antes de actualizar." +
                " Por favor seleccione un registro en la pestaña de busqueda que desea actualizar "
                  + "y vuelva a intentarlo.", "Error de eliminación",
                  MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                ObtenerEstado();
                entidad.id = ID;
                entidad.numero_documento = Convert.ToInt16(txt_NoDocumento.Text);
                entidad.fecha = Fecha1.Value;
                entidad.id_Proveedor = Convert.ToInt16(CmbProveedor.SelectedValue.ToString());
                entidad.memo = Txt_Memo.Text;
                entidad.responsable = Txt_Responsable.Text;
                entidad.tipo = Cb_Tipo.Text;
                entidad.estado = _estado;
                entidad.total = float.Parse(Txt_Total.Text);


                actualizar.ActualizarMovimiento(entidad);
                DgConsulta.Update();
                int id_dt;

               //id_dt= Convert.ToInt16(dg_Detalle.Rows[0].Cells["id_detalle"].Value.ToString());
               if (dg_Detalle.Rows.Count > 0)
               {
                   for (int i = 0; i < dg_Detalle.Rows.Count; i++) //Verificar que sea la primera linea del detalle
                   {
                       dt.id_detalle = Convert.ToInt16(dg_Detalle.Rows[i].Cells["id_detalle"].Value);
                       dt.id_Producto = Convert.ToInt16(dg_Detalle.Rows[i].Cells["id_Producto"].Value);
                       dt.cantidad = float.Parse(dg_Detalle.Rows[i].Cells["cantidad"].Value.ToString());
                       dt.precio = float.Parse(dg_Detalle.Rows[i].Cells["precio"].Value.ToString());
                       dt.id_movimiento = ID;
                       db.ActualizarDt_Movimiento(dt);
                   }
               }


                LlenarGrid();
                MessageBox.Show("Registro Actualizado.", "Actualización", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                modificar = false;
                BtNuevo.PerformClick();
            }
        }

        private void dg_Detalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           PaginarDetalle();
        }

        private void Cb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MovimientoBL pr = new MovimientoBL();
            Txt_Responsable.Text = this.Tag.ToString();
            if (Cb_Tipo.SelectedIndex == 0)
            {
                Gb_Estado.Visible = true;
                Rb_Pendiente.Checked = true;
                Gb_Estado.Enabled = false;
                Gb_detalle.Enabled = true;
                DgConsulta.DataSource = pr.ObtenerTipo("Vtodascotizacion");
                DgConsulta.Tag = "Cotizacion";
                Lbl_Accion.Text = "U";
                return;

            }

            if (Cb_Tipo.SelectedIndex == 1)
            {
                Gb_Estado.Visible = true;
                tabControl1.SelectTab(1);
                DgConsulta.DataSource = pr.ObtenerTipo("VCotizacion");
                //Gb_Actividad.Enabled = true;
                Gb_detalle.Enabled = false;
                Gb_Estado.Enabled = true;
                Deshabilitar();
                return;

            }
            if (Cb_Tipo.SelectedIndex == 2)
            {
                Gb_Estado.Visible = false;
                Gb_Estado.Enabled = true;
                tabControl1.SelectTab(1);
                DgConsulta.DataSource = pr.ObtenerTipo("VOrden");

                return;

            }

        }

        private void BtBuscarp_Click(object sender, EventArgs e)
        {
            ProductosBL p = new ProductosBL();

            DgConsulta.DataSource = p.LlenarProductos();
            DgConsulta.Tag = "Producto";
            tabControl1.SelectTab(1);
        }

        private void BnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID < 1)
                {
                    MessageBox.Show("Debe seleccionar un registro valido antes de eliminar." +
                    " Por favor seleccione un registro en la pestaña de busqueda que desea eliminar "
                      + "y vuelva a intentarlo.", "Error de eliminación",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Realmente desea eliminar el registro de nombre: " + txt_NoDocumento.Text + "?",
                                      "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (resultado == DialogResult.Yes)
                    {

                        Movimientos entidad = new Movimientos();
                        entidad.id = ID;
                        MovimientoBL eliminar = new MovimientoBL();

                        eliminar.EliminarMovimiento(entidad);
                        LlenarGrid();
                        MessageBox.Show("Registro Eliminado.", "Eliminación", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                        BtNuevo.PerformClick();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


    
    }   

 }


    

    


