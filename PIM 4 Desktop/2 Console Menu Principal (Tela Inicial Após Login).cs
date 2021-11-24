using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIM_4_Desktop.Back;
using PIM_4_Desktop.Back.Modelos;
using System.Windows.Forms;

namespace PIM_4_Desktop
{
    public partial class _2_Console_Menu_Principal__Tela_Inicial_Após_Login_ : Form
    {
        public _2_Console_Menu_Principal__Tela_Inicial_Após_Login_()
        {
            InitializeComponent();
            string nomeFuncionario = Gerenciador.UsuarioLogado.Nome;
            NomeFuncionario.Text = nomeFuncionario;
        }

        private void botaoPers1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void botaoPers5_Click(object sender, EventArgs e)
        {
            new Form16().Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new Gerenciador().deslogarUsuario(this);
        }

        private void botaoPers7_Click(object sender, EventArgs e)
        {
            new Form16().Show();
            this.Hide();
        }

        private void botaoPers6_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void botaoPers4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form16().Show();
        }

        private void botaoPers2_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }
    }
}
