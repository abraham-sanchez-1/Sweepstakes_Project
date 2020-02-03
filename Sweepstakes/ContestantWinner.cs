using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{ 
    public class ContestantWinner : Contestant
    {
        //member variable

        //constructor
        public ContestantWinner(string first, string last, string email, int registration)
            : base(first, last, email, registration)
        {
           
        }

        //member method
        public override void Notify()
        {
            Console.WriteLine("Hello {0}, you have won the sweepstake!\n Please contact us with your registration number handy to receive your reward!", firstName);
        }
        


    }
}
