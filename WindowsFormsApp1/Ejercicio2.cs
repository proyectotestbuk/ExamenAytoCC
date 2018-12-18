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
    public partial class Ejercicio2 : Plantilla
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd1DataSet.habitantes1' Puede moverla o quitarla según sea necesario.
            this.habitantes1TableAdapter.Fill(this.bd1DataSet.habitantes1);
            // TODO: esta línea de código carga datos en la tabla 'bd1DataSet.habitantes' Puede moverla o quitarla según sea necesario.
            this.habitantesTableAdapter.Fill(this.bd1DataSet.habitantes);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dni = comboBox1.SelectedValue.ToString();
            textBox1.Text = dni;
        }
    }
}
