using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
{
    public class Veiculo
    {
        public string Modelo;
        public string Placa;
        public string Marca;
        public int ID_carro;
        public int Ano;
        public decimal Quilometragem;
        public string Categoria; // definir como funcionara!!!
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
        public Veiculo(string modelo, string placa, string marca, int ano, decimal quilometragem, string categoria, bool disponibilidade, int idCarro)
        {
            Modelo = modelo;
            Placa = placa;
            Marca = marca;
            Ano = ano;
            Quilometragem = quilometragem;
            Categoria = categoria;
            Disponibilidade = disponibilidade;
            ID_carro = idCarro;

        }
    }

    
}
