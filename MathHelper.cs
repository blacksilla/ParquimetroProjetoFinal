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

        public static List<string> returnRandomLicense()
        {
            int lengthLetter = 4;
            int lengthNumber = 2;

            // creating a StringBuilder object()
            //StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            Random randomInt = new Random();


            List<string> randomLicense = new List<string>();
            




            for (int i = 0; i < lengthLetter; i++)
            {

                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                randomLicense.Add(Convert.ToString(Convert.ToChar(shift + 65)));

            }

            for (int i = lengthLetter; i < lengthNumber+lengthLetter; i++)
            {
                string INT = Convert.ToString(randomInt.Next(9));
                randomLicense.Add(INT);

            }
            

            List<string> licensePlate = new List<string>();
            licensePlate.Add(randomLicense[0]);
            licensePlate.Add(randomLicense[1]);
            licensePlate.Add(randomLicense[4]);
            licensePlate.Add(randomLicense[5]);
            licensePlate.Add(randomLicense[2]);
            licensePlate.Add(randomLicense[3]);

            


            return licensePlate;
           
        }

    }
}
