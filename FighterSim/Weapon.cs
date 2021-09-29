using System;

namespace FighterSim
{
    public class Weapon
    {

        private object[,]array =new object[3,2]{{"bow",25},{"sword",10},{"club",40} };
         private Random generator = new Random();
        private int r = 0;

        public int weaponType;

        public string weaponName; 

        public int weaponAttack; 
        public bool isHit = false; 

        public Weapon(){
            r = generator.Next(3);

            switch (r)
            {
                case 0:
                weaponType = r; 
                weaponName = Convert.ToString(array[0,0]);
                weaponAttack = Convert.ToInt16(array[0,1]);

                r = generator.Next(2);

                if (r == 1){
                    isHit = true;

                }

                break; 
                case 1:
                weaponType = r; 
                weaponName = Convert.ToString(array[1,0]);
                weaponAttack = Convert.ToInt16(array[1,1]);

                isHit = true; 

                break; 

                case 2:
                weaponType = r; 
                weaponName = Convert.ToString(array[2,0]);
                weaponAttack = Convert.ToInt16(array[2,1]);

                r = generator.Next(3);

                if (r == 1){
                    isHit = true;

                }

                break; 



            }
        }

    }


    }
