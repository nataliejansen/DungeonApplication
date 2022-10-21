using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //FIELDS
        //MinDamage as an int - can't be more than MaxDamage, or less than 0


        //PROPERTIES
        //MinDamage as an int - can't be more than MaxDamage, or less than 0
        //MaxDamage as an int
        //Description as a string

        //CONSTRUCTORS



        //METHODS
        public Monster()
        {

        }
        public Monster(string name, int hitChance, int block, int maxLife) : base(name, hitChance, block, maxLife)
        {
            //Remember to set MaxDamage first!!!!!! -- MinDamage will reference MaxDamage
        }

        public override string ToString()
        {
            return $"----- {Name} -----\n" +
             $"Life: {Life} of {MaxLife}\n" +
             //Put Damage here---MinDamage to MaxDamage
             $"Hit Chance: {HitChance}%\n" +
             $"Block: {Block}";
            //Put Description here
        }
        public override int CalcDamage()
        {
            return base.CalcDamage();
            //return a random number between Monster min and max damage

        }

    } //end class
}//end namespace
