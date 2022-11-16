using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Way_Too_Long_Words
{
    public class Way_Too_Long_Words_Solve
    {
        public void Solve()
        {
            var dataLenth = int.Parse(Console.ReadLine().Split(" ")[0]);
            var words = new List<string>();
            for (int i = 0; i < dataLenth; i++)
            {
                words.Add(Console.ReadLine());
            }
            foreach (var word in words)
            {
                if (word.Length <= 10)
                    Console.WriteLine(word);
                else
                {
                    var firstChar = word[0].ToString();
                    var lastWord = word[word.Length - 1].ToString();
                    var betweenLenth = (word.Length - 2).ToString();
                    Console.WriteLine(firstChar + betweenLenth + lastWord);
                }
            }
        }
    }
}
