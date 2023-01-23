using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParquimetroProjetoFinal
{
    
    internal class InterfaceHelper
    {
        //define o horario de funcionamento da app
        public static bool parkStatus(int hour, int dayOfWeek)
        {
            
            if (dayOfWeek < 6 && hour >= 9 && hour < 20)
            {
                return true;
            }
            else if (dayOfWeek == 7 && hour >= 9 && hour < 14)
            {
                return true;
            }
            else return false;
        }

        //falta criar interface do ticket
        //falta criar interface do estacionamento - ver Classe Zonas

        public static void writeStartMenu(DateTime date)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Clear();
            Console.WriteLine("  _______________________________________ ");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |--------      Bem-vindo        --------|");
            Console.WriteLine(" |--------  Sistema Parquimetro  --------|");
            Console.Write($" |         ");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.Write($"{date.ToString()}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("           | \n");
            Console.WriteLine(" |         1. Administrador              |");
            Console.WriteLine(" |         2. Cliente                    |");
            Console.WriteLine(" |         3. Opções                     |");
            Console.WriteLine(" |         0. Sair                       |");
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("Escolha a opção pretendida -> ");
        }

        public static void parkClosed1()
        {
            Console.Clear();
            Console.WriteLine(@"$$$$$$$\                                                         $$$$$$$$\                  $$\                       $$\           
$$  __$$\                                                        $$  _____|                 $$ |                      $$ |          
$$ |  $$ |$$$$$$\   $$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\        $$ |    $$$$$$\   $$$$$$$\ $$$$$$$\   $$$$$$\   $$$$$$$ | $$$$$$\  
$$$$$$$  |\____$$\ $$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\       $$$$$\ $$  __$$\ $$  _____|$$  __$$\  \____$$\ $$  __$$ |$$  __$$\ 
$$  ____/ $$$$$$$ |$$ |  \__|$$ /  $$ |$$ |  $$ |$$$$$$$$ |      $$  __|$$$$$$$$ |$$ /      $$ |  $$ | $$$$$$$ |$$ /  $$ |$$ /  $$ |
$$ |     $$  __$$ |$$ |      $$ |  $$ |$$ |  $$ |$$   ____|      $$ |   $$   ____|$$ |      $$ |  $$ |$$  __$$ |$$ |  $$ |$$ |  $$ |
$$ |     \$$$$$$$ |$$ |      \$$$$$$$ |\$$$$$$  |\$$$$$$$\       $$ |   \$$$$$$$\ \$$$$$$$\ $$ |  $$ |\$$$$$$$ |\$$$$$$$ |\$$$$$$  |
\__|      \_______|\__|       \____$$ | \______/  \_______|      \__|    \_______| \_______|\__|  \__| \_______| \_______| \______/ 
                                   $$ |                                                                                             
                                   $$ |                                                                                             
                                   \__|                                                                                             ");
            
        }


        public static void parkClosed2()
        {
            Console.Clear();
            Console.WriteLine(@" /$$$$$$$                                                         /$$$$$$$$                  /$$                       /$$          
| $$__  $$                                                       | $$_____/                 | $$                      | $$          
| $$  \ $$ /$$$$$$   /$$$$$$   /$$$$$$  /$$   /$$  /$$$$$$       | $$     /$$$$$$   /$$$$$$$| $$$$$$$   /$$$$$$   /$$$$$$$  /$$$$$$ 
| $$$$$$$/|____  $$ /$$__  $$ /$$__  $$| $$  | $$ /$$__  $$      | $$$$$ /$$__  $$ /$$_____/| $$__  $$ |____  $$ /$$__  $$ /$$__  $$
| $$____/  /$$$$$$$| $$  \__/| $$  \ $$| $$  | $$| $$$$$$$$      | $$__/| $$$$$$$$| $$      | $$  \ $$  /$$$$$$$| $$  | $$| $$  \ $$
| $$      /$$__  $$| $$      | $$  | $$| $$  | $$| $$_____/      | $$   | $$_____/| $$      | $$  | $$ /$$__  $$| $$  | $$| $$  | $$
| $$     |  $$$$$$$| $$      |  $$$$$$$|  $$$$$$/|  $$$$$$$      | $$   |  $$$$$$$|  $$$$$$$| $$  | $$|  $$$$$$$|  $$$$$$$|  $$$$$$/
|__/      \_______/|__/       \____  $$ \______/  \_______/      |__/    \_______/ \_______/|__/  |__/ \_______/ \_______/ \______/ 
                                   | $$                                                                                             
                                   | $$                                                                                             
                                   |__/                                                                                             ");

        }

        public static void parkClosed3()
        {
            Console.Clear();
            Console.WriteLine(@" _______                                                          ________                    __                        __           
|       \                                                        |        \                  |  \                      |  \          
| $$$$$$$\ ______    ______    ______   __    __   ______        | $$$$$$$$______    _______ | $$____    ______    ____| $$  ______  
| $$__/ $$|      \  /      \  /      \ |  \  |  \ /      \       | $$__   /      \  /       \| $$    \  |      \  /      $$ /      \ 
| $$    $$ \$$$$$$\|  $$$$$$\|  $$$$$$\| $$  | $$|  $$$$$$\      | $$  \ |  $$$$$$\|  $$$$$$$| $$$$$$$\  \$$$$$$\|  $$$$$$$|  $$$$$$\
| $$$$$$$ /      $$| $$   \$$| $$  | $$| $$  | $$| $$    $$      | $$$$$ | $$    $$| $$      | $$  | $$ /      $$| $$  | $$| $$  | $$
| $$     |  $$$$$$$| $$      | $$__| $$| $$__/ $$| $$$$$$$$      | $$    | $$$$$$$$| $$_____ | $$  | $$|  $$$$$$$| $$__| $$| $$__/ $$
| $$      \$$    $$| $$       \$$    $$ \$$    $$ \$$     \      | $$     \$$     \ \$$     \| $$  | $$ \$$    $$ \$$    $$ \$$    $$
 \$$       \$$$$$$$ \$$        \$$$$$$$  \$$$$$$   \$$$$$$$       \$$      \$$$$$$$  \$$$$$$$ \$$   \$$  \$$$$$$$  \$$$$$$$  \$$$$$$ 
                                   | $$                                                                                              
                                   | $$                                                                                              
                                    \$$                                                                                              ");
        }

        public static void parkClosed4()
        {
            Console.Clear();
            Console.WriteLine(@" _______                                                          ________                   __                        __           
/       \                                                        /        |                 /  |                      /  |          
$$$$$$$  | ______    ______    ______   __    __   ______        $$$$$$$$/______    _______ $$ |____    ______    ____$$ |  ______  
$$ |__$$ |/      \  /      \  /      \ /  |  /  | /      \       $$ |__  /      \  /       |$$      \  /      \  /    $$ | /      \ 
$$    $$/ $$$$$$  |/$$$$$$  |/$$$$$$  |$$ |  $$ |/$$$$$$  |      $$    |/$$$$$$  |/$$$$$$$/ $$$$$$$  | $$$$$$  |/$$$$$$$ |/$$$$$$  |
$$$$$$$/  /    $$ |$$ |  $$/ $$ |  $$ |$$ |  $$ |$$    $$ |      $$$$$/ $$    $$ |$$ |      $$ |  $$ | /    $$ |$$ |  $$ |$$ |  $$ |
$$ |     /$$$$$$$ |$$ |      $$ \__$$ |$$ \__$$ |$$$$$$$$/       $$ |   $$$$$$$$/ $$ \_____ $$ |  $$ |/$$$$$$$ |$$ \__$$ |$$ \__$$ |
$$ |     $$    $$ |$$ |      $$    $$ |$$    $$/ $$       |      $$ |   $$       |$$       |$$ |  $$ |$$    $$ |$$    $$ |$$    $$/ 
$$/       $$$$$$$/ $$/        $$$$$$$ | $$$$$$/   $$$$$$$/       $$/     $$$$$$$/  $$$$$$$/ $$/   $$/  $$$$$$$/  $$$$$$$/  $$$$$$/  
                                   $$ |                                                                                             
                                   $$ |                                                                                             
                                   $$/                                                                                              ");
        }


        public static void parkAnimation()
        {
            var timespan = 500;
            while(true) {
                parkClosed1();
                Thread.Sleep(timespan);
                parkClosed2();
                Thread.Sleep(timespan);
                parkClosed3();
                Thread.Sleep(timespan);
                parkClosed4();
                Thread.Sleep(timespan);
            }
            
        }

        public static void writeAdminMenu()
        {
            Console.Clear();
            Console.WriteLine("  _______________________________________ ");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |--------     Administrador     --------|");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |         1  Ver Zonas                  |");
            Console.WriteLine(" |         2. Ver Histórico              |");
            Console.WriteLine(" |         3. Ver Máquinas               |");
            Console.WriteLine(" |         4. Voltar                     |");
            Console.WriteLine(" |         0. Sair                       |");
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("Escolha a opção pretendida -> ");
        }

        public static void writeClientMenu()
        {
            Console.Clear();
            Console.WriteLine("  _______________________________________ ");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |--------         Cliente       --------|");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |         1  Estacionar                 |");
            Console.WriteLine(" |         2. Ver Zonas                  |");
            Console.WriteLine(" |         3. Ver Histórico              |");
            Console.WriteLine(" |         4. Voltar                     |");
            Console.WriteLine(" |         0. Sair                       |");
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("Escolha a opção pretendida -> ");
        }

        public static int returnIndexInput()
        {
            var Inputstate = int.TryParse(Console.ReadLine(), out var indexInput);
            if (Inputstate)
            {
                return indexInput;
            }
            return-1;
        }

        public static void errorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção Inválida");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Clica Enter para tentar novamente");
            Console.ReadLine();
        }


        public static void showZonas(Zonas z1,Zonas z2,Zonas z3, int occ1, int occ2, int occ3)
        {
            Console.Clear();
            Console.WriteLine("  _____________________________________________________________");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($"     A Zona {z1.Id} custa {z1.Preco}€/hora com {z1.Spots} lugares, {z1.Spots-occ1} disponíveis            ");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($"     A Zona {z2.Id} custa {z2.Preco}€/hora com {z2.Spots} lugares, {z2.Spots - occ2} disponíveis              ");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($"     A Zona {z3.Id} custa {z3.Preco}€/hora com {z3.Spots} lugares, {z3.Spots - occ3} disponíveis           ");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine("  _____________________________________________________________");
        }
        public static void showMachines(double total1,double total2,double total3,int spots1,int spots2,int spots3)
        {
            Console.Clear();
            Console.WriteLine("  _____________________________________________________________");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($"                    Total de faturação: {Math.Round(total1+total2+total3,2)}€                                            ");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($"          A Zona 1 angariou {total1}€ com {spots1} lugares ocupados            ");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($"          A Zona 2 angariou {total2}€ com {spots2} lugares ocupados              ");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($"          A Zona 1 angariou {total3}€ com {spots3} lugares ocupados            ");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine("  _____________________________________________________________"); 
        }


        //faz a animação de processar e depois imprime o ticket
        public static void printTicket(Ticket t)
        {
            processingAnimation();
            int waitTime=500;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"--------------------------------------------------------------------------");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"|         .---------------.          TICKET DE ESTACIONAMENTO            |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"|        /   ( ͡° ͜ʖ ͡°)   \                                             |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine($@"|      O/_____/________/____\O                Zona {t.Idofzone.Id}                     |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"|      /__________+__________\                                           |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine($@"|     /    (#############)    \     Hora de Entrada: {t.DataStart} |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"|    | [**](#############)[**] |    Hora de Saída:                       |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine($@"|     \_______________________/     Montante:{Math.Round(t.PayedQT,2)}€                       |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine($@"|      | _""__|_,-----,_|__""_ |      Matrícula: {t.License}                  |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"|      | |     '-----'     | |                                           |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"|      '-'                 '-'                                           |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"|                          Obrigado e Boa Viagem!                        |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"__________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();


        }   

        //imprime o parque
        public static void printPark(List<int> lista)
        {
            int maxCol = 10;
            int maxRows = lista.Count/maxCol;
            int indexnumber=0;

            //deverá aceitar lista/array contendo os lugares ocupados e disponiveis, ver class ZONAS
            Console.Clear();
            for (int j = 0; j < maxCol; j++)
            {
                Console.Write("+---");
            }
            Console.Write("+\n");
            for (int i = 0; i < maxRows; i++)
            {
                
                for (int k=0; k < maxCol; k++)
                {
                    if (lista[indexnumber] == 1)
                    {
                        Console.Write("| █ ");
                        indexnumber++;
                    }
                    else
                    {
                        Console.Write("|   ");
                        indexnumber++;
                    }
                }
                Console.Write("|\n");
                if (indexnumber/maxCol < maxRows)
                {
                    for (int j = 0; j < maxCol; j++)
                    {
                        Console.Write("  - ");
                    }
                    Console.Write("\n");
                }
            }
            for (int j = 0; j < maxCol; j++)
            {
                Console.Write("+---");
            }
            Console.Write("+\n");
            
        }
        public static void writeZonas()
        {
            Console.Clear();
            Console.WriteLine("  _______________________________________ ");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |--------   Escolha uma Zona    --------|");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |            1. Zona 1                  |");
            Console.WriteLine(" |            2. Zona 2                  |");
            Console.WriteLine(" |            3. Zona 3                  |");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("Escolha a opção pretendida -> ");

        }

        //animação simples de blocos a empilharem
        public static void processingAnimation()
        {
            Console.Clear();
            Console.Write("Processando...");
                for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(400);
                Console.Write(" █ ");
            }
            Thread.Sleep(200);
            Console.Clear();
        }

        public static void printZone(Zonas z)
        {

            Console.Clear();
            Console.WriteLine("  _______________________________________ ");
            Console.WriteLine(" |                                       |");
            Console.WriteLine($" |--------         Zona {z.Id}        --------|");
            Console.WriteLine(" |                                       |");
            Console.WriteLine($"              Preço: {z.Preco}€/hora              ");
            Console.WriteLine(" |     Tempo Máximo de Estacionamento    |");
            Console.WriteLine($"                 {z.MaxTimeInMs} minutos             ");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |    1.Estacionar         2.Voltar      |");
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("Escolha a opção pretendida -> ");
        }


        public static void writeCarsList(List<Car> cars, int numberOfCars)
        {
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lista de Carros nesta Zona: ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < numberOfCars; i++)
            {
                Console.Write($"\n {i + 1}. Marca: {cars[i].Brand}\nMatrícula: {cars[i].LicensePlate}\nTempo Estacionado: {cars[i].ParkingTime} minutos\n");
            }
        }

    }
}