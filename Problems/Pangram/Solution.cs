using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Pangram
{
    public class Solution
    {
        public void Solve()
        {
            var searchingArray = new int[26];
            var charLength = Console.ReadLine()!.Split("").Select(x => int.Parse(x)).ToArray()[0];
            var inputChar = Console.ReadLine();

            if (charLength < 26)
            {
                Console.WriteLine("NO");
            }
            else
            {
                foreach (var inputCharItem in inputChar.ToUpper())
                {
                    searchingArray[((int)inputCharItem - (int)'A')] = 1;
                }
                if (searchingArray.Where(x => x != 1).Count() != 0)
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");
            }

        }
    }
}
