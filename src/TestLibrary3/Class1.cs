using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    using Microsoft.Extensions.DependencyModel;
    using Xunit;

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
