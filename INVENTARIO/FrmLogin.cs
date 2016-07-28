using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LOGICA;


namespace INVENTARIO
{
    public partial class FrmLogin : Form
    {
        DatPersona ds = new DatPersona();
        DatPersonaTableAdapters.usuario_tTableAdapter consulta = new DatPersonaTableAdapters.usuario_tTableAdapter();


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                consulta.Fill(ds.usuario_t);
                CbUsuario.DataSource = ds.usuario_t;
                CbUsuario.DisplayMember = "usuario";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            MenuBL ClaseValidaUsuario = new MenuBL();

            try
            {
                bool valida = false;

                valida = ClaseValidaUsuario.ValidarUsuario(CbUsuario.Text, TxtClave.Text);

                if (valida)
                {
                    this.Hide();
                    //DEBEN TENER EN CTA. QUE AQUI IRA
                    //EL NOMBRE DEL FORMULARIO QUE 
                    //USTEDES DEFINIERON COMO MENU, EN 
                    //ESTE CASO SE LLAMA 
                    //FRM_MENUPRINCIPAL, DEBEN PONER EL 
                    //NOMBRE DEL FORMULARIO DE USTEDES, 
                    //SINO TENDRAN ERROR EN ESTA LINEA
                    FrmMenu menu = new FrmMenu(CbUsuario.Text);
                    menu.WindowState = FormWindowState.Maximized;
                    menu.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Clave de acceso errada", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtClave.Text = "";
                    TxtClave.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    TxtClave.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtClave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    e.Handled = true;
                    Aceptar.PerformClick();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "A Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Aceptar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

