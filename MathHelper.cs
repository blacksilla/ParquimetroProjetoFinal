using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParquimetroProjetoFinal
{
    internal class MathHelper

    {
        public static int returnRandomInt(int min, int max)
        {
            var randomInteiro = new Random().Next(min,max);
            return randomInteiro;
        }
    }
}
