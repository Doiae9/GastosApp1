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
    public partial class Editar_Gasto : Form
    {
        public Editar_Gasto()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void Editar_Gasto_Load(object sender, EventArgs e)
        {

        }
        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("IdGasto", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Fecha", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Categoría", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Monto", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Descripción", 300, HorizontalAlignment.Left);
        }

        private void AddItemToListView(string idGasto, string fecha, string categoria, string monto, string descripcion)
        {
            ListViewItem item = new ListViewItem(idGasto);
            item.SubItems.Add(fecha);
            item.SubItems.Add(categoria);
            item.SubItems.Add(monto);
            item.SubItems.Add(descripcion);
            listView1.Items.Add(item);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            //selected item
            //Agregar Fecha con un CateTimePicker
            NuevoGasto.Fecha = dtpFecha.Value;
            //textbox Agregar Descripcion
            NuevoGasto.Descripcion = txtDescipcion.Text.TrimEnd();
            //textbox monto
            NuevoGasto.Monto = Convert.ToDouble(txtMonto.Text);
            //cmbCategoria 
            NuevoGasto.Categoria = cmbCategoria.SelectedItem.ToString();
            NuevoGasto.ID = GetNextId();
            //Restar presupuesto con nuevo monto
            Form1.presupuesto -= NuevoGasto.Monto;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            //boton eliminar
            //dropear listview con list 
            if(Item.Selected == true)
            {

            }
            
        }
    }
}

