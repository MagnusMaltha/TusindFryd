using System.Security.Cryptography.X509Certificates;

namespace TusindFryd
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.ShowMenu();

            
            //Controller controller = new Controller();
            //Console.WriteLine("Name");
            //string flowerName = Console.ReadLine();
            //Console.WriteLine("Production");
            //string flowerProductionTime = Console.ReadLine();
            //Console.WriteLine("HalfLife");
            //string flowerHalfLife = Console.ReadLine();
            //Console.WriteLine("size");
            //string flowerSizem2 = Console.ReadLine();
            //Console.WriteLine("Picture");
            //string flowerPicture = Console.ReadLine();

            //Flower flower = new Flower(flowerName, int.Parse(flowerProductionTime), int.Parse(flowerHalfLife), double.Parse(flowerSizem2), flowerPicture);
            //Console.WriteLine(flower);
        }
    }
}