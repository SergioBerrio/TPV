using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV
{
    public partial class FormHacerReservas : Form
    {
        private String nombreUsuarioLogeado;
        private int id;

        public FormHacerReservas(String nombre)
        {
            InitializeComponent();
            this.nombreUsuarioLogeado = nombre;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            String query = "INSERT INTO Reservas (Fecha, id_usuarioLogeado, Tipo) VALUES ( '" + mcInsertar.SelectionRange.Start.ToString("dd/MM/yyyy") + "', " + id + ", '" + cbTipo.Text + "')";

            OleDbCommand comando = new OleDbCommand(query, conexion);
            comando.ExecuteNonQuery();

            lbReservas.Items.Clear();

            String query2 = "SELECT * FROM Reservas WHERE id_usuarioLogeado = " + id;

            OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbReservas.Items.Add(row["Fecha"]);

            }

            conexion.Close();

            MessageBox.Show("Has añadido la reserva en la fecha: " + mcInsertar.SelectionRange.Start.ToString("dd/MM/yyyy"), "Nueva reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            String query = "UPDATE Reservas SET Fecha = '" + mcModificar.SelectionRange.Start.ToString("dd/MM/yyyy") + "', Tipo = '" + cbTipo.Text + "' WHERE Fecha = '" + lbReservas.SelectedItem + "'";

            OleDbCommand comando = new OleDbCommand(query, conexion);
            comando.ExecuteNonQuery();

            lbReservas.Items.Clear();

            String query2 = "SELECT * FROM Reservas WHERE id_usuarioLogeado = " + id;

            OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbReservas.Items.Add(row["Fecha"]);

            }

            conexion.Close();

            MessageBox.Show("Has modificado la reserva en la fecha: " + mcInsertar.SelectionRange.Start.ToString("dd/MM/yyyy"), "Modificar reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            String query = "DELETE * FROM Reservas WHERE Fecha = '" + lbReservas.SelectedItem + "'";

            OleDbCommand comando = new OleDbCommand(query, conexion);
            comando.ExecuteNonQuery();

            lbReservas.Items.Clear();

            String query2 = "SELECT * FROM Reservas WHERE id_usuarioLogeado = " + id;

            OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbReservas.Items.Add(row["Fecha"]);

            }

            conexion.Close();

            MessageBox.Show("Has eliminado la reserva en la fecha: " + mcInsertar.SelectionRange.Start.ToString("dd/MM/yyyy"), "Eliminar reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormHacerReservas_Load(object sender, EventArgs e)
        {
            cbTipo.SelectedItem = "Comida";

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            Console.WriteLine(nombreUsuarioLogeado);

            String query = "SELECT * FROM Usuarios WHERE Usuario = '" + nombreUsuarioLogeado + "'";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            id = -1;

            foreach (DataRow row in d.Tables[0].Rows)
            {
                id = Convert.ToInt32(row["Id"]);
            }

            String query2 = "SELECT * FROM Reservas WHERE id_usuarioLogeado = " + id;

            OleDbDataAdapter adapter2 = new OleDbDataAdapter(query2, conexion);

            DataSet d2 = new DataSet();
            adapter2.Fill(d2);


            foreach (DataRow row in d2.Tables[0].Rows)
            {
                lbReservas.Items.Add(row["Fecha"]);
            }

            conexion.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario(nombreUsuarioLogeado);
            formUsuario.Show();
            this.Hide();
        }
    }
}
