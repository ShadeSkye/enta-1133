using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_AdvancedDieRoller
{
    internal class DieRoller
    {
        public int ComputerDie = 0;

        internal void ComputerPickDie()
        {
            Random RandomDie = new Random();
            ComputerDie = RandomDie.Next(1, 5);



        }

        internal void RollPlayerDie()
        {



        }




    }
}
