using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Models
{
    abstract class Animal
    {
        public abstract void Eat();
        public virtual void See() 
        {
            Console.WriteLine("See as Animal");
        }
        public abstract void Legs();
        public virtual void NumberOfEyes() 
        {
            Console.WriteLine(2);
        }

    }
}
