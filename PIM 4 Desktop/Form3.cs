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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            caixaTexPer2.Enabled = false;
            caixaTexPer2.Texts = Gerenciador.UsuarioLogado.Matricula;
        }

        private void botaoPers4_Click(object sender, EventArgs e)
        {
            if (new CheckIn().Executar(caixaTexPer1.Texts))
            {
                new Form4().Show();
                this.Hide();
                return;
            }
            MessageBox.Show("Ocorreu um erro. Por favor tente novamento mais tarde.");
        }

        private void botaoPers3_Click(object sender, EventArgs e)
        {
            new _2_Console_Menu_Principal__Tela_Inicial_Após_Login_().Show();
            this.Hide();
        }
    }
}
