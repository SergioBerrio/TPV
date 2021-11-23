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

        String producto = "";
        double precio = 0;
        double importe = 0;

        public FormConsumirProductos()
        {
            InitializeComponent();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            int aux = -1;

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

            conexion.Open();

            String query = "SELECT Precio FROM Productos WHERE Nombre = '" + lbSeleccionProductos.SelectedItem + "'";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {

                String var1 = (Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) - Convert.ToDouble(row["Precio"])).ToString();

                double impuesto = Convert.ToDouble(row["Precio"]) * 0.1;
                String var2 = (Convert.ToDouble(tbTotal.Text.Split(' ')[0]) - (Convert.ToDouble(row["Precio"]) + impuesto)).ToString();

                tbSubtotal.Text = var1 + " €";
                tbTotal.Text = var2 + " €";
            }


            if (lbSeleccionProductos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto para eliminar!!", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

                lbSeleccionProductos.Items.Remove(lbSeleccionProductos.SelectedItem);
            }

            conexion.Close();
        }

        private void FormConsumirProductos_Load(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

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

            String query2 = "SELECT * FROM Productos";

            OleDbDataAdapter adapter2 = new OleDbDataAdapter(query2, conexion);

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

                MessageBox.Show("Creación de la factura en curso...", "Factura de TPV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*string rutaTXT = "C:/DATOS/Factura.txt";

                try
                {
                    // Check if file already exists. If yes, delete it.     
                    if (File.Exists(rutaTXT))
                    {
                        File.Delete(rutaTXT);
                    }

                    // Create a new file     
                    using (StreamWriter sw = File.CreateText(rutaTXT))
                    {
                        sw.WriteLine("=============================================================");
                        sw.WriteLine(" Producto                Precio                     Importe ");
                        sw.WriteLine("=============================================================");
                        for (int i = 0; i < lbSeleccionProductos.Items.Count; i++)
                        {
                            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb");

                            conexion.Open();

                            String query = "SELECT * FROM Productos WHERE Nombre = '" + lbSeleccionProductos.Items[i] + "'";

                            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conexion);

                            DataSet d = new DataSet();
                            adapter.Fill(d);

                            foreach (DataRow row in d.Tables[0].Rows)
                            {

                                producto = lbSeleccionProductos.Items[i].ToString();

                                precio = Convert.ToDouble(row["Precio"]);

                                importe = precio;

                                sw.WriteLine(producto + "                     " + precio + "                        " + importe);


                                OleDbConnection conexion2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb");

                                conexion2.Open();

                                String query2 = "UPDATE Productos SET Cantidad = " + (Convert.ToInt32(row["Cantidad"]) - 1) + " WHERE Producto = '" + lbSeleccionProductos.Items[i] + "'";

                                Console.WriteLine(query2);

                                OleDbCommand comando = new OleDbCommand(query2, conexion2);
                                comando.ExecuteNonQuery();

                                conexion.Close();
                                conexion2.Close();

                                dgvProductos.Rows.Clear();
                                dgvProductos.Refresh();
                            }
                            
                        }
                        sw.WriteLine("======================================================================================");
                        sw.WriteLine(" Importe Base: " + tbSubtotal.Text + "     " + "IVA " + tbImpuestos.Text + "     " + "Importe IVA:    " + (Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) * 0.1).ToString() + " €");
                        sw.WriteLine("======================================================================================");
                        sw.WriteLine(" TOTAL EUROS (IMP. INCLUIDOS)          " + tbTotal.Text);
                    }

                    // Open the stream and read it back.    
                    using (StreamReader sr = File.OpenText(rutaTXT))
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
                }*/



                // Initialize document object
                Document factura = new Document();

                // Add page
                Page page = factura.Pages.Add();

                // Add text to new page
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("========================================"));
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(" Producto                Precio                     Importe "));
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("========================================"));
                for (int i = 0; i < lbSeleccionProductos.Items.Count; i++)
                {
                    OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                    conexion.Open();

                    String query = "SELECT * FROM Productos WHERE Nombre = '" + lbSeleccionProductos.Items[i] + "'";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conexion);

                    DataSet d = new DataSet();
                    adapter.Fill(d);

                    foreach (DataRow row in d.Tables[0].Rows)
                    {
                        producto = lbSeleccionProductos.Items[i].ToString();

                        precio = Convert.ToDouble(row["Precio"]);

                        importe = precio;

                        page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(producto + "                     " + precio + "                        " + importe));

                        try
                        {
                            OleDbConnection conexion2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb");

                            conexion2.Open();

                            String query2 = "UPDATE Productos SET Cantidad = " + (Convert.ToInt32(row["Cantidad"]) - 1) + " WHERE Nombre = '" + lbSeleccionProductos.Items[i] + "'";

                            Console.WriteLine(query2);

                            OleDbCommand comando = new OleDbCommand(query2, conexion2);
                            comando.ExecuteNonQuery();

                            dgvProductos.Rows.Clear();
                            dgvProductos.Refresh();

                            ArrayList myAL = new ArrayList();

                            String query3 = "SELECT * FROM Productos";

                            OleDbDataAdapter adapter2 = new OleDbDataAdapter(query3, conexion);

                            DataSet d2 = new DataSet();
                            adapter2.Fill(d2);

                            foreach (DataRow row2 in d2.Tables[0].Rows)
                            {
                                String[] rowProducto2 = new String[6];
                                rowProducto2[0] = row["Id"] + "";
                                rowProducto2[1] = row["Nombre"] + "";
                                rowProducto2[2] = row["Precio"] + "";
                                rowProducto2[3] = row["Cantidad"] + "";
                                rowProducto2[4] = row["Impuestos"] + "";
                                rowProducto2[5] = row["Total"] + "";
                                myAL.Add(rowProducto2);
                            }

                            foreach (String[] linea in myAL)
                            {
                                dgvProductos.Rows.Add(linea);
                            }

                            conexion2.Close();

                        } catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("=========================================="));
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(" Importe Base: " + tbSubtotal.Text + "     " + "IVA " + tbImpuestos.Text + "        " + "Importe IVA: " + (Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) * 0.1).ToString() + " €"));
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("=========================================="));
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(" TOTAL EUROS (IMP. INCLUIDOS)                " + tbTotal.Text));

                // Save PDF 
                String rutaPDF = "C:/DATOS/Factura.pdf";
                factura.Save(rutaPDF);
                System.Diagnostics.Process.Start("C:/DATOS/Factura.pdf");

                lbProductos.SelectedIndex = 0;
                lbSeleccionProductos.Items.Clear();
                tbSubtotal.Text = " €";
                tbImpuestos.Text = "10 %";
                tbTotal.Text = " €";
                
            }
        }

        private void elegirProducto(object sender, MouseEventArgs e)
        {
            lbSeleccionProductos.Items.Add(lbProductos.SelectedItem);

            double subtotal;
            int impuestos;

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

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
                    double impuesto = Convert.ToDouble(row["Precio"]) * 0.1;
                    tbTotal.Text = (Convert.ToDouble(tbSubtotal.Text.Split(' ')[0]) + impuesto).ToString() + " €";

                }
                else
                {
                    double impuesto = Convert.ToDouble(row["Precio"]) * 0.1;
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

        private void cerrarAplicacion(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
