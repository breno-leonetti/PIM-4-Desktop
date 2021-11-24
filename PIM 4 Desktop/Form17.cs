using PIM_4_Desktop.Back.Banco;
using PIM_4_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_Desktop
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void botaoPers1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario;
            try
            {
                funcionario = new Funcionario(nome.Texts, email.Texts, senha.Texts, celular.Texts, telefone.Texts, DateTime.Parse(nascimento.Texts), rg.Texts, cpf.Texts, int.Parse(matricula.Texts), decimal.Parse(salario.Texts), cargo.Texts); 
            }
            catch (Exception)
            {
                MessageBox.Show("Algum dado inserido é inválido.");
                return;
            }
            if(new CadastrarFuncionario(funcionario).Executar(null))
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                return;
            }
            MessageBox.Show("Algo deu errado. Tente novamente mais tarde!");
        }

        private void botaoPers2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }
    }
}
