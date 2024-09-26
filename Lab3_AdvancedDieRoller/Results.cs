using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_AdvancedDieRoller
{
    internal class Results
    {
        private int DidPlayerWin = 0;
        private int PlayerScore = 0;
        private int ComputerScore = 0;
        DieRoller DieRollerInstance = new DieRoller();
        Player PlayerInstance = new Player();


        internal void GameEnd()
        {
            RollDice();
            CalculateResults();
            ShowResults();
        }

        internal void RollDice()
        {
            DieRollerInstance.StartRolling();
        }

        internal void CalculateResults()
        {
            PlayerScore += DieRollerInstance.PlayerDieResult;
            ComputerScore += DieRollerInstance.ComputerDieResult;

            if (PlayerScore > ComputerScore)
            {
                DidPlayerWin = 1;
            }

            else if(PlayerScore < ComputerScore)
            {
                DidPlayerWin = 2;
            }

            else if (PlayerScore == ComputerScore)
            {
                DidPlayerWin = 3;
            }
        }

        internal void ShowResults()
        {
            if (DidPlayerWin == 1)
            {
                Console.WriteLine("\nYou win with " + (PlayerScore + ComputerScore) + " points :(");
            }

            else if (DidPlayerWin == 2)
            {
                Console.WriteLine("\nI win with " + (PlayerScore + ComputerScore) + " points :)");
            }

            else
            {
                if (DieRollerInstance.PlayerDieSize > DieRollerInstance.ComputerDieNumber)
                {
                    Console.WriteLine("\nI win with " + (PlayerScore + ComputerScore) + " points :)");
                }

                else if (DieRollerInstance.PlayerDieSize < DieRollerInstance.ComputerDieNumber)
                {
                    Console.WriteLine("\nYou win with " + (PlayerScore + ComputerScore) + " points :(");
                }

                else
                {
                    Console.WriteLine("It's a tie.");
                    DieRollerInstance.RollPlayerDie();
                    DieRollerInstance.RollComputerDie();
                    CalculateResults();
                    ShowResults();
                }
            }
        }




    }
}
