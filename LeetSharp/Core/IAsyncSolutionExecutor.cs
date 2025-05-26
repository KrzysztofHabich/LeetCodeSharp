namespace LeetSharp.Core;

interface IAsyncSolutionExecutor 
{
    Task<ISolutionResult> ExecuteAync(ISolutionRunner solutionRunner);
}
