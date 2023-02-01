using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParquimetroProjetoFinal
{
     public class Zonas

    {
        //criar funcao que desenhe isso na interface - pode ser feito na class da interface


        //falta criar variavel para duracao de tempo de carros random estacionados

        private int id;
        private double preco;
        private int MaxTimeInM;
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
        public int MaxTimeInMs { get => MaxTimeInM; set => MaxTimeInM = value; }
        public int Spots { get => spots; set => spots = value; }



        //criar funcao para popular array com 0s e 1s, disponivel/indisponivel

        public static List<int> fillParkingSlots(Zonas zona)
        {
            
                List<int> filledSpots = new List<int>();
                //ciclo para popular com 0s (livres) e 1s (ocupados) os lugares
                for (int i = 0; i < zona.spots; i++)
                {
                    filledSpots.Add(MathHelper.returnRandomInt(0, 2, 1));
                }
                return filledSpots;
                //retorna a lista para desenhar o parque
        }


        //dá update à listra criada em cima, preenchendo o primeiro lugar vazio que encontrar
        public static List<int> updateParkingSlots(List<int> carParked, int occupied)
        {
            var counter = occupied-1;




           

                for (int i = 0; i < carParked.Count && counter<occupied; i++)
                {
                    if (carParked[i] == 1)
                    {

                    }
                    else
                    {
                        carParked[i] = 1;
                        counter++;
                    }
                }
            

            return carParked;
        }

        



    }
}
