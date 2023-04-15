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

        public void Save()
        {
            writer = new StreamWriter("TusindfrydBlomster.txt");
            foreach (Flower flower in flowers)
            {
                writer.WriteLine(flower.ToString());
            }
            writer.Close();
        }
     
        public int Count { get { return flowers.Count; } }

    
    }
}
