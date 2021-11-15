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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            caixaTexPer2.Texts = Gerenciador.UsuarioLogado.Matricula;
            caixaTexPer2.Enabled = false;
        }

        private void botaoPers4_Click(object sender, EventArgs e)
        {

        }
    }
}
