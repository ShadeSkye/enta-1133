using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_AdvancedDieRoller
{
    internal class Player
    {
        public string PlayerName = "";
        public string PlayerDie = "";
        public int MaxRoll = 0;
        public int DieSize = 0;

        /// <summary>
        /// This function prompts the player to pick between the dice provied.
        /// </summary>
        internal void PickPlayerDie()
        {
            Console.WriteLine("\nPick a die [\"d6\" \"d8\" \"d12\" \"d20\"]\n");
            PlayerDie = Console.ReadLine();
            PlayerDie = PlayerDie.ToLower();

            if (PlayerDie == "d6")
            {
                MaxRoll = 7;
                DieSize = 1;
            }

            else if (PlayerDie == "d8")
            {
                MaxRoll = 9;
                DieSize = 2;
            }

            else if (PlayerDie == "d12")
            {
                MaxRoll = 13;
                DieSize = 3;
            }

            else if (PlayerDie == "d20")
            {
                MaxRoll = 21;
                DieSize = 4;
            }
            else
            {
                Console.WriteLine("\nThat's not a suitable answer.");
                PickPlayerDie();
            }

        }



    }
}
