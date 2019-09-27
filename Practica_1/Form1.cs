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
            
            Persona x = new Persona(tb3.Text, tb1.Text, tb2.Text, dtp1.Value, num1.Value, num2.Value);
            p1.Add(x);
            MessageBox.Show("Datos insertados");
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            num1.Value = 0;
            num2.Value = 0;
        }
    }
}
