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
        ComputerPlayer ComputerPlayerInstance = new ComputerPlayer();
        Program ProgramInstance = new Program();

        private string PlayerWantsToPlay = "";
        private string PlayerHasPlayed = "";
        private int PlayerScore = 0;
        private int ComputerScore = 0;

        /// <summary>
        /// The "GreetPlayer" function greets the player, asks if they want to play, asks for their name, and explains the rules of the game.
        /// </summary>
        internal void GreetPlayer()
        {

            // I used the "Text to ASCII Art" tool on the ASCII Art Archive website using the "Elite" font.
            Console.WriteLine("\n▄▄▌ ▐ ▄▌▄▄▄ .▄▄▌   ▄▄·       • ▌ ▄ ·. ▄▄▄ .▄▄ \r\n██· █▌▐█▀▄.▀·██•  ▐█ ▌▪▪     ·██ ▐███▪▀▄.▀·██▌\r\n██▪▐█▐▐▌▐▀▀▪▄██▪  ██ ▄▄ ▄█▀▄ ▐█ ▌▐▌▐█·▐▀▀▪▄▐█·\r\n▐█▌██▐█▌▐█▄▄▌▐█▌▐▌▐███▌▐█▌.▐▌██ ██▌▐█▌▐█▄▄▌.▀ \r\n ▀▀▀▀ ▀▪ ▀▀▀ .▀▀▀ ·▀▀▀  ▀█▄▀▪▀▀  █▪▀▀▀ ▀▀▀  ▀ ");

            Console.WriteLine("\n  ____\r\n /\\' .\\    _____\r\n/: \\___\\  / .  /\\     (dice art by valkyrie on ASCII Art Archive)\r\n\\' / . / /____/..\\\r\n \\/___/  \\'  '\\  /\r\n          \\'__'\\/  \n\nTo Try Not to Die!"); // Dice art by valkyrie on ASCII Art Archive.



            // Asking if the player wants to play
            ProgramInstance.Print("\n\nComputer: Would you like to play a game with me? :3c [Please enter \"yes\" or \"no\"]\n\n\n");
            Console.Write(PlayerInstance.PlayerName + ": ");
            PlayerWantsToPlay = Console.ReadLine();
            PlayerWantsToPlay = PlayerWantsToPlay.ToLower();

            // The player will be asked over again until they give a suitable answer.
            while (PlayerWantsToPlay != "yes" && PlayerWantsToPlay != "no")
            {
                Console.WriteLine("\n\nSystem: That is not a suitable answer.");
                ProgramInstance.Print("\n\nComputer: Would you like to play a game with me? :3c [Please enter \"yes\" or \"no\"]\n\n\n");
                Console.Write(PlayerInstance.PlayerName + ": ");
                PlayerWantsToPlay = Console.ReadLine();
                PlayerWantsToPlay = PlayerWantsToPlay.ToLower();
            }

            // If the player does not want to play, the program closes.
            if (PlayerWantsToPlay == "no")
            {
                ProgramInstance.Print("\n\nComputer: Suit yourself.");
                Environment.Exit(0);
            }



            // Gets the player's name.
            ProgramInstance.Print("\n\nComputer: Excellent, what is your name? :3c\n\n\n");
            Console.Write(PlayerInstance.PlayerName + ": ");
            PlayerInstance.PlayerName = Console.ReadLine();
            ProgramInstance.Print("\n\nComputer: It's nice to meet you, " + PlayerInstance.PlayerName + "! ^^");


            // Explains the rules to the player if they have not played before.
            ProgramInstance.Print("\n\nHave you ever played this game before? :3c [Please enter \"yes\" or \"no\"]\n\n\n");
            Console.Write(PlayerInstance.PlayerName + ": ");
            PlayerHasPlayed = Console.ReadLine();
            PlayerHasPlayed = PlayerHasPlayed.ToLower();

            // The player will be asked over again until they give a suitable answer.
            while (PlayerHasPlayed != "yes" && PlayerHasPlayed != "no")
            {
                Console.WriteLine("\n\nSystem: That is not a suitable answer.");
                ProgramInstance.Print("\n\nComputer: Have you ever played this game before? :3c [Please enter \"yes\" or \"no\"]\n\n\n");
                Console.Write(PlayerInstance.PlayerName + ": ");
                PlayerHasPlayed = Console.ReadLine();
                PlayerHasPlayed = PlayerHasPlayed.ToLower();
            }

            // Explains the rules to the player if they haven't played before.
            if (PlayerHasPlayed == "no")
            {
                ProgramInstance.Print("\n\nComputer: The rules aren't too complicated :3");

                ProgramInstance.Print("\n\nYou have a set of 4 dice, a d6, d8, d12, and d20. \n\n" +
                    "You roll each die one after another, choosing which one you want to play. \n\n" +
                    "Whoever rolls the biggest number wins both dice and adds both numbers rolled to their total score. \n\n" +
                    "If both dice land on the same number, the smaller die wins. \n\n" +
                    "If 2 dice of the same size land on the same number, you reroll the same dice. \n\n" +
                    "Whoever has the highest score at the end wins.");
            }

            else
            {
                ProgramInstance.Print("\n\nComputer: Perfect ^^");
            }

            ProgramInstance.Print("\n\nLet's get started! :3\n");

            GameLoop();
        }


        /// <summary>
        /// This function runs all 4 rounds of the game
        /// </summary>
        internal void GameLoop()
        {
            // Game loop
            while (ComputerPlayerInstance.DieCount > 0)
            {
                // Getting the die from the player and computer.
                PlayerInstance.PlayerPickDie();
                ComputerPlayerInstance.ComputerPickDie();

                // Rolls each die.
                PlayerInstance.PlayerRollDie();
                ComputerPlayerInstance.ComputerRollDie();

                // Checks to see who rolls the higher number.
                if (PlayerInstance.PlayerDieResult > ComputerPlayerInstance.ComputerDieResult)
                {
                    PlayerScore += PlayerInstance.PlayerDieResult + ComputerPlayerInstance.ComputerDieResult;
                    Console.WriteLine("\n\nSystem: " + PlayerInstance.PlayerName + " won this round!");
                }

                else if (PlayerInstance.PlayerDieResult < ComputerPlayerInstance.ComputerDieResult)
                {
                    ComputerScore += PlayerInstance.PlayerDieResult + ComputerPlayerInstance.ComputerDieResult;
                    Console.WriteLine("\n\nSystem: computer won this round!");
                }

                // If a tie occurs, checks who rolled the smaller die.
                else if (PlayerInstance.PlayerDieResult == ComputerPlayerInstance.ComputerDieResult && PlayerInstance.PlayerDieSize < ComputerPlayerInstance.ComputerDieSize)
                {
                    PlayerScore += PlayerInstance.PlayerDieResult + ComputerPlayerInstance.ComputerDieResult;
                    Console.WriteLine("\n\nSystem: " + PlayerInstance.PlayerName + " won this round!");
                }

                else if (PlayerInstance.PlayerDieResult == ComputerPlayerInstance.ComputerDieResult && PlayerInstance.PlayerDieSize > ComputerPlayerInstance.ComputerDieSize)
                {
                    ComputerScore += PlayerInstance.PlayerDieResult + ComputerPlayerInstance.ComputerDieResult;
                    Console.WriteLine("\n\nSystem: computer won this round!");
                }

                // If a complete tie occurs, re rolls the same dice.
                else
                {
                    Console.WriteLine("\n\nSystem: It's a tie! Roll again.");
                    PlayerInstance.PlayerRollDie();
                    ComputerPlayerInstance.ComputerRollDie();
                }

                ProgramInstance.Print("\n" + PlayerInstance.PlayerName + " has " + PlayerScore + " points!\n", 20);
                ProgramInstance.Print("\nComputer has " + ComputerScore + " points!\n", 20);
            }

            ShowResults();
        }

        /// <summary>
        /// This function compares both scores to determine who won.
        /// </summary>
        internal void ShowResults()
        {
            if (PlayerScore > ComputerScore)
            {
                ProgramInstance.Print("\n\nComputer: Good game, " + PlayerInstance.PlayerName + "! ^^");
            }

            else if (PlayerScore < ComputerScore)
            {
                ProgramInstance.Print("\n\nComputer: Better luck next time, " + PlayerInstance.PlayerName + "! ^^");
            }

            else
            {
                ProgramInstance.Print("\n\nComputer: What are the chances?! We tied :O");
            }

            Console.WriteLine("\n\n\nSystem: Game Over Thank You For Playing! [Press Enter to return to home screen]");
            Console.ReadLine();
            ProgramInstance.StartGame();
        }

    }
}
