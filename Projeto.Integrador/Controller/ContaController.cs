using Microsoft.Data.SqlClient;
using Projeto.Integrador.DAO;
using Projeto.Integrador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Conta BuscarContaPorUsuario(Usuario usuario)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string sql = "SELECT * FROM Conta WHERE UsuarioId = @UsuarioId";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@UsuarioId", usuario.Id);

                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    return new Conta
                    (
                        Convert.ToInt32(leitor["NumeroConta"]),
                        Convert.ToDouble(leitor["Saldo"]),
                        usuario
                    );
                }

                return null;
            }
        }

        public void AtualizarSaldo(Conta conta)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string sql = "UPDATE Conta SET Saldo = @Saldo " +
                             "WHERE NumeroConta = @NumeroConta";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Saldo", conta.Saldo);
                comando.Parameters.AddWithValue("@NumeroConta", conta.NumeroConta);

                comando.ExecuteNonQuery();
            }
        }

        public Conta BuscarContaPorCPF(string cpf)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string cpfLimpo = cpf.Replace(".", "").Replace("-", "");

                string sql = "SELECT c.NumeroConta, c.Saldo, c.UsuarioId " +
                             "FROM Conta c " +
                             "INNER JOIN Usuario u ON c.UsuarioId = u.Id " +
                             "WHERE u.CPF = @CPF";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@CPF", cpfLimpo);

                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    Usuario titular = new Usuario(
                        Convert.ToInt32(leitor["UsuarioId"]),
                        "", "", "", "", DateTime.MinValue
                    );

                    return new Conta(
                        Convert.ToInt32(leitor["NumeroConta"]),
                        Convert.ToDouble(leitor["Saldo"]),
                        titular
                    );
                }

                return null;
            }
        }
    }
    }
