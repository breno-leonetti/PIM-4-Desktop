using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
{
    class Cliente : Pessoa
    {
        public int NCarteiraHabilitacao;
        public long CPF;

       

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
        public Cliente(string nome, string email, string senha, long telefone, DateTime dataNascimento, long cpf, int ncarteiraHabilitacao) : base(nome, email, senha, telefone,dataNascimento)
        {
            
            NCarteiraHabilitacao = ncarteiraHabilitacao;
            CPF = cpf;

        }

    }
}
