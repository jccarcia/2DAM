using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        List<Persona> p1;

        public Form1(List<Persona> p)
        {
            InitializeComponent();
            this.p1 = p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //int x = 0;
            Persona x = new Persona(tb3.Text, tb1.Text, tb2.Text, dtp1.Value, tb5.Text, tb6.Text);
            p1.Add(x);
            MessageBox.Show("Datos insertados");
            //x = x + 1;
        }
    }
}
