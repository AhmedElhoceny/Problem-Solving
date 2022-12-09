using ProblemSolving.Algorithms.Sorting;

var Count = Console.ReadLine();
var Input = Console.ReadLine()!.Split(" ").Select(x => double.Parse(x)).ToArray();
Input = Input.Distinct().ToArray();
if(Input.Count() == 1)
{
    Console.WriteLine("NO");
}
else
{
    var SortingAlgo = new MergeSort();
    Input = SortingAlgo.SortArray(Input, 0, Input.Length - 1);
    Console.WriteLine(Input[1]);
}