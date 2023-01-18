using System;
namespace ParquimetroProjetoFinal
{
	public class Ticket
	{
		public static void paymentNchange()
		{
			double saldo = 0;
            double moeda;
            bool state;

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
						break;
                    case 0.1:
                        saldo = saldo + moeda;
                        break;
                    case 0.2:
                        saldo = saldo + moeda;
                        break;
                    case 0.5:
                        saldo = saldo + moeda;
                        break;
                    case 1:
                        saldo = saldo + moeda;
                        break;
                    case 2:
                        saldo = saldo + moeda;
                        break;

                    default:
                        Console.WriteLine("Moeda inválida.");
						saldo = saldo;
						break;
				}

				Console.WriteLine($"O saldo é {saldo}, e a moeda introduzida foi {moeda}");
			}

            Console.ReadLine();
        }
    }
}

