﻿using System;
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
        public FormAlmacen()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

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

            Console.ReadLine();

            tbProducto.Text = "Introduce el producto";
            tbProducto.ForeColor = Color.Silver;
            tbPrecio.Text = "Introduce el precio";
            tbPrecio.ForeColor = Color.Silver;
            tbCantidad.Text = "Introduce la cantidad";
            tbCantidad.ForeColor = Color.Silver;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            String query = "UPDATE Usuarios SET Nombre = '" + tbProductoModificar.Text + "', Precio = '" + tbPrecioModificar.Text + "', Cantidad = " + tbCantidadModificar.Text + " WHERE Usuario = '" + lbProductos.SelectedItem + "'";

            OleDbCommand comando = new OleDbCommand(query, conexion);
            comando.ExecuteNonQuery();

            lbProductos.Items.Clear();

            String query2 = "SELECT * FROM Usuarios";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbProductos.Items.Add(row["Usuario"]);

                Console.WriteLine(row["Id"]);
                Console.WriteLine(row["Usuario"]);

            }

            conexion.Close();

            Console.ReadLine();

            tbProductoModificar.Text = "Introduce el producto";
            tbProductoModificar.ForeColor = Color.Silver;
            tbPrecioModificar.Text = "Introduce el precio";
            tbPrecioModificar.ForeColor = Color.Silver;
            tbCantidadModificar.Text = "Introduce la cantidad";
            tbCantidadModificar.ForeColor = Color.Silver;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

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

                Console.WriteLine(row["Nombre"]);

            }

            conexion.Close();

            Console.ReadLine();
        }

        private void FormAlmacen_Load(object sender, EventArgs e)
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

                Console.WriteLine(row["Nombre"]);

            }

            conexion.Close();

            Console.ReadLine();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }
    }
}
