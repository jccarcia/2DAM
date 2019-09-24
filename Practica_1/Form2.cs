using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practica_1
{

    public partial class Form2 : Form
    {
        List<Persona> p1 = new List<Persona>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1(p1);
            formulario.Show();
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            Form3 formulario = new Form3(p1);
            formulario.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form4 formulario = new Form4(p1);
            formulario.Show();
        }
    }
}
