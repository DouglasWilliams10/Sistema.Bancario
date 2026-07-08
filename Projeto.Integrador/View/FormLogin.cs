using Projeto.Integrador.Controller;
using Projeto.Integrador.DAO;
using Projeto.Integrador.Model;
using System;
using System.Windows.Forms;

namespace Projeto.Integrador.View
{
    public partial class FormLogin : Form
    {
        UsuarioController usuarioDAO = new UsuarioController();
        ContaController contaDAO = new ContaController();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_login_Click(object sender, EventArgs e)
        {
            if (!txtUsuarioLogin.MaskCompleted)
            {
                MessageBox.Show("Por favor, preencha o CPF completo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenhaLogin.Text.Trim()))
            {
                MessageBox.Show("Por favor, insira uma senha.");
                return;
            }

            string cpfDigitado = txtUsuarioLogin.Text.Trim();
            string senhaDigitada = txtSenhaLogin.Text.Trim();

            Usuario? usuarioEncontrado = usuarioDAO.BuscarUsuario(cpfDigitado, senhaDigitada);

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("CPF ou senha inválidos.");
                return;
            }

            Conta? contaEncontrada = contaDAO.BuscarContaPorUsuario(usuarioEncontrado);

            if (contaEncontrada == null)
            {
                MessageBox.Show("Conta não encontrada para este usuário.");
                return;
            }

            FormSaldo formSaldo = new FormSaldo(contaEncontrada);
            formSaldo.Show();
            this.Hide();
        }

        private void btnVoltar_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuarioLogin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void btnVoltar_login_Click_1(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            cadastro.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtSenhaLogin_TextChanged(object sender, EventArgs e)
        {
        }
        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
