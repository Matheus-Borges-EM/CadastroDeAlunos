using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaSalario
{

    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lbxMostrar.Items.Clear();
            var salarioMinimo = new double();
            var horasTrabalhadas = new int();
            var salarioBruto = new double();
            var salarioLiquido = new double();
            var porcentagemSalarioMinimo = new double();
            var valorImposto = new double();
            var valorGratificacao = new int();
            var valorValeAlimentacao = new double();
            var valorCoeficiente = new double();

            salarioMinimo = Convert.ToDouble(txtSalarioMinimo.Text);
            horasTrabalhadas = Convert.ToInt32(txtHorasTrabalhadas.Text);

            RadioButton rbtTurno = gbxTurno.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            RadioButton rbnCategoria = gbxCategoria.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            
            if(rbtTurno.Text.Equals("Matutino"))
            {
                porcentagemSalarioMinimo = 0.01;
            }
            else if (rbtTurno.Text.Equals("Vespertino"))
            {
                porcentagemSalarioMinimo = 0.02;
            }
            else
            {
                porcentagemSalarioMinimo = 0.03;
            }
            valorCoeficiente = salarioMinimo * porcentagemSalarioMinimo;
            salarioBruto = valorCoeficiente * horasTrabalhadas;

            if(rbnCategoria.Text.Equals("Calouro"))
            {
                if (salarioBruto < 300)
                {
                    valorImposto = (salarioBruto * 0.01);
                }
                else
                {
                    valorImposto = (salarioBruto * 0.02);
                }
            }
            else
            {
                if(salarioBruto < 400)
                {
                    valorImposto = (salarioBruto * 0.03);
                }
                else
                {
                    valorImposto = (salarioBruto * 0.04);
                }
            }
            salarioLiquido = salarioBruto - valorImposto;


            if (rbtTurno.Text.Equals("Noturno") && horasTrabalhadas > 80)
            {
                valorGratificacao = 50;
            }
            else
            {
                valorGratificacao = 30;
            }
            salarioLiquido += valorGratificacao;

            if(rbnCategoria.Text.Equals("Calouro") && salarioBruto < (salarioMinimo / 2))
            {
                valorValeAlimentacao = salarioBruto / 3;
            }
            else
            {
                valorValeAlimentacao = salarioBruto / 6;
            }
            salarioLiquido += valorValeAlimentacao;

            if(salarioLiquido < 350)
            {
                txtRemuneracao.Text = "MAL REMUNERADO";
            }
            else if (salarioLiquido < 600)
            {
                txtRemuneracao.Text = "NORMAL";
            }
            else
            {
                txtRemuneracao.Text = "BEM REMUNERADO";
            }

            lbxMostrar.Items.Add(string.Format("{0,-29}{1,12:C}", "Valor do coeficiente: ", valorCoeficiente));
            lbxMostrar.Items.Add(string.Format("{0,-29}{1,12:C}", "Salário bruto: ", salarioBruto));
            lbxMostrar.Items.Add(string.Format("{0,-29}{1,12:C}", "Valor do imposto: ", valorImposto));
            lbxMostrar.Items.Add(string.Format("{0,-29}{1,12:C}", "Valor da gratificação: ", valorGratificacao));
            lbxMostrar.Items.Add(string.Format("{0,-29}{1,12:C}", "Valor do auxílio alimentação: ", valorValeAlimentacao));
            lbxMostrar.Items.Add(string.Format("{0,-29}{1,12:C}", "salário líquido: ", salarioLiquido));


        }

        private void lbxMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
