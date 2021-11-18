using PIM_4_Desktop.Back;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void botaoPers4_Click(object sender, EventArgs e)
        {
            if(new CheckOut(comboBoxPers1.Texts).Executar(caixaTexPer1.Texts))
            {
                new Form6().Show();
                this.Hide();
                return;
            }
            MessageBox.Show("Algo deu errado. Tente novamente mais tarde.");
        }

        private void botaoPers1_Click(object sender, EventArgs e)
        {
            Reserva reserva = new ConsultarReservaPeloId().Executar(caixaTexPer1.Texts);
            if(reserva == null)
            {
                MessageBox.Show("Reserva não encontrada");
                return;
            }
            botaoPers4.Enabled = true;
            caixaTexPer3.Enabled = false;
            botaoPers1.Enabled = false;
            caixaTexPer4.Texts = reserva.Cliente.Nome;
            caixaTexPer6.Texts = reserva.Veiculo.Marca.ToUpper() + " " +  reserva.Veiculo.Modelo.ToUpper() + " " + reserva.Veiculo.Ano;
            label15.Text = reserva.ValorPrevisto.ToString();
            try
            {
                int custoExtra = int.Parse(caixaTexPer3.Texts);
                label16.Text = (custoExtra + reserva.ValorPrevisto).ToString();
            }
            catch (Exception)
            {
                label16.Text = reserva.ValorPrevisto.ToString() ;
            }
        }

        private void botaoPers3_Click(object sender, EventArgs e)
        {
            new _2_Console_Menu_Principal__Tela_Inicial_Após_Login_().Show();
            this.Hide();
        }
    }
}
