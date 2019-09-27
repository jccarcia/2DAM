using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form5 : Form
    {
        List<Persona> p1;

        public Form5(List<Persona> p)
        {
            InitializeComponent();
            this.p1 = p;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            decimal ex = 0;
            foreach (Persona p in p1)
            {
                if (p.Altura > ex)
                {
                    ex = p.Altura;
                }
            }
            foreach (Persona p in p1)
            {
                if (p.Altura == ex)
                {
                    tb1.Text += p.ToString();
                }
            }
        }
    }
}
