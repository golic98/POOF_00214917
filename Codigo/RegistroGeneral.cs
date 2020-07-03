using System;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class RegistroGeneral : Form
    {
        public RegistroGeneral()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d = Conexion.ExecuteQuery($"select * from Registro");
            dataGridView1.DataSource = d;
        }
    }
}