using System;
using System.Reflection.Metadata.Ecma335;

namespace ParquimetroProjetoFinal
{
	public class Ticket
	{
        private DateTime dataStart;
        private Zonas idofzone;
        private string license;
        private double payedQT;

        public DateTime DataStart { get => dataStart; set => dataStart = value; }
        public Zonas Idofzone { get => idofzone; set => idofzone = value; }
        public string License { get => license; set => license = value; }
        public double PayedQT { get => payedQT; set => payedQT = value; }

        public Ticket(DateTime dataStart, Zonas idofzone, string license, double payedQT)
        {
            this.dataStart = dataStart;
            this.idofzone = idofzone;
            this.license = license;
            this.payedQT = payedQT;
        }

        public static Ticket PaymentNchange(Zonas z,int day,int hour)
		{
			double saldo = 0;
            double troco;
            double moeda;
            bool state,wannaPay=false;
            double possibleParkingTime = 0.0;
            DateTime CurrentDate = DateTime.Now;

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
                        default: InterfaceHelper.errorMessage(); wannaPay= false; break;
                    }
                }

                
            }
            


            Console.WriteLine("Confirmar Pagamento - C || Reiniciar - R");
            
            var input = Console.ReadLine();
            switch (input)
            {
                case "C" or "c":
                    if (saldo > timeLimit / 60 * pricePerHour)
                    {
                        troco = Math.Round(saldo - (timeLimit / 60 * pricePerHour), 2);
                        Console.WriteLine($"O troco é {troco}€");
                        string license = getLicense();
                        Ticket myticket = new Ticket(CurrentDate, z, license, saldo - troco);
                        return myticket;
                    }
                    else
                    {
                        troco = 0;
                        string license = getLicense();
                        Ticket myticket = new Ticket(CurrentDate, z, license, saldo - troco);
                        return myticket;
                    }
                    
                case "R" or "r":
                    //reset das variáveis
                    PaymentNchange(z,day,hour);
                    break;
                 default: InterfaceHelper.errorMessage(); break;
            }

            return null;
        }

        public static string getLicense()
        {
            Console.WriteLine("Insira a sua matrícula no formato XX-00-YY");
            string license = Console.ReadLine();
            return license;
        }
    }
}

