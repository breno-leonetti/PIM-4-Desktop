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
            var form = new Form17();
            this.Hide();
            form.Show();
        }
                       
    }
}
