namespace LeetSharp.Core;

internal class SolutionExecutor : ISolutionExecutor
{
    public ISolutionResult Execute(ISolutionRunner solutionRunner)
    {
        ISolutionResult result = null;

        try
        {
            Console.WriteLine($"NAME: {solutionRunner.Name}");
            Console.WriteLine($"DESC: {solutionRunner.Description}");
            //Time
            result = solutionRunner.Run();
            //
            Console.WriteLine($"=======");
            Console.WriteLine($"Result: {result.Answer}");
            Console.WriteLine($"Runtime: ");
            Console.WriteLine($"==============================================");
        }
        catch(Exception exp)
        {
            //log
            Console.WriteLine (exp.Message );
        }
        finally
        {
            //time reset
        }


        return result;
    }
}
