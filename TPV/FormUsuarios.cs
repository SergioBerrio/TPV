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

            lbUsuarios.Items.Clear();

            String query2 = "SELECT * FROM Usuarios";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbUsuarios.Items.Add(row["Usuario"]);
            }

            conexion.Close();

            MessageBox.Show("Has añadido al usuario: " + tbUsuario.Text, "Añadir usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tbUsuario.Text = "Introduce el usuario";
            tbUsuario.ForeColor = Color.Silver;
            tbContrasena.Text = "Introduce la contraseña";
            tbContrasena.ForeColor = Color.Silver;
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

            String query = "UPDATE Usuarios SET Usuario = '" + tbUsuarioModificar.Text + "', Contrasena = '" + tbContrasenaModificar.Text + "', Admin = " + esAdmin + " WHERE Usuario = '" + lbUsuarios.SelectedItem + "'";

            OleDbCommand comando = new OleDbCommand(query, conexion);
            comando.ExecuteNonQuery();

            lbUsuarios.Items.Clear();

            String query2 = "SELECT * FROM Usuarios";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbUsuarios.Items.Add(row["Usuario"]);
            }

            conexion.Close();

            MessageBox.Show("Has modificado al usuario: " + tbUsuarioModificar.Text, "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tbUsuarioModificar.Text = "Introduce el usuario";
            tbUsuarioModificar.ForeColor = Color.Silver;
            tbContrasenaModificar.Text = "Introduce la contraseña";
            tbContrasenaModificar.ForeColor = Color.Silver;
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

            String query = "DELETE * FROM Usuarios WHERE Usuario = '" + lbUsuarios.SelectedItem + "'";

            OleDbCommand comando = new OleDbCommand(query, conexion);
            comando.ExecuteNonQuery();

            lbUsuarios.Items.Clear();

            String query2 = "SELECT * FROM Usuarios";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query2, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbUsuarios.Items.Add(row["Usuario"]);
            }

            conexion.Close();

            MessageBox.Show("Has eliminado al usuario: " + tbUsuarioModificar.Text, "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void cambiarTextoUsuario(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "Introduce el usuario")
            {
                tbUsuario.Text = "";
                tbUsuario.ForeColor = Color.Black;
            }
        }

        private void cambiarTextoUsuarioSalir(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "")
            {
                tbUsuario.Text = "Introduce el usuario";
                tbUsuario.ForeColor = Color.Silver;
            }
        }

        private void cambiarTextoContrasena(object sender, EventArgs e)
        {
            if (tbContrasena.Text == "Introduce la contraseña")
            {
                tbContrasena.Text = "";
                tbContrasena.ForeColor = Color.Black;
                //tbContrasena.PasswordChar = '*';
            }
        }

        private void cambiarTextoContrasenaSalir(object sender, EventArgs e)
        {
            if (tbContrasena.Text == "")
            {
                tbContrasena.Text = "Introduce la contraseña";
                tbContrasena.ForeColor = Color.Silver;
            }
        }

        private void cambiarTextoUsuarioModificar(object sender, EventArgs e)
        {
            if (tbUsuarioModificar.Text == "Introduce el usuario")
            {
                tbUsuarioModificar.Text = "";
                tbUsuarioModificar.ForeColor = Color.Black;
            }
        }

        private void cambiarTextoUsuarioModificarSalir(object sender, EventArgs e)
        {
            if (tbUsuarioModificar.Text == "")
            {
                tbUsuarioModificar.Text = "Introduce el usuario";
                tbUsuarioModificar.ForeColor = Color.Silver;
            }
        }

        private void cambiarTextoContrasenaModificar(object sender, EventArgs e)
        {
            if (tbContrasenaModificar.Text == "Introduce la contraseña")
            {
                tbContrasenaModificar.Text = "";
                tbContrasenaModificar.ForeColor = Color.Black;
                //tbContrasenaModificar.PasswordChar = '*';
            }
        }

        private void cambiarTextoContrasenaModificarSalir(object sender, EventArgs e)
        {
            if (tbContrasenaModificar.Text == "")
            {
                tbContrasenaModificar.Text = "Introduce la contraseña";
                tbContrasenaModificar.ForeColor = Color.Silver;
            }
        }

        private void cargarForm(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            String query = "SELECT * FROM Usuarios";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                lbUsuarios.Items.Add(row["Usuario"]);

            }

            conexion.Close();
        }
    }
}
