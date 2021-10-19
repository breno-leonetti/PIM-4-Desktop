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
        protected int matricula;
        protected float SalarioBase;
        protected string Cargo;
        // *****conferir cargo como sera feito*******
        public Funcionario()
        {

        }
    }
}
