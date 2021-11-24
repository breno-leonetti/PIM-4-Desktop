using PIM_4_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco.Cadastro
{
    public class CadastrarVeiculo : TarefaSQL<bool>
    {

        private Veiculo Veiculo;

        public CadastrarVeiculo(Veiculo veiculo)
        {
            Veiculo = veiculo;
        }


        private const string comandoSQL = "INSERT INTO Veiculos(renavam, modelo, placa, marca, ano, km_atual, cor, valor_diaria)" +
                " VALUES(@Renavam, @Modelo, @Placa, @Marca, @Ano, @Quilometragem, @Cor, @Diaria)";

        public override bool Executar(string valor)
        {
            try
            {
                SqlCommand command = new SqlCommand(comandoSQL, getConexao());
                command.Parameters.AddWithValue("@Renavam", Veiculo.Renavam);
                command.Parameters.AddWithValue("@Modelo", Veiculo.Modelo);
                command.Parameters.AddWithValue("@Placa", Veiculo.Placa);
                command.Parameters.AddWithValue("@Marca", Veiculo.Marca);
                command.Parameters.AddWithValue("@Ano", Veiculo.Ano);
                command.Parameters.AddWithValue("@Quilometragem", Veiculo.Quilometragem);
                command.Parameters.AddWithValue("@Cor", Veiculo.Cor);
                command.Parameters.AddWithValue("@Diaria", Veiculo.Diaria);
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
