using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TusindFryd
{
    public class Controller
    {
        public FlowerRepository flowerRepository;
        public Controller() { }
        public void NewFlower()
        {
            Console.WriteLine("New Flower");
            Console.WriteLine("Name");
            string flowerName = "blomst";//Console.ReadLine();
            Console.WriteLine("Production");
            string flowerProductionTime = "20";// Console.ReadLine();
            Console.WriteLine("HalfLife");
            string flowerHalfLife = "150";// Console.ReadLine();
            Console.WriteLine("size");
            string flowerSizem2 = "0,5";// Console.ReadLine();
            Console.WriteLine("Picture");
            string flowerPicture = "Image1";// Console.ReadLine();

            flowerRepository.AddFlower(new Flower(flowerName, int.Parse(flowerProductionTime), int.Parse(flowerHalfLife), double.Parse(flowerSizem2), flowerPicture));
            
            //Console.WriteLine(flower);
           
            //flowerRepository.AddFlower(flower);

        }
        public void AddFlowerToList(Flower flower) 
        {
            flowerRepository.AddFlower(flower);
        }
    }
}
