﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParquimetroProjetoFinal
{
    internal class Zonas
    {
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


        //criar funcao para popular array com 0s e 1s, disponivel/indisponivel

        public static void fillParkingSlots(Zonas zona)
        {
            //lugares disponiveis
            //z.spots =

            for (int i = 0; i < zona.spots; i++)
            {


            }

        }
    }
}
