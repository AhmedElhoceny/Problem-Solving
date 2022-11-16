using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Night_at_the_Museum
{
    public class Night_at_the_Museum_Solve
    {
        public void Solve()
        {
            var Word = Console.ReadLine().ToCharArray();
            var TotalResult = 0;

            var CuurentPosition = 'a';

            foreach (var CharItem in Word)
            {
                var FirstCal = Math.Abs((int)CharItem - (int)CuurentPosition);
                var SecondCal = Math.Abs(26 - FirstCal);

                TotalResult += FirstCal < SecondCal ? FirstCal : SecondCal;
                CuurentPosition = CharItem;
            }
            Console.WriteLine(TotalResult);
        }
    }
}
