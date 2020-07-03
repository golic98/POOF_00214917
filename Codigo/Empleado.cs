using System;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = Conexion.ExecuteQuery($"select * from Registro");
            dataGridView1.DataSource = dt;
        }
    }
}