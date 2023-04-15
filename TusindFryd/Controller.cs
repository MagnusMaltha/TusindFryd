using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TusindFryd
{
    public class Controller
    {
        public FlowerRepository FlowerRepository { get; set; }
        public Controller() { }
        public void NewFlower()
        {
            Console.WriteLine("New Flower");
            Console.WriteLine("Name");
            string flowerName = Console.ReadLine();
            Console.WriteLine("Production");
            string flowerProductionTime = Console.ReadLine();
            Console.WriteLine("HalfLife");
            string flowerHalfLife = Console.ReadLine();
            Console.WriteLine("size");
            string flowerSizem2 = Console.ReadLine();
            Console.WriteLine("Picture");
            string flowerPicture = Console.ReadLine();

            Flower flower = new Flower(flowerName, int.Parse(flowerProductionTime), int.Parse(flowerHalfLife), double.Parse(flowerSizem2), flowerPicture);
            Console.WriteLine(flower);
        }
        public void AddFlowerToList(Flower flower) 
        {
            FlowerRepository.AddFlower(flower);
        }
    }
}
