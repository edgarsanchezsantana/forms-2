using System;
using System.Windows.Forms;

namespace ejercicio2_edg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           label1.Text = "Texto cambiando";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
