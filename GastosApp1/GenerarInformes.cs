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
    public partial class GenerarInformes : Form
    {
        public GenerarInformes()
        {
            InitializeComponent();
        }

        private void GenerarInformes_Load(object sender, EventArgs e)
        {
            // Configurar las columnas
            dataGridView1.Columns.Add("Categoria", "Categoría");

            // Agregar las filas
            dataGridView1.Rows.Add("Vivienda");
            dataGridView1.Rows.Add("Salud");
            dataGridView1.Rows.Add("Alimentación");
            dataGridView1.Rows.Add("Transporte");
            dataGridView1.Rows.Add("Educación");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
