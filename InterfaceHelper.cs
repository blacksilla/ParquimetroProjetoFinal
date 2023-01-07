﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParquimetroProjetoFinal
{
    //teste
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
            Console.Clear();
            Console.WriteLine("  _______________________________________ ");
            Console.WriteLine(" |                                       |");
            Console.WriteLine(" |--------      Bem-vindo        --------|");
            Console.WriteLine(" |--------  Sistema Parquímetro  --------|");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine($" |         {date.ToString()}           |");
            Console.ForegroundColor = ConsoleColor.White;
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


        

    }
}