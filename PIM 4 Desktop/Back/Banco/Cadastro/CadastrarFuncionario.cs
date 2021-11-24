using PIM_4_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class CadastrarFuncionario : TarefaSQL<bool>
    {
        private const string comandoSQL = "INSERT INTO Funcionarios(nome, email, senha, celular, telefone, datadenascimento, rg, cpf, matricula, salariobase, funcao)" +
                " VALUES(@Nome, @Email, @Senha, @Celular, @Telefone, @Nascimento, @Rg, @Cpf, @Matricula, @Salario, @Cargo)";

        private Funcionario Funcionario;

        public CadastrarFuncionario(Funcionario funcionario)
        {
            Funcionario = funcionario;
        }

        public override bool Executar(string valor)
        {
            try
            {
                SqlCommand command = new SqlCommand(comandoSQL, getConexao());
                command.Parameters.AddWithValue("@Nome", Funcionario.Nome);
                command.Parameters.AddWithValue("@Email", Funcionario.Email);
                command.Parameters.AddWithValue("@Senha", Funcionario.Senha);
                command.Parameters.AddWithValue("@Celular", Funcionario.Celular);
                command.Parameters.AddWithValue("@Telefone", Funcionario.Telefone);
                command.Parameters.AddWithValue("@Nascimento", Funcionario.DataNascimento);
                command.Parameters.AddWithValue("@Rg", Funcionario.RG);
                command.Parameters.AddWithValue("@Cpf", Funcionario.CPF);
                command.Parameters.AddWithValue("@Matricula", Funcionario.Matricula);
                command.Parameters.AddWithValue("@Salario", Funcionario.SalarioBase);
                command.Parameters.AddWithValue("@Cargo", Funcionario.Cargo);
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
