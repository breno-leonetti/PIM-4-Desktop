﻿using PIM_4_Desktop.Back.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back
{
    public class Gerenciador
    {
        public static UsuarioLogado UsuarioLogado { get; set; }

        public bool logarUsuario(UsuarioLogado usuarioLogado)
        {
            if(UsuarioLogado != null)
            {
                return false;
            }
            UsuarioLogado = usuarioLogado;
            return true;
        }
    }
}
