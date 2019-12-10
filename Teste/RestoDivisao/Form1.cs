using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDivisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(txt1.Text);
            int divisor = Convert.ToInt32(txt2.Text);
            int resto = dividendo % divisor;
            txtres.Text = resto.ToString();
            MessageBox.Show("Seu resultado esta pronto", "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
