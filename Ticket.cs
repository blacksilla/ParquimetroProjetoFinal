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
        private DateTime dataLeave;

        public Ticket(DateTime dataStart, Zonas idofzone, string license, double payedQT, DateTime dataLeave)
        {
            this.dataStart = dataStart;
            this.idofzone = idofzone;
            this.license = license;
            this.payedQT = payedQT;
            this.dataLeave = dataLeave;
        }

        public DateTime DataStart { get => dataStart; set => dataStart = value; }
        public Zonas Idofzone { get => idofzone; set => idofzone = value; }
        public string License { get => license; set => license = value; }
        public double PayedQT { get => payedQT; set => payedQT = value; }
        public DateTime DataLeave { get => dataLeave; set => dataLeave = value; }

        //o método mais importante, trata de receber moedas e fazer pagamentos consoante a zona
        public static Ticket PaymentNchange(Zonas z,DateTime dt)
		{
			double saldo = 0;
            double troco;
            double moeda;
            bool state,wannaPay=false;
            double possibleParkingTime = 0.0;
            DateTime CurrentDate = DateTime.Now;
            int day = (int)dt.DayOfWeek;
            double timeLimit = z.MaxTimeInMs;
            double maxTimeOnTheDay=0;
            bool paymentMenu = true;
            bool goback = false;

            //dá à zona 3 um limite, neste caso, a hora de fecho

            

            if (dt.Hour>=9)
            {
                switch (day)
                {
                    case 1: case 2: case 3: case 4: case 5:
                        maxTimeOnTheDay = (20 - dt.Hour)*60 - dt.Minute;
                        break;
                    case 6:
                        maxTimeOnTheDay = (14 - dt.Hour) * 60 - dt.Minute;
                        break;
                }
            }

            if(timeLimit==0 || timeLimit > maxTimeOnTheDay)
            {
                timeLimit = maxTimeOnTheDay;
            }else
            {
                timeLimit = z.MaxTimeInMs;
            }

            

            double pricePerHour = z.Preco;
            
            Console.WriteLine($"O preço da Zona {z.Id} é {pricePerHour}€/hora e o tempo máximo de estacionamento são de {timeLimit} minutos");
            while (paymentMenu)
            {
                while (Math.Round(possibleParkingTime * 60, 1) <= timeLimit && wannaPay == false && goback==false)
                {
                    //algoritmo para pedir moeda e calcular saldo
                    Console.WriteLine("Insira a moeda.");
                    state = double.TryParse(Console.ReadLine(), out double readedInput);
                    if (state)
                    {
                        moeda = readedInput;
                    }
                    else
                    {
                        moeda = -1;
                    }

                    switch (moeda)
                    {
                        case 0.05:
                        case 0.1:
                        case 0.2:
                        case 0.5:
                        case 1:
                        case 2:
                            saldo += moeda;
                            possibleParkingTime = saldo / pricePerHour;
                            break;

                        default:
                            Console.WriteLine("Moeda inválida.");
                            moeda = -1;
                            break;
                    }
                    if (moeda > 0)
                    {
                        Console.WriteLine($"O saldo é {Math.Round(saldo,2)}€ e a moeda introduzida foi {moeda}€.");

                        if (saldo >= pricePerHour / 60 * timeLimit || possibleParkingTime * 60 > timeLimit) 
                        {
                            Console.WriteLine($"O tempo de estacionamento é {timeLimit} minutos");
                            wannaPay = true;
                        }
                        else
                        {
                            Console.WriteLine($"O tempo de estacionamento é {Math.Round(possibleParkingTime * 60)} minutos");
                            Console.WriteLine("Continuar - C || Pagar - P || Voltar - V");
                            var inputPayOrNot = Console.ReadLine();
                            switch (inputPayOrNot)
                            {
                                case "P" or "p":
                                    wannaPay = true;
                                    break;

                                case "C" or "c":
                                    wannaPay = false;
                                    break;
                                case "V" or "v":
                                    return null;
                                default: InterfaceHelper.errorMessage(); wannaPay = false; continue;
                            }
                        }
                        if (goback == false)
                        {

                            Console.WriteLine("Confirmar Pagamento - C || Reiniciar - R || Voltar - V");

                            var input = Console.ReadLine();
                            switch (input)
                            {
                                case "C" or "c":
                                    if (saldo > (timeLimit / 60) * pricePerHour)
                                    {
                                        possibleParkingTime = timeLimit / 60;
                                        troco = Math.Round(saldo - (timeLimit / 60 * pricePerHour), 2);
                                        Console.WriteLine($"O troco é {troco}€");
                                        string license = getLicense();
                                        Ticket myticket = new Ticket(CurrentDate, z, license, saldo - troco, CurrentDate.AddMinutes(Math.Round(possibleParkingTime * 60)));
                                        return myticket;

                                    }
                                    else //deverá ser elseif, ver melhor
                                    {
                                        troco = 0;
                                        string license = getLicense();
                                        Ticket myticket = new Ticket(CurrentDate, z, license, saldo - troco, CurrentDate.AddMinutes(Math.Round(possibleParkingTime * 60)));
                                        return myticket;

                                    }

                                case "R" or "r":
                                    saldo = 0;
                                    possibleParkingTime = 0;
                                    wannaPay = false;
                                    paymentMenu = true;
                                    break;

                                case "V" or "v":
                                    return null;

                                default:
                                    saldo = 0;
                                    possibleParkingTime = 0;
                                    wannaPay = false;
                                    InterfaceHelper.errorMessage();
                                    continue;
                            }
                        }
                        else
                            return null;

                    }
                    else
                    {
                        Console.WriteLine("Tente de novo");
                    }
                }

                

            }
            return null;
        }

        //um metodo para pedir ao utilizador uma matricula, string simples sem verificação
        public static string getLicense()
        {
            Console.WriteLine("Insira a sua matrícula no formato XX-00-YY");
            string license = Console.ReadLine();

            //garantir que os caracteres ficam separados e em CAPS
            char[] allCLicense = license.ToUpper().ToCharArray();
            

            //se for escrito qualquer coisa random, ele gera uma matricula automaticamente
            if(allCLicense.Length < 6)
            {
                license = Car.returnRandomLicense();
            } else if(allCLicense.Length == 6) //no caso do utilizador por só 6 digitos, ele formata
            {
                license = ($"{allCLicense[0]}{allCLicense[1]}-{allCLicense[2]}{allCLicense[3]}-{allCLicense[4]}{allCLicense[5]}" );
            }
            else // no caso do utilizador por no formato direito, só garante que fiquem em maiusculas
            {
                license = ($"{allCLicense[0]}{allCLicense[1]}-{allCLicense[3]}{allCLicense[4]}-{allCLicense[6]}{allCLicense[7]}");
            }

            return license;
        }
    }
}

