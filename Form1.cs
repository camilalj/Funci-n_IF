using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Función_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //Obligar al usuario a que ingrese una edad válida
            if (int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Su edad es" + txtEdad.Text + "años");
            }
             else
            {
                MessageBox.Show("Por favor ingrese una edad válida.");
            }
        }
    }
}
