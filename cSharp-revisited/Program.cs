using System;
using DynamicExample;

namespace cSharp_revisited
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dynamic binding
            var dynamicExample = new DynamicExampleCaller();
            Console.WriteLine("Hello World!");
        }
    }
}
