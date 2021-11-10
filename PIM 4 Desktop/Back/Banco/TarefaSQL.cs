using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public abstract class TarefaSQL<T>
    {
        public const string sqlLogin = "root";
        public const string sqlSenha = "123456a";
        public const string instancia = "alucar";
        public const string endereco = "localhost";


        public abstract T Executar(String valor);
    }
}
