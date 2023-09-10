using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.DZY_Loves_Chessboard
{
    public class DZYLovesChessboard
    {
        public void Solve()
        {
            var firstInput = Console.ReadLine()!.Split(" ").ToArray();

            var rows = int.Parse(firstInput[0]);
            var columns = int.Parse(firstInput[1]);
            var cellsCount = int.Parse(firstInput[0]) * int.Parse(firstInput[1]);

            var cells = new string[rows, columns];

            for (var i = 0; i < rows; i++)
            {
                var input = Console.ReadLine()!.ToCharArray().Select(c => c.ToString()).ToArray();
                for (var j = 0; j < columns; j++)
                {
                    cells[i, j] = input[j];
                }
            }

            var selectedIndex = 0;
            var ChestTypes = new[] { "W", "B" };

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    if (cells[i, j] == ".")
                    {
                        cells[i, j] = ChestTypes[selectedIndex];
                        selectedIndex = selectedIndex == 0 ? 1 : 0;
                    }
                }
                selectedIndex = selectedIndex == 0 ? 1 : 0;
            }

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    Console.Write(cells[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
