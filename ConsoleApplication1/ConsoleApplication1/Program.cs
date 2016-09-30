using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int row=1;row<=n;row++)
            {
               if (row==1)
                {
                    Console.Write("+ ");
                    for (int minus = 1; minus <= n - 2; minus++)
                    {
                        Console.Write("- ");
                    }
                    Console.Write("+");
                    Console.WriteLine();
                }
               else if (row!=1 && row!=n)
                {
                    for (int a=1;a<=row-2;a++)
                    {
                        if (a == 1) Console.Write("| ");
                        else if (a != 1 && a != n) Console.Write("- ");
                        else if (a == n)
                        {
                            Console.Write("|");
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine();
                }
               else if (row==n)
                {
                    Console.Write("+ ");
                    for (int minus = 1; minus <= n - 2; minus++) Console.Write("- ");
                    Console.Write("+");
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
