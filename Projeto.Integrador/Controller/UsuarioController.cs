using Microsoft.Data.SqlClient;
using Projeto.Integrador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Integrador.DAO
{
    internal class UsuarioController
    {
        public void CadastrarUsuario(Usuario usuario)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string sql = "INSERT INTO Usuario (Nome, Sobrenome, Senha, CPF, DataNascimento) " +
                             "VALUES (@Nome, @Sobrenome, @Senha, @CPF, @DataNascimento);" +
                             "SELECT SCOPE_IDENTITY();";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                comando.Parameters.AddWithValue("@Sobrenome", usuario.Sobrenome);
                comando.Parameters.AddWithValue("@Senha", GerarHashSenha(usuario.Senha));
                comando.Parameters.AddWithValue("@CPF", usuario.CPF);
                comando.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);

                int idGerado = Convert.ToInt32(comando.ExecuteScalar());
                usuario.Id = idGerado;
            }
        }

        public Usuario? BuscarUsuario(string cpf, string senha)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string cpfLimpo = cpf.Replace(".", "").Replace("-", "");

                string sql = "SELECT * FROM Usuario WHERE CPF = @CPF";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@CPF", cpfLimpo);

                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    string senhaSalva = leitor["Senha"].ToString() ?? string.Empty;

                    if (!SenhaConfere(senha, senhaSalva))
                        return null;

                    return new Usuario
                    (
                        Convert.ToInt32(leitor["Id"]),
                        leitor["Nome"].ToString() ?? string.Empty,
                        leitor["Sobrenome"].ToString() ?? string.Empty,
                        senhaSalva,
                        leitor["CPF"].ToString() ?? string.Empty,
                        Convert.ToDateTime(leitor["DataNascimento"])
                    );
                }

                return null;
            }
        }

        public bool ExisteUsuario(string cpf)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string cpfLimpo = cpf.Replace(".", "").Replace("-", "");

                string sql = "SELECT COUNT(*) FROM Usuario WHERE CPF = @CPF";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@CPF", cpfLimpo);

                int resultado = Convert.ToInt32(comando.ExecuteScalar());
                return resultado > 0;
            }
        }

        private static string GerarHashSenha(string senha)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(senha));
            return Convert.ToHexString(bytes);
        }

        private static bool SenhaConfere(string senhaDigitada, string senhaSalva)
        {
            string hashDigitado = GerarHashSenha(senhaDigitada);
            return string.Equals(hashDigitado, senhaSalva, StringComparison.OrdinalIgnoreCase)
                   || senhaDigitada == senhaSalva;
        }
    }
}
