using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
{
    public class Pessoa
    {
        public string Nome;
        public string Email;
        public string Senha;
        public string Telefone;
        public int Id;
        public DateTime DataNascimento;

        /// <summary>
        /// Construtor Pessoa sera utilizado pelas classes cliente e funcionario
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <param name="telefone"></param>
        /// <param name="dataNascimento"></param>
        public Pessoa(string nome, string email, string senha, string telefone, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }
    }  
}
