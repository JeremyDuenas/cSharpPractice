using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gameshow Giveaway!");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";

            Console.Write("You entered: {0}, therefore you won a {1}", userValue, message);

            Console.ReadLine();
        }
    }
}
