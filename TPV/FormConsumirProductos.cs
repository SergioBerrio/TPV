using Aspose.Pdf;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Page = Aspose.Pdf.Page;

namespace TPV
{
    public partial class FormConsumirProductos : Form
    {
        String nombre;
        double subtotal;
        int impuestos;
        int cantidad;
        double precio;
        ArrayList arrayListCantidades = new ArrayList();

        public FormConsumirProductos()
        {
            InitializeComponent();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            int aux = -1;

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            String query = "SELECT Precio FROM Productos WHERE Nombre = '" + lbSeleccionProductos.SelectedItem + "'";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {

                String var1 = (Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) - Convert.ToDouble(row["Precio"])).ToString();

                double impuesto = Convert.ToDouble(row["Precio"]) * 0.04;
                String var2 = (Convert.ToDouble(tbTotal.Text.Split(' ')[0]) - (Convert.ToDouble(row["Precio"]) + impuesto)).ToString();

                tbSubtotal.Text = var1 + " €";
                tbTotal.Text = var2 + " €";
            }


            if (lbSeleccionProductos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto para eliminar!!", "Listbox de eliminar vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
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

                MessageBox.Show("Producto eliminado: " + lbSeleccionProductos.SelectedItem, "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lbSeleccionProductos.Items.Remove(lbSeleccionProductos.SelectedItem);
            }

            conexion.Close();
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
            
            if (lbSeleccionProductos.Items.Count == 0)
            {
                MessageBox.Show("No puedes hacer una factura vacía!!", "Pedido vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {

                MessageBox.Show("Creación de la factura de consumición en curso...", "Factura de TPV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string ruta = "C:/DATOS/Factura.txt";

                try
                {
                    // Check if file already exists. If yes, delete it.     
                    if (File.Exists(ruta))
                    {
                        File.Delete(ruta);
                    }

                    for (int i = 0; i < dgvProductos.Rows.Count - 1; i++)
                    {
                        cantidad = Convert.ToInt32(dgvProductos.Rows[i].Cells[3].Value);
                        precio = Convert.ToDouble(dgvProductos.Rows[i].Cells[2].Value);
                    }

                    int ocurrences;

                    // Create a new file     
                    using (StreamWriter sw = File.CreateText(ruta))
                    {
                        sw.WriteLine("===================================================================================");
                        sw.WriteLine(" Unidades                Producto                Precio                     Importe");
                        sw.WriteLine("===================================================================================");
                        for (int i = 0; i < lbSeleccionProductos.Items.Count; i++)
                        {
                            sw.Write(lbSeleccionProductos.Items.Count + "                          " + lbSeleccionProductos.Items[i] + "                     " + Convert.ToString(precio) + "                        " + Convert.ToString(cantidad * precio));
                        }
                        sw.WriteLine("==================================================================================");
                        sw.WriteLine("Importe Base: " + tbSubtotal.Text + "                      " + "IVA " + tbImpuestos.Text + "                " + "Importe IVA: " + (Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) * 0.04).ToString() + " %");
                        sw.WriteLine("==================================================================================");
                        sw.WriteLine("TOTAL EUROS (IMP. INCLUIDOS)                                               " + tbTotal.Text);
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
                
            

            // Initialize document object
            //Document factura = new Document();

            // Add page
            //Page page = factura.Pages.Add();

            // Add text to new page
            /*page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("[Factura de los productos consumidos]"));
            for (int i = 0; i < lbSeleccionProductos.Items.Count; i++)
            {
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(Convert.ToString(lbSeleccionProductos.Items[i]) + " - "));
            }
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Precio subtotal: " + tbSubtotal.Text));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Porcentaje de impuestos: " + tbImpuestos.Text));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Precio total de la consumición: " + tbTotal.Text));*/

            // Save PDF 
            //factura.Save("C:/DATOS/Factura.pdf");
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

                if (tbTotal.Text.Equals("€"))
                {
                    double impuesto = Convert.ToDouble(row["Precio"]) * 0.04;
                    tbTotal.Text = (Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) + impuesto).ToString() + " €";

                }
                else
                {
                    double impuesto = Convert.ToDouble(row["Precio"]) * 0.04;
                    tbTotal.Text = (Convert.ToDouble(tbTotal.Text.Split(' ')[0]) + (Convert.ToDouble(row["Precio"]) + impuesto)).ToString() + " €";
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
