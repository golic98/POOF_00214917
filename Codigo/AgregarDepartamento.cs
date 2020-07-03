using System;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class AgregarDepartamento : Form
    {
        public static string nombreDepartamento;
        public AgregarDepartamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox3.Text == "")
            {
                MessageBox.Show("No dejar campos vacios");
            }

            else
            {
                nombreDepartamento = textBox2.Text;
                
                Conexion.ExecuteNonQuery($"insert into Departamento values (" +
                                         $"'{textBox1.Text}'," +
                                         $"'{textBox2.Text}'," +
                                         $"'{textBox3.Text}')");
                MessageBox.Show("Se ha guardado");
                Hide();
                AgregarUsuarioGerente agregarUsuarioGerente = new AgregarUsuarioGerente();
                agregarUsuarioGerente.Show();
            }
        }
    }
}