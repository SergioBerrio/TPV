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

            MessageBox.Show("Nuevo usuario: " + "\nNombre: " + tbUsuario.Text + " \nContraseña: " + tbContrasena.Text, "Añadir usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            MessageBox.Show("Usurio modificado: " + "\nNombre: " + tbUsuarioModificar.Text + " \nContraseña: " + tbContrasenaModificar.Text, "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            MessageBox.Show("Usuario eliminado: " + "\nNombre: " + lbUsuarios.SelectedItem, "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
