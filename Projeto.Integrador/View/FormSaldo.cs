using Microsoft.VisualBasic;
using Projeto.Integrador.Controller;
using Projeto.Integrador.DAO;
using Projeto.Integrador.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Integrador.View
{
    public partial class FormSaldo : Form
    {
        private Conta _conta;
        private ContaController contaDAO = new ContaController();
        private ExtratoController extratoDAO = new ExtratoController();

        public FormSaldo(Conta conta)
        {
            InitializeComponent();
            _conta = conta;
        }

        private void FormSaldo_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = "Saldo: R$ " + _conta.Saldo.ToString("F2");
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

            double valor;
            if (!double.TryParse(valorDigitado, out valor))
            {
                MessageBox.Show("Valor inválido. Digite um número.");
                return;
            }

            if (valor <= 0)
            {
                MessageBox.Show("O valor do depósito deve ser maior que zero.");
                return;
            }

            _conta.Depositar(valor);
            contaDAO.AtualizarSaldo(_conta);

            Extrato extrato = new Extrato(0, _conta.NumeroConta, "Deposito", valor, _conta.Saldo, DateTime.Now);
            extratoDAO.RegistrarOperacao(extrato);

            lblSaldo.Text = "Saldo: R$ " + _conta.Saldo.ToString("F2");
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

            double valor;
            if (!double.TryParse(valorDigitado, out valor))
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

            _conta.Sacar(valor);
            contaDAO.AtualizarSaldo(_conta);

            Extrato extrato = new Extrato(0, _conta.NumeroConta, "Saque", valor, _conta.Saldo, DateTime.Now);
            extratoDAO.RegistrarOperacao(extrato);

            lblSaldo.Text = "Saldo: R$ " + _conta.Saldo.ToString("F2");
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

            // Verifica se não está transferindo pra si mesmo
            string cpfDestinoLimpo = cpfDestino.Replace(".", "").Replace("-", "");
            string cpfOrigemLimpo = _conta.Titular.CPF.Replace(".", "").Replace("-", "");

            if (cpfDestinoLimpo == cpfOrigemLimpo)
            {
                MessageBox.Show("Você não pode transferir para sua própria conta.");
                return;
            }

            // Busca a conta destino
            Conta contaDestino = contaDAO.BuscarContaPorCPF(cpfDestino);

            if (contaDestino == null)
            {
                MessageBox.Show("Conta destino não encontrada.");
                return;
            }

            // Pede o valor
            string valorDigitado = Interaction.InputBox(
                "Digite o valor a transferir:",
                "Transferência",
                "0"
            );

            if (string.IsNullOrWhiteSpace(valorDigitado))
                return;

            double valor;
            if (!double.TryParse(valorDigitado, out valor))
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

            // Realiza a transferência
            _conta.Sacar(valor);
            contaDAO.AtualizarSaldo(_conta);

            contaDestino.Depositar(valor);
            contaDAO.AtualizarSaldo(contaDestino);

            // Registra no extrato de quem enviou
            Extrato extratoOrigem = new Extrato(
                0, _conta.NumeroConta, "Transferencia Enviada", valor, _conta.Saldo, DateTime.Now
            );
            extratoDAO.RegistrarOperacao(extratoOrigem);

            // Registra no extrato de quem recebeu
            Extrato extratoDestino = new Extrato(
                0, contaDestino.NumeroConta, "Transferencia Recebida", valor, contaDestino.Saldo, DateTime.Now
            );
            extratoDAO.RegistrarOperacao(extratoDestino);

            lblSaldo.Text = "Saldo: R$ " + _conta.Saldo.ToString("F2");
            MessageBox.Show("Transferência de R$ " + valor.ToString("F2") + " realizada com sucesso!");
        }
    }
}