namespace ProblemSolving.A.Is_It_Rated
{
    public class is_it_rated_Solve
    {
        public void SolvingProblem()
        {
            var collaporatorsCount = Console.ReadLine().Split("").Select(x => long.Parse(x)).ToArray()[0];
            var checkingIsRating = new List<List<long>>();
            var collaporatorsRates = new List<long>();
            var checkingOrderingList = new List<long>();
            long counter = 0;
            for (int i = 0; i < collaporatorsCount; i++)
            {
                var collaporatorRate = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();
                checkingIsRating.Add(collaporatorRate.Distinct().ToList());
                collaporatorsRates.AddRange(collaporatorRate);
            }
            if (checkingIsRating.Where(x => x.Count == 2).FirstOrDefault() != null)
                Console.WriteLine("rated");
            else
            {
                foreach (var item in collaporatorsRates)
                {

                    var LastItem = checkingOrderingList.LastOrDefault();
                    if (LastItem != null && LastItem != 0)
                    {
                        if (LastItem < item)
                        {
                            Console.WriteLine("unrated");
                            break;
                        }
                        else
                        {
                            checkingOrderingList.Add(item);
                            counter++;
                        }
                    }
                    else
                    {
                        checkingOrderingList.Add(item);
                        counter++;
                    }
                }
            }
            if (counter == collaporatorsRates.Count)
                Console.WriteLine("maybe");
        }
    }
}
