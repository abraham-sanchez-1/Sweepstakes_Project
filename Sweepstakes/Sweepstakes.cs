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
        private int winner;
        //constructor

        //member method
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(count, contestant);
            count++;
        }
        public Contestant ContestantPickWinner()
        {
            Random random = new Random();
            int key = random.Next(1, count);
            winner = key;
            contestants[key] = new ContestantWinner(contestants[key].firstName, contestants[key].lastName, contestants[key].emailAddress, contestants[key].registrationNumber);
            Notify();
            return contestants[key];
            //email API, use email address of this user. contestants[winner].emailAddress
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("***Contestant Information***");
            Console.WriteLine("{0}, {1}\nEmail: {2}\nRegistration #: {3}\n",contestant.lastName, contestant.firstName, contestant.emailAddress, contestant.registrationNumber);
        }

        public void Notify()
        {
            foreach (KeyValuePair<int, Contestant> item in contestants)
            {
                item.Value.Notify();
            }
            
        }
    }
}
