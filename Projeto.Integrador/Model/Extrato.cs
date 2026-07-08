using Microsoft.Data.SqlClient;
using Projeto.Integrador.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Integrador.Model
{
    public class Extrato
    {
        public int Id { get; private set; }

        public int NumeroConta { get; private set; }

        public string Tipo { get; private set; }

        public decimal Valor { get; private set; }

        public decimal Saldo { get; private set; }

        public DateTime DataOperacao { get; private set; }

        public Extrato()
        {
            Tipo = string.Empty;
        }

        public Extrato(int id,
                       int numeroConta,
                       string tipo,
                       decimal valor,
                       decimal saldo,
                       DateTime dataOperacao)
        {
            Id = id;
            NumeroConta = numeroConta;
            Tipo = tipo;
            Valor = valor;
            Saldo = saldo;
            DataOperacao = dataOperacao;
        }
    }

}
