using System;
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
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
          
            InitializeComponent();
        }
        internal static double presupuesto;


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new GestionDePresupuestocs());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new AgregarGasto());
        }
        private void AbrirFormulario(object formHija)
        {
            if(this.PanelCotenedor.Controls.Count > 0) 
                this.PanelCotenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;   
            this.PanelCotenedor.Controls.Add(fh);
            this.PanelCotenedor.Tag = fh;
            fh.Show();
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new VerGasto());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Editar_Gasto());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new GenerarInformes());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
