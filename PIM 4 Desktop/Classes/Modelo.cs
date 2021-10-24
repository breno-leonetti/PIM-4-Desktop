using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
{
    class Categ
    {
        public string Categoria;
        public int Codigo;


        /// <summary>
        /// imput será feito direto no banco de dados
        /// </summary>
        /// <param name="categoria"></param>
        /// <param name="codigo"></param>
        public Categ(string categoria,int codigo)
        {
            Categoria = categoria;
            Codigo = codigo;
        }

    }

}
