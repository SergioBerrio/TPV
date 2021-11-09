using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV
{
    public partial class FormConsumirProductos : Form
    {
        String nombre;
        double subtotal;
        int impuestos;

        public FormConsumirProductos()
        {
            InitializeComponent();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            int aux = -1;

            for (int i = 0; i < dgvProductos.Rows.Count - 1; i++)
            {
                if (dgvProductos.Rows[i].Cells[1].Value.ToString().Equals(lbSeleccionProductos.SelectedItem.ToString()))
                {
                    aux = i;
                }
            }

            if (aux > -1)
            {
                dgvProductos.Rows[aux].Cells[3].Value = Convert.ToInt32(dgvProductos.Rows[aux].Cells[3].Value) + 1;
            }

            lbSeleccionProductos.Items.Remove(lbSeleccionProductos.SelectedItem);
            
            tbSubtotal.Text = (Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) + tbSubtotal.Text).ToString() + " €";
            tbTotal.Text = (Convert.ToDouble(tbTotal.Text.Split(' ')[0]) - (Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) + Convert.ToDouble(tbImpuestos.Text.Split(' ')[0]))).ToString() + " €";
            
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
            dgvProductos.Columns[4].Name = "Impuestos";
            dgvProductos.Columns[5].Name = "Total";

            conexion.Close();
            conexion.Open();

            OleDbDataAdapter adapter2 = new OleDbDataAdapter("SELECT * FROM Productos", conexion);

            DataSet d2 = new DataSet();
            adapter2.Fill(d2);

            //DataGridViewRow rowDGV = (DataGridViewRow)dgvProductos.Rows[0].Clone();
           
            foreach (DataRow row in d.Tables[0].Rows)
            {
                String[] rowProducto = new String[6];
                rowProducto[0] = row["Id"] + "";
                rowProducto[1] = row["Nombre"] + "";
                rowProducto[2] = row["Precio"] + "";
                rowProducto[3] = row["Cantidad"] + "";
                rowProducto[4] = row["Impuestos"] + "";
                rowProducto[5] = row["Total"] + "";
                myAL.Add(rowProducto);
            }

            foreach (String[] linea in myAL)
            {
                dgvProductos.Rows.Add(linea);
            }

            conexion.Close();

            lbProductos.SelectedIndex = 0;
        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            string ruta = "C:/DATOS/Factura.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(ruta))
                {
                    File.Delete(ruta);
                }

                // Create a new file     
                using (StreamWriter sw = File.CreateText(ruta))
                {
                    sw.WriteLine("Factura de los productos consumidos");
                    sw.WriteLine(lbSeleccionProductos.Text);
                    sw.WriteLine("=======================");
                    sw.WriteLine("Precio subtotal:" + lblSubtotal.Text + " €");
                    sw.WriteLine("Porcentaje de impuestos:" + lblImpuestos.Text + " %");
                    sw.WriteLine("Precio total de la consumición:" + lblTotal.Text + " €");
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(ruta))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void elegirProducto(object sender, MouseEventArgs e)
        {
            lbSeleccionProductos.Items.Add(lbProductos.SelectedItem);

            double subtotal;
            int impuestos;

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            String query = "SELECT Precio FROM Productos WHERE Nombre = '" + lbProductos.SelectedItem + "'";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                subtotal = Convert.ToDouble(row["Precio"]);

                if (tbSubtotal.Text.Equals("€"))
                {
                    tbSubtotal.Text = subtotal.ToString() + " €";

                } else
                {
                    tbSubtotal.Text = (Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) + subtotal).ToString() + " €";
                }
                
            }


            String query2 = "SELECT Impuestos FROM Productos WHERE Nombre = '" + lbProductos.SelectedItem + "'";

            OleDbDataAdapter adapter2 = new OleDbDataAdapter(query2, conexion);

            DataSet d2 = new DataSet();
            adapter2.Fill(d2);

            foreach (DataRow row in d2.Tables[0].Rows)
            {
                impuestos = Convert.ToInt32(row["Impuestos"]);
                tbImpuestos.Text = impuestos.ToString() + " %";
            }

            if (tbTotal.Text.Equals("€"))
            {
                tbTotal.Text = ((Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) + Convert.ToDouble(tbImpuestos.Text.Split(' ')[0]))).ToString() + " €";

            }
            else
            {
                tbTotal.Text = (Convert.ToDouble(tbTotal.Text.Split(' ')[0]) + (Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) + Convert.ToDouble(tbImpuestos.Text.Split(' ')[0]))).ToString() + " €";
            }

            int aux = -1;

            for (int i = 0; i < dgvProductos.Rows.Count-1; i++)
            {
                if (dgvProductos.Rows[i].Cells[1].Value.ToString().Equals(lbProductos.SelectedItem.ToString()))
                {
                    aux = i;
                } 
            }

            if (aux > -1)
            {
                dgvProductos.Rows[aux].Cells[3].Value = Convert.ToInt32(dgvProductos.Rows[aux].Cells[3].Value) - 1;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario(nombre);
            formUsuario.Show();
            this.Hide();
        }
    }
}
