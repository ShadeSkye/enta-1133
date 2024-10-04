using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedDieRollerPart2
{
    internal class Player
    {
        Random RandomNumber = new Random();

        public string PlayerName = "Player";
        private string PlayerDie = "";
        public int DiceCount = 4;
        public int PlayerMaxDieSide = 0;
        public int PlayerDieResult = 0;
        public int PlayerDieSize = 0;

        /// <summary>
        /// This string array contains all 4 useable dice.
        /// </summary>
        public string[] diceArray = new string[] { "\"d6\" ", "\"d8\" ", "\"d12\" ", "\"d20\"" };


        /// <summary>
        /// This bool array is used to know if a die has been used already.
        /// </summary>
        public bool[] DiceUsed = new bool[] { false, false, false, false };


        /// <summary>
        /// This function is used to get which die the player wants to use.
        /// </summary>
        internal void PlayerPickDie()
        {
            Console.WriteLine("\n\nSystem: Please select your die [" + diceArray[0] + diceArray[1] + diceArray[2] + diceArray[3] + "]\n\n");
            Console.Write(PlayerName + ": ");
            PlayerDie = Console.ReadLine();
            PlayerDie = PlayerDie.ToLower();

            // If the player provides an unsuitable answer, they are asked to choose again
            while (PlayerDie != "d6" && PlayerDie != "d8" && PlayerDie != "d12" && PlayerDie != "d20")
            {
                Console.WriteLine("\n\nSystem: That is not a suitable answer.");
                Console.WriteLine("\nPlease select your die [" + diceArray[0] + diceArray[1] + diceArray[2] + diceArray[3] + "]\n\n");
                Console.Write(PlayerName + ": ");
                PlayerDie = Console.ReadLine();
                PlayerDie = PlayerDie.ToLower();
            }

            // Sets the highest number the player can roll and changes the amount of turns left.
            if (PlayerDie == "d6" && DiceUsed[0] == false)
            {
                diceArray[0] = "n/a ";
                DiceUsed[0] = true;
                DiceCount -= 1;
                PlayerMaxDieSide = 6;
                PlayerDieSize = 0;
            }

            else if (PlayerDie == "d8" && DiceUsed[1] == false)
            {
                diceArray[1] = "n/a ";
                DiceUsed[1] = true;
                DiceCount -= 1;
                PlayerMaxDieSide = 8;
                PlayerDieSize = 1;
            }

            else if (PlayerDie == "d12" && DiceUsed[2] == false)
            {
                diceArray[2] = "n/a ";
                DiceUsed[2] = true;
                DiceCount -= 1;
                PlayerMaxDieSide = 12;
                PlayerDieSize = 2;
            }

            else if (PlayerDie == "d20" && DiceUsed[3] == false)
            {
                diceArray[3] = "n/a";
                DiceUsed[3] = true;
                DiceCount -= 1;
                PlayerMaxDieSide = 20;
                PlayerDieSize = 3;
            }

            else
            {
                Console.WriteLine("\n\nSystem: You've already selected that die.");
                PlayerPickDie();
            }

            
        }

        internal void PlayerRollDie()
        {
            PlayerDieResult = RandomNumber.Next(1, (PlayerMaxDieSide + 1));
            Console.WriteLine("\n\nSystem: you rolled a " + PlayerDieResult + " using a " + PlayerDie + " die!");
        }


    }
}
