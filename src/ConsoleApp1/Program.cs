﻿using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = DependencyContext.Default;

            foreach (var lib in context.RuntimeLibraries)
            {
                Console.WriteLine(lib.Name);
            }

            Console.ReadKey();
        }
    }
}
