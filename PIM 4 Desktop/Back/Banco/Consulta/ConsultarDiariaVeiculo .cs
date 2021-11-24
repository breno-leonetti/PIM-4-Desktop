using PIM_4_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class ConsultarDiariaVeiculo : TarefaSQL<decimal>
    {
        private const string comandoSQL = "SELECT valor_diaria " +
            "FROM Veiculos  " +
            "WHERE id_veiculo=@IdVeiculo";

        public override decimal Executar(string valor)
        {
            try
            {
                SqlCommand command = new SqlCommand(comandoSQL, getConexao());
                command.Parameters.AddWithValue("@IdVeiculo", int.Parse(valor));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetDecimal(0);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
            return 0;
        }
    }
}
