using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Form1 : Form
    {
        private List<string>lista = new List<string>();
        public static string nombre;
        delegate void delegateusuario();
        public Form1()
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
                delegateusuario d = new delegateusuario(empleado);
                d.Invoke();
            }
        }

        private void empleado()
        {
            var c = Conexion.ExecuteQuery($"select nombre from Usuario");

            foreach (DataRow d in c.Rows)
            {
                lista.Add(d[0].ToString());
            }

            if(lista.Contains(textBox1.Text))
            {
                nombre = textBox1.Text;
                MessageBox.Show("Bienvenido");
                Option option = new Option();
                option.Show();
            }

            else
            {
                MessageBox.Show("No esta inscrito");
            }
        }
    }
}