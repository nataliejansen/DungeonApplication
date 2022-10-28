using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Alien : Monster
    { 

        //FIELDS

        //PROPERTIES
        public bool IsGreen { get; set; }

        //CONSTRUCTORS
        //Default CTOR to set some basic values for a generic monster of this type

        public Alien()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Baby Alien";
            Life = MaxLife;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "The baby alien doesn't even know what's going on!";
            IsGreen = false;
        }
        //Parent compliant (Monster) CTOR
        //Intellisense quick action on the Parent name in the class declaration
        public Alien(string name, int maxLife, int hitChance, int block, //Character
            int maxDamage, int minDamage, string description, //Monster
            bool isGreen) 
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsGreen = isGreen;
        }


        //METHODS

        public override string ToString()
        {
            return base.ToString() + (IsGreen ? "It's green" : "It's not so green"); 
        }

        //Character CalcBlock 
        //Monster CalcBlock = Block
        //Rabbit CalcBlock = not block

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            //Apply a 50% increase to the alien's if it's green
            if (IsGreen)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }//end class
}//end namespace
