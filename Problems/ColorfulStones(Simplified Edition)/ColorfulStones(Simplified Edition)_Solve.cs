using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.ColorfulStones_Simplified_Edition_
{
    public class ColorfulStones_Simplified_Edition__Solve
    {
        public void Solve()
        {
            var FirstInputData = Console.ReadLine()!.ToCharArray();
            var SecondInputData = Console.ReadLine()!.ToCharArray();

            var Counter = 0;

            foreach (var SecondInputDataItem in SecondInputData)
            {
                if (FirstInputData[Counter] == SecondInputDataItem)
                {
                    Counter++;
                }
            }
            Console.WriteLine(Counter + 1);
        }
    }
}
