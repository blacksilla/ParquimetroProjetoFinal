﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParquimetroProjetoFinal
{
    //Sou lindo


    //teste
    //este é o paymentBranch
    //este é o paymentBranch1
    internal class Interface
    {
        //define o horario de funcionamento da app
        public static bool parkStatus(int hour, int dayOfWeek)
        {
            
            if (dayOfWeek < 6 && hour >= 9 && hour <= 20)
            {
                return true;
            }
            else if (dayOfWeek == 7 && hour >= 9 && hour <= 14)
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


        public static void showZonas(Zonas z1,Zonas z2,Zonas z3)
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("  _____________________________________________________________");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($" |         A Zona {z1.Id} custa {z1.Preco}€/hora com {z1.Spots} lugares            |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($" |         A Zona {z2.Id} custa {z2.Preco}€/hora com {z2.Spots} lugares               |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine($" |         A Zona {z3.Id} custa {z3.Preco}€/hora com {z3.Spots} lugares            |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine(" |                                                             |");
            Console.WriteLine("  _____________________________________________________________");
        }


        //faz a animação de processar e depois imprime o ticket
        public static void printTicket(DateTime data)
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
            Console.WriteLine(@"|      O/_____/________/____\O              Parque X                     |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"|      /__________+__________\                                           |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine($@"|     /    (#############)    \     Hora de Entrada: {data} |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"|    | [**](#############)[**] |    Hora de Saída:                       |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"|     \_______________________/     Montante:                            |");
            Thread.Sleep(waitTime);
            Console.Beep();
            Console.WriteLine(@"|      | _""__|_,-----,_|__""_ |      Matrícula: AA-XX-AA                  |");
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
        public static void printPark()
        {
            int maxRow = 10;

            //deverá aceitar lista/array contendo os lugares ocupados e disponiveis, ver class ZONAS
            Console.Clear();
            Console.WriteLine(@"
+---+---+---+---+---+---+---+---+---+---+
| █ | █ | █ | █ | █ | █ | █ | █ | █ | █ |
  -   -   -   -   -   -   -   -   -   -
| █ | █ | █ | █ | █ | █ | █ | █ | █ | █ |
  -   -   -   -   -   -   -   -   -   -
| █ | █ | █ | █ | █ | █ | █ | █ | █ | █ |
  -   -   -   -   -   -   -   -   -   -
| █ | █ | █ | █ | █ | █ | █ | █ | █ | █ |
  -   -   -   -   -   -   -   -   -   -
| █ | █ | █ | █ | █ | █ | █ | █ | █ | █ |
+---+---+---+---+---+---+---+---+---+---+
");
            Console.WriteLine("A Zona X tem Y lugares disponíveis");
            Console.WriteLine("Deseja Estacionar? - 1   Voltar - 4");

           

            

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
            Console.WriteLine($" |         Preço: {z.Preco}€/hora             |");
            Console.WriteLine(" |     Tempo Máximo de Estacionamento    |");
            Console.WriteLine($" |              {z.MaxTimeInMs / 60000} minutos               |");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |    1.Estacionar         2.Voltar      |");
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("Escolha a opção pretendida -> ");


            Console.ReadLine();
        }




    }
}