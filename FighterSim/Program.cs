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

           System.Console.WriteLine("Pick fighter 2 name");

            Fighter f2 = new Fighter();

            
            
            

            Console.WriteLine("fighter 1 name is " + f1.name);
            
            Console.WriteLine("fighter 2 name is " + f2.name);
            
            Console.WriteLine("fighter 1 weapon is " + f1.w1.weaponName);

            Console.WriteLine("fighter 2 weapon is " + f2.w1.weaponName);

            while(f1.hp >  0 || f2.hp > 0){
                System.Console.WriteLine(f1.name + " ATTACKS");
                f1.Attack(f2);

                Console.ReadLine();

                System.Console.WriteLine(f2.name + " ATTACKS");
                f2.Attack(f1);

                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
