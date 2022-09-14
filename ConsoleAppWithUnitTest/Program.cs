using ConsoleAppWithUnitTest.ExtensionMethods;
using System;

namespace ConsoleAppWithUnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = input.ToSafeInt(2);
            Console.WriteLine(result);
        }
    }
}
