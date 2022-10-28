using DungeonLibrary;
using System.IO;

namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title & Introduction

            #region Title / Introduction

            Console.Title = "SOLAR SYSTEM";

            Console.WriteLine("HELP! Our Solar Sytem is under attack! \n");

            #endregion

            //Variable to Track Score

            int score = 0;

            //TODO Weapon Object to be created
            Weapon sword = new Weapon(WeaponType.Sword, 5, "Sword", 3, false, 1);
            Weapon deathRay = new Weapon(WeaponType.DeathRay, 10, "Death Ray", 9, true, 5);
            Weapon laserPistol = new Weapon(WeaponType.LaserPistol, 6, "Laser Pistol", 5, true, 3);
            Weapon mindControl = new Weapon(WeaponType.MindControl, 10, "Mind Control", 5, false, 1);
            Weapon shield = new Weapon(WeaponType.Shield, 3, "Shield", 1, false, 1);

            //Console.WriteLine(sword);//test the ToString()
            //Create a list of weapons, and either give the player a random weapon, let them pick a weapon, 
            //or let them pick a WeaponType, and give them a weapon based off of that type.





            #region Player Object Creation
            Player player1 = new Player("Orion Jansen", 50, 5, 40, Race.Human, sword);
            Player player2 = new Player("Melvin", 65, 6, 50, Race.GoodAlien, laserPistol);
            Player player3 = new Player("Patrick", 70, 9, 75, Race.Consiousness, mindControl);
            Player player4 = new Player("Codescar", 40, 4, 40, Race.Dog, shield);
            Player player5 = new Player("Bella", 80, 8, 60, Race.Cat, deathRay);

            List<Player> players = new List<Player>()
            {
                player1,
                player2,
                player3,
                player4,
                player5
            };

            Console.WriteLine("Please choose one of the characters below to help take back the Solar System. \nThe entire human race is counting on you!!!\n");

            foreach (Player p in players)
            {
                Console.WriteLine($"{players.IndexOf(p) +1}) Name: {p.Name} \nRace: {p.CharacterRace} \nWeapon: {p.EquippedWeapon.Type} \n");

                
            }
            

            //int 
            //Console.Read().ToInt
            //Convert user input to  int
            Console.WriteLine("Enter your character choice here...Quick! (1-5)");
            int userInput = int.Parse(Console.ReadLine());
            Player player = players[userInput - 1];



            Console.Clear();
            
            #endregion





            // Create the main game loop
            #region Main Game Loop

            //Counter Variable- used in the condition of the loop
            bool exit = false;

        

            



            do
            {
                Console.WriteLine(GetRoom());

                //Select a random monster to inhabit the room
                Monster monster = Monster.GetMonster();
                Console.WriteLine("On this planet..." +monster.Name);

                //Create the gameplay menu loop

                #region Gameplay Menu Loop

                bool reload = false;

                do
                {
                    //TODO Create the main gameplay menu
                    #region MENU

                    //Prompt the user
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away!\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    //Capture the user's menu selection
                    ConsoleKey userChoice = Console.ReadKey(true).Key; //Capture the pressed key, hide the key from the console,
                    //and execute immediately . ---true hides the key from the console---

                    //clear the console
                    Console.Clear();

                    //Use branching logic to act upon the user's selection
                    switch (userChoice)
                    {
                        case ConsoleKey.A:

                            // Combat


                            Combat.DoBattle(player, monster);
                            //Check if monster is dead
                            if (monster.Life <= 0)
                            {
                                //Use green to indicate winning!
                                Console.ForegroundColor = ConsoleColor.Green;

                                //output the result
                                Console.WriteLine($"\nYou killed {monster.Name}!");

                                //Reset the color
                                Console.ResetColor();

                                //leave the inner loop
                                reload = true;

                                //update the score
                                score++;
                            }

                            break;

                        case ConsoleKey.R:

                            //TODO Run Away - Attack of Opportunity

                            Console.WriteLine("Run Away!!!");

                            //Monster gets an "attack of opportunity"
                            Console.WriteLine(monster.Name + " attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine(); //for formatting
                            reload = true;

                            break;

                        case ConsoleKey.P:

                            //TODO Player Stats

                            Console.WriteLine(player);

                            break;

                        case ConsoleKey.M:

                            //Monster Stats

                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:

                            //Exit the game

                            Console.WriteLine("Nobody likes a quitter...");

                            exit = true;
                            break;



                        default:

                            Console.WriteLine("That is not a valid option. Please try again.");
                            break;

                    }//end switch

                    #region Check Player's Life Total

                    //Check Player's Life

                    if (player.Life <=0)
                    {
                        Console.WriteLine("Dude, you died! \a");
                        exit = true;
                    }

                    #endregion


                    #endregion

                } while (!reload && !exit);

                #endregion








            } while (!exit); //keep looping as long as exit is false

            #endregion

            //TODO Output the Final Score
            Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? "!" : "s!"));


            //Added this line to preserve the Console.Title
            Console.ReadKey();

        }//end Main()

        private static string GetRoom()
        {
            string[] stellarObjects = {
                "The Sun- Ouch! Don't look! Or get too close...\n",
                "You've landed on the Mercury. It's a scorching 800 degrees....and the Sun is so close!\n",
                "You landed on the hottest planet...Venus! The atmosphere is thick and the pressure is immense.\n",
                "Back to Earth! Booming with life. Finally, a comfortable temperature.....but evil is still lurking.\n",
                "Looks like Earth...kind of. The ground is red with mountains on the horizon. You start looking for signs of life...\n",
                "You're at Jupiter...the largest of all! You start slowly sinking through the atmosphere without a surface in sight. Thank goodness you didn't land in the Great Red Spot!\n",
                "You've made it to Saturn. You see rings in the sky with a pale blue dot in the distance. Home seems so far away now...\n",
                "Why is everything tilted 98 degrees? It seems as if everything is now sideways...You've reached Uranus.\n",
                "Neptune. Dark blue and gaseous....watch out for the rainstorm of Diamonds!\n",
                "It's cold here at Pluto and the Sun is just a tiny dot in the sky.....You feel the gravitational pull of Neptune and know you're not on an actual planet anymore...\n",
               
            };
            Random rand = new Random();
            return stellarObjects[rand.Next(stellarObjects.Length)];
        

        }//endGetRoom
    }//end class
}//end namespace