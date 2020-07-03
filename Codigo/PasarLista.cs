using System;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class PasarLista : Form
    {
        public PasarLista()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") ||
                textBox4.Text.Equals("") ||
                textBox5.Text.Equals("") ||
                textBox6.Text.Equals(""))
            {
                MessageBox.Show("No dejar campos vacios");
            }

            else
            {
                try
                {
                    Conexion.ExecuteNonQuery($"insert into Registro values(" +
                                             $"'{textBox1.Text}'," +
                                             $"'{textBox2.Text}'," +
                                             $"'{textBox3.Text}'," +
                                             $"'{textBox4.Text}'," +
                                             $"'{textBox5.Text}'," +
                                             $"{textBox6.Text})");

                    MessageBox.Show("Se ha registrado");
                }
                catch (Exception)
                {
                    MessageBox.Show("Recuerde usar su idUsuario");
                }
            }
        }
    }
}