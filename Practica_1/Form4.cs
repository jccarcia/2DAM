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
    public partial class Form4 : Form
    {
        List<Persona> p1;

        public Form4(List<Persona> p)
        {
            InitializeComponent();
            this.p1 = p;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "")
            {
                MessageBox.Show("no ha insertado datos");
            }
            else
            {
                foreach (Persona p in p1)
                {
                    if (p.Dni == tb1.Text)
                    {
                        tb2.Visible = true;
                        tb2.Text += p.ToString();
                    }
                }
            }

            tb1.Text = "";
            
        }

        private void Tb1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
