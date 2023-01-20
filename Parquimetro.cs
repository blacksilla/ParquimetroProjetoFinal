﻿using System.Runtime.InteropServices;
using System.Transactions;

namespace ParquimetroProjetoFinal
{
    internal class Parquimetro
    {   
        
        
        static void Main(string[] args)
        {
            //falta criar sistema de horas de funcionamento do parque seg-sex:9-20/sab:9-14 (ex sabado as 15 não deverá aceitar ou estacionar ou moedas)
            //falta por o sistema de menus a funcionar corretamente
            


            //Por a consola a dar display corretamente dos caracteres especiais como o €
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            //guardar a hora de inicio do programa
            DateTime CurrentDate = DateTime.Now;
            int CurrentHour = CurrentDate.Hour;
            int CurrentDayofTheWeek = (int)CurrentDate.DayOfWeek;

            //Horario funcionamento do parque
            bool parkStatus = InterfaceHelper.parkStatus(CurrentHour, CurrentDayofTheWeek);

            //estados dos menus
            bool menuAdminActive = false;
            bool menuClientActive = false;
            bool menuMainActive = true;


            //inciar a criação de Zonas
            Zonas Zona1 = new Zonas(1, 1.15, 2700000, MathHelper.returnRandomInt(1 , 5 , 10));
            Zonas Zona2 = new Zonas(2, 1, 7200000, MathHelper.returnRandomInt(1, 5 , 10));
            Zonas Zona3 = new Zonas(3, 0.62, 0, MathHelper.returnRandomInt(1, 5, 10));
            List <int> Zona1Occspots = Zonas.fillParkingSlots(Zona1);

            //Ticket.paymentNchange(Zona1);



            while (menuMainActive) {

                //escreve o Menu Inicial com a data e hora a que o programa inicia e capta a escolha do utilizador
                
                InterfaceHelper.writeStartMenu(CurrentDate);
                var input = InterfaceHelper.returnIndexInput();

                switch (input) {

                    case 0://sair
                        menuMainActive = false;
                        Environment.Exit(0);
                        break;

                    case 1://Administrador
                        menuAdminActive= true;
                        
                        while (menuAdminActive)
                        {
                            InterfaceHelper.writeAdminMenu();
                            input = InterfaceHelper.returnIndexInput();
                            switch (input)
                            {
                                case 0: Environment.Exit(0); break;

                                case 1: //Ver Zonas
                                    InterfaceHelper.showZonas(Zona1, Zona2, Zona3);
                                    Console.WriteLine("Clique qualquer tecla para voltar");
                                    input= InterfaceHelper.returnIndexInput();
                                    if (input != 4)
                                        input = 4; break;


                                case 2: /*Ver Histórico*/

                                    //zona random com carro random com tempo estacionamento random
                                    //retorna uma matricula random
                                    //class Car
                                    Zonas.fillParkingSlots(Zona1);
                                    Console.ReadLine();
                                    break;
                                case 3: /*Ver Máquinas*/break;



                                case 4: /*Voltar*/menuAdminActive = false;  goto MainMenu;



                                default:
                                    InterfaceHelper.errorMessage();
                                    break;
                            }
                        }
                        break;

                    case 2: //Cliente
                        menuClientActive = true;
                        
                        while (menuClientActive)
                        {
                            InterfaceHelper.writeClientMenu();
                            input = InterfaceHelper.returnIndexInput();
                            switch (input)
                            {

                                case 0:
                                    Environment.Exit(0);
                                    break; //sair
                                case 1:

                                    InterfaceHelper.writeZonas();
                                    Console.ReadLine();
                                    InterfaceHelper.printPark(Zona1Occspots);
                                    Console.ReadLine();
                                    InterfaceHelper.printTicket(CurrentDate);
                                    menuClientActive= false;
                                    goto MainMenu;
                                    //Estacionar

                                case 2:
                                    //Ver Zonas
                                    InterfaceHelper.showZonas(Zona1, Zona2, Zona3);
                                    Console.WriteLine("Clique Enter para voltar");
                                    input = InterfaceHelper.returnIndexInput();
                                    if (input != 4)
                                        input = 4; break;


                                case 3:
                                    /*Ver Históricos*/
                                    break;
                                case 4:
                                    /*Voltar*/
                                    menuClientActive = false;
                                    goto MainMenu;
                                    
                            }
                            
                        }
                        break;

                    case 3: //Opções
                        Console.WriteLine("A fazer");
                        Console.ReadLine();
                        break;

                    default://Inválido
                        InterfaceHelper.errorMessage();
                        break;
                        
                }

            MainMenu:
                continue;
            }


            
             

            


        }
        
       

    }
}