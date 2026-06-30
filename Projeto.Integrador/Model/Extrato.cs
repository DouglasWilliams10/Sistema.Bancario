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

        public double Valor { get; private set; }

        public double Saldo { get; private set; }

        public DateTime DataOperacao { get; private set; }

        public Extrato()
        {

        }

        public Extrato(int id,
                       int numeroConta,
                       string tipo,
                       double valor,
                       double saldo,
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
