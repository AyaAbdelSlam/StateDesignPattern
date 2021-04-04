using System;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's cook a steak!
            Steak steak = new Steak("T-Bone");

            // Apply temperature changes
            steak.AddTemp(120);
            steak.AddTemp(15);
            steak.AddTemp(15);
            steak.RemoveTemp(10); //Yes I know cooking doesn't work this way, bear with me.
            steak.RemoveTemp(15);
            steak.AddTemp(20);
            steak.AddTemp(20);
            steak.AddTemp(20);

            Console.ReadKey();
        }
    }
}
