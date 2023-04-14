using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Models
{
    internal class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eagle Eat :Meat");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }

        public override void Legs()
        {
            Console.WriteLine("Eagle Legs: 2");
        }
    }
}
