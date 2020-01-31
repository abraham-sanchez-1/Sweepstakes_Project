using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //member variable
        private Stack<Sweepstakes> stack;
        //constructor

        //member method
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);

        }
        public Sweepstakes GetSweepstakes()
        {
            stack.Pop();
        }
    }
}
