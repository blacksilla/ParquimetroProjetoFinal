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
            
            if (dayOfWeek > 0 && dayOfWeek < 6 && hour >= 9 && hour < 20)
            {
                return true;
            }
            else if (dayOfWeek == 7 && hour >= 9 && hour < 14)
            {
                return true;
            }
            else return false;
        }

       //ecrã inicial do programa

        public static void writeStartMenu(DateTime date)
        {
            Console.Clear();
            Console.WriteLine("  _______________________________________ ");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |--------      Bem-vindo        --------|");
            Console.WriteLine(" |--------  Sistema Parquimetro  --------|");
            Console.Write($" |         ");
            Console.ForegroundColor=ConsoleColor.Blue;
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

        //parte 1 da animação do parque fechado
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
            Console.WriteLine("Clique 'ESC' para sair");
            
        }

        //parte 2 da animação do parque fechado
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
            Console.WriteLine("Clique 'ESC' para sair");

        }
        //parte 3 da animação do parque fechado
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
            Console.WriteLine("Clique 'ESC' para sair");
        }
        //parte 4 da animação do parque fechado
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
            Console.WriteLine("Clique 'ESC' para sair");
        }

        //junção das 4 partes para animar as letras, espera um ESC para voltar ao menu
        public static void parkAnimation()
        {
            
            var timespan = 500;

            ConsoleKeyInfo input;
            do
            {
                parkClosed1();
                Thread.Sleep(timespan);
                parkClosed2();
                Thread.Sleep(timespan);
                parkClosed3();
                Thread.Sleep(timespan);
                parkClosed4();
                Thread.Sleep(timespan);
                input = Console.ReadKey();
            } while (input.Key != ConsoleKey.Escape);



           
                
                
            
            
        }

        //escreve o menu administrador
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

        //escreve o menu cliente
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

        //metodo para garantir que o input é um inteiro, retorna -1 porque não faz parte dos menus, entra no default
        public static int returnIndexInput()
        {
            var Inputstate = int.TryParse(Console.ReadLine(), out var indexInput);
            if (Inputstate)
            {
                return indexInput;
            }
            return-1;
        }

        //escreve uma mensagem de erro caso o input esteja fora do menu, triggered para quando o metodo de cima retorna -1
        public static void errorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção Inválida");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Clica Enter para tentar novamente");
            Console.ReadLine();
        }

        //mostra o preço, lugares totais e lugares disponiveis das 3 zonas ao mesmo tempo
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

        //mostra o valor total das zonas e de cada zona individualmente
        public static void showMachines(double total1,double total2,double total3,int spots1,int spots2,int spots3)
        {
            Console.Clear();
            Console.WriteLine("  _____________________________________________________________");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($"                    Total de faturação: {Math.Round(total1+total2+total3,2)}€                                            ");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($"          A Zona 1 angariou {Math.Round(total1, 2)}€ com {spots1} lugares ocupados             ");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($"          A Zona 2 angariou {Math.Round(total2, 2)}€ com {spots2} lugares ocupados              ");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($"          A Zona 3 angariou {Math.Round(total3, 2)}€ com {spots3} lugares ocupados            ");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine("  _____________________________________________________________"); 
        }

        //animação simples de blocos a empilharem
        public static void processingAnimation()
        {
            Console.Clear();
            Console.Write("Processando...");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(400);
                Console.Write(" █ ");
            }
            Thread.Sleep(200);
            Console.Clear();
        }

        //faz a animação de processar e depois imprime o ticket, mostrando a Zona, hora de entrada/saida, montante gasto e a matricula do veiculo
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
            Console.WriteLine($@"|    | [**](#############)[**] |    Hora de Saída: {t.DataLeave}   |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine($@"      \_______________________/     Montante: {Math.Round(t.PayedQT,2)}€                      ");
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
            Console.WriteLine("Enter para voltar ao menu");
            Console.ReadLine();


        }   

        //imprime o parque com extremidades superior e inferior, onde há carros com blocos brancos e onde está vazio, fica apenas vazio
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

        //escreve um menu para o utilizador escolher a zona que quer estacionar
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


        //menu seguinte ao writeZonas() que mostra um pouco de info sobre a zona que vão estacionar, nada como redundância :D
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

        //desenha ecrã caso não haja mais lugares disponíveis na zona para estacionar
        public static void cantPark(Zonas z)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  _______________________________________ ");
            Console.WriteLine(" |                                       |");
            Console.WriteLine($" |--------         Zona {z.Id}        --------|");
            Console.WriteLine(" |                                       |");
            Console.WriteLine($"                            ");
            Console.WriteLine($" |    A Zona {z.Id} está totalmente ocupada   |");
            Console.WriteLine($"                              ");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" _________________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Prima Enter para voltar ");
            Console.ReadLine();
        }

        //no historico do Admin, escreve a lista de carros na zona com marca, matricula e tempo de estacionamento; mostra também se o estão dentro ou fora do limite de tempo
        public static void writeCarsList(List<Car> cars, int numberOfCars, Zonas zona)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Lista de Carros nesta Zona: ");
            Console.ForegroundColor = ConsoleColor.White;

          

            for (int i = 0; i < numberOfCars; i++)
            {
                Console.Write($"\n {i + 1}. Marca: {cars[i].Brand}\nMatrícula: {cars[i].LicensePlate}\nTempo Estacionado: {cars[i].ParkingTime} minutos\n");
                if (zona.MaxTimeInMs != 0)
                {
                    if (cars[i].ParkingTime > zona.MaxTimeInMs)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Tempo de estacionamento excedido \n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Dentro do tempo regulamentar \n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"Se não tem limite, não tem limite ¯\_(ツ)_/¯"+ "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        //desenha o histórico de bilhetes que o utilizador tem
        public static void drawTickets(List <Ticket> tickets)
        {

            Console.Clear();
            tickets.ForEach(x => Console.WriteLine($"Ticket {tickets.IndexOf(x) + 1} : Zona {x.Idofzone.Id} - Hora de Entrada:  {x.DataStart} - Hora de Saída:  {x.DataLeave} - Preço Pago: {x.PayedQT}€ - Matrícula: {x.License}  "));
            Console.WriteLine("Enter para voltar");
            Console.Read();
        }
    }
}