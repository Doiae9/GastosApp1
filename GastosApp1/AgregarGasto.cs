using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseGasto;

namespace GastosApp1
{
    public partial class AgregarGasto : Form
    {
        List<Gasto> ListaGastos = new List<Gasto>();
        
       
        public AgregarGasto()
        {
            InitializeComponent();
        }
        private int GetNextId()
        {
            int maxId = 0;

            // Obtener el máximo ID actual en la lista de gastos
            foreach (Gasto gasto in ListaGastos)
            {
                // if (ListaGastos.ID > maxId)
                {
                    //maxId = ListaGastos.Id;
                }
            }
            int nextId = maxId + 1;

            return nextId;
        }

        private void LimpiarCampos()
        {
            cmbCategoria.SelectedIndex = -1; // Deseleccionar cualquier categoría seleccionada
            txtMonto.Text = string.Empty; // Vaciar el campo de monto
            dtpFecha.Value = DateTime.Today; // Establecer la fecha actual
            //Id.Text = string.Empty; // Vaciar la etiqueta de ID
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Gasto NuevoGasto = new Gasto();
            //ComboBox Agregar Categoria
            // NuevoGasto.Categoria = cmbCategoria;
            //Agregar Fecha con un CateTimePicker
            NuevoGasto.Fecha = dtpFecha.Value;
            //textbox Agregar Descripcion
            NuevoGasto.Descripcion = txtDescipcion.Text.TrimEnd();
            //textbox monto
            NuevoGasto.Monto = Convert.ToDouble(txtMonto.Text);
            //cmbCategoria 
        NuevoGasto.Categoria= cmbCategoria.SelectedItem.ToString();
            NuevoGasto.ID = GetNextId();
            //Restar presupuesto con nuevo monto
            Form1.presupuesto -= NuevoGasto.Monto;

            if (Form1.presupuesto >= 0)
            {
                ListaGastos.Add(NuevoGasto);
                LimpiarCampos();
            }
            else
            {
                //Tus gastos exeden tu presupuesto.
            }
        }

        private void AgregarGasto_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
