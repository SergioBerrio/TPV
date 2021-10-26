using System;
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
    public partial class FormUsuarios : Form
    {
        int esAdmin = 0;

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            if (cbAdmin.Checked)
            {
                esAdmin = 1;

            } else {

                esAdmin = 0;
            }

            String query = "INSERT INTO Usuarios (Usuario, Contrasena, Admin) VALUES ( '" + tbUsuario.Text + "', '" + tbContrasena.Text + "', " + esAdmin + ")";

            OleDbCommand comando = new OleDbCommand(query, conexion);
            comando.ExecuteNonQuery();


            String query2 = "SELECT * FROM Usuarios";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbUsuarios.Items.Add(row["Usuario"]);

                Console.WriteLine(row["Usuario"]);

            }

            conexion.Close();

            Console.ReadLine();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            if (cbAdmin.Checked)
            {
                esAdmin = 1;

            }
            else
            {

                esAdmin = 0;
            }

            String query = "UPDATE Usuarios SET Usuario = '" + tbUsuario.Text + "', Contrasena = '" + tbContrasena.Text + "', Admin = " + esAdmin + " WHERE Usuario = " + tbUsuarioModificar.Text;

            OleDbCommand comando = new OleDbCommand(query, conexion);
            comando.ExecuteNonQuery();


            String query2 = "SELECT * FROM Usuarios";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbUsuarios.Items.Add(row["Usuario"]);

                Console.WriteLine(row["Usuario"]);

            }

            conexion.Close();

            Console.ReadLine();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            if (cbAdmin.Checked)
            {
                esAdmin = 1;

            }
            else
            {

                esAdmin = 0;
            }

            String query = "DELETE * FROM Usuarios WHERE Usuario = " + tbUsuarioEliminar.Text;

            OleDbCommand comando = new OleDbCommand(query, conexion);
            comando.ExecuteNonQuery();


            String query2 = "SELECT * FROM Usuarios";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbUsuarios.Items.Add(row["Usuario"]);

                Console.WriteLine(row["Usuario"]);

            }

            conexion.Close();

            Console.ReadLine();

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
