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
                MessageBox.Show("Por favor, insira uma senha");
                return;
            }


            string cpfDigitado = txtUsuarioLogin.Text.Trim().ToUpper();
            string senhaDigitada = txtSenhaLogin.Text.Trim();
            Usuario usuarioEncontrado = usuarioDAO.BuscarUsuario(cpfDigitado, senhaDigitada);

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("CPF ou senha inválidos.");
                return;
            }

            Conta contaEncontrada = contaDAO.BuscarContaPorUsuario(usuarioEncontrado);

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
            FormLogin menu = new FormLogin();
            menu.Show();
            this.Hide();
        }

        private void txtUsuarioLogin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnVoltar_login_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //instancia da tela de Cadastro
            FormCadastro cadastro = new FormCadastro();
            cadastro.Show();

            //Esconde a tela
            this.Hide();
        }
    }
}