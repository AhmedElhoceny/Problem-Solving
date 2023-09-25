using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Black_Square
{
    public class BearandFriendshipCondition
    {
        public void Solve()
        {
            var firstInput = Console.ReadLine()!.Split(" ").ToArray();
            var charsNumber = int.Parse(firstInput[0]);
            var rowCount = int.Parse(firstInput[1]);

            var size = 0;

            if (charsNumber > rowCount)
                size = charsNumber;
            else
                size = rowCount;

            var graphArray = new bool[size, size];



            for (var i = 0; i < rowCount; i++)
            {
                var input = Console.ReadLine()!.Split(" ").ToArray();

                var firstChar = int.Parse(input[0]);
                var secondChar = int.Parse(input[1]);

                graphArray[(firstChar - 1), (secondChar - 1)] = true;
                graphArray[(secondChar - 1), (firstChar - 1)] = true;
            }

            for (var i = 0; i < rowCount; i++)
            {
                for (int cn = 0; cn < charsNumber; cn++)
                {
                    for (int rc = 0; rc < charsNumber; rc++)
                    {
                        if (cn != rc && graphArray[i, cn] == true && graphArray[i, rc] == true)
                        {
                            if (graphArray[(cn), (rc)] != true || graphArray[(rc), (cn)] != true)
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
