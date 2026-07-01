using Microsoft.Data.SqlClient;
using Projeto.Integrador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
                comando.Parameters.AddWithValue("@Senha", usuario.Senha);
                comando.Parameters.AddWithValue("@CPF", usuario.CPF);
                comando.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);

                int idGerado = Convert.ToInt32(comando.ExecuteScalar());
                usuario.Id = idGerado;
            }
        }

        public Usuario BuscarUsuario(string cpf, string senha)
        {
            using (SqlConnection conexao = ConexaoDAO.ObterConexao())
            {
                string cpfLimpo = cpf.Replace(".", "").Replace("-", "");

                string sql = "SELECT * FROM Usuario WHERE CPF = @CPF AND Senha = @Senha";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@CPF", cpfLimpo);
                comando.Parameters.AddWithValue("@Senha", senha);

                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    return new Usuario
                    (
                        Convert.ToInt32(leitor["Id"]),
                        leitor["Nome"].ToString(),
                        leitor["Sobrenome"].ToString(),
                        leitor["Senha"].ToString(),
                        leitor["CPF"].ToString(),
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

       
    }
}
