﻿using PIM_4_Desktop.Back;
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
    }
}
