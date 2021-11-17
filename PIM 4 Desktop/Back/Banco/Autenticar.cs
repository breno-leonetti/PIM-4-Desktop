using PIM_4_Desktop.Back.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class Autenticar : TarefaSQL<bool>
    {
        private const string comandoSQL = "SELECT nome, senha from Funcionarios" +
                " where matricula=@matricula";
        private string Senha;

        public Autenticar(string senha)
        {
            this.Senha = senha;
        }

        public override bool Executar(string matricula)
        {
            if (matricula.Equals(String.Empty) || Senha.Equals(String.Empty))
            {
                return false;
            }
            SqlCommand command = new SqlCommand(comandoSQL, getConexao());
            command.Parameters.AddWithValue("@matricula", matricula);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (Senha.Equals(reader.GetString(1)))
                {
                    UsuarioLogado usuarioLogado = new UsuarioLogado(matricula, reader.GetString(0));
                    new Gerenciador().logarUsuario(usuarioLogado);
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
