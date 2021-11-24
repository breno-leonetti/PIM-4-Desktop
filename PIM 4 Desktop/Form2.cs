using PIM_4_Desktop.Back;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void botaoPers5_Click(object sender, EventArgs e)
        {
            new Gerenciador().deslogarUsuario(this);
        }

        private void botaoPers3_Click(object sender, EventArgs e)
        {

        }

        private void botaoPers4_Click(object sender, EventArgs e)
        {
            new Form13().Show();
            this.Hide();
        }

        private void btnFuncionários_Click(object sender, EventArgs e)
        {
            new Form17().Show();
            this.Hide();
        }

        private void botaoPers6_Click(object sender, EventArgs e)
        {
            new _2_Console_Menu_Principal__Tela_Inicial_Após_Login_().Show();
            this.Hide();
        }
    }
}
