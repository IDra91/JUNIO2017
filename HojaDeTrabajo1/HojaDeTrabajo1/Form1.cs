using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HojaDeTrabajo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metodos m = new Metodos();
            Txt4.Text =     m.hipotenusa(Int32.Parse(Txt1.Text), Int32.Parse(Txt2.Text)).ToString();
 
        }

        private void inverso_Click(object sender, EventArgs e)
        {
            Metodos m = new Metodos();
            Txt4.Text = m.reves(Txt1.Text, Txt2.Text); 
        }

        private void vocal_Click(object sender, EventArgs e)
        {
            Metodos m = new Metodos();
            Txt4.Text = m.vocales(Txt1.Text); 
        }

        private void regla_Click(object sender, EventArgs e)
        {
            Metodos m = new Metodos();
            Txt4.Text = m.regla(Int32.Parse(Txt1.Text), Int32.Parse(Txt2.Text), Int32.Parse(Txt3.Text)).ToString();
        }
    }
}
