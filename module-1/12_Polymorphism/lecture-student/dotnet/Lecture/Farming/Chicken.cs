using System;

namespace Lecture.Farming
{
    public class Chicken : FarmAnimal
    {
        public Chicken() : base("Chicken", "cluck")
        {
        }

        public void LayEgg()
        {
            Console.WriteLine("Chicken laid an egg!");
        }
    }
}
