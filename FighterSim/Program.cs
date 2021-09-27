using System;

namespace FighterSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Console.WriteLine("Pick fighter 1 name");

            Fighter f1 = new Fighter(); 

            Console.WriteLine("fighter 1 name is" + f1.name);

            Console.ReadLine();
        }
    }
}
