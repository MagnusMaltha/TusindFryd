using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TusindFryd
{
    public class FlowerRepository
    {
        StreamWriter writer;
        StreamReader reader;

        public Flower flower { get; set; }

        private List<Flower> flowers = new List<Flower>();

        public void AddFlower(Flower flower)
        {
            flowers.Add(flower);
            
        }
        public Flower GetFlower(string id)
        {
            foreach (Flower flower in flowers) 
            {
                if (flower.Name == id) ;
                break;
            }
            return flower;
        }
        public int Count { get { return flowers.Count; } }

    
    }
}
