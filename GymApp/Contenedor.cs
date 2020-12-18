using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp
{
    public partial class Inicio : Form
    {
        public Inicio(string rol, string usuario)
        {
            InitializeComponent();
            rols = rol;
            usu = usuario;
            UserMenu.Text = usu;
        }
        public string rols, usu;
        public void noButtones() {
            if (rols == "recepcionista")
            {
                BEmpleados.Visible = false;
                BRepVentas.Visible = false;
                BRepInv.Visible = false;
            }
            else if (rols == "entrenador")
            {
                BEmpleados.Visible = false;
                BRepVentas.Visible = false;
                BRepInv.Visible = false;
                BVentas.Visible = false;
            }
            else { 
            
            }
         }

        private void Menu_Click(object sender, EventArgs e)
        {
           if (MenuColor.Visible != true)
                MenuColor.Visible = true;
            else
                MenuColor.Visible = false;
        }

        public Point mouseLocation;
        private void WPanelBlack_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void WPanelBlack_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Hide();
            OpenForm(new Home());
        }


        private void foreBlack(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.ForeColor = Color.Black;
        }

        private void foreWhite(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.ForeColor = Color.FromArgb(63, 81, 181);
        }
        private void OpenForm(object formhijo) {
            if (this.FormContent.Controls.Count > 0) {
                this.FormContent.Controls.RemoveAt(0);
            }
            Form fhj = formhijo as Form;
            fhj.TopLevel = false;
            fhj.Dock = DockStyle.Fill;
            this.FormContent.Controls.Add(fhj);
            this.FormContent.Tag = fhj;
            fhj.Show();

        }

        private void BVentas_Click(object sender, EventArgs e)
        {
            OpenForm(new Ventas());
            WTitle.Text = "Ventas";
        }

        private void BArticulos_Click(object sender, EventArgs e)
        {
            OpenForm(new NuevoArticulo());
            WTitle.Text = "Articulos";
        }

        private void BRepVentas_Click(object sender, EventArgs e)
        {
            OpenForm(new RepVentas());
            WTitle.Text = "Reporte de ventas";
        }

        private void BRepInv_Click(object sender, EventArgs e)
        {
            OpenForm(new RepInventario());
            WTitle.Text = "Reporte de Inventario";
        }

        private void MenuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BInicio_Click(object sender, EventArgs e)
        {
            OpenForm(new Home());
            WTitle.Text = "Inicio";
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            OpenForm(new Clientes());
            WTitle.Text = "Clientes";
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            LogIn a = new LogIn();
            a.Show();
            this.Hide();
            usu = null;
            rols = null;
        }

        private void BEmpleados_Click(object sender, EventArgs e)
        {
            OpenForm(new Empleados());
            WTitle.Text = "Empleados";
        }
    }
}
