using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Integrador.Model
{
    public class Usuario
    {
        //atributos
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private  set; }
        public string Senha { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
       

        //Construtor vazio
        public Usuario()
        {
            Nome = string.Empty;
            Sobrenome = string.Empty;
            Senha = string.Empty;
            CPF = string.Empty;
        }
        //construtor completo
        public Usuario(int id, string nome, string sobrenome, string senha, string cpf, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Senha = senha;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }
         

    }
}

