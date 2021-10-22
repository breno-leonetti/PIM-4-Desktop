using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
{
    class Pessoa
    {
        public string Nome;
        public string Email;
        public string Senha;
        public long Telefone;
        public int Id;
        public DateTime DataNascimento;


        public Pessoa(string nome, string email, string senha, long telefone, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }
    }  
}
