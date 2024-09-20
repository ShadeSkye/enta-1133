using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeliaNLab2
{
    internal class GameManager
    {

        int score = 0;



        /// <summary>
        /// the play function calls on the DieRoller script to run a random number generator
        /// </summary>
        internal void play()
        {
            DieRoller dieRollerInstance;
            dieRollerInstance = new DieRoller();
            dieRollerInstance.roll();

            score += dieRollerInstance.side; //adds up all the rolls 


        }


       internal void printScore()
        {
            Console.WriteLine("Your total score is: " + score + "!"); //prints the total score
        }










    }
}
