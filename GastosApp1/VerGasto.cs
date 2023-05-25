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
    public partial class VerGasto : Form
    {
        public VerGasto()
        {
            InitializeComponent();
            InitializeListView();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("IdGasto", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Fecha", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Categoría", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Monto", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Descripción",300, HorizontalAlignment.Left);
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

    }
}
