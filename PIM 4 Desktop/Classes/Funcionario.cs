using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
    
{
    class Funcionario : Pessoa
    {
        protected long RG;
        protected long CPF;
        protected int Matricula;
        protected float SalarioBase;
        protected string Cargo;
        // *****conferir cargo como sera feito*******

        public Funcionario(string nome, string email, string senha, long telefone, DateTime dataNascimento, long rg, long cpf, int matricula, float salariobase) 
            : base(nome, email, senha, telefone, dataNascimento)
        {
            RG = rg;
            CPF = cpf;
            Matricula = matricula;
            SalarioBase = salariobase;
        }
    }
}
