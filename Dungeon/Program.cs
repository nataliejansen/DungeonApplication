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

            Console.WriteLine("Your journey begins...\n");

            #endregion

            //Variable to Track Score

            int score = 0;

            //TODO Weapon Object to be created

            //TODO Player Object to be created




            //TODO Create the main game loop
            #region Main Game Loop

            //Counter Variable- used in the condition of the loop
            bool exit = false;

            //The air in the room is steamy.The room smells smoky. A loud drumming noise can be heard. EXAMPLE

            
            

            do
            {
                Console.WriteLine(GetRoom());

                //TODO Select a random monster to inhabit the room

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

                            //TODO Combat

                            Console.WriteLine("Attack!");

                            break;

                        case ConsoleKey.R:

                            //TODO Run Away - Attack of Opportunity

                            Console.WriteLine("Run Away!");

                            break;

                        case ConsoleKey.P:

                            //TODO Player Stats

                            Console.WriteLine("Player Info");

                            break;

                        case ConsoleKey.M:

                            //TODO Monster Stats

                            Console.WriteLine("Monster Info");
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:

                            //Exit the game

                            Console.WriteLine("Nobody likes a quitter...");

                            exit = true;
                            break;



                        default:

                            Console.WriteLine("That is not a valid option. Please try again.");
                            break;

                    }//end switch

                    #region Check Player's Life Total

                    //TODO Check Player's Life

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
                "The Sun- Ouch! Don't look! Or get too close...",
                "You've landed on the smallest planet. It's a scorching 800 degrees. Mercury",
                "You landed on the hottest planet...Venus! The atmosphere is thick and the pressure is immense.",
                "Back to Earth! Booming with life. Finally, a comfortable temperature.",
                "Looks like Earth...kind of. The ground is red with mountains on the horizon. Mars",
                "The largest of all! You start slowly sinking through the atmosphere without a surface in sight. Jupiter",
                "Saturn. You see rings in the sky with a pale blue dot in the distance. Home seems so far away now...",
                "Uranus. Blue-green gas is all around you.",
                "Neptune. Dark blue and gaseous",
                "Pluto. Not even a planet! We are in the Kuiper belt. It's cold and the Sun is just a tiny dot in the sky",
                "Asteroid Belt. There's asteroids everywhere!",
                "Kuiper Belt- There's icy objects everywhere!",
                "Oort Cloud- Everything seems so far away and it feels like you're inside a bubble. There's some large, icy objects floating around you. "
            };
            Random rand = new Random();
            return stellarObjects[rand.Next(stellarObjects.Length)];
        }

    }//endGetRoom
    }//end class
}//end namespace