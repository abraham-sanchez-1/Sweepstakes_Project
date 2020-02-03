using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.CreateMarketingFirmWithManager();
            Sweepstakes avalon = new Sweepstakes("Avalon");
            Contestant con1 = new Contestant("Bob", "Jones", "bobb7@gmail.com", 1234);
            Contestant con2 = new Contestant("Billy", "Green", "green2@gmail.com", 1235);
            Contestant con3 = new Contestant("Joe", "College", "joethebe@gmail.com", 1236);
            Contestant con4 = new Contestant("John", "Grange", "fonn7@gmail.com", 1237);
            Contestant con5 = new Contestant("Cole", "Thompson", "coleth@gmail.com", 1238);
            avalon.RegisterContestant(con1);
            avalon.RegisterContestant(con2);
            avalon.RegisterContestant(con3);
            avalon.RegisterContestant(con4);
            avalon.RegisterContestant(con5);
            avalon.ContestantPickWinner();
            Console.ReadLine();
        }
    }
}
