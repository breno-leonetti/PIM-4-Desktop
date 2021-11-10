using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Modelos
{
    public class CarroAlugado
    {
        public string Id { get; }
        public double ValorDiaria { get; }

        public CarroAlugado(string id, double valorDiaria)
        {
            Id = id;
            ValorDiaria = valorDiaria;
        }
    }
}
