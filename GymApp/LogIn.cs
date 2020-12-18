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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            
            if (Usr.Text != null && Pwd.Text != null)
            {

                if (usuario.getUser(Usr.Text, Pwd.Text) != null)
                {
                    Inicio i = new Inicio(usuario.getUser(Usr.Text, Pwd.Text), Usr.Text);
                    this.Hide();
                    i.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contrasena incorrectos.");
                }
            }
            else
            {
                MessageBox.Show("Completa todos los campos.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
