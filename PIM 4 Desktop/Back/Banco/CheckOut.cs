using PIM_4_Desktop.Back.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class CheckOut : TarefaSQL<CarroAlugado>
    {

        public override CarroAlugado Executar(string id)
        {
            return new RecuperarVeiculoAlugado().Executar(id);
        }
    }
}
