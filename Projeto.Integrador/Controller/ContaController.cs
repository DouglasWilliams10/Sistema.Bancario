using Microsoft.Data.SqlClient;
using Projeto.Integrador.DAO;
using Projeto.Integrador.Model;
using System;

namespace Projeto.Integrador.Controller
{
    internal class ContaController
    {
        public void CriarConta(Conta conta)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string sql = "INSERT INTO Conta (Saldo, UsuarioId) " +
                             "VALUES (@Saldo, @UsuarioId)";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Saldo", conta.Saldo);
                comando.Parameters.AddWithValue("@UsuarioId", conta.Titular.Id);

                comando.ExecuteNonQuery();
            }
        }

        public Conta? BuscarContaPorUsuario(Usuario usuario)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string sql = "SELECT * FROM Conta WHERE UsuarioId = @UsuarioId";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@UsuarioId", usuario.Id);

                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    DateTime? dataPrimeiroDeposito = null;
                    if (leitor["DataPrimeiroDeposito"] != DBNull.Value)
                        dataPrimeiroDeposito = Convert.ToDateTime(leitor["DataPrimeiroDeposito"]);

                    return new Conta(
                        Convert.ToInt32(leitor["NumeroConta"]),
                        Convert.ToDecimal(leitor["Saldo"]),
                        usuario,
                        dataPrimeiroDeposito
                    );
                }

                return null;
            }
        }

        public void AtualizarSaldo(Conta conta)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                AtualizarSaldo(conexao, null, conta.NumeroConta, conta.Saldo, conta.DataPrimeiroDeposito);
            }
        }

        public Conta? BuscarContaPorCPF(string cpf)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string cpfLimpo = cpf.Replace(".", "").Replace("-", "");

                string sql = "SELECT c.NumeroConta, c.Saldo, c.UsuarioId, c.DataPrimeiroDeposito, " +
                             "u.Nome, u.Sobrenome, u.CPF " +
                             "FROM Conta c " +
                             "INNER JOIN Usuario u ON c.UsuarioId = u.Id " +
                             "WHERE u.CPF = @CPF";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@CPF", cpfLimpo);

                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    DateTime? dataPrimeiroDeposito = null;
                    if (leitor["DataPrimeiroDeposito"] != DBNull.Value)
                        dataPrimeiroDeposito = Convert.ToDateTime(leitor["DataPrimeiroDeposito"]);

                    Usuario titular = new Usuario(
                        Convert.ToInt32(leitor["UsuarioId"]),
                        leitor["Nome"].ToString() ?? string.Empty,
                        leitor["Sobrenome"].ToString() ?? string.Empty,
                        string.Empty,
                        leitor["CPF"].ToString() ?? string.Empty,
                        DateTime.MinValue
                    );

                    return new Conta(
                        Convert.ToInt32(leitor["NumeroConta"]),
                        Convert.ToDecimal(leitor["Saldo"]),
                        titular,
                        dataPrimeiroDeposito
                    );
                }

                return null;
            }
        }

        public string? BuscarNomePorConta(int numeroConta)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string sql = "SELECT u.Nome, u.Sobrenome FROM Usuario u " +
                             "INNER JOIN Conta c ON u.Id = c.UsuarioId " +
                             "WHERE c.NumeroConta = @NumeroConta";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@NumeroConta", numeroConta);

                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                    return leitor["Nome"].ToString() + " " + leitor["Sobrenome"].ToString();

                return null;
            }
        }

        public void RegistrarDeposito(Conta conta, decimal valor)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            using (SqlTransaction transacao = conexao.BeginTransaction())
            {
                try
                {
                    DateTime dataOperacao = DateTime.Now;
                    DateTime? dataPrimeiroDeposito = conta.DataPrimeiroDeposito ?? dataOperacao;
                    decimal novoSaldo = conta.Saldo + valor;

                    AtualizarSaldo(conexao, transacao, conta.NumeroConta, novoSaldo, dataPrimeiroDeposito);
                    RegistrarExtrato(conexao, transacao, conta.NumeroConta, "Deposito", valor, novoSaldo, dataOperacao);

                    transacao.Commit();
                    conta.AtualizarDados(novoSaldo, dataPrimeiroDeposito);
                }
                catch
                {
                    transacao.Rollback();
                    throw;
                }
            }
        }

        public void RegistrarSaque(Conta conta, decimal valor)
        {
            if (valor > conta.Saldo)
                throw new InvalidOperationException("Saldo insuficiente.");

            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            using (SqlTransaction transacao = conexao.BeginTransaction())
            {
                try
                {
                    DateTime dataOperacao = DateTime.Now;
                    decimal novoSaldo = conta.Saldo - valor;

                    AtualizarSaldo(conexao, transacao, conta.NumeroConta, novoSaldo, conta.DataPrimeiroDeposito);
                    RegistrarExtrato(conexao, transacao, conta.NumeroConta, "Saque", valor, novoSaldo, dataOperacao);

                    transacao.Commit();
                    conta.AtualizarDados(novoSaldo, conta.DataPrimeiroDeposito);
                }
                catch
                {
                    transacao.Rollback();
                    throw;
                }
            }
        }

        public void RealizarTransferencia(Conta contaOrigem, Conta contaDestino, decimal valor, string nomeOrigem, string nomeDestino)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            using (SqlTransaction transacao = conexao.BeginTransaction())
            {
                try
                {
                    DateTime dataOperacao = DateTime.Now;
                    DadosConta dadosOrigem = BuscarDadosConta(conexao, transacao, contaOrigem.NumeroConta);
                    DadosConta dadosDestino = BuscarDadosConta(conexao, transacao, contaDestino.NumeroConta);

                    if (valor > dadosOrigem.Saldo)
                        throw new InvalidOperationException("Saldo insuficiente.");

                    decimal novoSaldoOrigem = dadosOrigem.Saldo - valor;
                    decimal novoSaldoDestino = dadosDestino.Saldo + valor;
                    DateTime? dataPrimeiroDepositoDestino = dadosDestino.DataPrimeiroDeposito ?? dataOperacao;

                    AtualizarSaldo(conexao, transacao, contaOrigem.NumeroConta, novoSaldoOrigem, dadosOrigem.DataPrimeiroDeposito);
                    AtualizarSaldo(conexao, transacao, contaDestino.NumeroConta, novoSaldoDestino, dataPrimeiroDepositoDestino);

                    RegistrarExtrato(conexao, transacao, contaOrigem.NumeroConta, "Transf. para " + nomeDestino, valor, novoSaldoOrigem, dataOperacao);
                    RegistrarExtrato(conexao, transacao, contaDestino.NumeroConta, "Transf. de " + nomeOrigem, valor, novoSaldoDestino, dataOperacao);

                    transacao.Commit();

                    contaOrigem.AtualizarDados(novoSaldoOrigem, dadosOrigem.DataPrimeiroDeposito);
                    contaDestino.AtualizarDados(novoSaldoDestino, dataPrimeiroDepositoDestino);
                }
                catch
                {
                    transacao.Rollback();
                    throw;
                }
            }
        }

        private static void AtualizarSaldo(SqlConnection conexao, SqlTransaction? transacao, int numeroConta, decimal saldo, DateTime? dataPrimeiroDeposito)
        {
            string sql = "UPDATE Conta SET Saldo = @Saldo, DataPrimeiroDeposito = @DataPrimeiroDeposito WHERE NumeroConta = @NumeroConta";

            using SqlCommand comando = new SqlCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@Saldo", saldo);
            comando.Parameters.AddWithValue("@NumeroConta", numeroConta);
            comando.Parameters.AddWithValue("@DataPrimeiroDeposito", dataPrimeiroDeposito ?? (object)DBNull.Value);
            comando.ExecuteNonQuery();
        }

        private static void RegistrarExtrato(SqlConnection conexao, SqlTransaction transacao, int numeroConta, string tipo, decimal valor, decimal saldo, DateTime dataOperacao)
        {
            string sql = @"INSERT INTO Extrato
                           (NumeroConta, Tipo, Valor, Saldo, DataOperacao)
                           VALUES
                           (@NumeroConta, @Tipo, @Valor, @Saldo, @DataOperacao)";

            using SqlCommand comando = new SqlCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@NumeroConta", numeroConta);
            comando.Parameters.AddWithValue("@Tipo", tipo);
            comando.Parameters.AddWithValue("@Valor", valor);
            comando.Parameters.AddWithValue("@Saldo", saldo);
            comando.Parameters.AddWithValue("@DataOperacao", dataOperacao);
            comando.ExecuteNonQuery();
        }

        private static DadosConta BuscarDadosConta(SqlConnection conexao, SqlTransaction transacao, int numeroConta)
        {
            string sql = "SELECT Saldo, DataPrimeiroDeposito FROM Conta WITH (UPDLOCK) WHERE NumeroConta = @NumeroConta";

            using SqlCommand comando = new SqlCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@NumeroConta", numeroConta);

            using SqlDataReader leitor = comando.ExecuteReader();
            if (!leitor.Read())
                throw new InvalidOperationException("Conta não encontrada.");

            DateTime? dataPrimeiroDeposito = null;
            if (leitor["DataPrimeiroDeposito"] != DBNull.Value)
                dataPrimeiroDeposito = Convert.ToDateTime(leitor["DataPrimeiroDeposito"]);

            return new DadosConta(Convert.ToDecimal(leitor["Saldo"]), dataPrimeiroDeposito);
        }

        private readonly struct DadosConta
        {
            public DadosConta(decimal saldo, DateTime? dataPrimeiroDeposito)
            {
                Saldo = saldo;
                DataPrimeiroDeposito = dataPrimeiroDeposito;
            }

            public decimal Saldo { get; }
            public DateTime? DataPrimeiroDeposito { get; }
        }
    }
}
