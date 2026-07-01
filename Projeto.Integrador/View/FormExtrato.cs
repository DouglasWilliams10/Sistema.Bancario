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
    public partial class FormExtrato : Form
    {
        private int _numeroConta;
        private ExtratoController extratoController = new ExtratoController();

        public FormExtrato(int numeroConta)
        {
            InitializeComponent();
            _numeroConta = numeroConta;
        }
        private void FormExtrato_Load(object sender, EventArgs e)
        {
            dgvExtrato.Columns.Clear();
            dgvExtrato.Columns.Add("Tipo", "Tipo");
            dgvExtrato.Columns.Add("Valor", "Valor (R$)");
            dgvExtrato.Columns.Add("Saldo", "Saldo (R$)");
            dgvExtrato.Columns.Add("Data", "Data/Hora");

            List<Extrato> extratos = extratoController.BuscarExtrato(_numeroConta);

            foreach (Extrato extrato in extratos)
            {
                dgvExtrato.Rows.Add(
                    extrato.Tipo,
                    extrato.Valor.ToString("F2"),
                    extrato.Saldo.ToString("F2"),
                    extrato.DataOperacao.ToString("dd/MM/yyyy HH:mm")
                );
            }
            dgvExtrato.ReadOnly = true;
            dgvExtrato.AllowUserToAddRows = false;


        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }

}
