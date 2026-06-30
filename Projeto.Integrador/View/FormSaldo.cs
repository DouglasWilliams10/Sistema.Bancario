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
            // implementar depois
        }
    }
}