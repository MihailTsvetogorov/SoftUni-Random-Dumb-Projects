using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            { 
               for (int i=1;i<=row-1;i++)
                    {
                        Console.Write("* ");
                    }
                Console.WriteLine();
            }
            for (int row=1;row<=n-1;row++)
            {
                Console.Write("* ");
            }
        }
    }
}
