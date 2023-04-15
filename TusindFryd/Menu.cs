using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TusindFryd
{
    public class Menu
    {
        
        public void ShowMenu()
        {
            Controller controller = new Controller();
            Console.WriteLine(@"Tusindfryd Menu:
1: Ny blomst
2: Ny produktion
3: Ny optælling
4: Afslut produktion
5: Juster halveringstid");

            void handleFirst() 
            {
                Console.WriteLine("1"); 
                controller.NewFlower(); 
            }
            void handleSecond() { Console.WriteLine("2"); }
            void handleThird() { Console.WriteLine("3"); }
            void handleFourth() { Console.WriteLine("4"); }
            void handleFifth() { Console.WriteLine("5"); }
            var key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    handleFirst();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    handleSecond();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    handleThird();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    handleFourth();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    handleFifth();
                    break;
                default:
                    Console.WriteLine("Wrong number try again");
                    break;
            }
            }
        
    }
}
