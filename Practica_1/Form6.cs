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
    public partial class Form6 : Form
    {
        List<Persona> p1;
        public Form6(List<Persona> p)
        {
            InitializeComponent();
            this.p1 = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String name = "a";
            foreach (Persona p in p1)
            {
                if (p.Nombre.Length > name.Length)
                {
                    name = p.Nombre;
                }
            }
            foreach (Persona p in p1)
            {
                if (p.Nombre.Equals(name))
                {
                    tb1.Text += p.ToString();
                }
            }

        }
    }
}
