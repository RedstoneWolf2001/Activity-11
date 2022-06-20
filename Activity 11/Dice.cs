using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_11
{
    public class Dice
    {
        private int numSides;
        private static Random random = new Random();

        public Dice(int NumSides)
        {
            this.numSides = NumSides;
        }

        public int rollDie()
        {            
            return random.Next(1, numSides + 1);
        }
    }
}
