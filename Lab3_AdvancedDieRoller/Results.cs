using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_AdvancedDieRoller
{
    internal class Results
    {
        private bool DidPlayerWin = false;
        private int PlayerScore = 0;
        private int ComputerScore = 0;


        internal void GameEnd()
        {
            CalculateResults();
            ShowResults();
        }

        internal void CalculateResults()
        {
            DieRoller DieRollerInstance = new DieRoller();
            DieRollerInstance.StartRolling();

            PlayerScore += DieRollerInstance.PlayerDieResult;
            ComputerScore += DieRollerInstance.ComputerDieResult;

            if (PlayerScore > ComputerScore)
            {
                DidPlayerWin = true;
            }
        }

        internal void ShowResults()
        {
            if (DidPlayerWin)
            {
                Console.WriteLine("\nYou win :(");
            }

            else
            {
                Console.WriteLine("\nI win :)");
            }
        }




    }
}
