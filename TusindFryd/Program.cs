using System.Security.Cryptography.X509Certificates;

namespace TusindFryd
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Menu menu = new Menu();
            menu.menuShow = true;
            Controller controller = new Controller();
            FlowerRepository flowerRepository = new FlowerRepository();
            while (menu.menuShow == true)
            {
                menu.ShowMenu();
            }
            //controller.NewFlower();

            //Console.WriteLine("New Flower");
            //Console.WriteLine("Name");
            //string flowerName = "blomst";//Console.ReadLine();
            //Console.WriteLine("Production");
            //string flowerProductionTime = "20";// Console.ReadLine();
            //Console.WriteLine("HalfLife");
            //string flowerHalfLife = "150";// Console.ReadLine();
            //Console.WriteLine("size");
            //string flowerSizem2 = "0,5";// Console.ReadLine();
            //Console.WriteLine("Picture");
            //string flowerPicture = "Image";// Console.ReadLine();
            //flowerRepository.AddFlower(new Flower(flowerName, int.Parse(flowerProductionTime), int.Parse(flowerHalfLife), double.Parse(flowerSizem2), flowerPicture));
            //flowerRepository.Save();
            //flowerRepository.load();
        }
    }
}