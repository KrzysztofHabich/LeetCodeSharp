using LeetSharp.Core;
using LeetSharp.Problems;

namespace LeetSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISolutionExecutor executor = new SolutionExecutor();

            ISolutionRunner twoSum = new TwoSumProblem();
            _ = executor.Execute(twoSum);
        }
    }
}
