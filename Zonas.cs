using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParquimetroProjetoFinal
{
    internal class Zonas
    {
        //criar funcao para popular cada array com 0s e 1s, disponivel/indisponivel

        //criar funcao que desenhe isso na interface - pode ser feito na class da interface

        //falta criar variavel para duracao de tempo de carros random estacionados

        private int id;
        private double preco;
        private int MaxTimeInms;
        private int spots;

        public Zonas(int id, double preco, int maxTimeInMs, int spots)
        {
            this.Id = id;
            this.Preco = preco;
            MaxTimeInMs = maxTimeInMs;
            this.Spots = spots;
        }


        



        public int Id { get => id; set => id = value; }
        public double Preco { get => preco; set => preco = value; }
        public int MaxTimeInMs { get => MaxTimeInms; set => MaxTimeInms = value; }
        public int Spots { get => spots; set => spots = value; }




        
    }
}
