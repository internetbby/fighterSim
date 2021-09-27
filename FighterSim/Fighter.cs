using System;

namespace FighterSim
{
    public class Fighter
    {

        private Weapon w1= new Weapon();

        
        private int hp = 100; 
        public string name; 

        public int weaponChose ; 

        public Fighter(){
            name = Console.ReadLine();

        }
    }   
    
}