using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant 
    {
        //member variable
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;


        //constructor
        public Contestant(string first, string last, string email, int registration)
        {
            firstName = first;
            lastName = last;
            emailAddress = email;
            registrationNumber = registration;
        }
        //member method
        public virtual void Notify()
        {
            Console.WriteLine("Hello {0}, this season's Sweepstake is over, your entry was not selected.\nThank you for playing and join us for the next sweepstake!");
        }
       

    }
}
