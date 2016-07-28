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
    public partial class FrmClientes : Form
    {
        int ID;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void FrmClientes_Load(object sender, EventArgs e)
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

            if (!string.IsNullOrWhiteSpace(TxtNombre.Text) && !string.IsNullOrWhiteSpace(TxtDireccion.Text))
            {
                valor = true;
            }
            return valor;
        }
         public void LlenarGrid()
        {
            ClientesBL cli = new ClientesBL();

            DgConsulta.DataSource = cli.LlenarClientes();
        }

         private void BtNuevo_Click(object sender, EventArgs e)
         {
             try
             {
                 Limpiar(TxtNombre,TxtDireccion,TxtPais);
                 TxCodigo.Clear();
                 TxtSalAc.Clear();
                 TxtSalInic.Clear();
                 TxtNombre.Focus();
             }
             catch (Exception)
             {

                 throw;
             }
         }
         public void PaginarClientes()
         {
             int fila = DgConsulta.CurrentRow.Index;
             try
             {
                 ID = Convert.ToInt32(DgConsulta.Rows[fila].Cells["ID_CLIENTE"].Value);
                 TxCodigo.Text = DgConsulta.Rows[fila].Cells["ID_CLIENTE"].Value.ToString();
                 TxtNombre.Text = DgConsulta.Rows[fila].Cells["NOMB_CLIENTE"].Value.ToString();
                 TxtPais.Text = DgConsulta.Rows[fila].Cells["PAIS"].Value.ToString();
                 TxtDireccion.Text = DgConsulta.Rows[fila].Cells["DIRECCION"].Value.ToString();
                 TxtSalInic.Text = DgConsulta.Rows[fila].Cells["SALDO_INIC"].Value.ToString();
                 TxtSalAc.Text = DgConsulta.Rows[fila].Cells["SALDO_ACT"].Value.ToString();
             }

             catch (Exception) { }
         }
         private void BtGuardar_Click(object sender, EventArgs e)
         {
             try
             {
                 if (validar())
                 {
                     ClientesBL cli = new ClientesBL();
                     Clientes entidades = new Clientes();


                     if (TxtPais.Text == string.Empty)
                         TxtPais.Text = null;
                     if (TxtSalInic.Text == string.Empty)
                         TxtSalInic.Text = "0.0";

                     float SaldoIn = float.Parse(TxtSalAc.Text);
                     float SaldoAct = float.Parse(TxtSalAc.Text);

                     entidades.NOMB_CLIENTE = TxtNombre.Text;
                     entidades.DIRECCION = TxtDireccion.Text;
                     entidades.PAIS = TxtPais.Text;
                     entidades.SALDO_INIC = Convert.ToDecimal(TxtSalInic.Text);
                     entidades.SALDO_AC = Convert.ToDecimal(TxtSalAc.Text);

                     cli.RegClientes(entidades);
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

         private void BtModificar_Click(object sender, EventArgs e)
         {
             Clientes entidad = new Clientes();
             ClientesBL actualizar = new ClientesBL();

             if (ID < 1)
             {
                 MessageBox.Show("Debe seleccionar un registro valido antes de actualizar." +
                 " Por favor seleccione un registro en la pestaña de busqueda que desea actualizar "
                   + "y vuelva a intentarlo.", "Error de eliminación",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
             }
             else
             {
                 entidad.ID_CLIENTE = ID;
                 entidad.NOMB_CLIENTE = TxtNombre.Text;
                 entidad.DIRECCION = TxtDireccion.Text;
                 entidad.PAIS = TxtPais.Text;
                 entidad.SALDO_INIC = Convert.ToDecimal(TxtSalInic.Text);
                 entidad.SALDO_AC = Convert.ToDecimal(TxtSalAc.Text);

                 actualizar.ActualizarClientes(entidad);
                 LlenarGrid();
                 MessageBox.Show("Registro Actualizado.", "Actualización", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                 BtNuevo.PerformClick();
             }

         }

         private void DgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             PaginarClientes();
         }

         private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
         {
             try
             {
                 if (e.KeyChar == '\r')
                 {
                     e.Handled = true;

                     ClientesBL busqueda = new ClientesBL();

                     DgConsulta.DataSource = busqueda.BusquedaClientes(TxtBuscar.Text, "Nombre");
                 }
             }
             catch (Exception)
             {

                 throw;
             }
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

                         Clientes entidad = new Clientes();
                         entidad.ID_CLIENTE = ID;
                         ClientesBL eliminar = new ClientesBL();

                         eliminar.EliminarClientes(entidad);
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

         private void tabControl1_Selected(object sender, TabControlEventArgs e)
         {
             LlenarGrid();
         }


    }
}
