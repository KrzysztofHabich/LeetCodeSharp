namespace LeetSharp.Core;

//
public interface ISolutionContext
{
    string Name { get; }
    string Description { get; }
    string[] Tags { get; }
}
