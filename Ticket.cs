using System;
using System.Reflection.Metadata.Ecma335;

namespace ParquimetroProjetoFinal
{
	public class Ticket
	{
		public static double paymentNchange(Zonas z,int day,int hour)
		{
			double saldo = 0;
            double troco = 0;
            double moeda;
            bool state,wannaPay=false;
            double possibleParkingTime = 0.0;

            double timeLimit = z.MaxTimeInMs;

            if (timeLimit == 0 && hour>9)
            {
                switch (day)
                {
                    case 1: case 2: case 3: case 4:case 5:
                        timeLimit = (20 - hour)*60;
                        break;
                    case 6:
                        timeLimit = (14 - hour) * 60;
                        break;
                }
            }
            double pricePerHour = z.Preco;
            
            Console.WriteLine($"O preço da Zona {z.Id} é {pricePerHour}€/hora e o tempo máximo de estacionamento são de {timeLimit} minutos");            

			while (Math.Round(possibleParkingTime * 60, 1) <= timeLimit && wannaPay==false && timeLimit!=0)
			{

                Console.WriteLine("Insira a moeda.");
                state = double.TryParse(Console.ReadLine(), out double readedInput);
                if (state)
                {
                    moeda = readedInput;
                }
                else {
                    moeda = 0;
                }

				switch (moeda)
				{
					case 0.05:
                        saldo = saldo + moeda;
                        possibleParkingTime = saldo / pricePerHour;
						break;
                    case 0.1:
                        saldo = saldo + moeda;

                        possibleParkingTime = saldo / pricePerHour;
                        break;
                    case 0.2:
                        saldo = saldo + moeda;

                        possibleParkingTime = saldo / pricePerHour;
                        break;
                    case 0.5:
                        saldo = saldo + moeda;

                        possibleParkingTime = saldo / pricePerHour;
                        break;
                    case 1:
                        saldo = saldo + moeda;

                        possibleParkingTime = saldo / pricePerHour;
                        break;
                    case 2:
                        saldo = saldo + moeda;

                        possibleParkingTime = saldo / pricePerHour;
                        break;

                    default:
                        Console.WriteLine("Moeda inválida.");
						break;
				}

				Console.WriteLine($"O saldo é {saldo}€ e a moeda introduzida foi {moeda}€.");
                
                if(saldo > pricePerHour || possibleParkingTime*60>timeLimit)
                {
                    Console.WriteLine($"O tempo de estacionamento é {timeLimit} minutos");
                    wannaPay = true;
                }
                else {
                    Console.WriteLine($"O tempo de estacionamento é {Math.Round(possibleParkingTime * 60, 1)} minutos");
                    Console.WriteLine("Continuar - C || Pagar - P");
                    var inputPayOrNot = Console.ReadLine();
                    switch (inputPayOrNot)
                    {
                        case "P" or "p":
                            wannaPay = true;
                            break;

                        case "C" or "c":
                            wannaPay= false;
                            break;
                        default: InterfaceHelper.errorMessage(); continue;
                    }
                }
                

            }
            


            Console.WriteLine("Confirmar Pagamento - P || Resetar - R");
            
            var input = Console.ReadLine();
            switch (input)
            {
                case "P" or "p":
                    troco =Math.Round( saldo - (timeLimit / 60 * pricePerHour),2);
                    Console.WriteLine($"O troco é {troco}€");
                    Console.ReadLine();
                    //avança para pedir matricula
                    break;

                case "R" or "r":
                    //reset das variáveis
                    paymentNchange(z,day,hour);
                    break;
                 default: InterfaceHelper.errorMessage(); break;
            }
            
            var timeOfParking = Math.Round(possibleParkingTime * 60, 1);

            //Ou devolve ou chama mesmo a imrpessão do ticket, temos que ver
            return timeOfParking;
        }
    }
}

