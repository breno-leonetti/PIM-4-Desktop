﻿using System;
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
    public partial class Form12 : Form
    {

        private int IdReserva;

        public Form12(int idReserva)
        {
            InitializeComponent();
            IdReserva = idReserva;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            idReserva.Text = IdReserva.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new _2_Console_Menu_Principal__Tela_Inicial_Após_Login_().Show(); 
        }
    }
}
