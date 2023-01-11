using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParquimetroProjetoFinal
{
    internal class Zonas
    {
        //criar funcao para popular array com 0s e 1s, disponivel/indisponivel

        public static void populateArray() {

            int[] availableSpots = new int[20];
            Random availability = new Random();

            for (int i = 0; i < availableSpots.Length; i++) {

                string state;
                var available = availability.Next(2);
                availableSpots[i] = available; //no lugar i, guardar o valor do available

                if (availableSpots[i] == 0)
                {
                    state = "Existem {X} lugares disponíveis.";
                    Console.WriteLine(state);
                }
                else
                {
                    state = "Sem lugares disponíveis.";
                    Console.WriteLine(state);
                }
            }
        }


        //criar funcao que desenhe isso na interface - pode ser feito na class da interface


        //falta criar variavel para duracao de tempo de carros random estacionados

        private int id;
        private double preco;
        private int MaxTimeInMs;
        private int spots;

        public Zonas(int id, double preco, int maxTimeInMs, int spots)
        {
            this.Id = id;
            this.Preco = preco;
            MaxTimeInMs1 = maxTimeInMs;
            this.Spots = spots;
        }


        



        public int Id { get => id; set => id = value; }
        public double Preco { get => preco; set => preco = value; }
        public int MaxTimeInMs1 { get => MaxTimeInMs; set => MaxTimeInMs = value; }
        public int Spots { get => spots; set => spots = value; }
    }
}
