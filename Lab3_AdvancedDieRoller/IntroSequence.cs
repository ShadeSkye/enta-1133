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
            ExplainRules();
            

        }


        /// <summary>
        /// function to ask if the player will play
        /// </summary>
        internal void WillYouPlay()
        {
            Console.WriteLine("\nWould you like to play with me? [\"yes\" \"no\"]\n");
            String PlayerWantsToPlay = Console.ReadLine();
            PlayerWantsToPlay = PlayerWantsToPlay.ToLower();

            if (PlayerWantsToPlay == "yes")
            {
                Console.WriteLine("\nExcellent :)");      //if the player answers "yes" the program will continue
            }

            else if (PlayerWantsToPlay == "no")
            {
                Console.WriteLine("\nSuit yourself.");    //exists the program if the user enters "no"
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("\nThat's not a suitable answer.");     //if the player gives an unsuitable answer, they are asked if they want to play once again.
                WillYouPlay();
            }
        }


        /// <summary>
        /// function to learn the player's name and greet them.
        /// </summary>
        internal void AskPlayerName()
        {
            Console.WriteLine("\nWhat is your name?\n");
            
            Player PlayerInstance = new Player();
            PlayerInstance.PlayerName = Console.ReadLine();

            Console.WriteLine("\nIt's nice to meet you, " + PlayerInstance.PlayerName + ".");


        }

        /// <summary>
        /// if the player has not played before, the game will explain the rules.
        /// </summary>
        internal void ExplainRules()
        {
            Console.WriteLine("\nHave you played before? [\"yes\" \"no\"]\n");
            
            String PlayerHasPlayed = Console.ReadLine();
            PlayerHasPlayed = PlayerHasPlayed.ToLower();

            if (PlayerHasPlayed == "no")
            {
                Console.WriteLine("\nYou have a set of 4 dice, a d6, d8, d12, and d20. \n" +
                    "You roll each die one after another, choosing which one you want to play. \n" +
                    "Whoever rolls the biggest number wins both dice and adds their highest side to their total score. \n" +
                    "If both dice land on the same number, the smaller die wins. \n" +
                    "If 2 dice of the same size land on the same number, you reroll the same dice. \n" +
                    "Whoever has the highest score at the end wins.");

            }

            else if ( PlayerHasPlayed == "yes")
            {
                Console.WriteLine("\nPerfect.");
            }

            else
            {
                Console.WriteLine("\nThat's not a suitable answer.");   //if the player gives an unsuitable answer, they are asked if they want to play once again.
                ExplainRules();
            }

            Console.WriteLine("\nLet's get started.");


        }

        




    }
}
