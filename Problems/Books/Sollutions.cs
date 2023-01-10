using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Books
{
    public class Sollutions
    {
        public void Solve()
        {
            // Collecting The Data
            var firstDataInput = Console.ReadLine()!.Split(" ").Select(x => long.Parse(x)).ToArray();
            var secondDataInput = Console.ReadLine()!.Split(" ").Select(x => long.Parse(x)).ToList();

            // Books Counter
            long booksCounter = 0;

            // Sorting The Minutes
            secondDataInput.Sort();

            // Reading The Books Inside The Free Minutes
            foreach (var BookMinuteItem in secondDataInput)
            {
                firstDataInput[1] -= BookMinuteItem;
                if (firstDataInput[1] >= 0)
                    booksCounter++;
                else
                    break;
            }

            //Print The Count Of Books
            Console.WriteLine(booksCounter);
        }
    }
}
