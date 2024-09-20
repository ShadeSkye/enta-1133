using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_AdvancedDieRoller
{
    internal class IntroSequence
    {
        



        /// <summary>
        /// Introduces player to the game.
        /// Asks player's name, if they want to play, and if they know the rules.
        /// </summary>
        internal void Intro()
        {
            Console.WriteLine("Welcome to Try Not to Die!");

            WillYouPlay();
            AskPlayerName();
            

        }


        /// <summary>
        /// function to ask if the player will play
        /// </summary>
        internal void WillYouPlay()
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to play with me? [\"yes\" \"no\"]");
            Console.WriteLine("");
            String PlayerWantsToPlay = Console.ReadLine();
            PlayerWantsToPlay = PlayerWantsToPlay.ToLower();
            Console.WriteLine("");

            if (PlayerWantsToPlay == "yes")
            {
                Console.WriteLine("Excellent :)");      //if the player answers "yes" the program will continue
                Console.WriteLine("");
            }

            else if (PlayerWantsToPlay == "no")
            {
                Console.WriteLine("Suit yourself.");    //exists the program if the user enters "no"
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("That's not a suitable answer.");     //if the player gives an unsuitable answer, they are asked if they want to play once again.
                WillYouPlay();
            }
        }


        /// <summary>
        /// function to learn the player's name and greet them.
        /// </summary>
        internal void AskPlayerName()
        {
            Console.WriteLine("What is your name?");
            Console.WriteLine("");
            
            Player PlayerInstance = new Player();
            PlayerInstance.PlayerName = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("It's nice to meet you, " + PlayerInstance.PlayerName + ".");


        }







    }
}
