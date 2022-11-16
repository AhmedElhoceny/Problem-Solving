using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.FreeIceCream
{
    public class Free_Ice_Cream_Solve
    {
       public void solve()
        {
            var firstData = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            long kidsCount = 0;
            long packets = firstData[1];
            for (int i = 0; i < firstData[0]; i++)
            {
                var operation = Console.ReadLine().Split(" ").ToArray();
                var sign = operation[0];
                var val = int.Parse(operation[1]);
                switch (sign)
                {
                    case "+":
                        packets += val;
                        break;
                    case "-":
                        if ((packets - val) < 0)
                        {
                            kidsCount++;
                        }
                        else
                        {
                            packets -= val;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{packets} {kidsCount}");
        }
    }
}
