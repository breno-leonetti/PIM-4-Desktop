using PIM_4_Desktop.Back.Modelos;
using PIM_4_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class CheckOut : TarefaSQL<bool>

    {

        public string FormaPagamento { get; }

        public CheckOut(string formaPagamento)
        {
            FormaPagamento = formaPagamento;
        }
        private const string comandoSQL = "DELETE FROM Checkin WHERE id_reserva = @IdReserva";
        private const string comandoSQL2 = "INSERT INTO Checkout(id_cliente, id_funcionario, id_veiculo, " +
            "data_checkout, valor_diaria, quantidade_diastotal, pagamento_total, formapagamento) " +
            "VALUES " +
            "(@IdCliente, @IdFuncionario, @IdVeiculo, @DataCheckout, @ValorDiaria, @QuantidadeDiasTotal, " +
            "@PagamentoTotal, @FormaPagamento)";

        public override bool Executar(string id)
        {
            try
            {
                Reserva reserva = new ConsultarReservaPeloId().Executar(id);
                SqlCommand command = new SqlCommand(comandoSQL, getConexao());
                command.Parameters.AddWithValue("@IdReserva", int.Parse(id));

                command.ExecuteNonQuery();

                command = new SqlCommand(comandoSQL2, getConexao());

                command.Parameters.AddWithValue("@IdCliente", reserva.Cliente.IdCliente);
                command.Parameters.AddWithValue("@IdFuncionario", Gerenciador.UsuarioLogado.IdFuncionario);
                command.Parameters.AddWithValue("@IdVeiculo", reserva.Veiculo.ID_carro);
                command.Parameters.AddWithValue("@DataCheckout", DateTime.Now);
                command.Parameters.AddWithValue("@ValorDiaria", reserva.ValorDiaria);
                int totalDias = (int)(DateTime.Now - reserva.DateTime).TotalDays;
                command.Parameters.AddWithValue("@QuantidadeDiasTotal", totalDias);
                command.Parameters.AddWithValue("@PagamentoTotal", reserva.ValorDiaria * totalDias);
                command.Parameters.AddWithValue("@FormaPagamento", FormaPagamento);

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
