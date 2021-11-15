using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_Desktop.Back.Banco
{
    public class CheckIn : TarefaSQL<bool>
    {
        
        public override bool Executar(string idCheckIn)
        {
            if(2 > 1) //Caso a atualização sql seja bem sucedida
            {
                return true;
            }

            return false;
        }
    }
}
