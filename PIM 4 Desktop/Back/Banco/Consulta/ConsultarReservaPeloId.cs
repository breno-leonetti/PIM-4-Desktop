using PIM_4_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class ConsultarReservaPeloId : TarefaSQL<Reserva>
    {
        private const string comandoSQL = "SELECT c.nome, c.email, v.modelo, v.placa, v.marca, v.ano, v.km_atual, v.categoria, " +
            "r.valor_previsto, r.valor_diaria, r.data_reserva, v.id_veiculo, c.id_cliente " +
            "FROM Reservas r " +
            "JOIN Clientes c ON r.id_cliente = c.id_cliente " +
            "JOIN Veiculos v ON r.id_veiculo = v.id_veiculo " +
            "WHERE r.Id_reserva=@IdReserva";

        public override Reserva Executar(string valor)
        {
            try
            {
                SqlCommand command = new SqlCommand(comandoSQL, getConexao());
                command.Parameters.AddWithValue("@IdReserva", int.Parse(valor));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Cliente cliente = new Cliente(reader.GetString(0), reader.GetString(1), reader.GetInt32(12));
                    Veiculo veiculo = new Veiculo(reader.GetString(2), reader.GetString(3), reader.GetString(4),
                        reader.GetInt32(5), reader.GetDecimal(6), reader.GetString(7), true, reader.GetInt32(11));

                    Reserva reserva = new Reserva(cliente, veiculo, int.Parse(valor), reader.GetDecimal(8), reader.GetDecimal(9)
                        , reader.GetDateTime(10));
                    return reserva;

                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            return null;
        }
    }
}
