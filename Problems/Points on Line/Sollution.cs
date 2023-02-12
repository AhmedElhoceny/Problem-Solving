using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Points_on_Line
{
    public class Sollution
    {
        public void solve()
        {
            var firstInput = Console.ReadLine()!.Split(' ').Select(ch => int.Parse(ch)).ToArray();
            var secondInput = Console.ReadLine()!.Split(' ').Select(ch => int.Parse(ch)).ToArray();

            var totalResult = 0;

            var workingData = secondInput.Take(3).ToArray();
            var restdata = secondInput.Except(workingData).ToArray();

            totalResult += GetLongDistance(workingData);

            var workingItem = 0;

            foreach (var workingDataItemtem in workingData)
            {
                workingItem = workingDataItemtem;
                var itemIndex = Array.IndexOf(workingData, workingDataItemtem);

                foreach (var restDataItem in restdata)
                {
                    workingData[itemIndex] = restDataItem;
                    totalResult += GetLongDistance(workingData);
                }

                workingData[itemIndex] = workingItem;
            }
            Console.WriteLine(totalResult);


            int GetLongDistance(int[] data)
            {
                var minVal = Math.Abs(data.Min());
                var maxVal = Math.Abs(data.Max());

                return Math.Abs(maxVal - minVal) <= firstInput![1] ? 1 : 0;

            }
        }
    }
}
