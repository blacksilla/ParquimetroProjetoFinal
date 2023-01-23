using System.Collections;
using System.Runtime.InteropServices;
using System.Transactions;

namespace ParquimetroProjetoFinal
{
    internal class Parquimetro
    {   
        
        
        static void Main(string[] args)
        {
            //falta criar sistema de horas de funcionamento do parque seg-sex:9-20/sab:9-14 (ex sabado as 15 não deverá aceitar ou estacionar ou moedas)
            
            


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
            Zonas Zona1 = new Zonas(1, 1.15, 45, MathHelper.returnRandomInt(1 , 5 , 10));
            Zonas Zona2 = new Zonas(2, 1, 120, MathHelper.returnRandomInt(1, 5 , 10));
            Zonas Zona3 = new Zonas(3, 0.62, 0, MathHelper.returnRandomInt(1, 5, 10));

            //Retorna a disposição de cada parque depois de serem gerados os spots de forma aleatoria
            List<int> Zona1Occspots = Zonas.fillParkingSlots(Zona1);
            List<int> Zona2Occspots = Zonas.fillParkingSlots(Zona2);
            List<int> Zona3Occspots = Zonas.fillParkingSlots(Zona3);


            //garante que o valor dos lugares ocupados é guardado no main
            int Zona1occ = 0;
            int Zona2occ = 0;
            int Zona3occ = 0;

            

            for (int i = 0; i < Zona1Occspots.Count; i++)
            {
                if (Zona1Occspots[i] == 1)
                    Zona1occ++;
            }
            for (int i = 0; i < Zona2Occspots.Count; i++)
            {
                if (Zona2Occspots[i] == 1)
                    Zona2occ++;
            }
            for (int i = 0; i < Zona3Occspots.Count; i++)
            {
                if (Zona3Occspots[i] == 1)
                    Zona3occ++;
            }


            //gera carros random para os lugares ocupados recolhidos anteriormente
            List<Car> carsInZone1 = Car.returnParkedCars(Zona1occ); 
            List<Car> carsInZone2 = Car.returnParkedCars(Zona2occ); 
            List<Car> carsInZone3 = Car.returnParkedCars(Zona3occ); 

            //gerar valores monetarios para cada parque (ADMIN)
            double GrandTotalofTheParks = 0;
            double TotalAmountofZone1 = 0;
            double TotalAmountofZone2 = 0;
            double TotalAmountofZone3 = 0;


            for (int i = 0; i < Zona1occ; i++)
            {
                var carPrice = carsInZone1[i].ParkingTime * Zona1.Preco;
                TotalAmountofZone1 += carPrice;
            }
            for (int i = 0; i < Zona2occ; i++)
            {
                var carPrice = carsInZone2[i].ParkingTime * Zona2.Preco;
                TotalAmountofZone2 += carPrice;
            }
            for (int i = 0; i < Zona3occ; i++)
            {
                var carPrice = carsInZone3[i].ParkingTime * Zona3.Preco;
                TotalAmountofZone3 += carPrice;
            }

            TotalAmountofZone1 = Math.Round(TotalAmountofZone1,2);
            TotalAmountofZone2 = Math.Round(TotalAmountofZone2,2);
            TotalAmountofZone3 = Math.Round(TotalAmountofZone3,2);
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
                                    InterfaceHelper.writeZonas();
                                    input = InterfaceHelper.returnIndexInput();
                                    switch (input)
                                    {
                                        case 1:
                                            //InterfaceHelper.printZone(Zona1);
                                            InterfaceHelper.printPark(Zona1Occspots);
                                            Console.WriteLine("ZONA 1");
                                            Console.WriteLine($"Total do dia: {TotalAmountofZone3}€ || Total dos Parques: {Math.Round(TotalAmountofZone1 + TotalAmountofZone2 + TotalAmountofZone3,2)}€");
                                            Console.WriteLine($"Tamanho: {Zona1.Spots} || Lugares ocupados: {Zona1occ} || Lugares disponíveis: {Zona1.Spots - Zona1occ}");
                                            InterfaceHelper.writeCarsList(carsInZone1, Zona1occ);
                                            Console.WriteLine();
                                            Console.WriteLine("Clique Enter para voltar");
                                            break;
                                        case 2:
                                            //InterfaceHelper.printZone(Zona2);
                                            InterfaceHelper.printPark(Zona2Occspots);
                                            Console.WriteLine("ZONA 2");
                                            Console.WriteLine($"Total do dia: {TotalAmountofZone3}€ || Total dos Parques: {Math.Round(TotalAmountofZone1 + TotalAmountofZone2 + TotalAmountofZone3, 2)}€");
                                            Console.WriteLine($"Tamanho: {Zona2.Spots} || Lugares ocupados: {Zona2occ} || Lugares disponíveis: {Zona2.Spots - Zona2occ}");
                                            InterfaceHelper.writeCarsList(carsInZone2, Zona2occ);
                                            Console.WriteLine();
                                            Console.WriteLine("Clique Enter para voltar");
                                            break;
                                        case 3:
                                            //InterfaceHelper.printZone(Zona3);
                                            InterfaceHelper.printPark(Zona3Occspots);
                                            Console.WriteLine("ZONA 3");
                                            Console.WriteLine($"Total do dia: {TotalAmountofZone3}€ || Total dos Parques: {Math.Round(TotalAmountofZone1 + TotalAmountofZone2 + TotalAmountofZone3, 2)}€");
                                            Console.WriteLine($"Tamanho: {Zona3.Spots} || Lugares ocupados: {Zona3occ} || Lugares disponíveis: {Zona3.Spots - Zona3occ}");
                                            InterfaceHelper.writeCarsList(carsInZone3, Zona3occ);
                                            Console.WriteLine();
                                            Console.WriteLine("Clique Enter para voltar");
                                            break;
                                        default: InterfaceHelper.errorMessage(); continue;
                                    }

                                    Console.ReadLine();
                                    break;
                                case 3: /*Ver Máquinas*/
                                    InterfaceHelper.showMachines(TotalAmountofZone1, TotalAmountofZone2, TotalAmountofZone3, Zona1occ, Zona2occ, Zona3occ);
                                    Console.ReadLine();

                                    break;



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
                                    input=InterfaceHelper.returnIndexInput();
                                    switch (input)
                                        {
                                        case 1:
                                            InterfaceHelper.printZone(Zona1);
                                            input = InterfaceHelper.returnIndexInput();
                                            switch (input) {
                                                case 1:
                                                InterfaceHelper.printPark(Zona1Occspots);
                                                Console.WriteLine($"Tamanho: {Zona1.Spots} || Lugares ocupados: {Zona1occ} || Lugares disponíveis: {Zona1.Spots - Zona1occ}");
                                                Ticket.paymentNchange(Zona1);
                                                    break;
                                                case 2:
                                                    continue;
                                                default: InterfaceHelper.errorMessage(); continue;
                                            }
                                            

                                            break;
                                        case 2:
                                            //InterfaceHelper.printZone(Zona2);
                                            InterfaceHelper.printZone(Zona2);
                                            input = InterfaceHelper.returnIndexInput();
                                            switch (input)
                                            {
                                                case 1:
                                                    InterfaceHelper.printPark(Zona2Occspots);
                                                    Console.WriteLine($"Tamanho: {Zona2.Spots} || Lugares ocupados: {Zona2occ} || Lugares disponíveis: {Zona2.Spots - Zona2occ}");
                                                    Ticket.paymentNchange(Zona2);
                                                    break;
                                                case 2:
                                                    continue;
                                                default: InterfaceHelper.errorMessage(); continue;
                                            }


                                            break;
                                        case 3:
                                            //InterfaceHelper.printZone(Zona3);
                                            InterfaceHelper.printZone(Zona3);
                                            input = InterfaceHelper.returnIndexInput();
                                            switch (input)
                                            {
                                                case 1:
                                                    InterfaceHelper.printPark(Zona3Occspots);
                                                    Console.WriteLine($"Tamanho: {Zona3.Spots} || Lugares ocupados: {Zona3occ} || Lugares disponíveis: {Zona3.Spots - Zona3occ}");
                                                    Ticket.paymentNchange(Zona3);
                                                    break;
                                                case 2:
                                                    continue;
                                                default: InterfaceHelper.errorMessage(); continue;
                                            }


                                            break;
                                        default: InterfaceHelper.errorMessage(); break;
                                    }
                                    
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
                                default:
                                    InterfaceHelper.errorMessage();
                                    break;
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