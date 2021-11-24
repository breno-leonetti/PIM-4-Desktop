using PIM_4_Desktop.Back;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void botaoPers4_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(nome.Texts, email.Texts, senha.Texts, telefone1.Texts,
                    DateTime.Parse(data.Texts), cpf.Texts, cnh.Texts);
                Gerenciador.Cliente = cliente;
                this.Hide();
                new Form8().Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Algum dado inserido não é válido!");
            }
        }

        private void botaoPers3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form16().Show();
        }
    }
}
