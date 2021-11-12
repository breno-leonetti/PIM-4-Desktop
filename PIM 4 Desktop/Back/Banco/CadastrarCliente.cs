using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class CadastrarCliente : TarefaSQL<bool>
    {
        private const string comandoSQL = "INSERT INTO ClientePF(Nome, CPF, CNH, Passaporte, DataNascimento)" +
                " VALUES(@Nome, @CPF, @CNH, @Passaporte, @Data)";

        public override bool Executar(string valor)
        {
            try
            {
                SqlCommand command = new SqlCommand(comandoSQL, getConexao());
                command.Parameters.AddWithValue("@Nome", Gerenciador.Cliente.Nome);
                command.Parameters.AddWithValue("@CPF", Gerenciador.Cliente.CPF);
                command.Parameters.AddWithValue("@CNH", Gerenciador.Cliente.NCarteiraHabilitacao);
                command.Parameters.AddWithValue("@Passaporte", "123");
                command.Parameters.AddWithValue("@Data", Gerenciador.Cliente.DataNascimento);
                command.ExecuteNonQuery();
                return true;
            }catch(Exception)
            {
                return false;
            }
        }
    }
}
