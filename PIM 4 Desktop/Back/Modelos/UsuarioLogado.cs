using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Modelos
{
    public class UsuarioLogado
    {
        public int IdFuncionario { get; }
        public string Matricula { get; }
        public string Nome { get; }

        public UsuarioLogado(string matricula, string nome, int idFuncionario)
        {
            IdFuncionario = idFuncionario;
            Matricula = matricula;
            Nome = nome;
        }
    }
}
