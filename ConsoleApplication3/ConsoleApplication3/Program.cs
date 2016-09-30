using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            double num = 1;
            var n = int.Parse(Console.ReadLine());
            if (n == 1) { Console.WriteLine("1"); }
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num = num * 4;
            }
        }
    }
}
