using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm 
    {
        //member variable
        ISweepstakeManager manager;

        //constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        //member method
        public void CreateSweepstake()
        {

        }

    }
}
