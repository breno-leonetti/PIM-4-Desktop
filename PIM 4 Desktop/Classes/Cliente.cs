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
        /// 
        /// </summary>
        /// <param name="cpf"></param>
        /// <param name="ncarteiraHabilitacao"></param>
        /// <param name="Nome"></param>
        
 
        public Cliente(string nome, string email, string senha, long telefone, DateTime dataNascimento, long cpf, int ncarteiraHabilitacao) : base(nome, email, senha, telefone,dataNascimento)
        {
            
            NCarteiraHabilitacao = ncarteiraHabilitacao;
            CPF = cpf;
           

        }
    }
}
