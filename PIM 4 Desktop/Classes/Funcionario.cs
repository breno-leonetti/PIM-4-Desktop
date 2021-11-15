using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
    
{
    class Funcionario : Pessoa
    {
        protected string RG;
        protected string CPF;
        protected int Matricula;
        protected float SalarioBase;
        protected string Cargo;
        protected Endereco Endereco;
        // *****conferir cargo como sera feito*******


        /// <summary>
        /// Construtor funcionario para cadastro
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <param name="telefone"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="rg"></param>
        /// <param name="cpf"></param>
        /// <param name="matricula">sera gerado pelo sistema???</param>
        /// <param name="salariobase"></param>
        /// <param name="endereco">deve ser chamado o construtor de Endereco</param>
        /// 
        public Funcionario(string nome, string email, string senha, string telefone, DateTime dataNascimento, string rg, string cpf, int matricula, float salariobase, Endereco endereco, string cargo) 
            : base(nome, email, senha, telefone, dataNascimento)
        {
            RG = rg;
            CPF = cpf;
            Matricula = matricula;
            SalarioBase = salariobase;
            Endereco = endereco;
            Cargo = cargo;
        }
    }
}
