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
            String regexp = "(0[1-9]|1[0-2])/(0[1-9]|[1-2][0-9]|3[0-1])/[0-9]{4}-(2[0-3]|[01][0-9]):[0-5][0-9]";
            Match m = Regex.Match(tbFecha.Text, regexp);

            if (m.Success)
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/USER/source/repos/TPV/TPV/Database1.accdb");

                conexion.Open();

                String query = "INSERT INTO Reservas (Fecha, id_usuarioLogeado, Tipo) VALUES ( '" + tbFecha.Text + "', " + id + ", '" + cbTipo.Text + "')";

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

                Console.ReadLine();

                tbFecha.Text = "Introduce la fecha (formato dd/mm/aaaa-hora)";
                tbFecha.ForeColor = Color.Silver;

            } else {

                MessageBox.Show("Fecha introducida incorrecta, introduce una fecha con el formato correcto!! (formato dd/mm/aaaa-hora)");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            String regexp = "(0[1-9]|1[0-2])/(0[1-9]|[1-2][0-9]|3[0-1])/[0-9]{4}-(2[0-3]|[01][0-9]):[0-5][0-9]";
            Match m = Regex.Match(tbFechaModificar.Text, regexp);

            if (m.Success)
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/USER/source/repos/TPV/TPV/Database1.accdb");

                conexion.Open();

                String query = "UPDATE Reservas SET Fecha = '" + tbFechaModificar.Text + "', Tipo = '" + cbTipo.Text + "' WHERE Fecha = '" + lbReservas.SelectedItem + "'";

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

                Console.ReadLine();

                tbFechaModificar.Text = "Introduce la fecha (formato dd/mm/aaaa-hora)";
                tbFechaModificar.ForeColor = Color.Silver;

            } else
            {
                MessageBox.Show("Fecha introducida incorrecta, introduce una fecha con el formato correcto!! (formato dd/mm/aaaa-hora)");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/USER/source/repos/TPV/TPV/Database1.accdb");

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

            Console.ReadLine();

            tbFechaModificar.Text = "Introduce la fecha (formato dd/mm/aaaa-hora)";
            tbFechaModificar.ForeColor = Color.Silver;
        }

        private void cambiarTextoFecha(object sender, EventArgs e)
        {
            if (tbFecha.Text == "Introduce la fecha (formato dd/mm/aaaa-hora)")
            {
                tbFecha.Text = "";
                tbFecha.ForeColor = Color.Black;
            }
        }

        private void cambiarTextoFechaSalir(object sender, EventArgs e)
        {
            if (tbFecha.Text == "")
            {
                tbFecha.Text = "Introduce la fecha (formato dd/mm/aaaa-hora)";
                tbFecha.ForeColor = Color.Silver;
            }
        }

        private void cambiarTextoFechaModificar(object sender, EventArgs e)
        {
            if (tbFechaModificar.Text == "Introduce la fecha (formato dd/mm/aaaa-hora)")
            {
                tbFechaModificar.Text = "";
                tbFechaModificar.ForeColor = Color.Black;
            }
        }

        private void cambiarTextoFechaModificarSalir(object sender, EventArgs e)
        {
            if (tbFechaModificar.Text == "")
            {
                tbFechaModificar.Text = "Introduce la fecha (formato dd/mm/aaaa-hora)";
                tbFechaModificar.ForeColor = Color.Silver;
            }
        }

        private void FormHacerReservas_Load(object sender, EventArgs e)
        {
            cbTipo.SelectedItem = "Comida";

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/USER/source/repos/TPV/TPV/Database1.accdb");

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

            Console.ReadLine();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario(nombreUsuarioLogeado);
            formUsuario.Show();
            this.Hide();
        }

    }
}
