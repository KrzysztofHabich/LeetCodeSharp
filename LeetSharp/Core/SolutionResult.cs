
namespace LeetSharp.Core;

internal class SolutionResult : ISolutionResult
{
    public SolutionResult(string answer)
    {
        Answer = answer;
    }
    public string Answer { get;}
}
