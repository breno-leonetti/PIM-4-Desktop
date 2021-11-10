using PIM_4_Desktop.Back.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class Autenticar : TarefaSQL<bool>
    {
        private string Senha;

        public Autenticar(string senha)
        {
            this.Senha = senha;
        }

        public override bool Executar(string matricula)
        {
            if(matricula.Equals(String.Empty) || Senha.Equals(String.Empty))
            {
                return false;
            }
            if (2 > 1) //Caso a consulta sql resulte
            {
                UsuarioLogado usuarioLogado = new UsuarioLogado(matricula, "João"); //Alterar para o nome recebido do SQL
                new Gerenciador().logarUsuario(usuarioLogado);
                return true;
            }
            return false;
        }
    }
}
