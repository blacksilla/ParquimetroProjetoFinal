using System.Runtime.InteropServices;
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
            bool parkStatus = Interface.parkStatus(CurrentHour, CurrentDayofTheWeek);

            //estados dos menus
            bool menuAdminActive = false;
            bool menuClientActive = false;
            bool menuMainActive = true;


            //inciar a criação de Zonas
            Zonas Zona1 = new Zonas(1, 1.15, 2700000, MathHelper.returnRandomInt());
            Zonas Zona2 = new Zonas(2, 1, 7200000, MathHelper.returnRandomInt());
            Zonas Zona3 = new Zonas(3, 0.62, 0, MathHelper.returnRandomInt());

            Interface.writeStartMenu(CurrentDate);
            var input = Interface.returnIndexInput();

            while (true) {


                

                //escreve o Menu Inicial com a data e hora a que o programa inicia e capta a escolha do utilizador
                

                
                switch (input) {
                    case 0://sair
                        Environment.Exit(0);
                        break;
                    case 1://Administrador

                        Interface.writeAdminMenu();
                        var input2 = Interface.returnIndexInput();
                        switch (input2)
                        {
                            case 0: Environment.Exit(0); break;
                            case 1: Interface.showZonas(Zona1, Zona2, Zona3); break; 
                            case 2: /*Ver Histórico*/break;
                            case 3: /*Ver Máquinas*/break;
                            case 4: /*Voltar*/ goto MainMenu;  
                        }
                        break;

                    case 2: //Cliente
                        menuClientActive = true;
                        Interface.writeClientMenu();
                        input2 = Interface.returnIndexInput();
                        while (true)
                        {
                            switch (input2)
                            {

                                case 0:
                                    Environment.Exit(0);
                                    break; //sair
                                case 1:
                                    break; //Estacionar
                                case 2:
                                    /*Ver Zonas*/
                                    Interface.showZonas(Zona1, Zona2, Zona3);
                                    Console.WriteLine("Clique Enter para voltar");
                                    Console.ReadLine();
                                    //menuMainActive = false;
                                    break;
                                    
                                    
                                case 3:
                                    /*Ver Históricos*/
                                    break;
                                case 4:
                                    /*Voltar*/
                                    goto MainMenu;
                            }
                            goto MainMenu;
                        }  
                    case 3: //Opções
                        Console.WriteLine("A fazer");
                        Console.ReadLine();
                        break;

                    default://Inválido
                        Interface.errorMessage();
                        break;
                        
                }

            MainMenu:
                continue;
            

            }


            
             

            


        }
        
       

    }
}