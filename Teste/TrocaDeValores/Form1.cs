using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string auxiliar = txt1.Text;
            txt1.Text = txt2.Text;
            txt2.Text = auxiliar;
            MessageBox.Show("Troca de valores concluída", "cabeçalho", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

    }
}
