using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class ListaFuncionarios : TarefaSQL<DataTable>
    {
        private const string comandoSQL = "SELECT * FROM Funcionarios";

        public override DataTable Executar(string valor)
        {
            SqlCommand sqlCommand = new SqlCommand(comandoSQL, getConexao());

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
