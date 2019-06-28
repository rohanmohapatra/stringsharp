using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String subStr = StringMethods.StringGetMethods.GetSubstring("Hello World", 2, 4);
            Console.WriteLine(subStr);
        }
    }
}
