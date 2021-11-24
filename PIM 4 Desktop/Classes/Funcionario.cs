using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
    
{
    public class Funcionario : Pessoa
    {
        public string RG;
        public string CPF;
        public int Matricula;
        public decimal SalarioBase;
        public string Cargo;
        public string Celular;
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
        public Funcionario(string nome, string email, string senha, string celular, string telefone, DateTime dataNascimento, string rg, string cpf, int matricula, decimal salariobase,  string cargo) 
            : base(nome, email, senha, telefone, dataNascimento)
        {
            RG = rg;
            CPF = cpf;
            Matricula = matricula;
            SalarioBase = salariobase;
            Cargo = cargo;
            Celular = celular;
        }
    }
}
