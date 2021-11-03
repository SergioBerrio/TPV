using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV
{
    public partial class FormConsumirProductos : Form
    {
        public FormConsumirProductos()
        {
            InitializeComponent();
        }

        private void btnAbajo1_Click(object sender, EventArgs e)
        {

        }

        private void btnArriba1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAbajo2_Click(object sender, EventArgs e)
        {
            if (lbProductos.SelectedIndex == lbProductos.SelectedIndex)
            {
                MessageBox.Show("Selecciona un producto para consumir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnArriba2_Click(object sender, EventArgs e)
        {
            if (lbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un producto válido de la lista!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            } 
        }

        private void FormConsumirProductos_Load(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            String query = "SELECT * FROM Productos";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbProductos.Items.Add(row["Nombre"]);

            }

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            ArrayList myAL = new ArrayList();

            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Precio";
            dataGridView1.Columns[3].Name = "Cantidad";

            conexion.Close();
            conexion.Open();


            OleDbDataAdapter adapter2 = new OleDbDataAdapter("SELECT * FROM Productos", conexion);

            DataSet d2 = new DataSet();
            adapter2.Fill(d2);

            DataGridViewRow rowDGV = (DataGridViewRow)dataGridView1.Rows[0].Clone();

            foreach (DataRow row in d.Tables[0].Rows)
            {
                String[] rowProducto = new String[5];
                rowProducto[0] = row["Id"] + "";
                rowProducto[1] = row["Nombre"] + "";
                rowProducto[2] = row["Precio"] + "";
                rowProducto[3] = row["Cantidad"] + "";
                myAL.Add(rowProducto);

            }

            foreach (String[] linea in myAL)
            {
                dataGridView1.Rows.Add(linea);
            }

            conexion.Close();

            Console.ReadLine();

        }
    }
}
