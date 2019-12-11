using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteAvancado
{
    public partial class Form1 : Form
    {
        private IList<Leitura> leituras = new BindingList<Leitura>();
        private BindingSource leituraSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            leituraSource.DataSource = leituras;
            dgvLeituras.DataSource = leituraSource;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistraConsumo(txtNumeroCasa.Text, Convert.ToDouble(txtConsumo.Text));
        }
        private void RegistraConsumo(string casa, double consumo)
        {
            Leitura leitura = new Leitura(casa, consumo);
            if(leituras.Contains(leitura))
            {
                MessageBox.Show("A leitura para esta casa já foi feita", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                this.leituras.Add(leitura);
                InicializaFormulario();
            }

        }
        private void InicializaFormulario()
        {
            txtNumeroCasa.Clear();
            txtConsumo.Clear();
            txtNumeroCasa.Focus();
        }

        private void btnProcessarDados_Click(object sender, EventArgs e)
        {
            ProcessarLeituras(dgvLeituras);
        }
        private void ProcessarLeituras(DataGridView dgv)
        {
            DataGridViewCell cell = dgvLeituras.Rows[0].Cells[0];
            this.leituras.Add(new Leitura("Total", 0));
            for (int i = 0; i < 3; i++)
            {
                dgv.Rows[dgv.Rows.Count - 1].Cells[i].Style.BackColor = Color.Aquamarine;
                dgv.Rows[dgv.Rows.Count - 1].Cells[i].Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Regular);
                dgv.Rows[dgv.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Red;
            }
            var totalConsumo = new double();
            var totalDesconto = new double();

            foreach (var leitura in leituras)
            {
                totalConsumo += leitura.Consumo;
                totalDesconto += leitura.Desconto;
            }
            dgv[0, dgv.Rows.Count - 1].Value = "Total";
            dgv[1, dgv.Rows.Count - 1].Value = totalConsumo.ToString("N");
            dgv[2, dgv.Rows.Count - 1].Value = totalDesconto.ToString("N");

            lblTotal.Text = "Total consumo sem desconto: " + (totalConsumo - totalDesconto).ToString("N");
        }
    }
}
