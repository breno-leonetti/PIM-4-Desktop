using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
{
    class Endereco
    {
        public string Rua;
        public string Bairro;
        public string Cidade;
        public string Estado;
        public string Pais;
        public string Complemento;
        public int Numero;
        public long CEP;    

        /// <summary>
        /// cadastro de endereço de funcionario 
        /// </summary>
        /// <param name="rua"></param>
        /// <param name="bairro"></param>
        /// <param name="cidade"></param>
        /// <param name="estado"></param>
        /// <param name="pais"></param>
        /// <param name="numero"></param>
        /// <param name="cep">adicionar mascara</param>
        public Endereco(string rua, string bairro, string cidade,string estado,string pais, string complemento, int numero, long cep)
        {
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            Complemento = complemento;
            Numero = numero;
            CEP = cep;

        }    
    }
}
