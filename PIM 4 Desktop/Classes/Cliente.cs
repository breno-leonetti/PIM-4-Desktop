using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
{
    public class Cliente : Pessoa
    {
        public string NCarteiraHabilitacao;
        public string CPF;

       

        /// <summary>
        /// construtor para cadastro de clientes
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <param name="telefone"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="cpf">pode ser substituido por passaport </param>
        /// <param name="ncarteiraHabilitacao"></param>
        public Cliente(string nome, string email, string senha, string telefone, DateTime dataNascimento, string cpf, string ncarteiraHabilitacao) : base(nome, email, senha, telefone,dataNascimento)
        {
            
            NCarteiraHabilitacao = ncarteiraHabilitacao;
            CPF = cpf;

        }

    }
}
