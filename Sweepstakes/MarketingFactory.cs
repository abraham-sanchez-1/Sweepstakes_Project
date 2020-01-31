using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFactory
    {
        public static ISweepstakesManager CreateManagerType(string input)
        {
            switch (input.ToLower())
            {
                case "stack":
                    return new SweepstakesStackManager();

                case "queue":
                    return new SweepstakesQueueManager();

                default:
                    return CreateManagerType(input);
            }


        }


    }
}
