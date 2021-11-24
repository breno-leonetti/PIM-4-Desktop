using PIM_4_Desktop.Back.Banco.Cadastro;
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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void botaoPers4_Click(object sender, EventArgs e)
        {
            Veiculo veiculo;
            try
            {
                veiculo = new Veiculo(renavam.Texts, modelo.Texts, placa.Texts, marca.Texts, int.Parse(ano.Texts), decimal.Parse(quilometragem.Texts), cor.Texts, decimal.Parse(diaria.Texts));
            }
            catch (Exception)
            {
                MessageBox.Show("Algum dado inserido é inválido!");
                return;
            }
            if(new CadastrarVeiculo(veiculo).Executar(null))
            {
                MessageBox.Show("Veículo cadastrado com sucesso");
                return;
            }
            MessageBox.Show("Algo deu errado, verifique os dados inseridos e tente novamente!");
        }
    }
}
