using Projeto.Integrador.Controller;
using Projeto.Integrador.DAO;
using Projeto.Integrador.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Integrador.View
{
    public partial class FormCadastro : Form
    {
        UsuarioController usuarioDAO = new UsuarioController();
        ContaController contaDAO = new ContaController();

        public FormCadastro()
        {
            InitializeComponent();
        }

        private void lblUsuario_Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text.Trim()))
            {
                MessageBox.Show("Por favor Insira um Nome");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSobrenome.Text.Trim()))
            {
                MessageBox.Show("Por favor, Insira um Sobrenome");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text.Trim()))
            {
                MessageBox.Show("A senha é obrigatoria");
                return;
            }
            if (txtSenha.Text.Trim().Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.");
                return;
            }
            if (dtpDataNascimento.Value > DateTime.Now)
            {
                MessageBox.Show("Data de nascimento inválida.");
                return;
            }
            if (CalcularIdade(dtpDataNascimento.Value) < 18)
            {
                MessageBox.Show("É necessário ter pelo menos 18 anos para se cadastrar.");
                return;
            }

            if (txtConfirmarSenha.Text.Trim() != txtSenha.Text.Trim())
            {
                MessageBox.Show("As senhas não coincidem!");
                return;

            }
            if (!txtCPF.MaskCompleted)
            {
                MessageBox.Show("Por favor, preencha o CPF completo.");
                return;
            }
            if (!CpfIsValid(txtCPF.Text))
            {
                MessageBox.Show("CPF inválido.");
                return;
            }
            if (usuarioDAO.ExisteUsuario(txtCPF.Text))
            {
                MessageBox.Show("Já existe um usuário cadastrado com esse CPF.");
                return;
            }
            string senha = txtSenha.Text.Trim();
            string nome = txtNome.Text.Trim().ToUpper();
            string sobrenome = txtSobrenome.Text.Trim().ToUpper();
            string cpf = txtCPF.Text.Trim().Replace(".", "").Replace("-", "");
            DateTime dataNascimento = dtpDataNascimento.Value;

            Usuario usuario = new Usuario
                (
                 0,
                 nome,
                 sobrenome,
                 senha,
                 cpf,
                 dataNascimento
                 );
            usuarioDAO.CadastrarUsuario(usuario);
            Conta conta = new Conta(0, 0, usuario);
            contaDAO.CriarConta(conta);
            MessageBox.Show("Usuario Cadastrado com sucesso");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private bool CpfIsValid(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            // Bloqueia CPFs tipo 111.111.111-11, que passariam no cálculo mas não são válidos
            bool todosIguais = true;
            for (int i = 1; i < cpf.Length; i++)
            {
                if (cpf[i] != cpf[0])
                {
                    todosIguais = false;
                    break;
                }
            }
            if (todosIguais)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
        private int CalcularIdade(DateTime nascimento)
        {
            int idade = DateTime.Now.Year - nascimento.Year;
            if (nascimento.Date > DateTime.Now.AddYears(-idade))
                idade--;
            return idade;
        }

        private void btnVoltar_Cad_Click(object sender, EventArgs e)
        {
            FormLogin menu = new FormLogin();
            menu.Show();
            this.Hide();
        }
    }
}
