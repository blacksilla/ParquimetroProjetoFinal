using System;
namespace ParquimetroProjetoFinal
{
	public class Ticket
	{
		public static void paymentNchange(Zonas z)
		{
			double saldo = 0;
            double moeda;
            bool state;
            double possibleParkingTime = 0.0;

            int timeLimit = z.MaxTimeInMs;
            double pricePerHour = z.Preco;

            Console.WriteLine($"O preço da Zona {z.Id} é {pricePerHour}/hora");            

			while (true)
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
                        possibleParkingTime = saldo * pricePerHour;
						break;
                    case 0.1:
                        saldo = saldo + moeda;

                        possibleParkingTime = saldo * pricePerHour;
                        break;
                    case 0.2:
                        saldo = saldo + moeda;

                        possibleParkingTime = saldo * pricePerHour;
                        break;
                    case 0.5:
                        saldo = saldo + moeda;

                        possibleParkingTime = saldo * pricePerHour;
                        break;
                    case 1:
                        saldo = saldo + moeda;

                        possibleParkingTime = saldo * pricePerHour;
                        break;
                    case 2:
                        saldo = saldo + moeda;

                        possibleParkingTime = saldo * pricePerHour;
                        break;

                    default:
                        Console.WriteLine("Moeda inválida.");
						break;
				}

				Console.WriteLine($"O saldo é {saldo}, e a moeda introduzida foi {moeda}.");
                Console.WriteLine($"O tempo de estacionamento {possibleParkingTime}");
                
			}
        }
    }
}

