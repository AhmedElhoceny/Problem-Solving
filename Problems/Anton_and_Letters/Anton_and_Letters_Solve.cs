using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Anton_and_Letters
{
    public class Anton_and_Letters_Solve
    {
        public void Solve()
        {
            var Chars = Console.ReadLine().Split(", ");
            Chars[0] = Chars[0].ToCharArray()[1].ToString();
            Chars[Chars.Length - 1] = Chars[Chars.Length - 1].ToCharArray()[0].ToString();
            if (Chars.Length == 1 && (int)Chars[0][0] == 125)
                Console.WriteLine(0);
            else
            {
                var data = new char[122 - 96];

                foreach (var item in Chars)
                {
                    data[(int)item[0] - 97] = item[0];
                }
                var count = data.Where(x => (int)x > 96 && (int)x < 123).ToArray().Length;
                Console.WriteLine(count);
            }
        }
    }
}
