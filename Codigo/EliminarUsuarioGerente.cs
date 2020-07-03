using System;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class EliminarUsuarioGerente : Form
    {
        public EliminarUsuarioGerente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No dejar campos vacios");
            }

            else
            {
                try
                {
                    Conexion.ExecuteNonQuery($"delete from Usuario where nombre = '{textBox1.Text}'");
                    MessageBox.Show("Se ha eliminado");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un problema");
                }
            }
        }
    }
}