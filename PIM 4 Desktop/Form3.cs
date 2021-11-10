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
                //Abrir um dos 20 FormX que corresponde ao sucesso
                //new FormX().Show();
                //this.Hide();
                MessageBox.Show("CheckIn efetuado com sucesso.");
                return;
            }
            MessageBox.Show("Ocorreu um erro. Por favor tente novamento mais tarde.");
        }
    }
}
