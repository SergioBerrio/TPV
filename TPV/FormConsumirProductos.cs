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
        String nombre;

        public FormConsumirProductos()
        {
            InitializeComponent();
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            /*int indice = lbProductos.SelectedIndex;
            string listboxItemText = lbProductos.SelectedItem.ToString();

            if (indice > 0)
            {
                lbProductos.Items.RemoveAt(indice);
                lbProductos.Items.Insert(indice - 1, listboxItemText);
                lbProductos.SetSelected(indice - 1, true);

                MessageBox.Show("Selecciona un producto válido de la lista!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            /*int indice = lbProductos.SelectedIndex;
            string listboxItemText = lbProductos.SelectedItem.ToString();

            if (indice < lbProductos.Items.Count-1)
            {
                lbProductos.Items.RemoveAt(indice);
                lbProductos.Items.Insert(indice + 1, listboxItemText);
                lbProductos.SetSelected(indice + 1, true);

                MessageBox.Show("Selecciona un producto válido de la lista!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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

            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();

            ArrayList myAL = new ArrayList();

            dgvProductos.Columns[0].Name = "Id";
            dgvProductos.Columns[1].Name = "Nombre";
            dgvProductos.Columns[2].Name = "Precio";
            dgvProductos.Columns[3].Name = "Cantidad";
            dgvProductos.Columns[4].Name = "Impuesto";

            conexion.Close();
            conexion.Open();

            OleDbDataAdapter adapter2 = new OleDbDataAdapter("SELECT * FROM Productos", conexion);

            DataSet d2 = new DataSet();
            adapter2.Fill(d2);

            DataGridViewRow rowDGV = (DataGridViewRow)dgvProductos.Rows[0].Clone();

            foreach (DataRow row in d.Tables[0].Rows)
            {
                String[] rowProducto = new String[5];
                rowProducto[0] = row["Id"] + "";
                rowProducto[1] = row["Nombre"] + "";
                rowProducto[2] = row["Precio"] + "";
                rowProducto[3] = row["Cantidad"] + "";
                rowProducto[4] = row["Impuesto"] + "";
                myAL.Add(rowProducto);
            }

            foreach (String[] linea in myAL)
            {
                dgvProductos.Rows.Add(linea);
            }

            conexion.Close();

            Console.ReadLine();

            lbProductos.SelectedIndex = 0;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario(nombre);
            formUsuario.Show();
            this.Hide();
        }
    }
}
