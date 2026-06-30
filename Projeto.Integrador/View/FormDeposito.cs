using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Integrador.Controller;
using Projeto.Integrador.DAO;
using Projeto.Integrador.Model;

namespace Projeto.Integrador.View
{
    public partial class FormDeposito : Form
    {

        private Conta conta;

        private ContaController contaController = new ContaController();

        private ExtratoController extratoController = new ExtratoController();
        public FormDeposito(Conta conta)
        {
            InitializeComponent();
            this.conta = conta;
        }

        private void FormDeposito_Load(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            tmrDataHora.Start();

            txtDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDataHora_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        }

        private void txtDataHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
