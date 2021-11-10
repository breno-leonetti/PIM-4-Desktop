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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbMatriculaFunc__TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSenhaLogin__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (new Autenticar(txbSenhaLogin.Texts).Executar(txbMatriculaFunc.Texts))
            {
                var form = new _2_Console_Menu_Principal__Tela_Inicial_Após_Login_();
                this.Hide();
                form.Show();
                return;
            }
            MessageBox.Show("Usuário e/ou senha inválido(s).");
        }
                       
    }
}
