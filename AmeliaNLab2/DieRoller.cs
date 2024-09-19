using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeliaNLab2
{
    internal class DieRoller
    {
        int minRoll = 1;    //highest and lowest sides of the die
        int maxRoll = 6;
        public int side = 0;


        /// <summary>
        /// the roll function generates a random number from "minRoll" to "maxRoll" then prints the side you landed on for you to see
        /// </summary>
        internal void roll()
        {
            Random randomSide;
            randomSide = new Random();

            side = randomSide.Next(minRoll, maxRoll + 1);

            Console.WriteLine(side + "!");  //represents what side the die landed on
            Console.WriteLine("");
            
        }

        







    }
}
