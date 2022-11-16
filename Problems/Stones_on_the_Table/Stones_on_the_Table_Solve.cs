using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Stones_on_the_Table
{
    public class Stones_on_the_Table_Solve
    {
        public void Solve()
        {
            var Length = int.Parse(Console.ReadLine());
            var Chars = Console.ReadLine();

            var Counter = 0;
            var PreviousChar = Chars[0];

            for (int i = 1; i < Chars.Length; i++)
            {
                if (Chars[i] == PreviousChar)
                {
                    Counter++;
                }
                else
                {
                    PreviousChar = Chars[i];
                }
            }
            Console.WriteLine(Counter);
        }
    }
}
