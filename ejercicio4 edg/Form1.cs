﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4_edg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, resul; 
            num1 =Convert. ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            resul = num1 + num2;
           label1 .Text = Convert.ToString(resul);

        }   

    }
}
