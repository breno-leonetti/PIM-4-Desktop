using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public abstract class TarefaSQL<T>
    {
        private const string conexaoString = @"Data Source=DESKTOP-NGTV0A3\SQLEXPRESS;Initial Catalog=BD_Alucar; Integrated Security=True;";
        private SqlConnection conexaoSql = new SqlConnection(conexaoString);

        protected SqlConnection getConexao()
        {
            conexaoSql.Open();
            return conexaoSql;
        }



        public abstract T Executar(string valor);
    }
}
