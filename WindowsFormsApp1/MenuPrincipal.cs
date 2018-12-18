using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ejercicio2 = new Ejercicio2();
            ejercicio2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ejercicio3 = new Ejercicio3();
            ejercicio3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ejercicio4 = new Ejercicio4();
            ejercicio4.ShowDialog();
        }
    }
}
