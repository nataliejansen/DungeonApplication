    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DungeonLibrary
    {
        public class Monster : Character
        {
            //Fields // Funny
            //MinDamage as an int - can't be more than MaxDamage, or less than 0.
            private int _minDamage;


            //Properties // People
            //MaxDamage as an int
            public int MaxDamage { get; set; }
            //Description as a string
            public string Description { get; set; }
            //MinDamage as an int - can't be more than MaxDamage, or less than 0.
            public int MinDamage
            {
                get { return _minDamage; }
                set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
            }
            //Constructors // Collect

            //Methods // Monkeys
            public Monster()
            {
            }

            public Monster(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) : base(name, hitChance, block, maxLife)
            {
                //Remember to set MaxDamage first!!!
                MaxDamage = maxDamage;
                MinDamage = minDamage;
                Description = description;
            }
            public override string ToString()
            {
                return $"\n********** MONSTER **********\n" +
                       $"----- {Name} -----\n" +
                       $"Life: {Life} of {MaxLife}\n" +
                       $"Damage: {MinDamage} to {MaxDamage}" +
                       $"Hit Chance: {HitChance}%\n" +
                       $"Block: {Block}\n" +
                       $"Description: {Description}";
            }
            public override int CalcDamage()
            {
                return new Random().Next(MinDamage, MaxDamage + 1);

                //return a random number between Monster min and max damage.
            }

        public static Monster GetMonster()
        {
            Alien alien = new Alien("\nAn Alien!",25,50,20,8,2, "Take me to your leader? As if! This alien just wants to take over the Milky Way...and will stop at nothing to do it!",
                true);
            Alien babyAlien = new Alien();

            AnotherAstronaut anotherAstronaut = new AnotherAstronaut("\nRonald Cruise", 30, 70, 8, 1, 8, "He's trying to take over the Solar Sytem for selfish gain...not make it a better place!");

            TentacleMonster tentMonster = new TentacleMonster("\nA Tentacle Monster",25,50,10,4,1, "Legend has it he was born underneath the ice on Jupiter's moon Europa. He somehow got here and is not happy about it...",3,10);
            TentacleMonster babyTentMonster = new TentacleMonster();

            SolarFlare solarFlare = new SolarFlare("\nA Solar Flare!", 35, 65, 20, 15, 1, "SO. MUCH. RADIATION!!!", isStrong: true);
            SolarFlare smallSolarFlare = new SolarFlare();

            List<Monster> monsters = new List<Monster>()
            {
                alien,
                babyAlien, babyAlien, babyAlien,
                anotherAstronaut,
                tentMonster,
                babyTentMonster, babyTentMonster, babyTentMonster,
                solarFlare,
                smallSolarFlare,
            };
            int randomIndex = new Random().Next(monsters.Count);
            Monster monster = monsters[randomIndex];
            return monster;
        }




        }//end class
    }//end namespace

