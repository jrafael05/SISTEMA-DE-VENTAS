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
    public partial class FrmMenu : Form
    {

        public FrmMenu(string sesion)
        {
            InitializeComponent();
            lb_Estatus.Text = sesion;
            _user = sesion;
            //Sesion(sesion);
        }

        public FrmMenu()
        {
            InitializeComponent();
        }


        public  string _user;
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            this.Text = "SISTEMA DE CONTROL COMPRAS(O&M)" + Espacio(160);
            Trm_mensaje.Enabled = true;
            
            try
            {
                MenuBL consulta = new MenuBL();
                DataSet DsMenu = new DataSet();
                DataSet DsSubmenu = new DataSet();

                DsMenu = consulta.MostarMenu();
                DsSubmenu = consulta.MostrarSubMenu();

                CreateMenu(DsMenu.Tables["MenuOpciones"], DsSubmenu.Tables["SubMenuOpciones"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
        public static string Espacio(int n)
        {
            string s = " ";
            for (int i = 0; i <= n; i++) s += " ";
            return s;
        }
        
       
  
        private void CreateMenu(DataTable dtMenus, DataTable dtSubMenus)
        {
            foreach (DataRow row in dtMenus.Rows)
            {

                // Creamos el elemento del menu
                ToolStripMenuItem menuItem = new ToolStripMenuItem();

                // Asignamos el texto que se mostrar
                //
                menuItem.Text = Convert.ToString(row["Nombre"]);

                // Instalamos el controlador para el evento Click.

                menuItem.Click += this.MenuItemOnClick;

                // Obtenemos su identificador.

                int idMenu = Convert.ToInt32(row["IdMenu"]);

                // Seleccionamos los registros de la tabla
                // Submenu que tengan el mismo identificador
                // del elemento del menu actual.
                //
                DataRow[] rows = dtSubMenus.Select("IdMenu = " + idMenu);

                foreach (DataRow r in rows)
                {
                    ToolStripMenuItem subItem = new ToolStripMenuItem();
                    subItem.Text = Convert.ToString(r["Nombre"]);

                    // Controlador para el evento Click.
                    //
                    subItem.Click += MenuItemOnClick;

                    // Anadimos el submenu a su correspondiente menu
                    menuItem.DropDownItems.Add(subItem);
                }

                //// Hacer que el formulario sea padre
                //this.IsMdiContainer = true;

                ////Crear el objecto de la clase MenuStrip
                //MenuStrip MnuStrip = new MenuStrip();

                ////Colocar el control en el formulario
                //this.Controls.Add(MnuStrip);


                //Se lo asignamos al control MenuStrip

                this.menuStrip1.Items.Add(menuItem);

                //MnuStrip.Items.Add(menuItem);

                // El formulario determina la propiedad del objeto creado
                this.MainMenuStrip = menuStrip1;
            }

            //DsMenu.Tables("MenuOpciones").Clear();
            //DsSubMenu.Tables("SubMenuOpciones").Clear();
        }
        private void MenuItemOnClick(object sender, EventArgs e)
        {
            // Referenciamos el control que ha desencadenado el evento
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (item.ToString() == "Productos")
            {

                FrmProductos llamar = null;

                llamar = FrmProductos.Instance();
                llamar.MdiParent = this;
                llamar.Show();

           
            }

             if (item.ToString() == "Proveedor")
            {

                FrmProveedor llamar = null;

                llamar = FrmProveedor.Instance();
                llamar.MdiParent = this;
                llamar.Show();

             }
             if (item.ToString() == "Movimientos")
             {

                 FrmMovimiento llamar = null;

                 llamar = FrmMovimiento.Instance();
                 llamar.MdiParent = this;
                 llamar.Show();

             }

             else
             {
                 return;
             }
                 
        }

    
        private void Trm_mensaje_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void tb_Proveedor_Click(object sender, EventArgs e)
        {
        
                FrmProveedor llamar = null;

                llamar = FrmProveedor.Instance();
                llamar.MdiParent = this;
                llamar.Show();


           
        }

        private void tb_Productos_Click(object sender, EventArgs e)
        {
            FrmProductos llamar = null;

            llamar = FrmProductos.Instance();
            llamar.MdiParent = this;
            llamar.Show();
        }

        private void tb_Movimientos_Click(object sender, EventArgs e)
        {
            FrmMovimiento llamar = null;
            
            llamar = FrmMovimiento.Instance();
            llamar.Tag = _user;
            llamar.MdiParent = this;
            llamar.Show();
        }

        private void tb_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\Users\Mabel\Desktop\proyecto final modulo 3\programa\SISTEMA DE VENTAS\INVENTARIO\Ayuda\Manual del Sistema.docx");
            }
            catch (Exception)
            {

                throw;
            }
        }

      
        }
    }
