using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetSharp.Core;

public interface IAsyncSolutionRunner : ISolutionContext
{
    Task<ISolutionResult> RunAsync();
}
