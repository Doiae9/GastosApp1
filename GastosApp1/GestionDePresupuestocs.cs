﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastosApp1
{
    public partial class GestionDePresupuestocs : Form
    {
        public GestionDePresupuestocs()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void GestionDePresupuestocs_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Se asigna el presupuesto
            Form1.presupuesto = Convert.ToDouble(textBox1.Text);
              
        }
    }
}
