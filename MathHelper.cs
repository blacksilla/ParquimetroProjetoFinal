using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParquimetroProjetoFinal
{
    internal class MathHelper

    {
        public static int returnRandomInt()
        {
            var randomInteiro = new Random().Next(10,50);
            return randomInteiro;
        }



    }
}
