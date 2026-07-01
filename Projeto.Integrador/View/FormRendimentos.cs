using Projeto.Integrador.Model;
using System;
using System.Windows.Forms;

namespace Projeto.Integrador.View
{
    public partial class FormRendimentos : Form
    {
        private Conta _conta;
        private const double TAXA_MENSAL = 0.05; // 5% ao mês

        public FormRendimentos(Conta conta)
        {
            InitializeComponent();
            _conta = conta;
        }

        private void FormRendimentos_Load(object sender, EventArgs e)
        {
            if (_conta.DataPrimeiroDeposito == null)
            {
                MessageBox.Show("Nenhum depósito realizado ainda. Faça um depósito para começar a render.");
                this.Close();
                return;
            }

            // Configura colunas do grid
            dgvRendimentos.Columns.Clear();
            dgvRendimentos.Columns.Add("Data", "Data");
            dgvRendimentos.Columns.Add("Rendimento", "Rendimento do dia (R$)");
            dgvRendimentos.Columns.Add("Saldo", "Saldo com rendimento (R$)");
            dgvRendimentos.ReadOnly = true;
            dgvRendimentos.AllowUserToAddRows = false;

            // Taxa diária equivalente a 5% ao mês
            double taxaDiaria = Math.Pow(1 + TAXA_MENSAL, 1.0 / 30) - 1;

            DateTime dataInicio = _conta.DataPrimeiroDeposito.Value.Date;
            DateTime dataHoje = DateTime.Now.Date;

            double saldoSimulado = _conta.Saldo;
            double totalRendido = 0;

            for (DateTime dia = dataInicio; dia <= dataHoje; dia = dia.AddDays(1))
            {
                double rendimentoDia = saldoSimulado * taxaDiaria;
                saldoSimulado += rendimentoDia;
                totalRendido += rendimentoDia;

                dgvRendimentos.Rows.Add(
                    dia.ToString("dd/MM/yyyy"),
                    rendimentoDia.ToString("F2"),
                    saldoSimulado.ToString("F2")
                );
            }

            lblRendimentoTotal.Text = "Total rendido: R$ " + totalRendido.ToString("F2");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}