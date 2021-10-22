using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TPV
{
    public partial class FormLogin : Form
    {
       
        public FormLogin()
        {
            InitializeComponent();


            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/2DAM3/source/repos/TPV/TPV/Database1.accdb");

            conexion.Open();

            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Usuarios", conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            Boolean correcto = false;

            foreach (DataRow row in d.Tables[0].Rows)
            {
                Console.WriteLine("ID: " + row["Id"]);
                Console.WriteLine("Usuario: " + row["Usuario"]);
                Console.WriteLine("Contraseña: " + row["Contrasena"]);
                Console.WriteLine("Es Admin: " + row["Admin"]);
                Console.WriteLine("");


                if (tbUsuario.Text.Equals(row["Usuario"]) && tbContrasena.Text.Equals(row["Contrasena"]))
                {
                    correcto = true;

                    if ((Boolean)row["Admin"] == true){

                        FormAdmin admin = new FormAdmin();
                        admin.Show();
                        this.Hide();

                    } else
                    {
                        FormUsuario usuario = new FormUsuario();
                        usuario.Show();
                        this.Hide();
                    }
                }
            }

            if(!correcto){
                MessageBox.Show("Usuario incorrecto, introduce de nuevo los datos!!");
            }

            conexion.Close();

            Console.ReadLine();



            
        }
    }
}
