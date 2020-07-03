using System;
using System.Data;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class ResumenAdministrador : Form
    {
        public ResumenAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroGeneral registroGeneral = new RegistroGeneral();
            registroGeneral.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Empleados que se encuentran dentro de la empresa: " + Form1.nombre);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var c = Conexion.ExecuteQuery($"select nombre from Departamento");
            foreach (DataRow d in c.Rows)
            {
                MessageBox.Show("Departamento mas concurrido: " + d[0].ToString());
            }
        }
    }
}