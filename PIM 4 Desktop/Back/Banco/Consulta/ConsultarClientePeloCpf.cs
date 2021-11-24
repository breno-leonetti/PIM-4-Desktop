using PIM_4_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco.Consulta
{
    public class ConsultarClientePeloCpf : TarefaSQL<Cliente>
    {
        private const string comandoSQL = "SELECT id_cliente, nome, email " +
            "FROM Clientes  " +
            "WHERE cpf=@CPF";

        public override Cliente Executar(string valor)
        {
            try
            {
                SqlCommand command = new SqlCommand(comandoSQL, getConexao());
                command.Parameters.AddWithValue("@CPF", valor);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Cliente cliente = new Cliente(reader.GetString(1), reader.GetString(2), reader.GetInt32(0));
                    return cliente;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            return null;
        }
    }
}
