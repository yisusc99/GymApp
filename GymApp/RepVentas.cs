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
    public partial class RepVentas : Form
    {
        public RepVentas()
        {
            InitializeComponent();
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RepVentas_Load(object sender, EventArgs e)
        {
            string[] x = { "asd","dsa","sdd","d33"};
            int[] y = { 1, 2, 3, 4 };

            GraphProd.Series[0].Points.DataBindXY(x, y);
            GraphMem.Series[0].Points.DataBindXY(x, y);
        }
    }
}
