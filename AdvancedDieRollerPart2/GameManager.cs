using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedDieRollerPart2
{
    internal class GameManager
    {
        Player PlayerInstance = new Player();
        private string PlayerWantsToPlay = "";
        private string PlayerHasPlayed = "";

        /// <summary>
        /// The "GreetPlayer" function greets the player, asks if they want to play, asks for their name, and explains the rules of the game.
        /// </summary>
        internal void GreetPlayer()
        {

            // I used the "Text to ASCII Art" tool on the ASCII Art Archive website using the "Elite" font.
            Console.WriteLine("\n▄▄▌ ▐ ▄▌▄▄▄ .▄▄▌   ▄▄·       • ▌ ▄ ·. ▄▄▄ .▄▄ \r\n██· █▌▐█▀▄.▀·██•  ▐█ ▌▪▪     ·██ ▐███▪▀▄.▀·██▌\r\n██▪▐█▐▐▌▐▀▀▪▄██▪  ██ ▄▄ ▄█▀▄ ▐█ ▌▐▌▐█·▐▀▀▪▄▐█·\r\n▐█▌██▐█▌▐█▄▄▌▐█▌▐▌▐███▌▐█▌.▐▌██ ██▌▐█▌▐█▄▄▌.▀ \r\n ▀▀▀▀ ▀▪ ▀▀▀ .▀▀▀ ·▀▀▀  ▀█▄▀▪▀▀  █▪▀▀▀ ▀▀▀  ▀ ");

            Console.WriteLine("\n  ____\r\n /\\' .\\    _____\r\n/: \\___\\  / .  /\\     (dice art by valkyrie on ASCII Art Archive)\r\n\\' / . / /____/..\\\r\n \\/___/  \\'  '\\  /\r\n          \\'__'\\/  \n\nTo Try Not to Die!"); // Dice art by valkyrie on ASCII Art Archive.



            // Asking if the player wants to play
            Console.WriteLine("\n\nComputer: Would you like to play a game with me? :3c [Please enter \"yes\" or \"no\"]\n\n");
            Console.Write(PlayerInstance.PlayerName + ": ");
            PlayerWantsToPlay = Console.ReadLine();
            PlayerWantsToPlay = PlayerWantsToPlay.ToLower();

            // The player will be asked over again until they give a suitable answer.
            while (PlayerWantsToPlay != "yes" && PlayerWantsToPlay != "no")
            {
                Console.WriteLine("\nThat is not a suitable answer.");
                Console.WriteLine("\nComputer: Would you like to play a game with me? :3c [Please enter \"yes\" or \"no\"]\n");
                Console.Write(PlayerInstance.PlayerName + ": ");
                PlayerWantsToPlay = Console.ReadLine();
                PlayerWantsToPlay = PlayerWantsToPlay.ToLower();
            }

            // If the player does not want to play, the program closes.
            if (PlayerWantsToPlay == "no")
            {
                Console.WriteLine("\n\nComputer: Suit yourself.");
                Environment.Exit(0);
            }



            // Gets the player's name.
            Console.WriteLine("\n\nComputer: Excellent, what is your name? :3c\n\n");
            Console.Write(PlayerInstance.PlayerName + ": ");
            PlayerInstance.PlayerName = Console.ReadLine();
            Console.WriteLine("\n\nComputer: It's nice to meet you, " + PlayerInstance.PlayerName + " :3");



            // Explains the rules to the player if they have not played before.
            Console.WriteLine("\nHave you ever played this game before? :3c [Please enter \"yes\" or \"no\"]\n\n");
            Console.Write(PlayerInstance.PlayerName + ": ");
            PlayerHasPlayed = Console.ReadLine();
            PlayerHasPlayed = PlayerHasPlayed.ToLower();

            // The player will be asked over again until they give a suitable answer.
            while (PlayerHasPlayed != "yes" && PlayerHasPlayed != "no")
            {
                Console.WriteLine("\nThat is not a suitable answer.");
                Console.WriteLine("\nComputer: Have you ever played this game before? :3c [Please enter \"yes\" or \"no\"]\n");
                Console.Write(PlayerInstance.PlayerName + ": ");
                PlayerHasPlayed = Console.ReadLine();
                PlayerHasPlayed = PlayerHasPlayed.ToLower();
            }

            // Explains the rules to the player if they haven't played before.
            if (PlayerHasPlayed == "no")
            {
                Console.WriteLine("\n\nComputer: The rules aren't too complicated :3");

                Console.WriteLine("\nYou have a set of 4 dice, a d6, d8, d12, and d20. \n\n" +
                    "You roll each die one after another, choosing which one you want to play. \n\n" +
                    "Whoever rolls the biggest number wins both dice and adds their highest side to their total score. \n\n" +
                    "If both dice land on the same number, the smaller die wins. \n\n" +
                    "If 2 dice of the same size land on the same number, you reroll the same dice. \n\n" +
                    "Whoever has the highest score at the end wins.");
            }

        }
    }
}
