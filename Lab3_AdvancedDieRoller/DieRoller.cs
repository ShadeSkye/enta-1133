using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_AdvancedDieRoller
{
    internal class DieRoller
    {
        public int ComputerDieNumber = 0;
        private string ComputerDie = "";
        public int ComputerDieResult = 0;
        public int PlayerDieResult = 0;
        private int MaxPlayerRoll = 0;
        private int MaxComputerRoll = 0;
        public int PlayerDieSize = 0;
        Player PlayerInstance = new Player();

        internal void StartRolling()
        {
            PlayerInstance.PickPlayerDie();
            MaxPlayerRoll = PlayerInstance.MaxRoll;
            PlayerDieSize = PlayerInstance.DieSize;
            ComputerPickDie();
            RollPlayerDie();
            RollComputerDie();
        }

        internal void ComputerPickDie()
        {
            Random RandomComputerDie = new Random();
            ComputerDieNumber = RandomComputerDie.Next(1, 5);

            if (ComputerDieNumber == 1)
            {
                MaxComputerRoll = 7;
                ComputerDie = "d6";
            }

            else if (ComputerDieNumber == 2)
            {
                MaxComputerRoll = 9;
                ComputerDie = "d8";
            }

            else if (ComputerDieNumber == 3)
            {
                MaxComputerRoll = 13;
                ComputerDie = "d12";
            }

            else if (ComputerDieNumber == 4)
            {
                MaxComputerRoll = 21;
                ComputerDie = "d20";
            }
        }

        internal void RollPlayerDie()
        {
            Random RandomPlayerDieResult = new Random();
            PlayerDieResult = RandomPlayerDieResult.Next(1, MaxPlayerRoll);
            Console.WriteLine("\nYou rolled a " + PlayerDieResult + ", using a " + PlayerInstance.PlayerDie + " die.");
        }

        internal void RollComputerDie()
        {
            Random RandomComputerDieResult = new Random();
            ComputerDieResult = RandomComputerDieResult.Next(1, MaxComputerRoll);
            Console.WriteLine("\nI rolled a " + ComputerDieResult + ", using a " + ComputerDie + " die.");
        }





    }
}
