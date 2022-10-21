using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {

        //one-sided attack
        public static void DoAttack(Character attacker, Character defender)
        {
            //Roll a 100 sided dice
            int roll = new Random().Next(1, 101);
            Thread.Sleep(50);
            //The attacker "hits" if the roll is less than the attackers hit - defenders block.
            if (roll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //calculate the damage
                int damageDealt = attacker.CalcDamage();
                //Detract that damage from the defender's life
                defender.Life -= damageDealt;
                //Output the results to the screen
                //Red text helps indicate damage
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor(); //returns the color to normal
            }
            else //the attacker missed
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }



        }//end static void

        //Now we can create a method to handle "batle" - attack from both sides
        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);
            //if the monster survives, let them attack the player back
            if (monster.Life >0)
            {
                DoAttack(monster, player);
            }

            #region Potential Expansion - Initiative

            //Consider adding an "Initiative" property to Character
            //Then check the Initiative to determine who attacks first
            //if (player.Initiative >= monster.Initiative)
            //{
            //    DoAttack(player, monster);
            //}
            //else
            //{
            //    DoAttack(monster, player);
            //}

            #endregion

        }//end static void




    }//end class
}//end namespace
