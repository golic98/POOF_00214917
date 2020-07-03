using System;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class AgregarVigilante : Form
    {
        public AgregarVigilante()
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
                Conexion.ExecuteNonQuery($"insert into Departamento values(" +
                                         $"'{textBox1.Text}'," +
                                         $"'{textBox2.Text}'," +
                                         $"'{textBox3.Text}')");
                MessageBox.Show("Se ha registrado");
                
            }
        }
    }
}