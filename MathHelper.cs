using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParquimetroProjetoFinal
{
    internal class MathHelper

    {
        //retorna um inteiro random entre um minimo, um máximo e um múltiplo (ex: numeros entre 10 e 50 - (min:1,max:5,multiple:10) )
        public static int returnRandomInt(int min, int max, int multiple)
        {
            var randomInteiro = new Random().Next(min,max)*multiple;
            return randomInteiro;
        }
    }
}
