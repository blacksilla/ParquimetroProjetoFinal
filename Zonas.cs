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



        //criar funcao para popular array com 0s e 1s, disponivel/indisponivel

        public static List<int> fillParkingSlots(Zonas zona)
        {
            int occSpots=0; //variavel guardar quantos lugares ocupados
            List<Car> cars  = new List<Car>();


            //lista spots ocupados
            List<int> filledSpots = new List<int>();
            //ciclo para popular com 0s (livres) e 1s (ocupados) os lugares
            for (int i = 0; i < zona.spots; i ++)
            {
                filledSpots.Add(MathHelper.returnRandomInt(0, 2, 1));
                InterfaceHelper.printPark(filledSpots);
                if (filledSpots[i] == 1)
                    occSpots++;
               
            }
            Console.WriteLine("Lugares ocupados: " + occSpots);
            

            

            for (int i = 0; i < occSpots; i++)
            {
                cars.Add(new Car(Car.randomCarBrand(), Car.returnRandomLicense(), MathHelper.returnRandomInt(10, 480,1)));
                Console.Write($"\n {i+1}. Marca: {cars[i].Brand}\nMatrícula: {cars[i].LicensePlate}\nTempo Estacionado: {cars[i].ParkingTime} minutos");
            }

            return filledSpots;
            //tem que retornar a lista para desenhar o parque
        }


    }
}
