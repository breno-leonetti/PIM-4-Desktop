using PIM_4_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class CheckIn : TarefaSQL<bool>

    {
        
        private const string comandoSQL = "INSERT INTO Checkin(id_cliente, id_funcionario, id_veiculo, id_reserva, data_checkin) " +
            "VALUES " +
            "(@IdCliente, @IdFuncionario, @IdVeiculo, @IdReserva, @DataCheckin)";

        public override bool Executar(string id)
        {
            try
            {
                Reserva reserva = new ConsultarReservaPeloId().Executar(id);
                SqlCommand command = new SqlCommand(comandoSQL, getConexao());

                command = new SqlCommand(comandoSQL, getConexao());

                command.Parameters.AddWithValue("@IdCliente", reserva.Cliente.IdCliente);
                command.Parameters.AddWithValue("@IdFuncionario", Gerenciador.UsuarioLogado.IdFuncionario);
                command.Parameters.AddWithValue("@IdVeiculo", reserva.Veiculo.ID_carro);
                command.Parameters.AddWithValue("@IdReserva", reserva.IdReserva);
                command.Parameters.AddWithValue("@DataCheckin", DateTime.Now);

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
