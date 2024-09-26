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

        internal void PickPlayerDie()
        {
            Console.WriteLine("\nPick a die [\"d6\" \"d8\" \"d12\" \"d20\"]\n");
            PlayerDie = Console.ReadLine();
            PlayerDie = PlayerDie.ToLower();

            if (PlayerDie != "d6" && PlayerDie != "d8" && PlayerDie != "d12" && PlayerDie != "d20")
            {
                Console.WriteLine("\nThat's not a suitable answer");
                PickPlayerDie();

            }


        }



    }
}
