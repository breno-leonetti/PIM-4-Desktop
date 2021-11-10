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
    }
}
