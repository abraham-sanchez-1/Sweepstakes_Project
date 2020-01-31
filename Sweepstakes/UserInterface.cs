using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {

        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine("Enter:");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
