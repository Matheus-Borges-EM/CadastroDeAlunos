using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaNatacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblHojeEh.Text = "Hoje é " + DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan TsQuantidadeDeDias = DateTime.Now.Date - dtpNascimento.Value;
            int diferenca = TsQuantidadeDeDias.Days / 365;
            string categoria = null;
            if(txtNome.Text == string.Empty)
            {
                MessageBox.Show("POR FAVOR, PREENCHA TODOS OS CAMPOS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (diferenca >= 5 && diferenca <= 7)
                {
                    categoria = "INFANTIL A";
                }
                else if (diferenca >= 8 && diferenca <= 10)
                {
                    categoria = "INFANTIL B";
                }
                else if (diferenca >= 11 && diferenca <= 13)
                {
                    categoria = "JUVENIL A";
                }
                else if (diferenca >= 14 && diferenca <= 17)
                {
                    categoria = "JUVENIL B";
                }
                else if (diferenca >= 18)
                {
                    categoria = "ADULTO";
                }
                else if (diferenca < 5 && diferenca > 0)
                {
                    MessageBox.Show("NAO EXISTE CATEGORIA", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("A IDADE DE NASCIMENTO DEVE SER MENOR QUE A IDADE DE ULTIMO ANIVERSÁRIO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtCategoria.Text = categoria;
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
