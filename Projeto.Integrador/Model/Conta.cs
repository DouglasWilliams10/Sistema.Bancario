using System;

namespace Projeto.Integrador.Model
{
    public class Conta
    {
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public Usuario Titular { get; private set; }
        public DateTime? DataPrimeiroDeposito { get; private set; }

        public Conta()
        {
        }

        public Conta(int numeroConta, double saldo, Usuario titular, DateTime? dataPrimeiroDeposito = null)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
            Titular = titular;
            DataPrimeiroDeposito = dataPrimeiroDeposito;
        }

        public void Depositar(double valor)
        {
            if (DataPrimeiroDeposito == null)
                DataPrimeiroDeposito = DateTime.Now;
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
    }
}