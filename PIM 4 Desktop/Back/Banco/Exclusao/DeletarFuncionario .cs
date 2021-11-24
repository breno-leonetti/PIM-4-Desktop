using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class DeletarFuncionario : TarefaSQL<bool>
    {
        private const string comandoSQL = "DELETE FROM Funcionarios WHERE id_funcionario = @Id";

        public override bool Executar(string valor)
        {
            try
            {
                SqlCommand command = new SqlCommand(comandoSQL, getConexao());
                command.Parameters.AddWithValue("@Id", valor);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
