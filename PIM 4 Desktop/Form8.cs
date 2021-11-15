using PIM_4_Desktop.Back;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            email.Texts = Gerenciador.Cliente.Email;
            senha.Texts = Gerenciador.Cliente.Senha;
            nome.Texts = Gerenciador.Cliente.Nome;
            cpf.Texts = Gerenciador.Cliente.CPF;
            data.Texts = Gerenciador.Cliente.DataNascimento.ToString();
            cnh.Texts = Gerenciador.Cliente.NCarteiraHabilitacao;
            telefone.Texts = Gerenciador.Cliente.Telefone;
        }

        private void botaoPers4_Click(object sender, EventArgs e)
        {
            if(new CadastrarCliente().Executar(null))
            {
                this.Hide();
                new Form9().Show();
                return;
            }
            MessageBox.Show("Ocorreu um erro ao tentar salvar os dados informados. Tente novamente mais tarde.");
        }

        private void botaoPers3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form7().Show();
        }
    }
}
