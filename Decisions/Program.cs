using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            


            
            /*
            Console.WriteLine("Bob's big giveaway");
            Console.Write("Choose a door: 1,2, or 3: ");
            string userValue = Console.ReadLine();

            String message = "";

            if (userValue == "1")
                 message = "You've won";
  

            else if (userValue == "2")

                 message = "No Way";


            else if (userValue == "3")

                message = "It's a boat";
                


            else
            {
                message = "Whaaa?!";
                message += " You Lose";

            }
                
                

            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Bob's big giveaway");
            Console.Write("Choose a door: 1,2, or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "Boat" : "strand of pearls";
            //Console.Write("You've won a ");
            // Console.Write(message);
            //Console.Write(".");
            Console.WriteLine("You entered: {0}, Therefore you've won a {1}.", userValue, message);
            Console.ReadLine();
        }
    }
}
