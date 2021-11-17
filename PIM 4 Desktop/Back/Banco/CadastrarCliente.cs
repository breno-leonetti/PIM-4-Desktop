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
        private const string comandoSQL = "INSERT INTO Clientes(email, nome, cpf, cnh, datadenascimento, celular)" +
                " VALUES(@Email, @Nome, @CPF, @CNH, @Data, @Celular)";

        public override bool Executar(string valor)
        {
            try
            {
                SqlCommand command = new SqlCommand(comandoSQL, getConexao());
                command.Parameters.AddWithValue("@Email", Gerenciador.Cliente.Email);
                command.Parameters.AddWithValue("@Nome", Gerenciador.Cliente.Nome);
                command.Parameters.AddWithValue("@CPF", Gerenciador.Cliente.CPF);
                command.Parameters.AddWithValue("@CNH", Gerenciador.Cliente.NCarteiraHabilitacao);
                command.Parameters.AddWithValue("@Data", Gerenciador.Cliente.DataNascimento);
                command.Parameters.AddWithValue("@Celular", Gerenciador.Cliente.Telefone);
                command.ExecuteNonQuery();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
