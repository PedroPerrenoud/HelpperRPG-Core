using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpperRPG.Core.Utilities
{
    public class Dice 
    {
        public int rollDice( int diceNumber )
        {
            int draw = 0; // Rola um número aleatório entre 1 e diceNumber;
            
            if( draw == 0 || draw > diceNumber )
            {
                // Trata o erro se o valor for zero ou maior que o número de lados solicitado.
            }

            return draw;
        }

    }
}