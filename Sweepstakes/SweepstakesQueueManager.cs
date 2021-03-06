﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //member variable
        private Queue<Sweepstakes> stack;
        //constructor
        public SweepstakesQueueManager()
        {
            stack = new Queue<Sweepstakes>();
        }
        //member method
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return stack.Dequeue();
        }
    }
}
