using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Black_Square
{
    public class Sollution
    {
        public void Solve()
        {
            var firstInput = Console.ReadLine()!.Split(" ").ToArray();
            var charsNumber = int.Parse(firstInput[0]);
            var rowCount = int.Parse(firstInput[1]);

            var globalDanger = 1;

            var graphArray = new bool[charsNumber, charsNumber];
            var visited = new bool[charsNumber];

            // Visit Graph
            void Visit(int node)
            {
                visited[node] = true;
                for (var i = 0; i < charsNumber; i++)
                {
                    if (graphArray[node, i] && !visited[i])
                    {
                        globalDanger *= 2; ;
                        Visit(i);
                    }
                }
            }

            // Crate Graph Array
            for (var i = 0; i < rowCount; i++)
            {
                var input = Console.ReadLine()!.Split(" ").ToArray();

                var firstChar = int.Parse(input[0]);
                var secondChar = int.Parse(input[1]);

                graphArray[(firstChar - 1), (secondChar - 1)] = true;
                graphArray[(secondChar - 1), (firstChar - 1)] = true;
            }

            // Move through graph
            for (int i = 0; i < charsNumber; i++)
                Visit(i);

            // Print result
            Console.WriteLine(globalDanger);
        }
    }
}
