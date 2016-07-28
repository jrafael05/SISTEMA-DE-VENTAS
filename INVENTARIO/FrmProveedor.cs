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
    public partial class FrmProveedor : Form
    {
        int ID;
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar(TxtMemo,TxtNombre,TxCodigo);
                TxtDireccion.Clear();
                TxtEmail.Clear();
                TxtContacto.Clear();
                TxtFax.Clear();
                TxtTelefono.Clear();
                tabProveedor.SelectTab(0);
                TxtNombre.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        } 
        
        private static FrmProveedor frmInstance = null;

        public static FrmProveedor Instance()
        {
            if (((frmInstance == null)
                        || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmProveedor();
            }
            else
            {
                frmInstance.BringToFront();
                return frmInstance;
            }

            return frmInstance;
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid();
            }
            catch (Exception)
            {

                throw;
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

            if (!string.IsNullOrWhiteSpace(TxtNombre.Text)
                && !string.IsNullOrWhiteSpace(TxtContacto.Text)
                && !string.IsNullOrWhiteSpace(TxtTelefono.Text)
                && !string.IsNullOrWhiteSpace(TxtFax.Text)
                && !string.IsNullOrWhiteSpace(TxtEmail.Text)
                && !string.IsNullOrWhiteSpace(TxtDireccion.Text)
                && !string.IsNullOrWhiteSpace(TxtMemo.Text)
                )
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
                    ProveedorBL pro = new ProveedorBL();
                    Proveedor entidades = new Proveedor();

                    ////////////////////////////////////////////////
                    if (TxCodigo.Text == string.Empty)
                        TxCodigo.Text = null;

                    entidades.nombre = TxtNombre.Text;
                    entidades.contacto = TxtContacto.Text;
                    entidades.Telefono = TxtTelefono.Text;
                    entidades.Fax = TxtFax.Text;
                    entidades.Email = TxtEmail.Text;
                    entidades.Direccion = TxtDireccion.Text;
                    entidades.Memo = TxtMemo.Text;



                    pro.RegProveedor(entidades);
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
            catch (Exception)
            {

                throw;
            }
        }

        public void LlenarGrid()
        {
            ProveedorBL pro = new ProveedorBL();

            DgConsulta.DataSource = pro.LlenarProveedor();
        }

        public void LlenarCombo()
        {
            ProveedorBL pro = new ProveedorBL();

            DgConsulta.DataSource = pro.LlenarProveedor();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            Proveedor entidad = new Proveedor();
            ProveedorBL actualizar = new ProveedorBL();

            if (ID < 1)
            {
                MessageBox.Show("Debe seleccionar un registro valido antes de actualizar." +
                " Por favor seleccione un registro en la pestaña de busqueda que desea actualizar "
                  + "y vuelva a intentarlo.", "Error de eliminación",
                  MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                entidad.id_proveedor = ID;
                entidad.nombre = TxtNombre.Text;
                entidad.contacto = TxtContacto.Text;
                entidad.Telefono = TxtTelefono.Text;
                entidad.Fax = TxtFax.Text;
                entidad.Email = TxtEmail.Text;
                entidad.Direccion = TxtDireccion.Text;
                entidad.Memo = TxtMemo.Text;



                actualizar.ActualizarProveedor(entidad);
                LlenarGrid();
                MessageBox.Show("Registro Actualizado.", "Actualización", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                BtNuevo.PerformClick();
            }

        }

      
        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;

                    ProveedorBL busqueda = new ProveedorBL();
                    DgConsulta.DataSource = busqueda.BusquedaProveedor(TxtBuscar.Text, "DESC_PRODUCTO");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void PaginarProveedor()
        {
            int fila = DgConsulta.CurrentRow.Index;
            try
            {

                ID = Convert.ToInt32(DgConsulta.Rows[fila].Cells["id_proveedor"].Value);
                TxCodigo.Text = DgConsulta.Rows[fila].Cells["id_proveedor"].Value.ToString();
                TxtNombre.Text = DgConsulta.Rows[fila].Cells["nombre"].Value.ToString();
                TxtContacto.Text = DgConsulta.Rows[fila].Cells["contacto"].Value.ToString();
                TxtTelefono.Text = DgConsulta.Rows[fila].Cells["Telefono"].Value.ToString();
                TxtFax.Text = DgConsulta.Rows[fila].Cells["Fax"].Value.ToString();
                TxtEmail.Text = DgConsulta.Rows[fila].Cells["Email"].Value.ToString();
                TxtDireccion.Text = DgConsulta.Rows[fila].Cells["Direccion"].Value.ToString();
                TxtMemo.Text = DgConsulta.Rows[fila].Cells["Memo"].Value.ToString();

                tabProveedor.SelectTab(0);
            }

            catch (Exception) { }
        }

        private void DgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PaginarProveedor();
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
                    DialogResult resultado = MessageBox.Show("Realmente desea eliminar el registro de nombre: " + TxtNombre.Text + "?",
                                      "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (resultado == DialogResult.Yes)
                    {

                        Proveedor entidad = new Proveedor();
                        entidad.id_proveedor = ID;
                        ProveedorBL eliminar = new ProveedorBL();

                        eliminar.EliminarProveedor(entidad);
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
  

