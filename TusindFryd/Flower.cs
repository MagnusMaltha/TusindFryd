using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TusindFryd
{
    public class Flower
    {
        public string Name;
        public int ProductionTime;
        public int HalfLife;
        public double Sizem2;
        public string ImageName;

        public Flower(string name, int productionTime, int halfLife, double sizem2, string imageName)
        {
            Name = name;
            ProductionTime = productionTime;
            HalfLife = halfLife;
            Sizem2 = sizem2;
            ImageName = imageName;
        }
        public override string ToString() 
        {
            return $"Flower: {Name}; Production time: {ProductionTime}; Half-life: {HalfLife}; Size: {Sizem2}; Image: {ImageName}";
        }
    }
}
