using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System_Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yesCounter = 0;
            int noCounter = 7;

            Console.WriteLine("Welcome to the voting system- Vote yes (y) or no (n).");
            string vote = Console.ReadLine();

            if(vote == "y")
            {
                yesCounter++;
            }
            else if (vote == "n")
            {
                noCounter++;
            }
            else
            {
                Console.WriteLine("Invalid vote.");
            }

            Console.WriteLine();

            Console.WriteLine("The results are in: ");
            Console.WriteLine("Yes: " + yesCounter);
            Console.WriteLine("No: " + noCounter);

            Console.WriteLine();

            VotingResults(yesCounter, noCounter);

            Console.ReadLine();
        }

        //calculate the voting results
        static void VotingResults(int yesCounter, int noCounter)
        {
            int total = yesCounter + noCounter;
            double yesPercent = yesCounter * 100.0 / total;
            double noPercent = noCounter * 100.0 / total;

            double yesPercentRounded = Math.Round(yesPercent, 2);
            double noPercentRounded = Math.Round(noPercent, 2);

            Console.WriteLine($"Yes Count: {yesCounter}, Percentage: {yesPercentRounded}%");
            Console.WriteLine($"No Count: {noCounter}, Percentage: {noPercentRounded}%");

            Console.WriteLine();

            if (yesCounter > noCounter)
            {
                Console.WriteLine("The majority voted yes.");
            }
            else if (yesCounter < noCounter)
            {
                Console.WriteLine("The majority voted no.");
            }
            else
            {
                Console.WriteLine("Draw.");
            }
        }
    }
}
