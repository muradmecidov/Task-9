using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Models
{
    internal class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Shark Eat : Meat");
        }

        public override void Legs()
        {
            Console.WriteLine("fish don't have legs");
        }

        public override void Swim()
        {
            Console.WriteLine("Shark Swim : Swim as Shark");
        }
    }
}
