using Microsoft.VisualBasic;
using Projeto.Integrador.Controller;
using Projeto.Integrador.DAO;
using Projeto.Integrador.Model;
using System;
using System.Windows.Forms;

namespace Projeto.Integrador.View
{
    public partial class FormSaldo : Form
    {
        private Conta _conta;
        private ContaController contaDAO = new ContaController();
        public FormSaldo(Conta conta)
        {
            InitializeComponent();
            _conta = conta;
        }

        private void FormSaldo_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = "Saldo em conta: R$ " + _conta.Saldo.ToString("F2");
            lblBemVindo.Text = "Bem-vindo, " + _conta.Titular.Nome + " " + _conta.Titular.Sobrenome + "!";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            string valorDigitado = Interaction.InputBox(
                "Digite o valor a depositar:",
                "Depósito",
                "0"
            );

            if (string.IsNullOrWhiteSpace(valorDigitado))
                return;

            decimal valor;
            if (!decimal.TryParse(valorDigitado, out valor))
            {
                MessageBox.Show("Valor inválido. Digite um número.");
                return;
            }

            if (valor <= 0)
            {
                MessageBox.Show("O valor do depósito deve ser maior que zero.");
                return;
            }

            contaDAO.RegistrarDeposito(_conta, valor);

            lblSaldo.Text = "Saldo em conta: R$ " + _conta.Saldo.ToString("F2");
            MessageBox.Show("Depósito de R$ " + valor.ToString("F2") + " realizado com sucesso!");
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            string valorDigitado = Interaction.InputBox(
                "Digite o valor a sacar:",
                "Saque",
                "0"
            );

            if (string.IsNullOrWhiteSpace(valorDigitado))
                return;

            decimal valor;
            if (!decimal.TryParse(valorDigitado, out valor))
            {
                MessageBox.Show("Valor inválido. Digite um número.");
                return;
            }

            if (valor <= 0)
            {
                MessageBox.Show("O valor do saque deve ser maior que zero.");
                return;
            }

            if (valor > _conta.Saldo)
            {
                MessageBox.Show("Saldo insuficiente.");
                return;
            }

            contaDAO.RegistrarSaque(_conta, valor);

            lblSaldo.Text = "Saldo em conta: R$ " + _conta.Saldo.ToString("F2");
            MessageBox.Show("Saque de R$ " + valor.ToString("F2") + " realizado com sucesso!");
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            FormExtrato formExtrato = new FormExtrato(_conta.NumeroConta);
            formExtrato.ShowDialog();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            string cpfDestino = Interaction.InputBox(
                "Digite o CPF da conta destino:",
                "Transferência",
                ""
            );

            if (string.IsNullOrWhiteSpace(cpfDestino))
                return;

            string cpfDestinoLimpo = cpfDestino.Replace(".", "").Replace("-", "");
            string cpfOrigemLimpo = _conta.Titular.CPF.Replace(".", "").Replace("-", "");

            if (cpfDestinoLimpo == cpfOrigemLimpo)
            {
                MessageBox.Show("Você não pode transferir para sua própria conta.");
                return;
            }

            Conta? contaDestino = contaDAO.BuscarContaPorCPF(cpfDestino);

            if (contaDestino == null)
            {
                MessageBox.Show("Conta destino não encontrada.");
                return;
            }

            // Busca o nome do destinatário
            string nomeDestino = contaDAO.BuscarNomePorConta(contaDestino.NumeroConta) ?? "destinatário";

            // Confirma com o usuário antes de transferir
            DialogResult confirmacao = MessageBox.Show(
                "Transferir para: " + nomeDestino + "\nConfirma?",
                "Confirmar Transferência",
                MessageBoxButtons.YesNo
            );

            if (confirmacao == DialogResult.No)
                return;

            string valorDigitado = Interaction.InputBox(
                "Digite o valor a transferir para " + nomeDestino + ":",
                "Transferência",
                "0"
            );

            if (string.IsNullOrWhiteSpace(valorDigitado))
                return;

            decimal valor;
            if (!decimal.TryParse(valorDigitado, out valor))
            {
                MessageBox.Show("Valor inválido. Digite um número.");
                return;
            }

            if (valor <= 0)
            {
                MessageBox.Show("O valor da transferência deve ser maior que zero.");
                return;
            }

            if (valor > _conta.Saldo)
            {
                MessageBox.Show("Saldo insuficiente.");
                return;
            }

            string nomeOrigem = _conta.Titular.Nome + " " + _conta.Titular.Sobrenome;

            contaDAO.RealizarTransferencia(_conta, contaDestino, valor, nomeOrigem, nomeDestino);

            lblSaldo.Text = "Saldo em conta: R$ " + _conta.Saldo.ToString("F2");
            MessageBox.Show("Transferência de R$ " + valor.ToString("F2") +
                          " realizada com sucesso para " + nomeDestino + "!");

        }

        private void btnRendimentos_Click(object sender, EventArgs e)
        {
            FormRendimentos formRendimentos = new FormRendimentos(_conta);
            formRendimentos.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }
        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
