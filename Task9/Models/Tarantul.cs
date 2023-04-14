using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Models
{
    internal class Tarantul : Spider
    {
        public override void Cobweb()
        {
            Console.WriteLine("Cobweb as Tarantul");
        }

        public override void Eat()
        {
            Console.WriteLine("Tarantul Eat: Worm");
        }

        public override void Legs()
        {
            Console.WriteLine("Tarantul Legs: 8");
        }
        public override void NumberOfEyes()
        {
            Console.WriteLine("Tarantul NumberOfEyes: 8");
        }
    }
}
