using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedDieRollerPart2
{
    internal class ComputerPlayer
    {
        Random RandomNumber = new Random();
        Program ProgramInstance = new Program();

        private int ComputerDie = 0;
        public int ComputerDieSize = 0;
        public int ComputerDieResult = 0;
        public int ComputerDieMax = 0;
        private string DieName = "";

        /// <summary>
        /// List of the max number each die can roll (add + 1 to each for the RandomNumber.Next() method)
        /// </summary>
        List<int> DiceList = new List<int> { 7, 9, 13, 21 };

        List<string> DiceNames = new List<string> { "d6", "d8", "d12", "d20" };

        public int DieCount = 4;


        /// <summary>
        /// This is a function used to pick a random die for the computer.
        /// </summary>
        internal void ComputerPickDie()
        {
            ComputerDie = RandomNumber.Next(0, DieCount);
            DieCount -= 1;

            DieName = DiceNames[ComputerDie];
            ComputerDieMax = DiceList[ComputerDie];
            DiceNames.Remove(DieName);
            DiceList.Remove(ComputerDieMax);
        }

        /// <summary>
        /// This function rolls the die that the computer rolled.
        /// </summary>
        internal void ComputerRollDie()
        {
            ComputerDieResult = RandomNumber.Next(1, ComputerDieMax);

            ProgramInstance.Print("\n\nComputer: I rolled a " + ComputerDieResult + " using a " + DieName + " die!\n", 100);

            if (DieName == "d6")
            {
                ComputerDieSize = 0;
            }

            else if (DieName == "d8")
            {
                ComputerDieSize = 1;
            }

            else if (DieName == "d12")
            {
                ComputerDieSize = 2;
            }

            else if (DieName == "d20")
            {
                ComputerDieSize = 3;
            }
        }
    }
}
