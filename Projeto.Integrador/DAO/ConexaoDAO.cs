using Microsoft.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Projeto.Integrador.DAO
{
    public class ConexaoDAO
    {
        public static SqlConnection ObterConexao()
        {
            string caminho = Path.Combine(
                Application.StartupPath,
                "DAO",
                "BD_Caixa.mdf"); 

            string conexao =
                $@"Data Source=(LocalDB)\MSSQLLocalDB;
                   AttachDbFilename={caminho};
                   Integrated Security=True;
                   Connect Timeout=30;
                   TrustServerCertificate=True;";

            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();

            return conn;
        }
    }
}