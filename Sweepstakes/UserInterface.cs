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
        public static string GetManagerType()
        {
            Console.WriteLine("Select a manager type:\nStack\nQueue\n");
            Console.WriteLine("Enter:");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "stack" || userInput.ToLower() == "queue")
            {
                return userInput.ToLower();
            }
            Console.WriteLine("Selection was invalid, try again...");
            return GetManagerType();
        }

    }
}
