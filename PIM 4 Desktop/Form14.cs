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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }


        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_AlucarDataSet2.Veiculos'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculosTableAdapter.Fill(this.bD_AlucarDataSet2.Veiculos);

        }

        private void botaoPers1_Click(object sender, EventArgs e)
        {
            if(new DeletarVeiculo().Executar(veiculoId.Texts))
            {
                this.veiculosTableAdapter.Fill(this.bD_AlucarDataSet2.Veiculos);
                MessageBox.Show("Veículo deletado com sucesso!");
                return;
            }
            MessageBox.Show("Ocorreu um erro ao tentar deletar o veículo informado!");
        }

        private void botaoPers3_Click(object sender, EventArgs e)
        {
            this.veiculosTableAdapter.Fill(this.bD_AlucarDataSet2.Veiculos);
        }

        private void botaoPers2_Click(object sender, EventArgs e)
        {
            new Form16().Show();
            this.Hide();
        }
    }
}
