using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {

        //FIELDS // No Fields

        //PROPERTIES 
        //Race CharacterRace
        //EquippedWeapon Weapon
        //CONSTRUCTORS
        
        public Player(string name, int hitChance, int block, int maxLife) : base(name, hitChance, block, maxLife)
        {
            //handle unique assignment

           
            //Potential Expansion- not required

            //switch (CharacterRace)
            // {
            // case Race.Elf
                //HitChance += 5
                //MaxHealth -= 5
                //break;
                //}
        }

        public Player()
        {

        }

        //METHODS
        public override int CalcDamage()
        {
            //return a random value between the Weapon's min and max damage
            return 0;
        }
        public override int CalcHitChance()
        {
            return 0;
            //HitChance + Weapon BonusHitChance
        }
        public override string ToString()
        {
            //CREATE a holding variable for the description
            //THEN create a Switch on CharacterRace
            //Description = "Whatever"
            //case CharacterRace.Elf:    --"Describe an Elf"
            // break;
            return base.ToString(); //+ some unique description based on player race
            //HINT- use a switch
        }

    }//end class
}//end namespace
