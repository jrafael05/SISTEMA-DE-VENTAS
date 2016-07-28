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
    public partial class FrmProductos : Form
    {
        int ID;
        public FrmProductos()
        {
            InitializeComponent();
            LlenarCombo();
        }


        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void BtNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar(TxCodigo,TxtProducto);
                TxtCosto.Clear();
                TxtVenta.Clear();
                CmbProveedor.SelectedIndex = -1;
                txt_Existencia.Clear();
                tabProductos.SelectTab(0);
                TxtProducto.Focus();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static FrmProductos frmInstance = null;

        public static FrmProductos Instance()
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmProductos();
            }
            else
            {
                frmInstance.BringToFront();
                return frmInstance;
            }

            return frmInstance;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }

        }
        public bool validar()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(TxtProducto.Text) && !string.IsNullOrWhiteSpace(TxtCosto.Text) && !string.IsNullOrWhiteSpace(TxtVenta.Text))
            {
                valor = true;
            }
            return valor;

        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    ProductosBL pro = new ProductosBL();
                    Productos entidades = new Productos();


                    if (TxtProducto.Text == string.Empty)
                        TxtProducto.Text = null;
                    if (TxtCosto.Text == string.Empty)
                        TxtCosto.Text = "0.0";

                    //float SaldoIn = float.Parse(TxtVenta.Text);
                    //float SaldoAct = float.Parse(TxtVenta.Text);

                    entidades.DESC_PRODUCTO = TxtProducto.Text;
                    entidades.ID_PROVEEDOR = Convert.ToInt16(CmbProveedor.SelectedValue.ToString());
                    entidades.COSTO = Convert.ToDecimal(TxtCosto.Text);
                    entidades.PRECIO = Convert.ToDecimal(TxtVenta.Text);
                    


                    pro.RegProducto(entidades);
                    LlenarGrid();
                    MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    BtNuevo.PerformClick();
                }
                else
                {
                    MessageBox.Show("Hay campos que son obligatorios que se encuentran vacios.", "Error de validación", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarGrid()
        {
            ProductosBL pro = new ProductosBL();

            DgConsulta.DataSource = pro.LlenarProductos();
        }

        public void LlenarCombo()
        {
            ProveedorBL pro = new ProveedorBL();

            CmbProveedor.DataSource = pro.LlenarProveedor();
            CmbProveedor.DisplayMember= "nombre";
            CmbProveedor.ValueMember = "id_proveedor";
            CmbProveedor.SelectedIndex = -1;
            
        }

        private void CmbProveedor_DropDown(object sender, EventArgs e)
        {
            try
            {
                LlenarCombo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            try
            {
                 Productos entidad = new Productos();
            ProductosBL actualizar = new ProductosBL();

            if (string.IsNullOrWhiteSpace(TxCodigo.Text))
            {
                MessageBox.Show("Debe seleccionar un registro valido antes de actualizar." +
                " Por favor seleccione un registro en la pestaña de busqueda que desea actualizar "
                  + "y vuelva a intentarlo.", "Error de Actualización",
                  MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (ID < 1)
            {
                MessageBox.Show("Debe seleccionar un registro valido antes de actualizar." +
                " Por favor seleccione un registro en la pestaña de busqueda que desea actualizar "
                  + "y vuelva a intentarlo.", "Error de Actualización",
                  MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                entidad.ID_PRODUCTO = ID;
                entidad.DESC_PRODUCTO = TxtProducto.Text;
                entidad.ID_PROVEEDOR = Convert.ToInt16(CmbProveedor.SelectedValue.ToString());
                entidad.COSTO = Convert.ToDecimal(TxtCosto.Text);
                entidad.PRECIO = Convert.ToDecimal(TxtVenta.Text);



                actualizar.ActualizarProductos(entidad);
                LlenarGrid();
                MessageBox.Show("Registro Actualizado.", "Actualización", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                BtNuevo.PerformClick();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;

                    ProductosBL busqueda = new ProductosBL();
                    DgConsulta.DataSource = busqueda.BusquedaProdusctos(TxtBuscar.Text, "DESC_PRODUCTO");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PaginarProductos()
        {
            int fila = DgConsulta.CurrentRow.Index;

            
            
            try
            {

                ID = Convert.ToInt32(DgConsulta.Rows[fila].Cells["ID_PRODUCTO"].Value);
                TxCodigo.Text = DgConsulta.Rows[fila].Cells["ID_PRODUCTO"].Value.ToString();
                TxtProducto.Text = DgConsulta.Rows[fila].Cells["DESC_PRODUCTO"].Value.ToString();
                CmbProveedor.SelectedValue = DgConsulta.Rows[fila].Cells["ID_PROVEEDOR"].Value;
                TxtCosto.Text = DgConsulta.Rows[fila].Cells["COSTO"].Value.ToString();
                TxtVenta.Text = DgConsulta.Rows[fila].Cells["PRECIO"].Value.ToString();
                txt_Existencia.Text = DgConsulta.Rows[fila].Cells["Existencia"].Value.ToString();

                tabProductos.SelectTab(0);

                
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void DgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PaginarProductos();
            
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
                    DialogResult resultado = MessageBox.Show("Realmente desea eliminar el registro de nombre: " + TxtProducto.Text + "?",
                                      "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (resultado == DialogResult.Yes)
                    {

                        Productos entidad = new Productos();
                        entidad.ID_PRODUCTO = ID;
                        ProductosBL eliminar = new ProductosBL();

                        eliminar.EliminarProductos(entidad);
                        LlenarGrid();
                        MessageBox.Show("Registro Eliminado.", "Eliminación", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                        BtNuevo.PerformClick();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
