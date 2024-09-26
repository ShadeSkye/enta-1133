using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_AdvancedDieRoller
{
    internal class DieRoller
    {
        private int ComputerDie = 0;
        public int ComputerDieResult = 0;
        public int PlayerDieResult = 0;
        private int MaxPlayerRoll = 0;
        private int MaxComputerRoll = 0;

        internal void StartRolling()
        {
            Player PlayerInstance = new Player();
            PlayerInstance.PickPlayerDie();
            MaxPlayerRoll = PlayerInstance.MaxRoll;
            ComputerPickDie();
            RollPlayerDie();
            RollComputerDie();
        }

        internal void ComputerPickDie()
        {
            Random RandomComputerDie = new Random();
            ComputerDie = RandomComputerDie.Next(1, 5);

            if (ComputerDie == 1)
            {
                MaxComputerRoll = 7;
            }

            else if (ComputerDie == 2)
            {
                MaxComputerRoll = 9;
            }

            else if (ComputerDie == 3)
            {
                MaxComputerRoll = 13;
            }

            else if (ComputerDie == 4)
            {
                MaxComputerRoll = 21;
            }
        }

        internal void RollPlayerDie()
        {
            Random RandomPlayerDieResult = new Random();
            PlayerDieResult = RandomPlayerDieResult.Next(1, MaxPlayerRoll);
            Console.WriteLine("\nYou rolled a " + PlayerDieResult + ".");
        }

        internal void RollComputerDie()
        {
            Random RandomComputerDieResult = new Random();
            ComputerDieResult = RandomComputerDieResult.Next(1, MaxComputerRoll);
            Console.WriteLine("\nI rolled a " + ComputerDieResult + ".");
        }





    }
}
