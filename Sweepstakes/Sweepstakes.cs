using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //member variables
        Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;
        private int count = 0;
        //constructor

        //member method
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
            count++;
        }
        public void ContestantPickWinner()
        {
            Random random = new Random();
            int winner = random.Next(0, count);
            Console.WriteLine("Winner of {0} sweepstake is {1}", Name, contestants[winner]);
            //email API, use email address of this user. contestants[winner].emailAddress
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("***Contestant Information***");
            Console.WriteLine("{0}, {1}\nEmail: {2}\nRegistration #: {3}\n",contestant.lastName, contestant.firstName, contestant.emailAddress, contestant.registrationNumber);
        }

    }
}
