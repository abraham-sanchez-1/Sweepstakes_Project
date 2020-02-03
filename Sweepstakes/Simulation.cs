using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        //member variable


        //constructor

        //member method
        public void CreateMarketingFirmWithManager()
        {
            MarketingFirm firm = new MarketingFirm(MarketingFactory.CreateManagerType(UserInterface.GetManagerType()));
            firm.CreateSweepstake();
            


            //string respose = UserInterface.GetUserInputFor("Select a manager type:\nStack\nQueue\n");
            //switch (respose.ToLower())
            //{
            //    case "stack":
            //        break;
            //    case "queue":
            //        MarketingFactory.CreateManagerType("queue");
            //            break;
            //    default:
            //        Console.WriteLine("Your selection was invalid, please try again...");
            //        CreateMarketingFirmWithManager();
            //        break;
            //}
        }
        
    }
}
