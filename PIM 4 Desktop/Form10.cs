using PIM_4_Desktop.Back.Banco;
using PIM_4_Desktop.Back.Banco.Cadastro;
using PIM_4_Desktop.Back.Banco.Consulta;
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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private double dias;
        private decimal valorDiaria;
        private Cliente cliente;

        private void botaoPers3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new _2_Console_Menu_Principal__Tela_Inicial_Após_Login_().Show();
        }

        private void botaoPers1_Click(object sender, EventArgs e)
        {
            
            try
            {
                cliente = new ConsultarClientePeloCpf().Executar(cpf.Texts);
                valorDiaria = new ConsultarDiariaVeiculo().Executar(idVeiculo.Texts);
                dias = (DateTime.Parse(dataEntrega.Texts) - DateTime.Parse(dataRetirada.Texts)).TotalDays;
                if(dias < 0 || (DateTime.Parse(dataRetirada.Texts) - DateTime.Now).TotalDays < 0)
                {
                    MessageBox.Show("A data inserida é inválida, por favor tente novamente com outra data.");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algum dado inserido é inválido, por favor tente novamente mais tarde.");
                return;
            }
            nome.Texts = cliente.Nome;
            email.Texts = cliente.Email;
            previa.Texts = (valorDiaria * (decimal)dias).ToString();
            diaria.Texts = valorDiaria.ToString();

            botaoProsseguir.Enabled = true;
            botaoPers1.Enabled = false;
            nome.Enabled = false;
            email.Enabled = false;
            previa.Enabled = false;
            diaria.Enabled = false;

        }

        private void botaoProsseguir_Click(object sender, EventArgs e)
        {
            int idReserva = new CadastrarReserva(cliente, DateTime.Parse(dataRetirada.Texts), DateTime.Parse(dataEntrega.Texts), dias, valorDiaria, valorDiaria * (decimal)dias).Executar(idVeiculo.Texts);
            if (idReserva != 0)
            {
                new Form12(idReserva).Show();
                this.Hide();
                return;
            }
            MessageBox.Show("Ocorreu um erro ao efetuar a reserva. Verifique os dados informados e tente novamente mais tarde.");
        }
    }
}
