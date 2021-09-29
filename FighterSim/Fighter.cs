using System;

namespace FighterSim
{
    public class Fighter
    {

        public Weapon w1= new Weapon();

        
        public int hp = 100; 
        public string name; 

        private int weaponChose ; 

        public Fighter(){
            name = Console.ReadLine();

            weaponChose = w1.weaponType;

        }

        public void Attack(Fighter target)
        {
            if (w1.isHit == true){
                target.hp = target.hp - w1.weaponAttack;
            }

            System.Console.WriteLine("HERO " + target.name + " HP LEFT: " + target.hp);
        }
    }   
    
}