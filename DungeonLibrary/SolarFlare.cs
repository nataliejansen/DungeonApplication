using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class SolarFlare : Monster
    {

        public bool IsStrong { get; set; }

        public SolarFlare(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, 
            string description, bool isStrong)
            : base (name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsStrong = isStrong;
        }

        public SolarFlare()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Small Solar Flare";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "Small- but still enough to disrupt communications on Earth. At least the auroras are pretty!";
            IsStrong = false;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + (IsStrong? "A powerful burst of energy" : "A short-lived increase in the intensity of the Sun's radiation"); 
        }

        public override int CalcBlock()
        {
            //increase block by 50$
            int calculatedBlock = Block;

            if (IsStrong)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }//end class
}//end namespace
