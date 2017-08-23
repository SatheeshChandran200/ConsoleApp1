using System;
//sing System.Object;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 + 2 + 3);
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is a new line");
            Test1 test = new Test1();
            test.Count = 1;
            Console.WriteLine(test.Count);
            Console.ReadLine();
        }
    }
}