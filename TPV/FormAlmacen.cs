using Aspose.Pdf;
using MySql.Data.MySqlClient;
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
    public partial class FormAlmacen : Form
    {
        int id = 0;
        String producto = "";
        String articulo = "";
        int cantidad = 0;
        double precio = 0;
        int minimo = 0;

        public FormAlmacen()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (tbProducto.Text == "" || tbPrecio.Text == "" || tbCantidad.Text == "")
            {
                MessageBox.Show("Introduce datos en los campos!!", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            } else
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "INSERT INTO Productos (Nombre, Precio, Cantidad) VALUES ( '" + tbProducto.Text + "', '" + tbPrecio.Text + "', '" + tbCantidad.Text + "')";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.ExecuteNonQuery();

                lbProductos.Items.Clear();

                String query2 = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    lbProductos.Items.Add(row["Nombre"]);
                }

                conexion.Close();

                MessageBox.Show("Producto añadido! " + "\nNombre: " + tbProducto.Text + "\nPrecio: " + tbPrecio.Text + "\nCantidad: " + tbCantidad.Text, "Añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbProducto.Text = "";
                tbPrecio.Text = "";
                tbCantidad.Text = "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbProducto.Text == "")
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "UPDATE Productos SET Precio = '" + tbPrecioModificar.Text + "', Cantidad = " + tbCantidadModificar.Text + " WHERE Nombre = '" + lbProductos.SelectedItem + "'";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.ExecuteNonQuery();

                lbProductos.Items.Clear();

                String query2 = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    lbProductos.Items.Add(row["Nombre"]);
                }

                conexion.Close();

                MessageBox.Show("Producto modificado! " + " \nPrecio: " + tbPrecioModificar.Text + "\nCantidad: " + tbCantidadModificar.Text, "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbPrecioModificar.Text = "";
                tbCantidadModificar.Text = "";

            }
            else if (tbProducto.Text == "" && tbPrecio.Text == "")
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "UPDATE Productos SET Cantidad = " + tbCantidadModificar.Text + " WHERE Nombre = '" + lbProductos.SelectedItem + "'";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.ExecuteNonQuery();

                lbProductos.Items.Clear();

                String query2 = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    lbProductos.Items.Add(row["Nombre"]);
                }

                conexion.Close();

                MessageBox.Show("Producto modificado! " + " \nCantidad: " + tbCantidadModificar.Text, "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbCantidadModificar.Text = "";

            }
            else if (tbProducto.Text == "" && tbCantidadModificar.Text == "")
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "UPDATE Productos SET Precio = " + tbPrecioModificar.Text + " WHERE Nombre = '" + lbProductos.SelectedItem + "'";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.ExecuteNonQuery();

                lbProductos.Items.Clear();

                String query2 = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    lbProductos.Items.Add(row["Nombre"]);
                }

                conexion.Close();

                MessageBox.Show("Producto modificado! " + "\nPrecio: " + tbPrecioModificar.Text, "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbPrecioModificar.Text = "";
            }
            else if (tbPrecio.Text == "")
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "UPDATE Productos SET Nombre = '" + tbProducto.Text + "', Cantidad = " + tbCantidadModificar.Text + " WHERE Nombre = '" + lbProductos.SelectedItem + "'";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.ExecuteNonQuery();

                lbProductos.Items.Clear();

                String query2 = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    lbProductos.Items.Add(row["Nombre"]);
                }

                conexion.Close();

                MessageBox.Show("Producto modificado! " + "\nProducto: " + tbProductoModificar.Text + "\nCantidad: " + tbCantidadModificar.Text, "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbProductoModificar.Text = "";
                tbCantidadModificar.Text = "";
            }
            else if (tbPrecio.Text == "" && tbProducto.Text == "")
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "UPDATE Productos SET Cantidad = " + tbCantidadModificar.Text + " WHERE Nombre = '" + lbProductos.SelectedItem + "'";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.ExecuteNonQuery();

                lbProductos.Items.Clear();

                String query2 = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    lbProductos.Items.Add(row["Nombre"]);
                }

                conexion.Close();

                MessageBox.Show("Producto modificado! " + "\nCantidad: " + tbCantidadModificar.Text, "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbCantidadModificar.Text = "";

            } else if (tbPrecio.Text == "" && tbCantidad.Text == "")
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "UPDATE Productos SET Nombre = '" + tbProducto.Text + " WHERE Nombre = '" + lbProductos.SelectedItem + "'";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.ExecuteNonQuery();

                lbProductos.Items.Clear();

                String query2 = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    lbProductos.Items.Add(row["Nombre"]);
                }

                conexion.Close();

                MessageBox.Show("Producto modificado! " + "\nNombre: " + tbProductoModificar.Text, "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbProductoModificar.Text = "";

            } else if (tbCantidad.Text == "")
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "UPDATE Productos SET Nombre = '" + tbPrecioModificar.Text + "', Precio = " + tbPrecioModificar.Text + " WHERE Nombre = '" + lbProductos.SelectedItem + "'";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.ExecuteNonQuery();

                lbProductos.Items.Clear();

                String query2 = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    lbProductos.Items.Add(row["Nombre"]);
                }

                conexion.Close();

                MessageBox.Show("Producto modificado! " + "\nProducto: " + tbProductoModificar.Text + " \nPrecio: " + tbPrecioModificar.Text, "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbProductoModificar.Text = "";
                tbPrecioModificar.Text = "";

            } else if (tbCantidad.Text == "" && tbProducto.Text == "")
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "UPDATE Productos SET Precio = " + tbPrecioModificar.Text + " WHERE Nombre = '" + lbProductos.SelectedItem + "'";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.ExecuteNonQuery();

                lbProductos.Items.Clear();

                String query2 = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    lbProductos.Items.Add(row["Nombre"]);
                }

                conexion.Close();

                MessageBox.Show("Producto modificado! " + "\nPrecio: " + tbPrecioModificar.Text, "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbPrecioModificar.Text = "";

            } else if (tbCantidad.Text == "" && tbPrecio.Text == "")
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "UPDATE Productos SET Nombre = '" + tbPrecioModificar.Text + " WHERE Nombre = '" + lbProductos.SelectedItem + "'";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.ExecuteNonQuery();

                lbProductos.Items.Clear();

                String query2 = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    lbProductos.Items.Add(row["Nombre"]);
                }

                conexion.Close();

                MessageBox.Show("Producto modificado! " + "\nProducto: " + tbProductoModificar.Text, "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbProductoModificar.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lbProductos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto para eliminar!!", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "DELETE * FROM Productos WHERE Nombre = '" + lbProductos.SelectedItem + "'";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.ExecuteNonQuery();

                lbProductos.Items.Clear();

                String query2 = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    lbProductos.Items.Add(row["Nombre"]);

                }

                conexion.Close();

                MessageBox.Show("Producto eliminado! " + lbProductos.SelectedItem, "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormAlmacen_Load(object sender, EventArgs e)
        {
            cbElegir.SelectedItem = "Access";

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

            conexion.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void cerrarAplicacion(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            if (cbElegir.Text == "Access")
            {
                MessageBox.Show("Creación del informe de cuentas en curso...", "Informe de cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Initialize document object
                Document factura = new Document();

                // Add page
                Page page = factura.Pages.Add();

                // Add text to new page
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("=================================================================="));
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(" Id                Producto                     Cantidad                     Precio                     Mínimo disponible "));
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("=================================================================="));
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database1.accdb");

                conexion.Open();

                String query = "SELECT * FROM Productos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conexion);

                DataSet d = new DataSet();
                adapter.Fill(d);

                foreach (DataRow row in d.Tables[0].Rows)
                {
                    id = Convert.ToInt32(row["Id"]);

                    producto = row["Nombre"].ToString();

                    cantidad = Convert.ToInt32(row["Cantidad"]);

                    precio = Convert.ToDouble(row["Precio"]);

                    minimo = Convert.ToInt32(row["minimo_disponible"]);

                    Aspose.Pdf.Text.TextFragment textFragment = new Aspose.Pdf.Text.TextFragment(id + "                     " + producto + "                        " + cantidad + "                        " + precio + "                        " + minimo);

                    if (cantidad < minimo)
                    {
                        textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.Red;
                    }

                    page.Paragraphs.Add(textFragment);
                }

                // Save PDF 
                String rutaPDF = "C:/DATOS/Informe.pdf";
                factura.Save(rutaPDF);
                System.Diagnostics.Process.Start("C:/DATOS/Informe.pdf");

            } else if (cbElegir.Text == "MySql")
            {
                MessageBox.Show("Creación del informe de cuentas en curso...", "Informe de cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Initialize document object
                Document factura = new Document();

                // Add page
                Page page = factura.Pages.Add();

                // Add text to new page
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("=================================================================="));
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(" Id                Artículo                     Precio                     Cantidad                     Precio                     Mínimo disponible "));
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("=================================================================="));

                string connectionString = "datasource=localhost;database=Database1;username=root;password=root;";

                string query = "SELECT * FROM Productos";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();

                    reader = commandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            object[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6) };
                            Aspose.Pdf.Text.TextFragment text = new Aspose.Pdf.Text.TextFragment(reader.GetString(0) + "           " + reader.GetString(1) + "           " + reader.GetString(2) + "           " + reader.GetString(3) + "           " + reader.GetString(4) + "           " + reader.GetString(5) + "           " + reader.GetString(6));

                            if (Convert.ToDouble(reader.GetString(3)) < Convert.ToDouble(reader.GetString(6)))
                            {
                                text.TextState.ForegroundColor = Aspose.Pdf.Color.Red;
                            }

                            page.Paragraphs.Add(text);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al ejecutar la conexión con la db", "Error en la conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // Save PDF 
                String rutaPDF = "C:/DATOS/Informe.pdf";
                factura.Save(rutaPDF);
                System.Diagnostics.Process.Start("C:/DATOS/Informe.pdf");
            }
        }
    }
}
