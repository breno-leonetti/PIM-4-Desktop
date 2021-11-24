﻿using PIM_4_Desktop.Back.Banco;
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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void botaoPers1_Click(object sender, EventArgs e)
        {
            if(new DeletarCliente().Executar(caixaTexPer6.Texts))
            {
                MessageBox.Show("Usuário deletado com sucesso!");
                return;
            }
            MessageBox.Show("O ID inserido é inválido");
        }

        private void botaoPers2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form16().Show();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_AlucarDataSet1.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bD_AlucarDataSet1.Clientes);

        }
    }
}
