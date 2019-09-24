using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form3 : Form
    {
        List<Persona> p1;

        public Form3(List<Persona> p)
        {
            InitializeComponent();
            this.p1 = p;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            foreach (Persona p in p1)
            {
                tb1.Text += p.ToString();
            }
        }
    }
}
