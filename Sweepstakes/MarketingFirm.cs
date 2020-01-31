using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        //member variable
        ISweepstakesManager _manager;

        //constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }
        //member method
        public void CreateSweepstake()
        {
            string response = UserInterface.GetUserInputFor("Please give this new sweepstake a name.");
            Sweepstakes sweepstakes = new Sweepstakes(response);
            _manager.InsertSweepstakes(sweepstakes);

        }

    }
}
