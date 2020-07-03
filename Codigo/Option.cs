using System;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PasarLista pasar = new PasarLista();
            pasar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gerente gerente = new Gerente();
            gerente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.nombre);
        }
    }
}