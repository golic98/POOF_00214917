using System;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Gerente : Form
    {
        public Gerente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarDepartamento agregarDepartamento = new AgregarDepartamento();
            agregarDepartamento.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarUsuarioGerente eliminar = new EliminarUsuarioGerente();
            eliminar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResumenAdministrador resumenAdministrador = new ResumenAdministrador();
            resumenAdministrador.Show();
        }
    }
}