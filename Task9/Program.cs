using Task9.Models;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();


            Shark shark = new Shark();


            Tarantul tantul = new Tarantul();

            Animal[] animals = new Animal[] {eagle,shark,tantul };
            foreach (var animal in animals)
            {
                animal.Eat();
                animal.Legs();
                animal.NumberOfEyes();
                animal.See();
            }




        }
    }
}