using PIM_4_Desktop.Back.Modelos;
using PIM_4_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_Desktop.Back
{
    public class Gerenciador
    {
        public static UsuarioLogado UsuarioLogado { get; set; }
        public static Cliente Cliente { get; set; }

        public bool logarUsuario(UsuarioLogado usuarioLogado)
        {
            if(UsuarioLogado != null)
            {
                return false;
            }
            UsuarioLogado = usuarioLogado;
            return true;
        }

        public void deslogarUsuario(Form formularioAtual)
        {
            new Form1().Show();
            formularioAtual.Hide();
            UsuarioLogado = null;
        }

    }
}
