using PIM_4_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco.Cadastro
{
    public class CadastrarReserva : TarefaSQL<int>
    {

        private const string comandoSQL = "INSERT INTO Reservas(id_cliente, Id_funcionario, id_veiculo, data_reserva, data_devolucaoprevista, valor_diaria, quantidade_diasprevistos, valor_previsto) " +
                "VALUES(@IdCliente, @IdFuncionario, @IdVeiculo, @DataReserva, @DataDevolucao, @ValorDiaria, @Dias, @ValorPrevisto); SELECT SCOPE_IDENTITY();";

        private Cliente Cliente;
        private int Dias;
        private decimal Diaria;
        private decimal ValorPrevisto;
        private DateTime DataReserva;
        private DateTime DataDevolucao;

        public CadastrarReserva(Cliente cliente, DateTime dataReserva, DateTime dataDevolucao, double dias, decimal diaria, decimal valorPrevisto)
        {
            Cliente = cliente;
            Dias = (int) dias;
            Diaria = diaria;
            DataReserva = dataReserva;
            DataDevolucao = dataDevolucao;
            ValorPrevisto = valorPrevisto;
        }

        public override int Executar(string idVeiculo)
        {
            try
            {
                SqlCommand command = new SqlCommand(comandoSQL, getConexao());
                command.Parameters.AddWithValue("@IdCliente", Cliente.IdCliente);
                command.Parameters.AddWithValue("@IdFuncionario", Gerenciador.UsuarioLogado.IdFuncionario);
                command.Parameters.AddWithValue("@IdVeiculo", int.Parse(idVeiculo));
                command.Parameters.AddWithValue("@DataReserva", DataReserva);
                command.Parameters.AddWithValue("@DataDevolucao", DataDevolucao);
                command.Parameters.AddWithValue("@ValorDiaria", Diaria);
                command.Parameters.AddWithValue("@Dias", Dias);
                command.Parameters.AddWithValue("@ValorPrevisto", ValorPrevisto);
                int modified = Convert.ToInt32(command.ExecuteScalar());
                return modified;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
    }
}
