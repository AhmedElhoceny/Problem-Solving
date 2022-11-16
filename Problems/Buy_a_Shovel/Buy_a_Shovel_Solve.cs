using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Buy_a_Shovel
{
    public class Buy_a_Shovel_Solve
    {
        public void Solve()
        {
            var Data = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
            long Counter = 1;
            while (true)
            {
                if ((Data[0] * Counter) % 10 == Data[1] || (Data[0] * Counter) % 10 == 0)
                {
                    break;
                }
                Counter++;
            }
            Console.WriteLine(Counter);
        }
    }
}
