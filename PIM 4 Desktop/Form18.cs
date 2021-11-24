using PIM_4_Desktop.Back.Banco;
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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_AlucarDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bD_AlucarDataSet.Funcionarios);

        }

        private void botaoPers1_Click(object sender, EventArgs e)
        {
            this.funcionariosTableAdapter.Fill(this.bD_AlucarDataSet.Funcionarios);
        }

        private void botaoPers5_Click(object sender, EventArgs e)
        {
            if(new DeletarFuncionario().Executar(funcionarioId.Texts))
            {
                MessageBox.Show("Funcionário deletado com sucesso!");
                this.funcionariosTableAdapter.Fill(this.bD_AlucarDataSet.Funcionarios);
                return;

            }
            MessageBox.Show("Ocorreu um erro ao tentar deletar o funcionário informado!");

        }

        private void botaoPers2_Click(object sender, EventArgs e)
        {
            new Form16().Show();
            this.Hide();
        }
    }
}
