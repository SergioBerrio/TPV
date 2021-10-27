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

            String query = "INSERT INTO Usuarios (Nombre, Contrasena, Admin) VALUES ( " + tbNombre.Text + ")";

            OleDbCommand comando = new OleDbCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void FormAlmacen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet1.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.database1DataSet1.Productos);

        }
    }
}
