using System;

namespace Runner
{
    partial class Program
    {
        static void Main(string[] args)
        {
            HelloFrom("Generated Code");

            Console.ReadKey();
        }

        static partial void HelloFrom(string name);
    }
}
