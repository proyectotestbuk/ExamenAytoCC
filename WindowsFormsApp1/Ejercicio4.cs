using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Ejercicio4 : Plantilla
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("e:\\7\\habitantes.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        string linea = sr.ReadLine();
                        string dni = linea.Substring(0, 10);
                        string nombre = linea.Remove(0,10);
                        MessageBox.Show(dni + " - " + nombre);

                        //bd1DataSet.habitantesRow fila = bd1DataSet.habitantes.Newhabitantes1Row();
                        //DataRow fila = bd1DataSet.habitantesRow();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
