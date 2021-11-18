using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Classes
{
    public class Reserva
    {
        public Cliente Cliente { get; }
        public Veiculo Veiculo { get; }
        public int IdReserva { get; }
        public decimal ValorPrevisto { get; }
        public decimal ValorDiaria { get; }
        public DateTime DateTime { get; }

        public Reserva(Cliente cliente, Veiculo veiculo, int idReserva, decimal valorPrevisto, decimal valorDiaria,
            DateTime dateTime)
        {
            Cliente = cliente;
            Veiculo = veiculo;
            IdReserva = idReserva;
            ValorPrevisto = valorPrevisto;
            ValorDiaria = valorDiaria;
            DateTime = dateTime;
        }

    }
}
