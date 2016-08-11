using System;
using Microsoft.Extensions.DependencyModel;
using Xunit;

namespace ClassLibrary3
{

    public class Class1
    {
        [Fact]
        public void DependencyContextTest()
        {
            var context = DependencyContext.Default;

            foreach (var lib in context.RuntimeLibraries)
            {
                Console.WriteLine(lib.Name);
            }
        }
    }
}
