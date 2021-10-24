using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
{
    class Veiculos
    {
        public string Modelo; 
        protected string Placa;
        protected string Marca;
        protected string ID_carro;
        protected string Ano;
        protected string Quilometragem;
        public Categ Categoria; // definir como funcionara!!!
        public bool Disponibilidade;

        /// <summary>
        /// Cadastro de veiculos 
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="placa"></param>
        /// <param name="marca"></param>
        /// <param name="ano"></param>
        /// <param name="quilometragem"></param>
        /// <param name="categoria">conferir conceito de entrada</param>
        public Veiculos(string modelo, string placa, string marca, string ano, string quilometragem, Categ categoria, bool disponibilidade)
        {
            Modelo = modelo;
            Placa = placa;
            Marca = marca;
            Ano = ano;
            Quilometragem = quilometragem;
            Categoria = categoria;
            Disponibilidade = disponibilidade;

        }
    }

    
}
